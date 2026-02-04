using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class QuantityExpressionParser_InvalidCasesTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        [DataTestMethod]
        [DataRow("10 m + 5 s")]                 // dimension mismatch
        [DataRow("10 °C + 5 m")]                // dimension mismatch
        [DataRow("1 W + 1 V")]                  // dimension mismatch
        [DataRow("10 m + 2 (m^2)")]             // dimension mismatch
        [DataRow("10 + 5 m")]                   // dimension mismatch (dimensionless + length)
        [DataRow("10 m +")]                     // missing operand
        [DataRow("- 10 m")]                     // missing left operand
        [DataRow("10 m ** 2")]                  // invalid operator sequence
        [DataRow("10 m // 2")]                  // invalid operator sequence
        [DataRow("(10 m + 2 m")]                // mismatched parentheses
        [DataRow("10 m + 2 m)")]                // mismatched parentheses
        //[DataRow("10m + + 2m")]                 // double operator
        [DataRow("10m -- 2m")]                  // ambiguous unary/binary; decide later
        [DataRow(")10 m(")]                     // nonsense
        [DataRow("m + 10 m")]                   // literal missing number
        [DataRow("10 totallyNotAUnit + 1 m")]   // unknown token in literal
        public void InvalidExpressions_ShouldReturnFriendlyFailure(string expr)
        {
            var r = QuantityExpressionParser.ParseWithWarnings(expr, Inv);

            Assert.IsFalse(r.Success, $"Expected failure for '{expr}' but parsed OK.");
            Assert.IsFalse(string.IsNullOrWhiteSpace(r.Error), $"Expected error message for '{expr}'.");
        }

        [DataTestMethod]
        [DataRow("10 m + 5 s")]
        [DataRow("10 m +")]
        [DataRow("(10 m + 2 m")]
        public void InvalidExpressions_StrictParse_ShouldThrow(string expr)
        {
            Assert.ThrowsException<System.FormatException>(() =>
            {
                _ = QuantityExpressionParser.Parse(expr, Inv);
            });
        }
    }
}