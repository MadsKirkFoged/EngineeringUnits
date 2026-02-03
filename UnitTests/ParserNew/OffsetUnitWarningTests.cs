using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class OffsetUnitWarningTests
    {
        private static readonly CultureInfo Inv = CultureInfo.InvariantCulture;

        [TestMethod]
        public void UnitExpression_WithOffsetTemperature_InCompound_ShouldWarn_AndRewrite()
        {
            // Example that should trigger offset handling
            var ok = UnitExpressionParser.TryParseWithWarnings("W/°C", out var unit, out var warnings, out var error);

            Assert.IsTrue(ok, $"Expected OK, error: {error}");
            Assert.IsNotNull(unit);
            Assert.IsNotNull(warnings);
            Assert.IsTrue(warnings.Count > 0, "Expected at least one warning.");

            Assert.IsTrue(warnings[0].Code == "OFFSET_UNIT_IN_COMPOUND", "Expected OFFSET_UNIT_IN_COMPOUND warning code.");
        }

        [TestMethod]
        public void UnknownUnit_WithOffsetTemperature_InCompound_ShouldReturnSuccess_WithWarning()
        {
            var r = UnknownUnitParser.ParseWithWarnings("1 W/°C", Inv);

            Assert.IsTrue(r.Success, $"Expected OK, error: {r.Error}");
            Assert.IsNotNull(r.Value);
            Assert.IsTrue(r.Warnings.Count > 0, "Expected warnings for offset temp in compound.");
        }
    }
}