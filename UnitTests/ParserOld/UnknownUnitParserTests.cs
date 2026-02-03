using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringUnits.Parsing;
using EngineeringUnits.Units;
using EngineeringUnits;

namespace UnitTests.Parsing
{
    [TestClass]
    public class UnknownUnitParserTests
    {
        [DataTestMethod]
        [DataRow("10 m")]
        [DataRow("2 N*m")]
        [DataRow("3 kg*m^2/s^2")]
        [DataRow("1 W*h")]
        public void UnknownUnitParser_Basic(string input)
        {
            var ok = AnyUnitParser.TryParse(input, out var u, CultureInfo.InvariantCulture);
            Assert.IsTrue(ok, $"Expected parse OK for '{input}'");
            Assert.IsNotNull(u);
        }

        [TestMethod]
        public void UnknownUnitParser_DimensionEquality_EnergyExamples()
        {
            AnyUnitParser.TryParse("1 N*m", out var a, CultureInfo.InvariantCulture);
            AnyUnitParser.TryParse("1 kg*m^2/s^2", out var b, CultureInfo.InvariantCulture);

            // compare SI-normalized unit systems
            Assert.IsTrue(a.Unit.GetSIUnitsystem() == b.Unit.GetSIUnitsystem());
        }
    }
}