//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using EngineeringUnits.Parsing;
//using EngineeringUnits;
//using System.Diagnostics;

//namespace UnitTests.Parsing
//{
//    [TestClass]
//    public class ParserBigCoverageFuzzTests
//    {
//        // Deterministic seed -> reproducible failures
//        private const int Seed = 1337;

//        // Keep runtime reasonable (start at 2k–5k; bump if you want)
//        private const int Iterations = 5000;

//        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;
//        private static readonly CultureInfo Da = CultureInfo.GetCultureInfo("da-DK");

//        // A conservative symbol set that should exist in most engineering contexts.
//        // Avoid known problematic/ambiguous ones (you already removed 'h' from Hand).
//        // These tokens should resolve via canonical unit symbols (ToString()).
//        private static readonly string[] UnitTokens =
//        {
//            "kg", "m", "s", "A", "K",
//            "N", "Pa", "W", "J",
//            "V", "Ohm"
//        };

//        // For negative tests, include some garbage tokens
//        private static readonly string[] BadTokens =
//        {
//            "???", "notAUnit", "m//s", "kg**m", "(", ")", "^^", "m^", "m^x"
//        };

//        [TestMethod]
//        public void Fuzz_UnitExpressionParser_ShouldBeStable_AndRoundTripSI()
//        {
//            var rng = new Random(Seed);

//            int okCount = 0;
//            int failCount = 0;

//            for (int i = 0; i < Iterations; i++)
//            {
//                // 80% valid-ish expressions, 20% intentionally noisy
//                string expr = (rng.NextDouble() < 0.80)
//                    ? GenerateExpression(rng, maxDepth: 3)
//                    : GenerateNoisyExpression(rng);

//                bool ok = UnitExpressionParser.TryParseWithWarnings(
//                    expr,
//                    out var unitSystem,
//                    out var warnings,
//                    out var error);

//                // Invariant: should never throw; errors returned via ok=false+error.
//                if (!ok)
//                {
//                    failCount++;
//                    Assert.IsFalse(string.IsNullOrWhiteSpace(error), $"Expected error message for '{expr}'");
//                    continue;
//                }

//                okCount++;

//                Assert.IsNotNull(unitSystem, $"UnitSystem was null for '{expr}'");
//                Assert.IsNotNull(warnings, $"Warnings was null for '{expr}'");

//                // Invariant: Round-trip of normalized unit expression should preserve SI-normalized dimensions
//                // (UnitSystem equality is dimension-based; GetSIUnitsystem normalizes to SI unitsystem). [1](https://careerkarma.com/blog/git-download-a-single-file-from-github/)[2](https://github.com/MadsKirkFoged/)
//                //string normalizedExpr = unitSystem.ToString();
//                string normalizedExpr = UnitSystemParserSafeFormatter.ToParserSafeExpression(unitSystem);

//                bool ok2 = UnitExpressionParser.TryParseWithWarnings(
//                    normalizedExpr,
//                    out var unitSystem2,
//                    out var warnings2,
//                    out var error2);

//                Assert.IsTrue(ok2, $"Round-trip parse failed. expr='{expr}', normalized='{normalizedExpr}', error='{error2}'");

//                //if (ok2 is false)
//                //{
//                //    Debug.WriteLine($"Round-trip parse failed. expr='{expr}', normalized='{normalizedExpr}', error='{error2}'");
//                //}

//                var si1 = unitSystem.GetSIUnitsystem();
//                var si2 = unitSystem2.GetSIUnitsystem();

//                Assert.IsTrue(si1 == si2, $"SI mismatch after round-trip. expr='{expr}', normalized='{normalizedExpr}'");

//                //if (si1 != si2)
//                //{
//                //    Debug.WriteLine($"SI mismatch after round-trip. expr='{expr}', normalized='{normalizedExpr}'");
//                //}
//            }

//            // Sanity: we should see both successes and failures.
//            Assert.IsTrue(okCount > 0, "Fuzzer produced no successful parses; token set likely wrong.");
//            Assert.IsTrue(failCount > 0, "Fuzzer produced no failures; noisy generation may be too tame.");
//        }

//        [TestMethod]
//        public void Fuzz_UnknownUnitParser_ShouldBeStable_AndNormalizedExpressionParsable()
//        {
//            var rng = new Random(Seed + 1);

//            int okCount = 0;

//            for (int i = 0; i < Iterations; i++)
//            {
//                string expr = (rng.NextDouble() < 0.85)
//                    ? GenerateExpression(rng, maxDepth: 3)
//                    : GenerateNoisyExpression(rng);

//                // Values: include integers, decimals, exponent, and comma-decimal (culture test)
//                bool useDa = rng.NextDouble() < 0.15;
//                var culture = useDa ? (IFormatProvider)Da : Inv;

//                string valueText = GenerateNumberText(rng, useDa);
//                string input = $"{valueText} {expr}";

//                var r = UnknownUnitParser.ParseWithWarnings(input, culture);

//                // Invariant: no throws, always returns friendly result
//                if (!r.Success)
//                {
//                    Assert.IsFalse(string.IsNullOrWhiteSpace(r.Error), $"Expected error for '{input}'");
//                    continue;
//                }

//                okCount++;

//                Assert.IsNotNull(r.Value, $"Success but Value null for '{input}'");
//                Assert.IsFalse(string.IsNullOrWhiteSpace(r.Normalized), $"Missing normalized output for '{input}'");

