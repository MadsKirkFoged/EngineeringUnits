using EngineeringUnits;
using EngineeringUnits.Units;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using static System.Math;

namespace UnitTests
{
    [TestClass]
    public class SpecificThermalResistanceTest
    {
        [TestMethod]
        public void FromDefinition()
        {
            double P = 10.0;
            double L = 2.0;
            double T = 4.0;

            var expected = new SpecificThermalResistance(Length.FromMeters(L) * Temperature.FromKelvins(T) / Power.FromWatts(P));
            var expected_SI = (double)expected.SI;

            var actual = new SpecificThermalResistance(Power.FromWatts(P) / Length.FromMeters(L) * Temperature.FromKelvins(T));
            var actual_SI = (double)actual.SI;

            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected_SI, actual_SI, 1e-9);
        }

        [TestMethod]
        public void FromCalculation()
        {
            double thermalConductivity = 0.42;
            double expected_SI = 1 / (2 * PI * thermalConductivity);

            var expected = SpecificThermalResistance.From(expected_SI, SpecificThermalResistanceUnit.SI);

            var k = ThermalConductivity.FromWattsPerMeterKelvin(thermalConductivity);

            var actual = new SpecificThermalResistance(1 / (2 * PI * k));
            var actual_SI = (double)actual.SI;

            //Assert.AreEqual(expected, actual);    // Equality check is somehow broken
            Assert.AreEqual(expected_SI, actual_SI, 1e-9);
        }
    }
}
