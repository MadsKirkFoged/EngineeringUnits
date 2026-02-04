using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;
using EngineeringUnits.Parser.UnitParser;

namespace UnitTests.Formatting
{
    [TestClass]
    public class UnitSystemFormatRoundTripFuzzTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        // Tune these:
        private const int Seed = 1337;
        private const int Iterations = 3000; // start 1000–3000; bump later
        private const int MaxDepth = 3;

        // Tokens that should exist in your global resolver.
        // Keep these conservative. Add more if you want.
        private static readonly string[] UnitTokens =
        {
            "kg", "m", "s", "A", "K",
            "N", "Pa", "W", "J", "V", "Ohm", "Hz", "C", "F", "H"
        };

        // Formats to test (including default)
        private static readonly (string Name, string? Format)[] Formats =
        {
            ("Default", null),
            ("PF", "PF"),
            ("PP", "PP"),
            ("C",  "C"),
            ("S",  "S"),
        };

        [TestMethod]
        public void UnitSystem_AllFormats_ShouldRoundTrip_ToSameSIDimension()
        {
            var rng = new Random(Seed);

            // Collect failures per format (so you can see which formats are weak)
            var failures = new Dictionary<string, List<string>>();
            foreach (var (name, _) in Formats)
                failures[name] = new List<string>();

            for (int i = 0; i < Iterations; i++)
            {
                string expr = GenerateExpression(rng, MaxDepth);

                // Parse original
                if (!UnitExpressionParser.TryParseWithWarnings(expr, out var u1, out var w1, out var err1))
                {
                    // this can happen depending on token set; skip (or count) as you prefer
                    continue;
                }

                var si1 = u1.GetSIUnitsystem();

                // For each format: format -> normalize -> parse -> compare SI
                foreach (var (name, fmt) in Formats)
                {
                    string rendered = (fmt is null)
                        ? u1.ToString()
                        : u1.ToString(fmt, Inv);

                    string normalized = NormalizeForParsing(rendered);

                    bool ok = UnitExpressionParser.TryParseWithWarnings(normalized, out var u2, out var w2, out var err2);
                    if (!ok)
                    {
                        failures[name].Add($"ParseFail | expr='{expr}' | rendered='{rendered}' | normalized='{normalized}' | err='{err2}'");
                        continue;
                    }

                    var si2 = u2.GetSIUnitsystem();

                    if (!(si1 == si2))
                    {
                        failures[name].Add($"Mismatch | expr='{expr}' | rendered='{rendered}' | normalized='{normalized}' | si1='{si1}' | si2='{si2}'");
                    }
                }
            }

            // Fail with a useful summary if ANY format has issues
            var messages = new List<string>();
            foreach (var (name, _) in Formats)
            {
                var list = failures[name];
                if (list.Count == 0)
                    continue;

                messages.Add($"Format {name}: {list.Count} failures. First 5:\n- " +
                             string.Join("\n- ", list.GetRange(0, System.Math.Min(5, list.Count))));
            }

            if (messages.Count > 0)
                Assert.Fail(string.Join("\n\n", messages));
        }

        // ---------------- helpers ----------------

        private static string NormalizeForParsing(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return s ?? "";

            // 1) Your existing normalizer (superscripts -> ^, dots -> *, etc.)
            // Replace this call name with whatever your normalizer is actually called.
            // Examples could be: UnitExpressionNormalizer.Normalize(s) or Normalizer.Normalize(s)
            s = UnitExpressionNormalizer.Normalize(s);

            // 2) Make dimensionless parseable even if you display [-]
            s = s.Replace("[-]", "1").Replace("[ - ]", "1");

            return s.Trim();
        }

        private static string GenerateExpression(Random rng, int maxDepth)
        {
            // expression: factor {(op factor)}*
            string t = GenerateFactor(rng, maxDepth);

            int extra = rng.Next(0, 4); // 0..3
            for (int i = 0; i < extra; i++)
            {
                string op = rng.Next(0, 2) == 0 ? "*" : "/";
                string rhs = GenerateFactor(rng, maxDepth);
                t = $"{t}{op}{rhs}";
            }

            return t;
        }

        private static string GenerateFactor(Random rng, int depth)
        {
            bool parens = depth > 0 && rng.NextDouble() < 0.25;

            string baseExpr = parens
                ? $"({GenerateExpression(rng, depth - 1)})"
                : UnitTokens[rng.Next(UnitTokens.Length)];

            if (rng.NextDouble() < 0.50)
            {
                int exp = rng.Next(-3, 4);
                if (exp == 0)
                    exp = 1;
                bool wrap = rng.NextDouble() < 0.30;
                baseExpr = wrap ? $"{baseExpr}^({exp})" : $"{baseExpr}^{exp}";
            }

            return baseExpr;
        }
    }
}