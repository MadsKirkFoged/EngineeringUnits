//using EngineeringUnits;
//using EngineeringUnits.Units;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Globalization;
//using System.Reflection;

//namespace UnitTests;

//// Tests showing known ToString bugs - they are expected to fail until each bug is fixed
//[TestClass]
//[TestCategory("KnownBug")]
//public class ToStringBugTests
//{
//    // kg^kgPower·m⁵ - a dimension that IntelligentCast can't turn into a known quantity
//    static UnknownUnit OddUnit(int kgPower)
//    {
//        var m = new Length(1, LengthUnit.Meter);
//        UnknownUnit result = m * m * m * m * m;

//        for (int i = 0; i < kgPower; i++)
//            result = result * new Mass(1, MassUnit.Kilogram);

//        return result;
//    }


//    // Small numbers: DisplaySignificantDigits counts leading zeros as significant digits

//    [TestMethod]
//    public void SmallValueDoesNotRoundToZero()
//    {
//        Assert.AreEqual("0.0001234 m", new Length(0.0001234m, LengthUnit.Meter).ToString());
//        Assert.AreEqual("-0.0001234 m", new Length(-0.0001234m, LengthUnit.Meter).ToString());
//        Assert.AreEqual("0.000000001234 m", new Length(0.000000001234m, LengthUnit.Meter).ToString());
//    }

//    [TestMethod]
//    public void SmallValueKeepsFourSignificantDigits()
//    {
//        Assert.AreEqual("0.001234 m", new Length(0.001234m, LengthUnit.Meter).ToString());
//        Assert.AreEqual("0.0001235 m", new Length(0.00012345678m, LengthUnit.Meter).ToString());
//    }

//    [TestMethod]
//    public void SmallResultOfCalculationDoesNotRoundToZero()
//    {
//        // No named unit for kg⁴·m⁵ so it is shown in SI
//        var small = OddUnit(4) * 0.001234m;

//        Assert.AreEqual("0.001234 m⁵·kg⁴", small.ToString());
//    }


//    // Multiply/divide cache is keyed on hash codes that ignore Symbol
//    // --> a unit gets the symbols of whichever unit with the same hash was calculated first

//    [TestMethod]
//    public void MultiplyCacheDoesNotMixUpSymbols()
//    {
//        UnknownUnit odd = OddUnit(1);
//        var bit = new Information(1, InformationUnit.Bit);
//        var decibel = new UnknownUnit(1.0, LevelUnit.Decibel.Unit);
//        var degree = new Angle(1, AngleUnit.Degree);

//        // Fills the cache
//        Assert.AreEqual("1 m⁵·kg·b", (bit * odd).ToString());

//        Assert.AreEqual("1 m⁵·kg·dB", (decibel * odd).ToString());
//        Assert.AreEqual("1 m⁵·kg·°", (degree * odd).ToString());
//    }

//    [TestMethod]
//    public void DivideCacheDoesNotMixUpSymbols()
//    {
//        UnknownUnit odd = OddUnit(2);
//        var bit = new Information(1, InformationUnit.Bit);
//        var decibel = new UnknownUnit(1.0, LevelUnit.Decibel.Unit);

//        // Fills the cache
//        Assert.AreEqual("1 dB/(m⁵·kg²)", (decibel / odd).ToString());

//        Assert.AreEqual("1 b/(m⁵·kg²)", (bit / odd).ToString());
//    }

//    [TestMethod]
//    public void ReduceUnitsDoesNotMergeDifferentUnitsWithSameFactor()
//    {
//        // ReduceUnits groups on (UnitType, A) so ° and b (both A=1) are merged into °²
//        UnknownUnit odd = OddUnit(3);
//        var bit = new Information(1, InformationUnit.Bit);
//        var degree = new Angle(1, AngleUnit.Degree);

//        var result = (degree * bit * odd).ToString();

//        Assert.DoesNotContain("°²", result);
//        Assert.Contains("°", result);
//        Assert.Contains("b", result);
//    }


//    // Dimensionless UnknownUnits: IntelligentCast checks Ratio before Angle/Information/Level
//    // --> every dimensionless result is shown as a Ratio and loses its unit

