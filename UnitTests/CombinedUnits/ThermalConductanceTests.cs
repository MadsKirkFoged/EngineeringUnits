using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class ThermalConductanceTests
{
    [TestMethod]
    public void ThermalConductance_BasicUsage_WorksCorrectly()
    {
        // Arrange - Example from heat exchanger: ka = 17.4 W/(m²·K), Aa = 39.58 m²
        var ka = HeatTransferCoefficient.FromWattPerSquareMeterKelvin(17.4);
        var area = Area.FromSquareMeter(39.58);

        // Act - Calculate thermal conductance (KA = ka * Area)
        var expectedValueInWattPerKelvin = ka.WattPerSquareMeterKelvin * area.SquareMeter;
        var thermalConductance = ThermalConductance.FromWattPerKelvin(expectedValueInWattPerKelvin);
        ThermalConductance res = ka * area;

        // Assert
        Assert.AreEqual(expectedValueInWattPerKelvin, thermalConductance.WattPerKelvin, 1e-10);
        Assert.AreEqual(res, thermalConductance);
    }

    [TestMethod]
    public void ThermalConductance_DifferentUnits_ConversionsWork()
    {
        // Arrange
        var thermalConductance = ThermalConductance.FromWattPerKelvin(1000);

        // Act & Assert
        Assert.AreEqual(1000, thermalConductance.WattPerKelvin, 1e-10);
        Assert.AreEqual(1, thermalConductance.KilowattPerKelvin, 1e-10);
        Assert.AreEqual(0.001, thermalConductance.MegawattPerKelvin, 1e-10);
        Assert.AreEqual(1000000, thermalConductance.MilliwattPerKelvin, 1e-10);
    }

    [TestMethod]
    public void ThermalConductance_FromHeatTransferCoefficient_CalculationIsCorrect()
    {
        // This test verifies the calculation: ThermalConductance = HeatTransferCoefficient x Area

        // Arrange
        var heatTransferCoeff = HeatTransferCoefficient.FromWattPerSquareMeterKelvin(25.0); // W/(m²·K)
        var area = Area.FromSquareMeter(50.0); // m²

        // Act
        var expectedThermalConductance = heatTransferCoeff.WattPerSquareMeterKelvin * area.SquareMeter; // Should be 1250 W/K
        var actualThermalConductance = ThermalConductance.FromWattPerKelvin(expectedThermalConductance);

        // Assert
        Assert.AreEqual(1250.0, actualThermalConductance.WattPerKelvin, 1e-10);
    }

    [TestMethod]
    public void ThermalConductance_PowerCalculation_VerifiesHeatTransferEquation()
    {
        // This test verifies: Q = KA x DeltaT (Heat transfer equation)

        // Arrange
        var thermalConductance = ThermalConductance.FromWattPerKelvin(500.0); // W/K
        var temperatureDifference = Temperature.FromKelvin(20.0); // K

        // Act - Calculate power using Q = KA x DeltaT
        var power = Power.FromWatt(thermalConductance.WattPerKelvin * temperatureDifference.Kelvin);

        // Assert
        Assert.AreEqual(10000.0, power.Watt, 1e-10); // 500 W/K x 20 K = 10000 W
    }
}
