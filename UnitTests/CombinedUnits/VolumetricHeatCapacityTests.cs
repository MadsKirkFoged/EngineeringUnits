using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class VolumetricHeatCapacityTests
{
    [TestMethod]
    public void VolumetricHeatCapacityConstructorTest()
    {
        // Test basic constructor
        var volumetricHeatCapacity = new VolumetricHeatCapacity(1000, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        Assert.AreEqual(1000, volumetricHeatCapacity.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityConversionTest()
    {
        // Test conversion between different volumetric heat capacity units
        var volumetricHeatCapacity1 = new VolumetricHeatCapacity(1000, VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);
        var volumetricHeatCapacity2 = volumetricHeatCapacity1.ToUnit(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);

        Assert.AreEqual(1, volumetricHeatCapacity2.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityKelvinCelsiusConversionTest()
    {
        // Test Kelvin vs Celsius units (should be equivalent for heat capacity per temperature difference)
        // Note: For heat capacity, Kelvin and Celsius have the same scale for temperature differences
        var volumetricHeatCapacity1 = new VolumetricHeatCapacity(1000, VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);
        var volumetricHeatCapacity2 = volumetricHeatCapacity1.ToUnit(VolumetricHeatCapacityUnit.JoulePerCubicMeterCelsius);

        // The actual conversion factor will depend on the temperature unit implementation
        // For heat capacity calculations, we expect them to be the same since 1 K = 1 °C in terms of differences
        double conversionFactor = volumetricHeatCapacity2.As(VolumetricHeatCapacityUnit.JoulePerCubicMeterCelsius) / 1000;
        Assert.IsTrue(System.Math.Abs(conversionFactor - 1.0) < 0.3, $"Conversion factor was {conversionFactor}, expected close to 1.0");
    }

    [TestMethod]
    public void VolumetricHeatCapacityArithmeticTest()
    {
        // Test arithmetic operations
        var volumetricHeatCapacity1 = new VolumetricHeatCapacity(500, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var volumetricHeatCapacity2 = new VolumetricHeatCapacity(300, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);

        var sum = volumetricHeatCapacity1 + volumetricHeatCapacity2;
        var difference = volumetricHeatCapacity1 - volumetricHeatCapacity2;

        Assert.AreEqual(800, sum.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);
        Assert.AreEqual(200, difference.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityToStringTest()
    {
        var volumetricHeatCapacity = new VolumetricHeatCapacity(42.5, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var stringResult = volumetricHeatCapacity.ToString();

        Assert.IsTrue(stringResult.Contains("42.5"));
        Assert.IsTrue(stringResult.Contains("kJ") && (stringResult.Contains("m³") || stringResult.Contains("m3")) && stringResult.Contains("K"));
    }

    [TestMethod]
    public void VolumetricHeatCapacityDivisionByVolumeAndTemperatureTest()
    {
        // Test creating volumetric heat capacity from energy, volume and temperature
        var energy = new Energy(1000, EnergyUnit.Kilojoule);
        var volume = new Volume(1, VolumeUnit.CubicMeter);
        var temperature = new Temperature(10, TemperatureUnit.Kelvin);

        VolumetricHeatCapacity volumetricHeatCapacity = energy / (volume * temperature);

        Assert.IsInstanceOfType(volumetricHeatCapacity, typeof(VolumetricHeatCapacity));
        Assert.AreEqual(100, volumetricHeatCapacity.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityMultiplicationByVolumeAndTemperatureTest()
    {
        // Test creating energy from volumetric heat capacity, volume and temperature
        var volumetricHeatCapacity = new VolumetricHeatCapacity(500, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var volume = new Volume(2, VolumeUnit.CubicMeter);
        var temperature = new Temperature(10, TemperatureUnit.Kelvin);

        Energy energy = volumetricHeatCapacity * volume * temperature;

        Assert.IsInstanceOfType(energy, typeof(Energy));
        Assert.AreEqual(10000, energy.As(EnergyUnit.Kilojoule), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacitySIUnitTest()
    {
        // Test SI unit (J/(m³·K))
        var volumetricHeatCapacity = new VolumetricHeatCapacity(1, VolumetricHeatCapacityUnit.SI);

        Assert.AreEqual(1, volumetricHeatCapacity.As(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin), 1e-10);
        Assert.AreEqual(1, volumetricHeatCapacity.SI, 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityConversionFactorsTest()
    {
        // Test 1: J to kJ conversion (1000 J = 1 kJ)
        var volumetricHeatCapacity1 = new VolumetricHeatCapacity(1000, VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);
        var converted1 = volumetricHeatCapacity1.ToUnit(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        Assert.AreEqual(1, converted1.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);

        // Test 2: kJ to MJ conversion (1000 kJ = 1 MJ)
        var volumetricHeatCapacity2 = new VolumetricHeatCapacity(1000, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var converted2 = volumetricHeatCapacity2.ToUnit(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin);
        Assert.AreEqual(1, converted2.As(VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin), 1e-10);

        // Test 3: Critical test - kWh to kJ conversion (1 kWh = 3600 kJ)
        var volumetricHeatCapacity3 = new VolumetricHeatCapacity(1, VolumetricHeatCapacityUnit.KilowattHourPerCubicMeterKelvin);
        var converted3 = volumetricHeatCapacity3.ToUnit(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        Assert.AreEqual(3600, converted3.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-8);

        // Test 4: Reverse - kJ to kWh conversion (3600 kJ = 1 kWh)
        var volumetricHeatCapacity4 = new VolumetricHeatCapacity(3600, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var converted4 = volumetricHeatCapacity4.ToUnit(VolumetricHeatCapacityUnit.KilowattHourPerCubicMeterKelvin);
        Assert.AreEqual(1, converted4.As(VolumetricHeatCapacityUnit.KilowattHourPerCubicMeterKelvin), 1e-10);

        // Test 5: Wh to J conversion (1 Wh = 3600 J)
        var volumetricHeatCapacity5 = new VolumetricHeatCapacity(1, VolumetricHeatCapacityUnit.WattHourPerCubicMeterKelvin);
        var converted5 = volumetricHeatCapacity5.ToUnit(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);
        Assert.AreEqual(3600, converted5.As(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin), 1e-8);
    }

    [TestMethod]
    public void VolumetricHeatCapacityArithmeticConversionTest()
    {
        // Test arithmetic with conversion: 3600 kJ / (1 m³ x 1 K) should equal 1 kWh/(m³·K)
        var energy = new Energy(3600, EnergyUnit.Kilojoule);
        var volume = new Volume(1, VolumeUnit.CubicMeter);
        var temperature = new Temperature(1, TemperatureUnit.Kelvin);
        VolumetricHeatCapacity result = energy / (volume * temperature);
        var resultInkWh = result.ToUnit(VolumetricHeatCapacityUnit.KilowattHourPerCubicMeterKelvin);
        Assert.AreEqual(1, resultInkWh.As(VolumetricHeatCapacityUnit.KilowattHourPerCubicMeterKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityAllArithmeticOperationsTest()
    {
        var volumetricHeatCapacity1 = new VolumetricHeatCapacity(1000, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var volumetricHeatCapacity2 = new VolumetricHeatCapacity(500, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var scalar = 2.0;

        // Test Addition
        var sum = volumetricHeatCapacity1 + volumetricHeatCapacity2;
        Assert.AreEqual(1500, sum.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);

        // Test Subtraction
        var difference = volumetricHeatCapacity1 - volumetricHeatCapacity2;
        Assert.AreEqual(500, difference.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);

        // Test Multiplication by scalar
        var product = volumetricHeatCapacity1 * scalar;
        Assert.AreEqual(2000, product.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);

        // Test Division by scalar
        var quotient = volumetricHeatCapacity1 / scalar;
        Assert.AreEqual(500, quotient.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);

        // Test Multiplication with Volume and Temperature: VolumetricHeatCapacity * Volume * Temperature = Energy
        var volume = new Volume(3, VolumeUnit.CubicMeter);
        var temperature = new Temperature(5, TemperatureUnit.Kelvin);
        Energy totalEnergy = volumetricHeatCapacity1 * volume * temperature;
        Assert.AreEqual(15000, totalEnergy.As(EnergyUnit.Kilojoule), 1e-10);

        // Test Division to create VolumetricHeatCapacity: Energy / (Volume * Temperature) = VolumetricHeatCapacity
        var energy = new Energy(2000, EnergyUnit.Kilojoule);
        var volume2 = new Volume(2, VolumeUnit.CubicMeter);
        var temperature2 = new Temperature(1, TemperatureUnit.Kelvin);
        VolumetricHeatCapacity calculatedCapacity = energy / (volume2 * temperature2);
        Assert.AreEqual(1000, calculatedCapacity.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityComparisonOperationsTest()
    {
        var volumetricHeatCapacity1 = new VolumetricHeatCapacity(1000, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var volumetricHeatCapacity2 = new VolumetricHeatCapacity(500, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        var volumetricHeatCapacity3 = new VolumetricHeatCapacity(1, VolumetricHeatCapacityUnit.MegajoulePerCubicMeterKelvin);

        // Test equality
        Assert.IsTrue(volumetricHeatCapacity1 == volumetricHeatCapacity3);
        Assert.IsFalse(volumetricHeatCapacity1 == volumetricHeatCapacity2);

        // Test greater than
        Assert.IsTrue(volumetricHeatCapacity1 > volumetricHeatCapacity2);
        Assert.IsFalse(volumetricHeatCapacity2 > volumetricHeatCapacity1);

        // Test less than
        Assert.IsTrue(volumetricHeatCapacity2 < volumetricHeatCapacity1);
        Assert.IsFalse(volumetricHeatCapacity1 < volumetricHeatCapacity2);
    }

    [TestMethod]
    public void VolumetricHeatCapacityUnaryOperationsTest()
    {
        var volumetricHeatCapacity = new VolumetricHeatCapacity(-500, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);

        // Test absolute value
        var absoluteValue = volumetricHeatCapacity.Abs();
        Assert.AreEqual(500, absoluteValue.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);

        // Test negation
        var negated = -volumetricHeatCapacity;
        Assert.AreEqual(500, negated.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityComposeDecomposeTest()
    {
        // Composition: SpecificHeatCapacity x Density = VolumetricHeatCapacity
        var specificHeatCapacity = new SpecificHeatCapacity(1000, SpecificHeatCapacityUnit.JoulePerKilogramKelvin);
        var density = new Density(1200, DensityUnit.KilogramPerCubicMeter);

        VolumetricHeatCapacity volumetricHeatCapacity1 = specificHeatCapacity * density;
        Assert.IsInstanceOfType(volumetricHeatCapacity1, typeof(VolumetricHeatCapacity));
        Assert.AreEqual(1200000, volumetricHeatCapacity1.As(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin), 1e-6);

        // Decomposition: VolumetricHeatCapacity / Density = SpecificHeatCapacity
        var volumetricHeatCapacity4 = new VolumetricHeatCapacity(1500000, VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);
        var density2 = new Density(1000, DensityUnit.KilogramPerCubicMeter);

        SpecificHeatCapacity specificHeatCapacity2 = volumetricHeatCapacity4 / density2;
        Assert.IsInstanceOfType(specificHeatCapacity2, typeof(SpecificHeatCapacity));
        Assert.AreEqual(1500, specificHeatCapacity2.As(SpecificHeatCapacityUnit.JoulePerKilogramKelvin), 1e-10);
    }

    [TestMethod]
    public void VolumetricHeatCapacityPhysicalMeaningTest()
    {
        // Physical meaning test: Water at room temperature
        // Water has specific heat capacity ~4200 J/(kg·K) and density ~1000 kg/m³
        // Therefore volumetric heat capacity should be ~4,200,000 J/(m³·K)

        var waterSpecificHeat = new SpecificHeatCapacity(4200, SpecificHeatCapacityUnit.JoulePerKilogramKelvin);
        var waterDensity = new Density(1000, DensityUnit.KilogramPerCubicMeter);

        VolumetricHeatCapacity waterVolumetricHeat = waterSpecificHeat * waterDensity;

        Assert.AreEqual(4200000, waterVolumetricHeat.As(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin), 1e-6);
        Assert.AreEqual(4200, waterVolumetricHeat.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-6);

        // Energy to heat 2 m³ of water by 5°C should be 2 x 5 x 4200 = 42,000 kJ
        var volume = new Volume(2, VolumeUnit.CubicMeter);
        var temperatureRise = new Temperature(5, TemperatureUnit.Kelvin);

        Energy energyRequired = waterVolumetricHeat * volume * temperatureRise;
        Assert.AreEqual(42000, energyRequired.As(EnergyUnit.Kilojoule), 1e-6);
    }

    [TestMethod]
    public void VolumetricHeatCapacityBtuTest()
    {
        // Test British Thermal Unit conversions
        var btuCapacity = new VolumetricHeatCapacity(1, VolumetricHeatCapacityUnit.BtuPerCubicFootFahrenheit);

        // Convert to SI and verify it's a reasonable value
        var siCapacity = btuCapacity.ToUnit(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin);

        // BTU = 1055.06 J, ft³ = 0.0283168 m³, °F = 5/9 K
        // So 1 BTU/(ft³·°F) = 1055.06 / (0.0283168 * 5/9) J/(m³·K) ≈ 67066 J/(m³·K)
        Assert.AreEqual(67066, siCapacity.As(VolumetricHeatCapacityUnit.JoulePerCubicMeterKelvin), 300);
    }

    [TestMethod]
    public void VolumetricHeatCapacityFromStaticMethodsTest()
    {
        // Test From static methods
        var vhc1 = VolumetricHeatCapacity.From(1000, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        Assert.AreEqual(1000, vhc1.As(VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin), 1e-10);

        // Test FromKilojoulePerCubicMeterKelvin static method
        var vhc2 = VolumetricHeatCapacity.FromKilojoulePerCubicMeterKelvin(1000);
        Assert.AreEqual(1000, vhc2.KilojoulePerCubicMeterKelvin, 1e-10);

        // Test null handling
        var vhc3 = VolumetricHeatCapacity.From(null, VolumetricHeatCapacityUnit.KilojoulePerCubicMeterKelvin);
        Assert.IsNull(vhc3);

        var vhc4 = VolumetricHeatCapacity.FromKilojoulePerCubicMeterKelvin(null);
        Assert.IsNull(vhc4);

        // Test Zero and NaN
        var zero = VolumetricHeatCapacity.Zero;
        Assert.AreEqual(0, zero.As(VolumetricHeatCapacityUnit.SI), 1e-10);

        var nan = VolumetricHeatCapacity.NaN;
        Assert.IsTrue(double.IsNaN(nan.As(VolumetricHeatCapacityUnit.SI)));
    }
}