//    [TestMethod]
//    public void AngleCalculationKeepsItsUnit()
//    {
//        UnknownUnit sum = new Angle(1, AngleUnit.Degree) + new Angle(0, AngleUnit.Degree);

//        Assert.AreEqual("1 °", sum.ToString());
//    }

//    [TestMethod]
//    public void AngleAsUnknownUnitKeepsItsUnit()
//    {
//        var arcminute = new UnknownUnit(1.234, AngleUnit.Arcminute.Unit);

//        Assert.AreEqual("1.234 '", arcminute.ToString());
//    }

//    [TestMethod]
//    public void InformationCalculationKeepsItsUnit()
//    {
//        UnknownUnit sum = new Information(1, InformationUnit.Byte) + new Information(0, InformationUnit.Byte);

//        Assert.AreEqual("1 B", sum.ToString());
//    }

//    [TestMethod]
//    public void LevelCalculationKeepsItsUnit()
//    {
//        var decibel = new UnknownUnit(1.0, LevelUnit.Decibel.Unit);

//        Assert.AreEqual("2 dB", (2 * decibel).ToString());
//    }


//    // GetStandardSymbol<T> picks the first unit in the list with the same factor

//    [TestMethod]
//    public void LengthRatioIsNotShownAsMassRatio()
//    {
//        var ratio = new Length(1, LengthUnit.Kilometer) / new Length(1, LengthUnit.Meter);

//        Assert.AreNotEqual("1 kg/g", ratio.ToString());
//    }

//    [TestMethod]
//    public void CelsiusDividedByTimeIsNotLabelledCelsius()
//    {
//        // The value is converted to Kelvin, but the symbol says °C
//        var rate = new Temperature(2, TemperatureUnit.DegreeCelsius) / new Duration(1, DurationUnit.Second);

//        Assert.AreEqual("275.2 K/s", rate.ToString());
//    }


//    // Unit formats after "U:" are ignored
//    // --> UnitSystem.ToString uppercases the format and then compares against "Unit:PP"/"Unit:C"

//    [TestMethod]
//    public void PrettyProductUnitFormatIsUsed()
//    {
//        var x = new Length(1.234, LengthUnit.Meter) / new Duration(1, DurationUnit.Second) / new Mass(1, MassUnit.Kilogram);

//        var result = x.ToString("S4U:PP");

//        Assert.DoesNotContain("/", result);
//        Assert.Contains("⁻¹", result);
//    }

//    [TestMethod]
//    public void CanonicalUnitFormatIsUsed()
//    {
//        var x = new Length(1.234, LengthUnit.Meter) / new Duration(1, DurationUnit.Second) / new Mass(1, MassUnit.Kilogram);

//        var result = x.ToString("S4U:C");

//        Assert.DoesNotContain("/", result);
//        Assert.Contains("^-1", result);
//    }


//    // Culture: the default format ignores the IFormatProvider, "N2" uses it

//    [TestMethod]
//    public void DefaultFormatUsesFormatProvider()
//    {
//        var danish = new CultureInfo("da-DK");

//        Assert.AreEqual("1,50 m", new Length(1.5, LengthUnit.Meter).ToString("N2", danish));
//        Assert.AreEqual("1,5 m", new Length(1.5, LengthUnit.Meter).ToString(danish));
//    }


//    // Unit definitions that make ToString show the wrong thing

//    [TestMethod]
//    [DataRow(nameof(VolumeUnit.MetricCup))]
//    [DataRow(nameof(VolumeUnit.UsCustomaryCup))]
//    [DataRow(nameof(VolumeUnit.UsLegalCup))]
//    [DataRow(nameof(VolumeUnit.UsTeaspoon))]
//    [DataRow(nameof(VolumeUnit.UsTablespoon))]
//    [DataRow(nameof(VolumeUnit.UkTablespoon))]
//    [DataRow(nameof(VolumeUnit.AuTablespoon))]
//    public void VolumeUnitHasSymbol(string unitName)
//    {
//        var unit = (VolumeUnit)typeof(VolumeUnit).GetField(unitName, BindingFlags.Public | BindingFlags.Static)!.GetValue(null)!;

