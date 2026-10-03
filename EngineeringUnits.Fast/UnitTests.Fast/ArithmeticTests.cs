using EngineeringUnits.Fast;
using EngineeringUnits.NumberExtensions.NumberToLength.Fast;
using EngineeringUnits.NumberExtensions.NumberToPower.Fast;
using EngineeringUnits.NumberExtensions.NumberToTemperature.Fast;
using EU = global::EngineeringUnits;
using EUUnits = global::EngineeringUnits.Units;

using EngineeringUnits.Units.Fast;

namespace UnitTests.Fast;

/// <summary>The same equations in both libraries must give the same numbers.</summary>
[TestClass]
public class ArithmeticTests
{
    [TestMethod]
    public void ReadmeEquation_MatchesOriginal()
    {
        // Power q = m1 * p1 * (t2 - t1) from the EngineeringUnits README
        SpecificEntropy p1 = SpecificEntropy.FromJoulePerKilogramKelvin(1);
        MassFlow m1 = MassFlow.FromKilogramPerSecond(1);
        Temperature t2 = Temperature.FromDegreeCelsius(10);
        Temperature t1 = Temperature.FromDegreeCelsius(5);

        Power q = m1 * p1 * (t2 - t1);

        EU.Power expected = EU.MassFlow.FromKilogramPerSecond(1) * EU.SpecificEntropy.FromJoulePerKilogramKelvin(1) * (EU.Temperature.FromDegreeCelsius(10) - EU.Temperature.FromDegreeCelsius(5));
        Assert.AreEqual(expected.As(EUUnits.PowerUnit.Watt), q.Watt, 1e-12);
        Assert.AreEqual(5, q.Watt, 1e-12);
    }

    [TestMethod]
    public void BenchmarkEquation_MatchesOriginal()
    {
        Enthalpy h1 = Enthalpy.FromJoulePerKilogram(856.75245687853), h2 = Enthalpy.FromJoulePerKilogram(1456.546239456);
        MassFlow m1 = MassFlow.FromKilogramPerSecond(7.4526425854623);
        Power p2 = Power.FromWatt(1567.1567896541), p3 = Power.FromWatt(1000.3487624531);

        double fast = (double)(((m1 * (h2 - h1)) + p2) / p3);
        double expected = (double)(((EU.MassFlow.FromKilogramPerSecond(7.4526425854623) * (EU.Enthalpy.FromJoulePerKilogram(1456.546239456) - EU.Enthalpy.FromJoulePerKilogram(856.75245687853))) + EU.Power.FromWatt(1567.1567896541)) / EU.Power.FromWatt(1000.3487624531));

        Assert.IsTrue(Close.Enough(expected, fast, 1e-14), $"{expected:R} vs {fast:R}");
    }

    [TestMethod]
    public void MixedUnits_AreConvertedToSI()
    {
        Length sum = Length.FromFoot(1) + Length.FromInch(12) + Length.FromMeter(1);
        Assert.AreEqual(1 + (2 * 0.3048), sum.Meter, 1e-15);

        Speed v = Length.FromKilometer(1) / Duration.FromHour(2);
        Assert.AreEqual(0.5, v.KilometerPerHour, 1e-12);

        Area a = Length.FromFoot(3) * Length.FromFoot(3);
        Assert.AreEqual(9, a.SquareFoot, 1e-12);
    }

    [TestMethod]
    public void DensityFromMassAndVolume()
    {
        Mass mass = Mass.FromKilogram(10);
        Volume volume = Volume.FromCubicMeter(4);
        Density d = mass / volume;
        Assert.AreEqual(2.5, d.KilogramPerCubicMeter, 1e-15);
    }

    [TestMethod]
    public void ScalarsKeepTheType()
    {
        Length l = Length.FromMeter(2);
        Length a = l * 3, b = 3 * l, c = l / 4.0, d = -l, e = +l;
        Assert.AreEqual(6, a.SI); Assert.AreEqual(6, b.SI); Assert.AreEqual(0.5, c.SI); Assert.AreEqual(-2, d.SI); Assert.AreEqual(2, e.SI);

        Frequency f = 1 / Duration.FromSecond(4);
        Assert.AreEqual(0.25, f.Hertz);
    }

