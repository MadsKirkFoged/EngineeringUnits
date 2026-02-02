using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringUnits;
using EngineeringUnits.Units;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class LengthParserTests
    {
        private static double Meters(Length l) => l.As(LengthUnit.Meter);

        [DataTestMethod]
        // Basic
        [DataRow("12.3 m", 12.3)]
        [DataRow("12.3m", 12.3)]
        [DataRow("   12.3   m   ", 12.3)]
        // Synonyms
        [DataRow("10 metre", 10.0)]
        [DataRow("10metre", 10.0)]
        [DataRow("10 meter", 10.0)]
        [DataRow("10Meter", 10.0)]
        // Scientific
        [DataRow("2e3 mm", 2.0)]
        [DataRow("2000 mm", 2.0)]
        [DataRow("0.002 km", 2.0)]
        public void TryParse_Length_Succeeds_AndMatchesMeters(string input, double expectedMeters)
        {
            var ok = LengthParser.TryParse(input, out var length, culture: CultureInfo.InvariantCulture);

            Assert.IsTrue(ok, $"Expected parse OK for '{input}'");
            Assert.AreEqual(expectedMeters, Meters(length), 1e-9, $"Meters mismatch for '{input}'");
        }

        [DataTestMethod]
        // Danish comma decimal
        [DataRow("1,5 m", "da-DK", 1.5)]
        [DataRow("1,5 metre", "da-DK", 1.5)]
        // Also accept dot decimal even under comma culture (because parser tries Invariant too)
        [DataRow("1.5 m", "da-DK", 1.5)]
        public void TryParse_Length_CultureAware(string input, string cultureName, double expectedMeters)
        {
            var culture = CultureInfo.GetCultureInfo(cultureName);

            var ok = LengthParser.TryParse(input, out var length, culture);

            Assert.IsTrue(ok, $"Expected parse OK for '{input}' with culture '{cultureName}'");
            Assert.AreEqual(expectedMeters, Meters(length), 1e-9);
        }

        [DataTestMethod]
        // Prefix short symbol last-resort examples
        // "um" => micro + meter => 1 * 1e-6 m
        [DataRow("1um", 0.000001)]
        // "µm" => micro + meter => 3 * 1e-6 m
        [DataRow("3µm", 0.000003)]
        // "km" should usually resolve directly, but also works if it falls through prefix logic
        [DataRow("2km", 2000.0)]
        public void TryParse_Length_PrefixShort_LastResort(string input, double expectedMeters)
        {
            var ok = LengthParser.TryParse(input, out var length, CultureInfo.InvariantCulture);

            Assert.IsTrue(ok, $"Expected prefix parse OK for '{input}'");
            Assert.AreEqual(expectedMeters, Meters(length), 1e-6, $"Meters mismatch for '{input}'");
        }

        [DataTestMethod]
        // Prefix long name last-resort examples (space tolerated)
        [DataRow("2 mega metre", 2_000_000.0)]
        [DataRow("2 megametre", 2_000_000.0)]
        [DataRow("3 micro metre", 0.000003)]
        [DataRow("3 micrometre", 0.000003)]
        [DataRow("4 kilo meter", 4000.0)]
        public void TryParse_Length_PrefixLong_LastResort(string input, double expectedMeters)
        {
            var ok = LengthParser.TryParse(input, out var length, CultureInfo.InvariantCulture);

            Assert.IsTrue(ok, $"Expected prefix-long parse OK for '{input}'");
            Assert.AreEqual(expectedMeters, Meters(length), 1e-6, $"Meters mismatch for '{input}'");
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("10")]          // missing unit
        [DataRow("m")]           // missing number
        [DataRow("abc m")]       // invalid number
        [DataRow("10 unknown")]  // unknown unit token
        public void TryParse_Length_Fails_OnInvalidInput(string input)
        {
            var ok = LengthParser.TryParse(input, out var _);

            Assert.IsFalse(ok, $"Expected parse FAIL for '{input}'");
        }

        [TestMethod]
        public void Parse_ThrowsFormatException_OnInvalid()
        {
            Assert.ThrowsException<FormatException>(() =>
            {
                _ = LengthParser.Parse("10 unknown", CultureInfo.InvariantCulture);
            });
        }

        [TestMethod]
        public void UnitTokenRegistry_ForLengthUnit_DoesNotHaveAmbiguousTokens()
        {
            // This test will fail early if the registry throws due to token collisions.
            // It’s intentionally here to catch problems like case-insensitive collisions ("nm" vs "NM") etc.
            // If this fails, fix synonyms or make token matching case-sensitive for those tokens.

            // Force registry static init + build
            Assert.IsTrue(UnitTokenRegistry<LengthUnit>.TryResolve("m", out var _));
        }
    }
}