//                // Invariant: Normalized output should be re-parsable (at least unit expression part)
//                // Normalized is "<number> <unitSystemString>"
//                var partsOk = SplitNumberAndUnit(r.Normalized, out var n2, out var u2);
//                Assert.IsTrue(partsOk, $"Could not split normalized '{r.Normalized}'");

//                bool okUnit = UnitExpressionParser.TryParseWithWarnings(u2, out var us2, out var w2, out var e2);
//                Assert.IsTrue(okUnit, $"Normalized unit expr not parsable. norm='{r.Normalized}', unit='{u2}', error='{e2}'");
//            }

//            Assert.IsTrue(okCount > 0, "No successful UnknownUnit parses; token set likely wrong.");
//        }

//        // ------------------ generators ------------------

//        private static string GenerateExpression(Random rng, int maxDepth)
//        {
//            // Expression := Term {(MulOrDiv Term | implicitMul Term)}*
//            // We'll generate a small AST-ish string with optional parentheses and exponents.

//            string term = GenerateFactor(rng, maxDepth);

//            int extra = rng.Next(0, 4); // 0..3 extra factors
//            for (int i = 0; i < extra; i++)
//            {
//                int kind = rng.Next(0, 3);
//                string op = kind switch
//                {
//                    0 => "*",
//                    1 => "/",
//                    _ => " " // implicit multiply
//                };

//                string rhs = GenerateFactor(rng, maxDepth);
//                term = $"{term}{op}{rhs}";
//            }

//            return term;
//        }

//        private static string GenerateFactor(Random rng, int depth)
//        {
//            bool parens = depth > 0 && rng.NextDouble() < 0.25;

//            string baseExpr = parens
//                ? $"({GenerateExpression(rng, depth - 1)})"
//                : GenerateUnitToken(rng);

//            // Optional exponent
//            if (rng.NextDouble() < 0.45)
//            {
//                int exp = rng.Next(-3, 4);
//                if (exp == 0)
//                    exp = 1;

//                // Mix between "^2" and "^(2)" forms
//                bool wrap = rng.NextDouble() < 0.3;
//                baseExpr = wrap ? $"{baseExpr}^({exp})" : $"{baseExpr}^{exp}";
//            }

//            return baseExpr;
//        }

//        private static string GenerateUnitToken(Random rng)
//        {
//            // Pick valid token, sometimes vary casing (important for symbol map correctness)
//            string t = UnitTokens[rng.Next(UnitTokens.Length)];

//            if (rng.NextDouble() < 0.20)
//                t = t.ToUpperInvariant();
//            else if (rng.NextDouble() < 0.20)
//                t = t.ToLowerInvariant();

//            return t;
//        }

//        private static string GenerateNoisyExpression(Random rng)
//        {
//            // Combine some valid tokens with intentionally malformed fragments
//            string a = rng.NextDouble() < 0.5 ? GenerateUnitToken(rng) : BadTokens[rng.Next(BadTokens.Length)];
//            string b = rng.NextDouble() < 0.5 ? GenerateUnitToken(rng) : BadTokens[rng.Next(BadTokens.Length)];

//            string[] junkOps = { "**", "//", "^^", ")", "(", " / / ", " * * ", " ^ " };
//            string op = junkOps[rng.Next(junkOps.Length)];

//            return $"{a}{op}{b}";
//        }

//        private static string GenerateNumberText(Random rng, bool commaDecimal)
//        {
//            // 60% integer, 30% decimal, 10% scientific notation
//            double roll = rng.NextDouble();

//            if (roll < 0.60)
//            {
//                int v = rng.Next(-1000, 1001);
//                return v.ToString(CultureInfo.InvariantCulture);
//            }

//            if (roll < 0.90)
//            {
//                int whole = rng.Next(-1000, 1001);
//                int frac = rng.Next(0, 1000);
//                string decSep = commaDecimal ? "," : ".";
//                return $"{whole}{decSep}{frac:D3}".TrimEnd('0');
//            }

//            // scientific
//            int mant = rng.Next(1, 100);
//            int exp = rng.Next(-6, 7);
//            return $"{mant}e{exp}";
//        }

//        private static bool SplitNumberAndUnit(string input, out string numberPart, out string unitPart)
//        {
//            numberPart = "";
//            unitPart = "";

//            if (string.IsNullOrWhiteSpace(input))
//                return false;

//            input = input.Trim();

//            int i = 0;
//            while (i < input.Length && char.IsWhiteSpace(input[i]))
//                i++;
//            if (i >= input.Length)
//                return false;

//            int startNum = i;

//            while (i < input.Length)
//            {
//                char c = input[i];

//                if (char.IsDigit(c) || c == '+' || c == '-' || c == '.' || c == ',' || c == 'e' || c == 'E')
//                { i++; continue; }

//                if (char.IsWhiteSpace(c))
//                { i++; continue; }

//                break;
//            }

//            int endNum = i;

//            while (i < input.Length && char.IsWhiteSpace(input[i]))
//                i++;
//            if (i >= input.Length)
//                return false;

//            numberPart = input.Substring(startNum, endNum - startNum).Trim();
//            unitPart = input.Substring(i).Trim();

//            return numberPart.Length > 0 && unitPart.Length > 0;
//        }
//    }
//}