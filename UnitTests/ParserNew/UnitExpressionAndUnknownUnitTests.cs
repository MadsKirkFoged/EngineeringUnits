using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class UnitExpressionAndUnknownUnitTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;
        private static readonly CultureInfo Da = CultureInfo.GetCultureInfo("da-DK");

        [DataTestMethod]
        [DataRow("kg*m^2/s^2")]
        [DataRow("kg m^2 / s^2")]
        [DataRow("N*m")]
        [DataRow("N m")]
        [DataRow("W*h")]
        [DataRow("W h")]
        [DataRow("(kg*m^2)/(s^2)")]
        [DataRow("kg*m^2*s^-2")]
        public void UnitExpressionParser_ShouldParse_CommonForms(string expr)
        {
            var ok = UnitExpressionParser.TryParseWithWarnings(expr, out var unit, out var warnings, out var error);
            Assert.IsTrue(ok, $"Expected OK for '{expr}', error: {error}");
            Assert.IsNotNull(unit);
            Assert.IsNotNull(warnings);
        }

        [DataTestMethod]
        [DataRow("1 kg m^2 / s^2")]
        [DataRow("1 N m")]
        [DataRow("1 W h")]
        public void UnknownUnitParser_ShouldParse_CommonExpressions(string input)
        {
            var r = UnknownUnitParser.ParseWithWarnings(input, Inv);
            Assert.IsTrue(r.Success, $"Expected OK for '{input}', error: {r.Error}");
            Assert.IsNotNull(r.Value);
            Assert.IsFalse(string.IsNullOrWhiteSpace(r.Normalized));
        }

        [TestMethod]
        public void UnknownUnitParser_ShouldParse_CommaDecimal_Culture()
        {
            var r = UnknownUnitParser.ParseWithWarnings("1,5 m", Da);
            Assert.IsTrue(r.Success, $"Expected OK, error: {r.Error}");
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("   ")]
        [DataRow("10")]
        [DataRow("m")]
        [DataRow("abc m")]
        [DataRow("10 totallyNotAUnit")]
        [DataRow("10 kg ** m")]
        [DataRow("10 (kg m")]
        [DataRow("10 kg m^")]
        public void UnknownUnitParser_ShouldFail_Friendly(string input)
        {
            var r = UnknownUnitParser.ParseWithWarnings(input, Inv);
            Assert.IsFalse(r.Success, $"Expected FAIL for '{input}'");
            Assert.IsFalse(string.IsNullOrWhiteSpace(r.Error), "Expected an error message.");
        }
    }
}