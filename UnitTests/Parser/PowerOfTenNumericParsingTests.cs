using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using EngineeringUnits;

namespace UnitTests.Parsing
{
    [TestClass]
    public class PowerOfTenNumericParsingTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        public static IEnumerable<object[]> ShouldParse()
        {
            // e/E scientific notation (double.TryParse supports this with NumberStyles.Float) [1](https://learn.microsoft.com/en-us/dotnet/api/system.double.tryparse?view=net-10.0)[2](https://learn.microsoft.com/en-us/answers/questions/1294430/in-c-why-can-double-tryparse%28%29-parse-numbers-in-sc)
            yield return Case("1e1 Pa", 10m);
            yield return Case("1E1 Pa", 10m);
            yield return Case("1e+1 Pa", 10m);
            yield return Case("1e-1 Pa", 0.1m);

            // Unicode minus in exponent (normalize − -> -) [3](https://unicodeplus.com/U+2212)[4](https://www.fileformat.info/info/unicode/char/2212/index.htm)
            yield return Case("1e−1 Pa", 0.1m); // U+2212

            // caret power (rewrite 10^n -> 1e+n)
            yield return Case("10^1 Pa", 10m);
            yield return Case("10^-1 Pa", 0.1m);
            yield return Case("10^−1 Pa", 0.1m); // U+2212 in exponent [3](https://unicodeplus.com/U+2212)[4](https://www.fileformat.info/info/unicode/char/2212/index.htm)
            yield return Case("10^(−1) Pa", 0.1m);

            // superscript power-of-ten (rewrite 10⁻¹ etc.) [5](https://www.youtube.com/watch?v=uRjcZkHxi4g)[6](https://unicodeplus.com/U+207B)
            yield return Case("10¹ Pa", 10m);
            yield return Case("10⁻¹ Pa", 0.1m);

            // coefficient × 10^n (rewrite to e notation) [7](https://www.howtogeek.com/devops/how-to-download-single-files-from-a-github-repository/)[8](https://unicode-explorer.com/c/22C5)[9](https://github.com/orgs/community/discussions/44370)
            yield return Case("3×10^2 Pa", 300m);
            yield return Case("3⋅10^2 Pa", 300m);
            yield return Case("3·10^2 Pa", 300m);
            yield return Case("3*10^2 Pa", 300m);
            yield return Case("3×10^−2 Pa", 0.03m);

            // "lost caret" copy/paste case: 10−1 (literal Parse only)
            yield return Case("10−1 Pa", 0.1m); // U+2212 [3](https://unicodeplus.com/U+2212)[4](https://www.fileformat.info/info/unicode/char/2212/index.htm)
        }

        public static IEnumerable<object[]> ShouldFail()
        {
            // Ambiguous or unsupported numeric expressions (depending on your policy):
            yield return Fail("10 - 1 Pa");   // spaced subtraction-looking token
            yield return Fail("10^ Pa");      // missing exponent
            yield return Fail("10^--1 Pa");   // malformed
        }

        private static object[] Case(string input, decimal expectedSI)
            => new object[] { input, expectedSI };

        private static object[] Fail(string input)
            => new object[] { input };

        [DataTestMethod]
        [DynamicData(nameof(ShouldParse), DynamicDataSourceType.Method)]
        public void Pressure_Parse_ShouldAcceptPowerOfTenForms(string input, decimal expected)
        {
            var p = Pressure.Parse(input, Inv);
            Assert.AreEqual(expected, p.AsSI, 1e-12m, $"Input '{input}'");
        }

        [DataTestMethod]
        [DynamicData(nameof(ShouldFail), DynamicDataSourceType.Method)]
        public void Pressure_Parse_ShouldRejectMalformedOrAmbiguousPowerForms(string input)
        {
            Assert.ThrowsException<FormatException>(() => Pressure.Parse(input, Inv), $"Input '{input}'");
        }
    }
}