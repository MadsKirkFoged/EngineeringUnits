using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

// A value keeps the type it was created with (double or decimal).
// Math between SI units - or the very same unit - on doubles is plain double math (fast).
// Math that involves converting between units is exact, also when the values are doubles.
[TestClass]
public class DoubleAndDecimalPrecision
{
    [TestMethod]
    public void MixedUnitSubtractIsExact()
    {
        Length L1 = new(3.87, LengthUnit.Inch);
        Length L2 = new(2.78, LengthUnit.Meter);

        Length L3 = L2 - L1;

        Assert.AreEqual(268.1702, L3.As(LengthUnit.Centimeter));
    }

    [TestMethod]
    public void MixedUnitAddIsExact()
    {
        Length sum = Length.FromFoot(1) + Length.FromInch(12);

        Assert.AreEqual(2, sum.As(LengthUnit.Foot));
        Assert.AreEqual(0.6096, sum.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void MixedUnitCompareIsExact()
    {
        Assert.IsTrue(Length.FromFoot(3) == Length.FromInch(36));
        Assert.IsTrue(Length.FromFoot(3) < Length.FromMeter(1));
        Assert.IsTrue(Length.FromYard(1) > Length.FromInch(35.99));
    }

    [TestMethod]
    public void MixedUnitDivideIsExact()
    {
        Speed speed = Length.FromKilometer(1) / Duration.FromHour(2);

        Assert.AreEqual(0.5, speed.As(SpeedUnit.KilometerPerhour));
        Assert.AreEqual(1000d / 7200d, speed.As(SpeedUnit.MeterPerSecond));
    }

    [TestMethod]
    public void FootToMeterRoundTripIsExact()
    {
        double[] values = [0.1, 1, 3.87, 12.345, 123.456789, 1e6];

        foreach (double value in values)
        {
            Length roundTrip = Length.FromFoot(value).ToUnit(LengthUnit.Meter);

            Assert.AreEqual(value, roundTrip.As(LengthUnit.Foot), $"Round trip of {value} ft");
        }
    }

    [TestMethod]
    public void FahrenheitToCelsiusIsExact()
    {
        Temperature boiling = Temperature.FromDegreeFahrenheit(212);

        Assert.AreEqual(100, boiling.As(TemperatureUnit.DegreeCelsius));
        Assert.AreEqual(373.15, boiling.As(TemperatureUnit.Kelvin));
        Assert.IsTrue(boiling == Temperature.FromDegreeCelsius(100));
    }

    [TestMethod]
    public void SameNonSIUnitUsesDoubleMath()
    {
        Length sum = Length.FromInch(3.87) + Length.FromInch(1.5);

        Assert.AreEqual(3.87 + 1.5, sum.As(LengthUnit.Inch));
    }

    [TestMethod]
    public void SIDoubleMathIsPlainDouble()
    {
        Length sum = Length.FromMeter(0.1) + Length.FromMeter(0.2);

        // Same result as doing the math on plain doubles - 0.30000000000000004
        Assert.AreEqual(0.1 + 0.2, sum.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void SIDecimalMathIsExact()
    {
        Length sum = new Length(0.1m, LengthUnit.Meter) + new Length(0.2m, LengthUnit.Meter);

        Assert.AreEqual(0.3, sum.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void DoubleBeyondDecimalRangeStaysFinite()
    {
        Ratio ratio = Length.FromMeter(1e30) / Length.FromMeter(1e-10);

        Assert.AreEqual(1e40, ratio.As(RatioUnit.SI), 1e26);
    }
}