    [TestMethod]
    public void UnknownOnEitherSideOfPlus()
    {
        MassFlow m = MassFlow.FromKilogramPerSecond(2);
        Enthalpy h = Enthalpy.FromJoulePerKilogram(3);
        Power p = Power.FromWatt(1);

        Power a = p + (m * h), b = (m * h) + p, c = p - (m * h), d = (m * h) - p;
        Assert.AreEqual(7, a.Watt); Assert.AreEqual(7, b.Watt); Assert.AreEqual(-5, c.Watt); Assert.AreEqual(5, d.Watt);
    }

    [TestMethod]
    public void CompoundAssignment()
    {
        Power p = Power.FromWatt(1);
        p += Power.FromWatt(2);
        p += MassFlow.FromKilogramPerSecond(1) * Enthalpy.FromJoulePerKilogram(1);
        p -= Power.FromKilowatt(0.001);
        p *= 2;
        p /= 4;
        Assert.AreEqual(1.5, p.Watt, 1e-15);
    }

    [TestMethod]
    public void Comparisons()
    {
        Power small = Power.FromWatt(1), big = Power.FromKilowatt(1);
        Assert.IsTrue(small < big);
        Assert.IsTrue(big >= small);
        Assert.IsTrue(small != big);
        Assert.IsTrue(Power.FromWatt(1000) == big);
        Assert.IsTrue(MassFlow.FromKilogramPerSecond(1) * Enthalpy.FromJoulePerKilogram(2000) > big);
        Assert.AreEqual(-1, small.CompareTo(big));
        Assert.IsTrue(Power.FromWatt(1000).Equals(big));
    }

    [TestMethod]
    public void RatioCastsToDouble()
    {
        double r = (double)(Length.FromMeter(3) / Length.FromMeter(2));
        Assert.AreEqual(1.5, r);
    }

    [TestMethod]
    public void NullableOperators()
    {
        Power? none = null;
        Power? some = Power.FromWatt(2);
        Power p = Power.FromWatt(1);

        Assert.IsNull(none + p);
        Assert.IsNull(p + none);
        Assert.AreEqual(3, (some + p)!.Value.Watt);
        Assert.AreEqual(1, (some - p)!.Value.Watt);
        Assert.AreEqual(4, (some + some)!.Value.Watt);   // lifted
        Assert.IsTrue(some > p);
        Assert.IsFalse(none > p);
        Assert.IsTrue(p < some);
        Assert.IsTrue(none == null);
        Assert.IsTrue(some != null);
        Assert.IsTrue(none is null);
        Assert.IsTrue(some == Power.FromWatt(2));
#pragma warning disable CS1718 // comparing a variable with itself is the point here
        Assert.IsTrue(some == some);
        Assert.IsFalse(none == some);
        Assert.IsTrue(none == none);
#pragma warning restore CS1718
        Assert.IsTrue((some ?? p) == Power.FromWatt(2));
    }

    [TestMethod]
    public void Aliases_MixWithoutCasts()
    {
        SpecificEnergy se = SpecificEnergy.FromJoulePerKilogram(2);
        Enthalpy h = Enthalpy.FromJoulePerKilogram(3);

        SpecificEnergy a = se + h;
        Enthalpy b = h + se;
        SpecificEnergy c = (SpecificEnergy)h;   // explicit: same dimension, different meaning
        Assert.AreEqual(5, a.SI); Assert.AreEqual(5, b.SI); Assert.AreEqual(3, c.SI);
        Assert.IsTrue(se < h);
        Assert.IsFalse(se == h);
    }

    [TestMethod]
    public void NumberExtensions()
    {
        Length l = 5.Meter + 2.5.Centimeter;
        Power p = 1.5.Kilowatt;
        Temperature t = 21.DegreeCelsius;

        Assert.AreEqual(5.025, l.Meter, 1e-15);
        Assert.AreEqual(1500, p.Watt);
        Assert.AreEqual(294.15, t.Kelvin, 1e-12);
    }

