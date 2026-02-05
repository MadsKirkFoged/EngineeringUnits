using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class CopyPasteCorpusTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        // -------------------------
        // SHOULD PARSE (normalized)
        // -------------------------

        public static IEnumerable<object[]> ShouldParseCases()
        {
            // Each case: input, equivalentCanonical (ASCII-ish) used for equality check
            // We assert:
            //  - both parse
            //  - SI unit dimensions match
            //  - AsSI values match
            yield return Case("1 kg*m^2/s^2", "1 kg*m^2/s^2");

            // Superscripts for exponent digits (common copy/paste) [1](https://www.youtube.com/watch?v=uRjcZkHxi4g)[9](https://www.nuget.org/packages/EngineeringUnits/1.1.100)
            yield return Case("1 kg*m²/s²", "1 kg*m^2/s^2");
            yield return Case("1 m/s²", "1 m/s^2");
            yield return Case("1 m·s⁻²", "1 m*s^-2"); // superscript minus + digit

            // Unicode minus sign U+2212 often pasted from Word/PDF/math pages [3](https://www.autodesk.com/support/technical/article/caas/sfdcarticles/sfdcarticles/When-opening-drawings-exported-from-other-platforms-or-software-the-units-are-read-incorrectly-in-Civil-3D.html)[10](https://forums.autodesk.com/t5/revit-api-forum/change-project-units/td-p/12858468)
            yield return Case("1 kg*m^2*s^−2", "1 kg*m^2*s^-2"); // ^−2 using U+2212

            // Dot operator U+22C5 is used as multiplication in math typography [4](https://github.com/orgs/community/discussions/44370)[11](https://mystry-geek.blogspot.com/2024/12/compile-time-unit-checking-enhancing.html)
            yield return Case("1 N⋅m", "1 N*m");

            // Multiplication sign U+00D7 commonly used instead of '*' [5](https://www.howtogeek.com/devops/how-to-download-single-files-from-a-github-repository/)[12](blob:https://m365.cloud.microsoft/d82160bd-d1e0-4858-a8e8-1be8734b5ecb)
            yield return Case("1 N×m", "1 N*m");

            // Division sign and fraction slashes (common in formatted sources)
            yield return Case("1 m÷s", "1 m/s");
            yield return Case("1 m⁄s", "1 m/s");
            yield return Case("1 m∕s", "1 m/s");

            // NBSP between number and unit (common in HTML/Word) [6](https://www.engineeringtoolbox.net/getsimdata/getunisim)[13](https://www.etsi.org/deliver/etsi_ts/121100_121199/121111/16.01.00_60/ts_121111v160100p.pdf)
            yield return Case("10\u00A0kg", "10 kg");

            // Greek mu vs micro sign confusion is common [8](https://github.blog/developer-skills/github/beginners-guide-to-github-repositories-how-to-create-your-first-repo/)[7](https://github.com/DI-Lab-THU/EngineeringSim)
            yield return Case("1 μm", "1 µm");

            // Ohm sign vs Greek omega confusion is common [8](https://github.blog/developer-skills/github/beginners-guide-to-github-repositories-how-to-create-your-first-repo/)[14](https://people.freebsd.org/~kami/2015-32C3/paper-twocolumn-grey.pdf)
            yield return Case("1 Ω", "1 Ω");

            // Degree ordinal indicator sometimes appears instead of degree sign
            yield return Case("1 ºC", "1 °C");

            // Fullwidth parentheses/brackets/braces (copy/paste from Asian typography)
            yield return Case("1 （kg*m^2）/s^2", "1 (kg*m^2)/s^2");

            yield return Case("1 m\u200B/s", "1 m/s");       // zero-width space (if not removed)
            yield return Case("1 m\u200C/s", "1 m/s"); // ZWNJ
            yield return Case("1 m\u200D/s", "1 m/s"); // ZWJ
            yield return Case("1 m\u2060/s", "1 m/s"); // WORD JOINER
            yield return Case("1 m\uFEFF/s", "1 m/s"); // ZERO WIDTH NO-BREAK SPACE (BOM)
        }

        private static object[] Case(string input, string equivalentCanonical)
            => new object[] { input, equivalentCanonical };

        [DataTestMethod]
        [DynamicData(nameof(ShouldParseCases), DynamicDataSourceType.Method)]
        public void CopyPasteInputs_ShouldParse_AndMatchCanonical(string input, string canonical)
        {
            // Parse both forms
            var r1 = QuantityParser.ParseWithWarnings(input, Inv);
            Assert.IsTrue(r1.Success, $"Expected parse success for '{input}'. Error: {r1.Error}");

            var r2 = QuantityParser.ParseWithWarnings(canonical, Inv);
            Assert.IsTrue(r2.Success, $"Expected parse success for canonical '{canonical}'. Error: {r2.Error}");

            var u1 = r1.Value!;
            var u2 = r2.Value!;

            // Compare SI dimension (UnitSystem equality is dimension-based) and SI value
            Assert.IsTrue(u1.Unit.GetSIUnitsystem() == u2.Unit.GetSIUnitsystem(),
                $"SI unit mismatch. input='{input}', canonical='{canonical}', u1='{u1.Unit}', u2='{u2.Unit}'");

            Assert.AreEqual(((EngineeringUnits.BaseUnit)u2).AsSI, ((EngineeringUnits.BaseUnit)u1).AsSI, 1e-12m,
                $"AsSI mismatch. input='{input}', canonical='{canonical}'");
        }

        // -------------------------
        // SHOULD FAIL (ambiguous)
        // -------------------------

        public static IEnumerable<object[]> ShouldFailCases()
        {
            // Subscripts are ambiguous (indices/labels, chemical formulas) [1](https://www.youtube.com/watch?v=uRjcZkHxi4g)[2](https://github.com/MadsKirkFoged/)
            yield return Fail("1 m₂");              // m sub 2 (index), not exponent
            yield return Fail("1 s₋²");             // subscript minus + digit
            yield return Fail("1 kg*m₂/s^2");       // mixed index in expression
            yield return Fail("1 H₂O");             // chemical formula style
            yield return Fail("1 m₁/s");            // indexed variable style

            // Random Unicode that often indicates OCR/formatting problems
            

        }

        private static object[] Fail(string input) => new object[] { input };

        [DataTestMethod]
        [DynamicData(nameof(ShouldFailCases), DynamicDataSourceType.Method)]
        public void CopyPasteInputs_AmbiguousOrUnsupported_ShouldFail(string input)
        {
            var r = QuantityParser.ParseWithWarnings(input, Inv);
            Assert.IsFalse(r.Success, $"Expected failure for '{input}', but parsed OK as '{r.Value}'.");

            // Optional: ensure we get a meaningful message (once you add better bubbling)
            Assert.IsFalse(string.IsNullOrWhiteSpace(r.Error), $"Expected a helpful error for '{input}'.");
        }
    }
}