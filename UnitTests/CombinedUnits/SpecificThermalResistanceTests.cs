using EngineeringUnits;
using EngineeringUnits.Units;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class SpecificThermalResistanceTests
{
    [TestMethod]
    public void From_ValueShouldBeEqual()
    {
        var expected = SpecificThermalResistance.From(1.0, SpecificThermalResistanceUnit.SI);

        var actual_1 = SpecificThermalResistance.FromSI(1.0);
        var actual_2 = SpecificThermalResistance.FromMeterDegreeCelsiusPerWatt(1.0);
        var actual_3 = SpecificThermalResistance.FromMeterKelvinPerKilowatt(1000.0);
        var actual_4 = SpecificThermalResistance.FromCentimeterKelvinPerWatt(100.0);

        Assert.AreEqual(expected, actual_1);
        Assert.AreEqual(expected, actual_2);
        Assert.AreEqual(expected, actual_3);
        Assert.AreEqual(expected, actual_4);
    }

    [TestMethod]
    public void FromNullValue_ShouldReturnNull()
    {
        var actual = SpecificThermalResistance.From(null, SpecificThermalResistanceUnit.SI);

        Assert.IsNull(actual);
    }

    [TestMethod]
    public void As_ValueShouldBeEqual()
    {
        var STR = SpecificThermalResistance.FromSI(1.0);

        var actual_1 = STR.As(SpecificThermalResistanceUnit.SI);
        var actual_2 = STR.As(SpecificThermalResistanceUnit.MeterDegreeCelsiusPerWatt);
        var actual_3 = STR.As(SpecificThermalResistanceUnit.MeterKelvinPerKilowatt);
        var actual_4 = STR.As(SpecificThermalResistanceUnit.CentimeterKelvinPerWatt);

        Assert.AreEqual(1.0, actual_1);
        Assert.AreEqual(1.0, actual_2);
        Assert.AreEqual(1000.0, actual_3);
        Assert.AreEqual(100.0, actual_4);
    }

    [TestMethod]
    public void CalculateFromThermalConductivity_ResultShouldBeEqual()
    {
        var expected = SpecificThermalResistance.FromSI(10.0);
        SpecificThermalResistance actual = 1 / ThermalConductivity.FromWattPerMeterKelvin(0.1);

        Assert.AreEqual(expected, actual);
    }
}