    [TestMethod]
    public void DefaultIsZero()
    {
        Power p = default;
        Assert.AreEqual(0, p.SI);
        Assert.AreEqual(Power.Zero, p);
    }
}

[TestClass]
public class TemperatureTests
{
    [TestMethod]
    public void CelsiusMinusKelvin()
    {
        Temperature tIn = Temperature.FromDegreeCelsius(21);
        Temperature tOut = tIn - Temperature.FromKelvin(10);
        Assert.AreEqual(11, tOut.DegreeCelsius, 1e-12);
        Assert.AreEqual(51.8, tOut.DegreeFahrenheit, 1e-12);
    }

    /// <summary>Stored in kelvin, so adding two °C values adds kelvins - same as EngineeringUnits.</summary>
    [TestMethod]
    public void CelsiusPlusCelsius_MatchesOriginal()
    {
        Temperature fast = Temperature.FromDegreeCelsius(21) + Temperature.FromDegreeCelsius(10);
        EU.Temperature original = EU.Temperature.FromDegreeCelsius(21) + EU.Temperature.FromDegreeCelsius(10);
        Assert.AreEqual(original.As(EUUnits.TemperatureUnit.DegreeCelsius), fast.DegreeCelsius, 1e-12);
    }

    [TestMethod]
    public void TemperatureDifferenceTimesCapacity_MatchesOriginal()
    {
        Temperature a = Temperature.FromDegreeFahrenheit(100), b = Temperature.FromDegreeCelsius(20);
        SpecificEntropy cp = SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
        SpecificEnergy fast = cp * (a - b);

        EU.SpecificEnergy original = EU.SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18) * (EU.Temperature.FromDegreeFahrenheit(100) - EU.Temperature.FromDegreeCelsius(20));
        Assert.IsTrue(Close.Enough(original.As(EUUnits.SpecificEnergyUnit.SI), fast.SI, 1e-12));
    }

    [TestMethod]
    public void ToStringInUnit()
    {
        Assert.AreEqual("52 °F", Temperature.FromDegreeCelsius(11).ToString(TemperatureUnit.DegreeFahrenheit, "S2"));
        Assert.AreEqual("21 °C", Temperature.FromDegreeCelsius(21).ToString(TemperatureUnit.DegreeCelsius));
    }
}

[TestClass]
public class PrecisionTests
{
    /// <summary>
    /// Known and accepted: Fast is double-only. A value created in a non-SI unit does not always come back bit-exact.
    /// EngineeringUnits does (it keeps the original unit and exact fractions). This test documents the size of it.
    /// </summary>
    [TestMethod]
    public void RoundTripThroughFoot_IsWithinOneUlp()
    {
        var notExact = 0;
        for (int i = 1; i <= 1000; i++)
        {
            double x = i / 10.0;
            var back = Length.FromFoot(x).Foot;
            if (back != x) notExact++;
            Assert.IsTrue(Math.Abs(back - x) <= Math.Abs(x) * 2.3e-16, $"{x}: {back:R}");
        }

        Console.WriteLine($"{notExact}/1000 foot round trips not bit-exact (all within 1 ulp)");
    }

    /// <summary>Unit factors of the form 1/n are one division, not a multiplication by a rounded 1/n.</summary>
    [TestMethod]
    public void JoulePerHour_IsExactDivision()
    {
        Power p = Power.FromJoulePerHour(3600);
        Assert.AreEqual(1, p.Watt);
        Assert.AreEqual(3600, p.JoulePerHour);
    }

    [TestMethod]
    public void TinyValues_KeepAllDigits()
    {
        // EngineeringUnits.As() goes through decimal (28 decimals) and gives 1.15740741E-20 here
        MassFlow m = MassFlow.FromMicrogramPerDay(1e-6);
        Assert.AreEqual(1e-15 / 86400, m.SI, 1e-35);
    }
}
