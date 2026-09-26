using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.CombinedUnits;

[TestClass]
public class EnergyDensityTests
{
    [TestMethod]
    public void EnergyDensityConstructorTest()
    {
        // Test basic constructor
        var energyDensity = new EnergyDensity(1000, EnergyDensityUnit.KilojoulePerCubicMeter);
        Assert.AreEqual(1000, energyDensity.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityConversionTest()
    {
        // Test conversion between different energy density units
        var energyDensity1 = new EnergyDensity(1000, EnergyDensityUnit.JoulePerCubicMeter);
        var energyDensity2 = energyDensity1.ToUnit(EnergyDensityUnit.KilojoulePerCubicMeter);

        Assert.AreEqual(1, energyDensity2.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityFromWattHourTest()
    {
        // Test Wh/m³ to kWh/m³ conversion
        var energyDensity1 = new EnergyDensity(1000, EnergyDensityUnit.WattHourPerCubicMeter);
        var energyDensity2 = energyDensity1.ToUnit(EnergyDensityUnit.KilowattHourPerCubicMeter);

        Assert.AreEqual(1, energyDensity2.As(EnergyDensityUnit.KilowattHourPerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityArithmeticTest()
    {
        // Test arithmetic operations
        var energyDensity1 = new EnergyDensity(500, EnergyDensityUnit.KilojoulePerCubicMeter);
        var energyDensity2 = new EnergyDensity(300, EnergyDensityUnit.KilojoulePerCubicMeter);

        var sum = energyDensity1 + energyDensity2;
        var difference = energyDensity1 - energyDensity2;

        Assert.AreEqual(800, sum.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);
        Assert.AreEqual(200, difference.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityToStringTest()
    {
        var energyDensity = new EnergyDensity(42.5, EnergyDensityUnit.KilojoulePerCubicMeter);
        var stringResult = energyDensity.ToString();

        Assert.IsTrue(stringResult.Contains("42.5"));
        Assert.IsTrue(stringResult.Contains("kJ/m³") || stringResult.Contains("kJ/m3"));
    }

    [TestMethod]
    public void EnergyDensityDivisionByVolumeTest()
    {
        // Test creating energy density from energy and volume
        var energy = new Energy(1000, EnergyUnit.Kilojoule);
        var volume = new Volume(1, VolumeUnit.CubicMeter);

        EnergyDensity energyDensity = energy / volume;

        Assert.IsInstanceOfType(energyDensity, typeof(EnergyDensity));
        Assert.AreEqual(1000, energyDensity.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityMultiplicationByVolumeTest()
    {
        // Test creating energy from energy density and volume
        var energyDensity = new EnergyDensity(500, EnergyDensityUnit.KilojoulePerCubicMeter);
        var volume = new Volume(2, VolumeUnit.CubicMeter);

        Energy energy = energyDensity * volume;

        Assert.IsInstanceOfType(energy, typeof(Energy));
        Assert.AreEqual(1000, energy.As(EnergyUnit.Kilojoule), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityLargeUnitsTest()
    {
        // Test large units (GWh/m³)
        var energyDensity1 = new EnergyDensity(1, EnergyDensityUnit.GigawattHourPerCubicMeter);
        var energyDensity2 = energyDensity1.ToUnit(EnergyDensityUnit.MegawattHourPerCubicMeter);

        Assert.AreEqual(1000, energyDensity2.As(EnergyDensityUnit.MegawattHourPerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensitySIUnitTest()
    {
        // Test SI unit (J/m³)
        var energyDensity = new EnergyDensity(1, EnergyDensityUnit.SI);

        Assert.AreEqual(1, energyDensity.As(EnergyDensityUnit.JoulePerCubicMeter), 1e-10);
        Assert.AreEqual(1, energyDensity.SI, 1e-10);
    }

    [TestMethod]
    public void EnergyDensityConversionFactorsTest()
    {
        // Test 1: J to kJ conversion (1000 J = 1 kJ)
        var energyDensity1 = new EnergyDensity(1000, EnergyDensityUnit.JoulePerCubicMeter);
        var converted1 = energyDensity1.ToUnit(EnergyDensityUnit.KilojoulePerCubicMeter);
        Assert.AreEqual(1, converted1.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);

        // Test 2: kJ to MJ conversion (1000 kJ = 1 MJ)
        var energyDensity2 = new EnergyDensity(1000, EnergyDensityUnit.KilojoulePerCubicMeter);
        var converted2 = energyDensity2.ToUnit(EnergyDensityUnit.MegajoulePerCubicMeter);
        Assert.AreEqual(1, converted2.As(EnergyDensityUnit.MegajoulePerCubicMeter), 1e-10);

        // Test 3: Critical test - kWh to kJ conversion (1 kWh = 3600 kJ)
        var energyDensity3 = new EnergyDensity(1, EnergyDensityUnit.KilowattHourPerCubicMeter);
        var converted3 = energyDensity3.ToUnit(EnergyDensityUnit.KilojoulePerCubicMeter);
        Assert.AreEqual(3600, converted3.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-8);

        // Test 4: Reverse - kJ to kWh conversion (3600 kJ = 1 kWh)
        var energyDensity4 = new EnergyDensity(3600, EnergyDensityUnit.KilojoulePerCubicMeter);
        var converted4 = energyDensity4.ToUnit(EnergyDensityUnit.KilowattHourPerCubicMeter);
        Assert.AreEqual(1, converted4.As(EnergyDensityUnit.KilowattHourPerCubicMeter), 1e-10);

        // Test 5: Wh to J conversion (1 Wh = 3600 J)
        var energyDensity5 = new EnergyDensity(1, EnergyDensityUnit.WattHourPerCubicMeter);
        var converted5 = energyDensity5.ToUnit(EnergyDensityUnit.JoulePerCubicMeter);
        Assert.AreEqual(3600, converted5.As(EnergyDensityUnit.JoulePerCubicMeter), 1e-8);

        // Test 6: MWh to kWh conversion (1 MWh = 1000 kWh)
        var energyDensity6 = new EnergyDensity(1, EnergyDensityUnit.MegawattHourPerCubicMeter);
        var converted6 = energyDensity6.ToUnit(EnergyDensityUnit.KilowattHourPerCubicMeter);
        Assert.AreEqual(1000, converted6.As(EnergyDensityUnit.KilowattHourPerCubicMeter), 1e-8);

        // Test 7: GWh to MWh conversion (1 GWh = 1000 MWh)
        var energyDensity7 = new EnergyDensity(1, EnergyDensityUnit.GigawattHourPerCubicMeter);
        var converted7 = energyDensity7.ToUnit(EnergyDensityUnit.MegawattHourPerCubicMeter);
        Assert.AreEqual(1000, converted7.As(EnergyDensityUnit.MegawattHourPerCubicMeter), 1e-8);

        // Test 8: Chain conversion - GWh to J (1 GWh = 3.6E12 J)
        var energyDensity8 = new EnergyDensity(1, EnergyDensityUnit.GigawattHourPerCubicMeter);
        var converted8 = energyDensity8.ToUnit(EnergyDensityUnit.JoulePerCubicMeter);
        Assert.AreEqual(3.6E12, converted8.As(EnergyDensityUnit.JoulePerCubicMeter), 1e6);
    }

    [TestMethod]
    public void EnergyDensityArithmeticConversionTest()
    {
        // Test arithmetic with conversion: 3600 kJ / 1 m³ should equal 1 kWh/m³
        var energy = new Energy(3600, EnergyUnit.Kilojoule);
        var volume = new Volume(1, VolumeUnit.CubicMeter);
        EnergyDensity result = energy / volume;
        var resultInkWh = result.ToUnit(EnergyDensityUnit.KilowattHourPerCubicMeter);
        Assert.AreEqual(1, resultInkWh.As(EnergyDensityUnit.KilowattHourPerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityAllArithmeticOperationsTest()
    {
        var energyDensity1 = new EnergyDensity(1000, EnergyDensityUnit.KilojoulePerCubicMeter);
        var energyDensity2 = new EnergyDensity(500, EnergyDensityUnit.KilojoulePerCubicMeter);
        var scalar = 2.0;

        // Test Addition: EnergyDensity + EnergyDensity = EnergyDensity
        var sum = energyDensity1 + energyDensity2;
        Assert.AreEqual(1500, sum.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);

        // Test Subtraction: EnergyDensity - EnergyDensity = EnergyDensity
        var difference = energyDensity1 - energyDensity2;
        Assert.AreEqual(500, difference.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);

        // Test Multiplication by scalar: EnergyDensity * scalar = EnergyDensity
        var product = energyDensity1 * scalar;
        Assert.AreEqual(2000, product.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);

        // Test Division by scalar: EnergyDensity / scalar = EnergyDensity
        var quotient = energyDensity1 / scalar;
        Assert.AreEqual(500, quotient.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);

        // Test Multiplication with Volume: EnergyDensity * Volume = Energy
        var volume = new Volume(3, VolumeUnit.CubicMeter);
        Energy totalEnergy = energyDensity1 * volume;
        Assert.AreEqual(3000, totalEnergy.As(EnergyUnit.Kilojoule), 1e-10);

        // Test Division to create EnergyDensity: Energy / Volume = EnergyDensity
        var energy = new Energy(2000, EnergyUnit.Kilojoule);
        var volume2 = new Volume(2, VolumeUnit.CubicMeter);
        EnergyDensity calculatedDensity = energy / volume2;
        Assert.AreEqual(1000, calculatedDensity.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityComparisonOperationsTest()
    {
        var energyDensity1 = new EnergyDensity(1000, EnergyDensityUnit.KilojoulePerCubicMeter);
        var energyDensity2 = new EnergyDensity(500, EnergyDensityUnit.KilojoulePerCubicMeter);
        var energyDensity3 = new EnergyDensity(1, EnergyDensityUnit.MegajoulePerCubicMeter); // Same as 1000 kJ/m³

        // Test equality
        Assert.IsTrue(energyDensity1 == energyDensity3); // 1000 kJ/m³ == 1 MJ/m³
        Assert.IsFalse(energyDensity1 == energyDensity2);

        // Test inequality
        Assert.IsFalse(energyDensity1 != energyDensity3);
        Assert.IsTrue(energyDensity1 != energyDensity2);

        // Test greater than
        Assert.IsTrue(energyDensity1 > energyDensity2);
        Assert.IsFalse(energyDensity2 > energyDensity1);

        // Test less than
        Assert.IsTrue(energyDensity2 < energyDensity1);
        Assert.IsFalse(energyDensity1 < energyDensity2);

        // Test greater than or equal
        Assert.IsTrue(energyDensity1 >= energyDensity2);
        Assert.IsTrue(energyDensity1 >= energyDensity3);

        // Test less than or equal
        Assert.IsTrue(energyDensity2 <= energyDensity1);
        Assert.IsTrue(energyDensity1 <= energyDensity3);
    }

    [TestMethod]
    public void EnergyDensityUnaryOperationsTest()
    {
        var energyDensity = new EnergyDensity(-500, EnergyDensityUnit.KilojoulePerCubicMeter);

        // Test absolute value
        var absoluteValue = energyDensity.Abs();
        Assert.AreEqual(500, absoluteValue.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);

        // Test negation
        var negated = -energyDensity;
        Assert.AreEqual(500, negated.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);

        // Test positive (unary plus)
        var positive = +energyDensity;
        Assert.AreEqual(-500, positive.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-10);
    }

    [TestMethod]
    public void EnergyDensityDivisionOperationsTest()
    {
        var energyDensity1 = new EnergyDensity(1000, EnergyDensityUnit.KilojoulePerCubicMeter);
        var energyDensity2 = new EnergyDensity(500, EnergyDensityUnit.KilojoulePerCubicMeter);

        // Test EnergyDensity / EnergyDensity = Ratio (dimensionless)
        var ratio = energyDensity1 / energyDensity2;
        Assert.IsInstanceOfType(ratio, typeof(UnknownUnit)); // Should be dimensionless

        // Test the ratio value by converting to a known dimensionless unit
        var ratioValue = ratio.GetValueAsDouble(energyDensity1.Unit / energyDensity2.Unit);
        Assert.AreEqual(2.0, ratioValue, 1e-10);
    }

    [TestMethod]
    public void EnergyDensityComposeDecomposeTest()
    {
        // Test composition from different unit combinations

        // Composition 1: Power x Time / Volume = EnergyDensity
        var power = new Power(1000, PowerUnit.Watt); // 1000 W = 1 kW
        var time = new Duration(3600, DurationUnit.Second); // 3600 s = 1 hour
        var volume = new Volume(1, VolumeUnit.CubicMeter);

        // Create energy from power and time, then divide by volume
        Energy energy1 = power * time; // 1000 W x 3600 s = 3,600,000 J = 3600 kJ = 1 kWh
        EnergyDensity energyDensity1 = energy1 / volume;

        Assert.AreEqual(1, energyDensity1.As(EnergyDensityUnit.KilowattHourPerCubicMeter), 1e-10);
        Assert.AreEqual(3600, energyDensity1.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-8);

        // Composition 2: Mass x SpecificEnergy / Volume = EnergyDensity
        var mass = new Mass(2, MassUnit.Kilogram);
        var specificEnergy = new SpecificEnergy(1800, SpecificEnergyUnit.KilojoulePerKilogram); // 1800 kJ/kg
        var volume2 = new Volume(1, VolumeUnit.CubicMeter);

        Energy energy2 = mass * specificEnergy; // 2 kg x 1800 kJ/kg = 3600 kJ
        EnergyDensity energyDensity2 = energy2 / volume2; // 3600 kJ / 1 m³ = 3600 kJ/m³

        Assert.AreEqual(3600, energyDensity2.As(EnergyDensityUnit.KilojoulePerCubicMeter), 1e-8);
        Assert.AreEqual(1, energyDensity2.As(EnergyDensityUnit.KilowattHourPerCubicMeter), 1e-10);

        // Decomposition: EnergyDensity x Volume = Energy
        var testEnergyDensity = new EnergyDensity(2500, EnergyDensityUnit.KilojoulePerCubicMeter);
        var testVolume = new Volume(0.8, VolumeUnit.CubicMeter);

        Energy totalEnergy = testEnergyDensity * testVolume; // 2500 kJ/m³ x 0.8 m³ = 2000 kJ
        Assert.AreEqual(2000, totalEnergy.As(EnergyUnit.Kilojoule), 1e-10);

        // Verify energy can be converted to other forms
        var energyInkWh = totalEnergy.ToUnit(EnergyUnit.KilowattHour);
        Assert.AreEqual(2000.0 / 3600.0, energyInkWh.As(EnergyUnit.KilowattHour), 1e-10); // 2000 kJ / 3600 = 0.556 kWh

        // Decomposition: Energy / EnergyDensity = Volume
        var knownEnergy = new Energy(5000, EnergyUnit.Kilojoule);
        var knownEnergyDensity = new EnergyDensity(1000, EnergyDensityUnit.KilojoulePerCubicMeter);

        // This should give us volume, but it returns UnknownUnit - convert it
        var volumeResult = knownEnergy / knownEnergyDensity;
        Assert.IsInstanceOfType(volumeResult, typeof(UnknownUnit));

        var convertedVolume = new Volume(volumeResult);
        Assert.AreEqual(5, convertedVolume.As(VolumeUnit.CubicMeter), 1e-10); // 5000 kJ / 1000 kJ/m³ = 5 m³
    }

    [TestMethod]
    public void EnergyDensityDimensionalAnalysisTest()
    {
        // Test that dimensional analysis works correctly
        // EnergyDensity should have dimensions of [Energy]/[Volume] = [M L² T⁻²]/[L³] = [M L⁻¹ T⁻²]

        var energyDensity = new EnergyDensity(1000, EnergyDensityUnit.KilojoulePerCubicMeter);
        var force = new Force(1000, ForceUnit.Newton); // 1000 N
        var area = new Area(1, AreaUnit.SquareMeter); // 1 m²

        // Force/Area should equal Pressure, and Pressure should have same base dimensions as EnergyDensity
        // Both should be [M L⁻¹ T⁻²]
        var pressure = force / area; // 1000 N / 1 m² = 1000 Pa = 1000 kg⁻¹⋅s⁻²

        // Convert both to SI base units for comparison
        var energyDensitySI = energyDensity.As(EnergyDensityUnit.JoulePerCubicMeter); // 1,000,000 J/m³
        var pressureInPa = new Pressure(pressure).As(PressureUnit.Pascal); // 1000 Pa

        // They should have the same dimensional structure [M L⁻¹ T⁻²]
        // 1,000,000 J/m³ = 1,000,000 N⋅m/m³ = 1,000,000 N/m² = 1,000,000 Pa
        Assert.AreEqual(1000000, energyDensitySI, 1e-6);
        Assert.AreEqual(1000, pressureInPa, 1e-6);

        // Verify the ratio makes sense: 1000 kJ/m³ should be 1000x larger than 1000 Pa
        Assert.AreEqual(1000, energyDensitySI / pressureInPa, 1e-6);
    }
}