//        Assert.AreNotEqual("1", new Volume(1, unit).ToString());
//    }

//    [TestMethod]
//    public void HectocubicMeterIsOneMillionCubicMeters()
//    {
//        Assert.AreEqual(1e6, new Volume(1, VolumeUnit.HectocubicMeter).As(VolumeUnit.CubicMeter), 1e-3);
//    }

//    [TestMethod]
//    public void KilocubicMeterIsOneBillionCubicMeters()
//    {
//        Assert.AreEqual(1e9, new Volume(1, VolumeUnit.KilocubicMeter).As(VolumeUnit.CubicMeter), 1);
//    }

//    [TestMethod]
//    [DataRow("HectocubicMeter")]
//    [DataRow("KilocubicMeter")]
//    public void ElectricConductanceHasNoVolumeUnits(string unitName)
//    {
//        Assert.IsNull(typeof(ElectricConductanceUnit).GetField(unitName, BindingFlags.Public | BindingFlags.Static));
//    }

//    [TestMethod]
//    public void PoundForcePerFootSecondIsAHeatFlux()
//    {
//        // lbf/(ft·s) = 4.4482216152605 N / (0.3048 m · 1 s)
//        Assert.IsTrue(HeatFluxUnit.PoundForcePerFootSecond.Unit == HeatFluxUnit.SI.Unit);
//        Assert.AreEqual(14.5939029, new HeatFlux(1, HeatFluxUnit.PoundForcePerFootSecond).As(HeatFluxUnit.WattPerSquareMeter), 1e-6);
//    }

//    [TestMethod]
//    public void InformationPerTimeIsABitRate()
//    {
//        UnknownUnit perSecond = new Information(8, InformationUnit.Bit) / new Duration(1, DurationUnit.Second);

//        BitRate rate = perSecond;

//        Assert.AreEqual(8, rate.As(BitRateUnit.BitPerSecond), 1e-9);
//    }

//    [TestMethod]
//    public void AcreFootPerMinuteSymbolUsesMin()
//    {
//        Assert.AreEqual("1 af/min", new VolumeFlow(1, VolumeFlowUnit.AcreFootPerMinute).ToString());
//    }

//    [TestMethod]
//    public void PoundForcePerSquareFootSymbolUsesLbf()
//    {
//        Assert.AreEqual("1 lbf/ft²", new Pressure(1, PressureUnit.PoundForcePerSquareFoot).ToString());
//    }

//    [TestMethod]
//    public void InverseDegreeCelsiusHasNoOffset()
//    {
//        // A coefficient per °C is the same size as per K
//        Assert.AreEqual(1.234, new CoefficientOfThermalExpansion(1.234, CoefficientOfThermalExpansionUnit.InverseDegreeCelsius).As(CoefficientOfThermalExpansionUnit.InverseKelvin), 1e-9);
//    }

//    [TestMethod]
//    public void InverseDegreeFahrenheitHasNoOffset()
//    {
//        // 1 °F⁻¹ = 1.8 K⁻¹
//        Assert.AreEqual(1.8, new CoefficientOfThermalExpansion(1, CoefficientOfThermalExpansionUnit.InverseDegreeFahrenheit).As(CoefficientOfThermalExpansionUnit.InverseKelvin), 1e-9);
//    }


//    // Seen along the way

//    [TestMethod]
//    public void ListOfTemperatureDeltaUnitDoesNotThrow()
//    {
//#pragma warning disable CS0618 // TemperatureDelta is obsolete
//        _ = UnitTypebase.ListOf<TemperatureDeltaUnit>();
//#pragma warning restore CS0618
//    }

//    [TestMethod]
//    public void SqrtOfLargeUnitDoesNotOverflow()
//    {
//        var energy = new Energy(1.234, EnergyUnit.GigaelectronVolt);

//        Energy root = (energy * energy).Sqrt();

//        Assert.AreEqual(1.234, root.As(EnergyUnit.GigaelectronVolt), 1e-9);
//    }
//}
