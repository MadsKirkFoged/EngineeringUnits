using EngineeringUnits;
using EngineeringUnits.Units;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SpecificThermalResistanceTest
    {
        [TestMethod]
        public void From_ValueShouldBeEqual()
        {
            SpecificThermalResistance expected = SpecificThermalResistance.From(1.0, SpecificThermalResistanceUnit.SI);

            SpecificThermalResistance actual_1 = SpecificThermalResistance.FromSI(1.0);
            SpecificThermalResistance actual_2 = SpecificThermalResistance.FromMeterDegreeCelsiusPerWatt(1.0);
            SpecificThermalResistance actual_3 = SpecificThermalResistance.FromMeterKelvinPerKilowatt(1000.0);
            SpecificThermalResistance actual_4 = SpecificThermalResistance.FromCentimeterKelvinPerWatt(100.0);

            Assert.AreEqual(expected, actual_1);
            Assert.AreEqual(expected, actual_2);
            Assert.AreEqual(expected, actual_3);
            Assert.AreEqual(expected, actual_4);
        }

        [TestMethod]
        public void FromNullValue_ShouldReturnNull()
        {
            SpecificThermalResistance actual = SpecificThermalResistance.From(null, SpecificThermalResistanceUnit.SI);

            Assert.IsNull(actual);
        }

        [TestMethod]
        public void As_ValueShouldBeEqual()
        {
            SpecificThermalResistance STR = SpecificThermalResistance.FromSI(1.0);

            double actual_1 = STR.As(SpecificThermalResistanceUnit.SI);
            double actual_2 = STR.As(SpecificThermalResistanceUnit.MeterDegreeCelsiusPerWatt);
            double actual_3 = STR.As(SpecificThermalResistanceUnit.MeterKelvinPerKilowatt);
            double actual_4 = STR.As(SpecificThermalResistanceUnit.CentimeterKelvinPerWatt);

            Assert.AreEqual(1.0, actual_1);
            Assert.AreEqual(1.0, actual_2);
            Assert.AreEqual(1000.0, actual_3);
            Assert.AreEqual(100.0, actual_4);
        }

        [TestMethod]
        public void CalculateFromThermalConductivity_ResultShouldBeEqual()
        {
            SpecificThermalResistance expected = SpecificThermalResistance.FromSI(10.0);
            SpecificThermalResistance actual = 1 / ThermalConductivity.FromWattPerMeterKelvin(0.1);

            Assert.AreEqual(expected, actual);
        }
    }
}
