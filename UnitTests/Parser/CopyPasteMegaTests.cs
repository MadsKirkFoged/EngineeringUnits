using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class CopyPasteMegaTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        private sealed record Case(
            string Name,
            string Input,
            bool ShouldParse,
            Func<bool>? ExtraAssert = null
        );

        [TestMethod]
        public void CopyPaste_MegaCorpus_ShouldBehaveAsExpected()
        {
            // IMPORTANT:
            // - This test intentionally collects all failures and reports at the end.
            // - It uses typed parses where meaningful (Pressure, Acceleration, etc.)
            // - And UnknownUnit.ParseWithWarnings for generic unit-expression coverage.

            var cases = new List<Case>
            {
                // ------------------------------------------------------------
                // A) Power-of-ten numeric variants (web/PDF/Word copy/paste)
                // ------------------------------------------------------------
                new("10^1", "10^1 Pa", true, () => AssertPressure("10^1 Pa", 10m)),
                new("10^-1", "10^-1 Pa", true, () => AssertPressure("10^-1 Pa", 0.1m)),
                new("10^−1 (U+2212 minus)", "10^−1 Pa", true, () => AssertPressure("10^−1 Pa", 0.1m)), // U+2212 [1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)[2](https://github.com/lbborkowski/engineering-unit-converter)
                new("10^(−1)", "10^(−1) Pa", true, () => AssertPressure("10^(−1) Pa", 0.1m)),            // U+2212 [1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)[2](https://github.com/lbborkowski/engineering-unit-converter)

                new("1e−1 (unicode minus)", "1e−1 Pa", true, () => AssertPressure("1e−1 Pa", 0.1m)),    // U+2212 [1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)[2](https://github.com/lbborkowski/engineering-unit-converter)
                new("1E+1", "1E+1 Pa", true, () => AssertPressure("1E+1 Pa", 10m)),                      // scientific notation [11](https://github.com/MadsKirkFoged/)[12](https://www.nuget.org/packages/EngineeringUnits/1.1.0)

                // Lost-caret shorthand (start-only, literal parser only)
                new("10−1 (lost caret)", "10−1 Pa", true, () => AssertPressure("10−1 Pa", 0.1m)),        // U+2212 [1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)[2](https://github.com/lbborkowski/engineering-unit-converter)

                // coefficient × 10^n style
                new("3×10^2", "3×10^2 Pa", true, () => AssertPressure("3×10^2 Pa", 300m)),               // × [4](https://www.nuget.org/packages/UnitsNet/)[5](https://github.com/angularsen/UnitsNet)
                new("3⋅10^2", "3⋅10^2 Pa", true, () => AssertPressure("3⋅10^2 Pa", 300m)),               // ⋅ [3](https://libs.tech/project/11521218/unitsnet)
                new("3·10^2", "3·10^2 Pa", true, () => AssertPressure("3·10^2 Pa", 300m)),               // middle dot used for multiplication [3](https://libs.tech/project/11521218/unitsnet)

                // ------------------------------------------------------------
                // B) Superscripts in units (exponents)
                // ------------------------------------------------------------
                new("Acceleration m/s²", "1 m/s²", true, () => AssertAcceleration("1 m/s²", 1m)),
                new("Acceleration m·s⁻²", "1 m·s⁻²", true, () => AssertAcceleration("1 m·s⁻²", 1m)),     // ⁻ is U+207B [10](https://1library.net/document/q2vw1rjy-unisim-design-operations-guide.html)

                // ------------------------------------------------------------
                // C) Unit operators from typography
                // ------------------------------------------------------------
                new("Dot operator multiplication", "1 N⋅m", true, () => AssertUnknownSIEqual("1 N⋅m", "1 N*m")), // ⋅ multiplication [3](https://libs.tech/project/11521218/unitsnet)
                new("Multiplication sign ×", "1 N×m", true, () => AssertUnknownSIEqual("1 N×m", "1 N*m")),      // × [4](https://www.nuget.org/packages/UnitsNet/)[5](https://github.com/angularsen/UnitsNet)

                new("Division sign ÷", "1 m÷s", true, () => AssertUnknownSIEqual("1 m÷s", "1 m/s")),
                new("Fraction slash ⁄", "1 m⁄s", true, () => AssertUnknownSIEqual("1 m⁄s", "1 m/s")),
                new("Division slash ∕", "1 m∕s", true, () => AssertUnknownSIEqual("1 m∕s", "1 m/s")),

                // ------------------------------------------------------------
                // D) Confusable unit symbols (μ/µ, Ω/Ω)
                // ------------------------------------------------------------
                new("Greek mu μ vs micro µ", "1 μm", true, () => AssertUnknownSIEqual("1 μm", "1 µm")),         // μ vs µ [8](https://people.freebsd.org/~kami/2015-32C3/paper-twocolumn-grey.pdf)[9](https://github.com/orgs/community/discussions/44370)
                new("Ohm sign Ω vs Ω", "1 Ω", true, () => AssertUnknownSIEqual("1 Ω", "1 Ω")),                  // Ω vs Ω [9](https://github.com/orgs/community/discussions/44370)[1](https://skillbolt.dev/blog/top-10-github-repos-engineering-students-should-know)

                // ------------------------------------------------------------
                // E) Whitespace issues (NBSP)
                // ------------------------------------------------------------
                new("NBSP between number and unit", "10\u00A0kg", true, () => AssertUnknownSIEqual("10\u00A0kg", "10 kg")), // NBSP U+00A0 [6](https://github.com/angularsen/UnitsNet/issues/1322)[7](https://www.autodesk.com/support/technical/article/caas/sfdcarticles/sfdcarticles/When-opening-drawings-exported-from-other-platforms-or-software-the-units-are-read-incorrectly-in-Civil-3D.html)

                // ------------------------------------------------------------
                // F) Things we *currently* consider ambiguous / unsupported
                // (Mark as ShouldParse=false so we can revisit policy later)
                // ------------------------------------------------------------
                new("Ambiguous subtraction-looking numeric token", "10 - 1 Pa", false),
                new("Subscript index (ambiguous intent)", "1 m₂", false), // subscripts are semantic/index often [13](https://github.com/MadsKirkFoged/EngineeringUnits/pulls)[14](https://github.com/MadsKirkFoged/EngineeringUnits/issues)
                new("Chemical-formula-like token", "1 H₂O", false),       // not a unit [13](https://github.com/MadsKirkFoged/EngineeringUnits/pulls)[14](https://github.com/MadsKirkFoged/EngineeringUnits/issues)
            };

            var failures = new List<string>();

            foreach (var c in cases)
            {
                try
                {
                    if (c.ShouldParse)
                    {
                        // Use UnknownUnit.ParseWithWarnings to ensure "works" at the parser layer too.
                        var r = QuantityParser.ParseWithWarnings(c.Input, Inv);
                        if (!r.Success || r.Value is null)
                        {
                            failures.Add($"FAIL (expected parse): {c.Name} | input='{c.Input}' | error='{r.Error}'");
                            continue;
                        }

                        // Optional extra asserts (typed parse or equivalence checks)
                        c.ExtraAssert?.Invoke();
                    }
                    else
                    {
                        var r = QuantityParser.ParseWithWarnings(c.Input, Inv);
                        if (r.Success)
                        {
                            failures.Add($"FAIL (expected failure): {c.Name} | input='{c.Input}' | parsed='{r.Value}'");
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (c.ShouldParse)
                        failures.Add($"THREW (expected parse): {c.Name} | input='{c.Input}' | ex='{ex.GetType().Name}: {ex.Message}'");
                    else
                        ; // throwing is fine for fail cases; ParseWithWarnings should ideally not throw, but this is acceptable for now
                }
            }

            if (failures.Count > 0)
            {
                Assert.Fail("Copy/paste mega corpus failures:\n- " + string.Join("\n- ", failures));
            }
        }

        // ----------------------
        // Helper assertions
        // ----------------------

        private static bool AssertPressure(string text, decimal expectedPaSI)
        {
            var p = Pressure.Parse(text, Inv);
            Assert.AreEqual(expectedPaSI, p.AsSI, 1e-12m, $"Pressure.AsSI mismatch for '{text}'");
            return true;
        }

        private static bool AssertAcceleration(string text, decimal expectedAccSI)
        {
            var a = Acceleration.Parse(text, Inv);
            Assert.AreEqual(expectedAccSI, a.AsSI, 1e-12m, $"Acceleration.AsSI mismatch for '{text}'");
            return true;
        }

        private static bool AssertUnknownSIEqual(string a, string b)
        {
            var r1 = QuantityParser.ParseWithWarnings(a, Inv);
            var r2 = QuantityParser.ParseWithWarnings(b, Inv);

            Assert.IsTrue(r1.Success && r1.Value is not null, $"Expected parse success for '{a}'. Error: {r1.Error}");
            Assert.IsTrue(r2.Success && r2.Value is not null, $"Expected parse success for '{b}'. Error: {r2.Error}");

            var u1 = r1.Value!;
            var u2 = r2.Value!;

            Assert.IsTrue(u1.Unit.GetSIUnitsystem() == u2.Unit.GetSIUnitsystem(),
                $"SI unit mismatch: '{a}' vs '{b}'");

            Assert.AreEqual(((EngineeringUnits.BaseUnit)u2).AsSI, ((EngineeringUnits.BaseUnit)u1).AsSI, 1e-12m,
                $"AsSI mismatch: '{a}' vs '{b}'");

            return true;
        }
    }
}