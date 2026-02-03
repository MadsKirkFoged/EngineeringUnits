using System;
using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EngineeringUnits;
using EngineeringUnits.Units;
using EngineeringUnits.Parsing;

namespace UnitTests.Parsing
{
    [TestClass]
    public class EnergyParserTests
    {
        private static double Joules(Energy e) => e.As(EnergyUnit.Joule);

        [DataTestMethod]
        [DataRow("10 J", 10.0)]
        [DataRow("10 joule", 10.0)]
        [DataRow("10 kJ", 10_000.0)]
        [DataRow("1 Wh", 3600.0)]
        [DataRow("1 kWh", 3_600_000.0)]
        public void Energy_DirectTokens(string input, double expectedJ)
        {
            var e = Energy.Parse(input, CultureInfo.InvariantCulture);

            Assert.AreEqual(expectedJ, Joules(e), 1e-6);
        }

        [DataTestMethod]
        [DataRow("1 N*m", 1.0)]
        [DataRow("1 N·m", 1.0)]
        [DataRow("1 kg*m^2/s^2", 1.0)]
        [DataRow("1 W*s", 1.0)]
        [DataRow("1 W*h", 3600.0)]
        public void Energy_Expressions(string input, double expectedJ)
        {
            var e = Energy.Parse(input, CultureInfo.InvariantCulture);

            //Assert.IsTrue(ok, $"Expected parse OK for '{input}'");
            Assert.AreEqual(expectedJ, Joules(e), 1e-3);
        }

        [TestMethod]
        public void Energy_Fails_OnWrongDimension()
        {
          
            Assert.ThrowsException<FormatException>(() =>
            {
                var ok = Energy.Parse("10 N");
            });

        }

        [TestMethod]
        public void Energy_Parse_Throws_OnInvalid()
        {
            Assert.ThrowsException<FormatException>(() =>
            {
                Energy.Parse("10 totallyNotAUnit", CultureInfo.InvariantCulture);
            });
        }
    }
}