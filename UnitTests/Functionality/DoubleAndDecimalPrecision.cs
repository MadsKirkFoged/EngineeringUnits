using EngineeringUnits;
using EngineeringUnits.Units;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Functionality;

// A double becomes a decimal when it comes in (15 significant digits - the digits that were typed),
// so all math is exact decimal math, also between SI units: 0.1 m + 0.2 m == 0.3 m.
// Only values decimal can't hold (NaN, Infinity, beyond ±7.9e28) stay doubles.
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
    public void SameNonSIUnitMathIsExact()
    {
        Length sum = Length.FromInch(0.1) + Length.FromInch(0.2);

        Assert.AreEqual(0.3, sum.As(LengthUnit.Inch));
        Assert.IsTrue(sum == Length.FromInch(0.3));
    }

    [TestMethod]
    public void SIDoubleMathIsExact()
    {
        Length total = Length.FromMeter(0.1) + Length.FromMeter(0.2);

        // Not 0.30000000000000004 as plain doubles would give
        Assert.AreEqual(0.3, total.As(LengthUnit.Meter));
        Assert.IsTrue(total == Length.FromMeter(0.3));
        Assert.IsFalse(total != Length.FromMeter(0.3));
        Assert.IsTrue(total <= Length.FromMeter(0.3));
        Assert.IsTrue(total >= Length.FromMeter(0.3));
        Assert.IsFalse(total > Length.FromMeter(0.3));
        Assert.IsFalse(total < Length.FromMeter(0.3));
        Assert.AreEqual(Length.FromMeter(0.3), total);
    }

    [TestMethod]
    public void SIDoubleSubtractMultiplyDivideIsExact()
    {
        Assert.IsTrue(Length.FromMeter(0.3) - Length.FromMeter(0.1) == Length.FromMeter(0.2));
        Assert.AreEqual(0.2, (Length.FromMeter(0.3) - Length.FromMeter(0.1)).As(LengthUnit.Meter));

        Area area = Length.FromMeter(0.1) * Length.FromMeter(3);
        Assert.IsTrue(area == Area.FromSquareMeter(0.3));

        Length back = Area.FromSquareMeter(0.3) / Length.FromMeter(0.1);
        Assert.IsTrue(back == Length.FromMeter(3));
    }

    [TestMethod]
    public void DoubleIsTakenAtFifteenSignificantDigits()
    {
        // (decimal)double keeps 15 significant digits - what the user typed, not the binary noise of a double
        Assert.IsTrue(Length.FromMeter(0.1 + 0.2) == Length.FromMeter(0.3));
        Assert.IsTrue(Length.FromMeter(0.1) == new Length(0.1m, LengthUnit.Meter));
    }

    [TestMethod]
    public void DoubleAndDecimalInputsMix()
    {
        Length total = Length.FromMeter(0.1) + new Length(0.2m, LengthUnit.Meter);

        Assert.IsTrue(total == new Length(0.3m, LengthUnit.Meter));
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
