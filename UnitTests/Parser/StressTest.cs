using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;
using EngineeringUnits.Parser.UnitParser;
using System.Diagnostics;

namespace UnitTests.Stress
{
    [TestClass]
    public class UnitSystemCacheFuzzStressTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        private static readonly string[] UnitTokens =
        {
            "kg","m","s","A","K","N","Pa","W","J","V","Ohm","Hz","C","F","H"
        };

        private static readonly (string Name, string? Format)[] Formats =
        {
            ("Default", null),
            ("PF", "PF"),
            ("PP", "PP"),
            ("C",  "C"),
            ("S",  "S"),
        };

        [TestMethod]
        [TestCategory("Stress")]
        [Ignore("Long-running stress test. Run manually.")]
        public void Stress_AllFormats_RoundTrip_AndCacheGrowth()
        {
            var rng = new Random(1337);
            var failures = new Dictionary<string, int>();
            foreach (var (n, _) in Formats)
                failures[n] = 0;

            const int iterations = 500_000; // bump to 200k+ if you want
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            long mem0 = GC.GetTotalMemory(true);

            for (int i = 0; i < iterations; i++)
            {
                string expr = GenerateExpression(rng, 3);

                if (!UnitExpressionParser.TryParseWithWarnings(expr, out var u1, out _, out _))
                    continue;

                var si1 = u1.GetSIUnitsystem();

                foreach (var (name, fmt) in Formats)
                {
                    string rendered = (fmt is null) ? u1.ToString() : u1.ToString(fmt, Inv);

                    // Normalize using your existing normalizer (superscripts -> ^, dot -> *, etc.)
                    string norm = UnitExpressionNormalizer.Normalize(rendered)
                        .Replace("[-]", "1").Replace("[ - ]", "1")
                        .Trim();

                    if (!UnitExpressionParser.TryParseWithWarnings(norm, out var u2, out _, out _))
                    {
                        failures[name]++;
                        continue;
                    }

                    var si2 = u2.GetSIUnitsystem();
                    if (!(si1 == si2))
                        failures[name]++;
                }

                // occasional GC to keep memory measurement sensible
                if ((i % 10_000) == 0 && i > 0)
                    GC.Collect();
            }

            long mem1 = GC.GetTotalMemory(true);

            Debug.WriteLine($"Iterations: {iterations}");
            Debug.WriteLine($"Memory delta (bytes): {mem1 - mem0}");
#if DEBUG
            Debug.WriteLine($"Multiply cache: {UnitSystem.MultiplyCacheCount}, Divide cache: {UnitSystem.DivideCacheCount}");
#endif
            foreach (var kv in failures)
                Debug.WriteLine($"{kv.Key}: failures={kv.Value}");

            // No hard assert here — this is exploratory.
            // Once you’ve observed stable numbers, you can add thresholds.
        }


        //private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        [TestMethod]
        [TestCategory("Stress")]
        [Ignore("Long-running stress test. Run manually.")]
        public void Stress_CacheCorrectness_Deterministic_RoundTrip()
        {
            // Pick expressions that force lots of * and / and negative exponents.
            // These flow through UnitSystem.operator * and / and therefore the caches
            string[] exprs =
            {
                "m/(s^2*kg)",
                "kg*m^2/s^3/A",
                "V^2/W/Ohm",
                "Pa*m^3/J",
                "Ohm/(A^2)",
                "W/(m*K)",
                "kg/(m*s^2)",
                "m^3/(s^3*A^3)",
                "N*m/(s^2)",
                "J/(kg*K)"
            };

            const int iterations = 200_000; // adjust up/down
            int idx = 0;

            // Memory baselining
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            long mem0 = GC.GetTotalMemory(forceFullCollection: true);

            for (int i = 0; i < iterations; i++)
            {
                string expr = exprs[idx++ % exprs.Length];

                Assert.IsTrue(UnitExpressionParser.TryParseWithWarnings(expr, out var u1, out _, out var err1),
                    $"Parse failed for '{expr}': {err1}");

                // Canonical / parse-friendly round-trip string should always be parseable.
                // If you use "C" as canonical product format, test that:
                string canon = u1.ToString("C", Inv);

                // Normalize (superscripts/dots/etc.) if your canonical still uses any fancy chars
                canon = UnitExpressionNormalizer.Normalize(canon);

                Assert.IsTrue(UnitExpressionParser.TryParseWithWarnings(canon, out var u2, out _, out var err2),
                    $"Round-trip parse failed: expr='{expr}', canon='{canon}', err='{err2}'");

                // Dimension equality should hold in SI-normalized space. [1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)
                Assert.IsTrue(u1.GetSIUnitsystem() == u2.GetSIUnitsystem(),
                    $"SI mismatch: expr='{expr}', canon='{canon}', si1='{u1.GetSIUnitsystem()}', si2='{u2.GetSIUnitsystem()}'");

                // Occasionally collect to keep memory reading sane
                if ((i % 50_000) == 0 && i > 0)
                {
                    GC.Collect();
                }
            }

            long mem1 = GC.GetTotalMemory(forceFullCollection: true);

            // Not a hard assert yet; just output signal.
            // If you add internal cache size accessors, you can assert growth thresholds here.
            Debug.WriteLine($"Memory delta (bytes): {mem1 - mem0}");
#if DEBUG
            Debug.WriteLine($"Multiply cache: {UnitSystem.MultiplyCacheCount}, Divide cache: {UnitSystem.DivideCacheCount}");
#endif
        }





        private static string GenerateExpression(Random rng, int depth)
        {
            string f = GenerateFactor(rng, depth);
            int extra = rng.Next(0, 4);
            for (int i = 0; i < extra; i++)
            {
                string op = rng.Next(0, 2) == 0 ? "*" : "/";
                f = $"{f}{op}{GenerateFactor(rng, depth)}";
            }
            return f;
        }

        private static string GenerateFactor(Random rng, int depth)
        {
            bool parens = depth > 0 && rng.NextDouble() < 0.25;
            string baseTok = UnitTokens[rng.Next(UnitTokens.Length)];
            string baseExpr = parens ? $"({GenerateExpression(rng, depth - 1)})" : baseTok;

            if (rng.NextDouble() < 0.50)
            {
                int exp = rng.Next(-3, 4);
                if (exp == 0)
                    exp = 1;
                baseExpr = rng.NextDouble() < 0.3 ? $"{baseExpr}^({exp})" : $"{baseExpr}^{exp}";
            }
            return baseExpr;
        }
    }
}