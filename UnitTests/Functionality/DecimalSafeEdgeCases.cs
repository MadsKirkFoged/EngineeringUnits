using EngineeringUnits;
using EngineeringUnits.Units;
using Fractions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace UnitTests.Functionality;

// A value is a decimal whenever decimal can hold it - also default(DecimalSafe) and values coming back from JSON.
// Only NaN, ±Infinity and values beyond ±7.9e28 are doubles, and those must survive comparisons and JSON too.
[TestClass]
public class DecimalSafeEdgeCases
{
    [TestMethod]
    public void EqualValuesHashTheSame()
    {
        // 7.71604122021982 and 7.7160412202198200 are equal decimals with a different scale
        Length a = Length.FromMeter(7.71604122021982);
        Length b = a * 1.00m;

        Assert.IsTrue(a == b);
        Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
        Assert.IsTrue(new HashSet<Length> { a }.Contains(b));
        Assert.AreEqual(1, new[] { a, b }.Distinct().Count());

        Assert.AreEqual(new DecimalSafe(366.47242394913101m).GetHashCode(), new DecimalSafe(366.472423949131010m).GetHashCode());
        Assert.AreEqual(new DecimalSafe(0m).GetHashCode(), new DecimalSafe(-0.00m).GetHashCode());

        // .NET Framework hashes a decimal through double, which tells these two apart
        Assert.AreEqual(new DecimalSafe(3842.10023380985478068802318m).GetHashCode(), new DecimalSafe(3842.1002338098547806880231800m).GetHashCode());
    }

    [TestMethod]
    public void DefaultIsDecimalZero()
    {
        DecimalSafe zero = default;

        Assert.IsTrue(zero.IsDecimal);
        Assert.AreEqual(0m, (decimal)zero);
        Assert.AreEqual(1m / 3m, (decimal)(zero + new DecimalSafe(1m / 3m)));
        Assert.AreEqual(0m, (decimal)(new DecimalSafe[1])[0]);
        Assert.AreEqual(0m, (decimal)JsonConvert.DeserializeObject<DecimalSafe>("{}"));
    }

    [TestMethod]
    public void BeyondDecimalComparesExactly()
    {
        var max = new DecimalSafe(decimal.MaxValue);
        var beyond = new DecimalSafe(System.Math.Pow(2, 96));

        Assert.IsTrue(max < beyond);
        Assert.IsTrue(max != beyond);
        Assert.IsFalse(max == beyond);
        Assert.IsTrue(-max > -beyond);

        // decimal.MaxValue + 0.5 spills over into a double
        DecimalSafe spilled = max + new DecimalSafe(0.5m);
        Assert.IsFalse(spilled.IsDecimal);
        Assert.IsTrue(spilled > max);
        Assert.IsTrue(spilled != max);

        Assert.IsTrue(max < new DecimalSafe(double.PositiveInfinity));
        Assert.IsTrue(max > new DecimalSafe(double.NegativeInfinity));
        Assert.IsFalse(max < new DecimalSafe(double.NaN));
        Assert.IsFalse(max >= new DecimalSafe(double.NaN));
    }

    [TestMethod]
    public void BeyondDecimalTemperatureComparesExactly()
    {
        // The °C side is 273.15 K more than decimal.MaxValue - so beyond decimal
        var kelvin = new Temperature(decimal.MaxValue, TemperatureUnit.Kelvin);
        var celsius = new Temperature(decimal.MaxValue, TemperatureUnit.DegreeCelsius);

        Assert.IsFalse(kelvin == celsius);
        Assert.IsTrue(kelvin < celsius);
    }

    [TestMethod]
    public void SameNonSIUnitKeepsScaleAsConversion()
    {
        // Same as converting the right value into inches first (as it always did): trailing zeros are dropped
        Length sum = Length.FromInch(1) + (Length.FromInch(1.5) + Length.FromInch(1.5));

        Assert.AreEqual("4 in", sum.ToString("G"));
        Assert.IsTrue(sum == Length.FromInch(4));
    }

    [TestMethod]
    public void BeyondDecimalIsTheNearestDouble()
    {
        // About 1e30, with numerator and denominator both beyond double
        var huge = new Fraction(BigInteger.Pow(10, 430) + 1, BigInteger.Pow(10, 400));

        Assert.AreEqual(1e30, (double)new DecimalSafe(huge));
        Assert.AreEqual(-1e30, (double)new DecimalSafe(-huge));

        // Fraction.ToDouble truncates 10^30 to 9.999999999999999E+29
        Assert.AreEqual(1e30, Length.FromKilometer(1e27).As(LengthUnit.Meter));
        Assert.AreEqual(1e30, (double)new DecimalSafe(new Fraction(BigInteger.Pow(10, 30))));
    }

    [TestMethod]
    public void SpillJustBeyondDecimalStaysBeyond()
    {
        var max = new DecimalSafe(decimal.MaxValue);

        // decimal.MaxValue + 8.145 and + 5.77: (double)left * (double)right would land below decimal.MaxValue
        DecimalSafe product = new DecimalSafe(28.2825m) * new DecimalSafe(2801313975577277029737256266m);
        DecimalSafe quotient = new DecimalSafe(79228162514263717561846382397m) / new DecimalSafe(0.9999999999999921740997406533m);
        DecimalSafe half = new DecimalSafe((Fraction)decimal.MaxValue + new Fraction(1, 2));

        foreach (DecimalSafe beyond in new[] { product, quotient, half })
        {
            Assert.IsFalse(beyond.IsDecimal);
            Assert.AreEqual(System.Math.Pow(2, 96), (double)beyond);
            Assert.IsTrue(beyond > max);
            Assert.IsFalse(beyond < max);
        }

        // decimal.MaxValue yards + 845/1143 yd, given in meters
        var meters = new Length(72446231803043310295536588187m, LengthUnit.Meter);
        var maxYards = new Length(decimal.MaxValue, LengthUnit.Yard);

        Assert.IsTrue(meters > maxYards);
        Assert.IsFalse(maxYards > meters);
        Assert.IsTrue(maxYards < meters);
    }

    [TestMethod]
    public void EveryNaNHashesTheSame()
    {
        var nan = new DecimalSafe(double.NaN);
        DecimalSafe negated = -nan;

        Assert.IsTrue(nan == negated);
        Assert.AreEqual(nan.GetHashCode(), negated.GetHashCode());
    }

    [TestMethod]
    public void ConversionsOfNonDecimals()
    {
        Assert.AreEqual(0, (int)new DecimalSafe(double.NaN));
        Assert.AreEqual(0, (int)new DecimalSafe(double.PositiveInfinity));
        Assert.ThrowsExactly<InvalidOperationException>(() => (decimal)new DecimalSafe(1e30));
        Assert.ThrowsExactly<InvalidOperationException>(() => (decimal)new DecimalSafe(double.NaN));
    }

    [TestMethod]
    public void JsonOfDecimalIsUnchanged()
    {
        var value = new DecimalSafe(3.87m);

        Assert.AreEqual("{\"Value\":3.87,\"IsInf\":false,\"IsNaN\":false}", JsonConvert.SerializeObject(value));
        Assert.AreEqual("{\"Value\":3.87,\"IsInf\":false,\"IsNaN\":false}", System.Text.Json.JsonSerializer.Serialize(value));
    }

    [TestMethod]
    public void JsonKeepsWhatDecimalCantHold()
    {
        double[] values = [1e30, -1e30, double.MaxValue, double.PositiveInfinity, double.NegativeInfinity, double.NaN];

        foreach (double value in values)
        {
            var newtonsoft = JsonConvert.DeserializeObject<DecimalSafe>(JsonConvert.SerializeObject(new DecimalSafe(value)));
            var stj = System.Text.Json.JsonSerializer.Deserialize<DecimalSafe>(System.Text.Json.JsonSerializer.Serialize(new DecimalSafe(value)));

            Assert.AreEqual(value, (double)newtonsoft, $"Newtonsoft {value}");
            Assert.AreEqual(value, (double)stj, $"System.Text.Json {value}");
        }

        Length length = JsonConvert.DeserializeObject<Length>(JsonConvert.SerializeObject(Length.FromMeter(1e30)))!;
        Assert.AreEqual(1e30, length.As(LengthUnit.Meter));
    }

    [TestMethod]
    public void JsonOfBeyondDecimalReadsAsInfinityInOlderVersions()
    {
        // Older versions only know Value, IsInf and IsNaN - and held values beyond decimal as Infinity
        Assert.AreEqual("{\"Value\":0.0,\"IsInf\":true,\"IsNaN\":false,\"Double\":1E+30}", JsonConvert.SerializeObject(new DecimalSafe(1e30)));
        Assert.AreEqual("{\"Value\":0.0,\"IsInf\":true,\"IsNaN\":false,\"Double\":\"-Infinity\"}", JsonConvert.SerializeObject(new DecimalSafe(double.NegativeInfinity)));
        Assert.AreEqual("{\"Value\":0.0,\"IsInf\":false,\"IsNaN\":true,\"Double\":\"NaN\"}", JsonConvert.SerializeObject(new DecimalSafe(double.NaN)));

        Assert.AreEqual("{\"Value\":0,\"IsInf\":true,\"IsNaN\":false,\"Double\":1E+30}", System.Text.Json.JsonSerializer.Serialize(new DecimalSafe(1e30)));
    }

    [TestMethod]
    public void JsonPropertyOrderDoesNotMatter()
    {
        Assert.IsTrue(JsonConvert.DeserializeObject<DecimalSafe>("{\"IsInf\":true,\"IsNaN\":false,\"Value\":0.0}").IsInf);
        Assert.IsTrue(JsonConvert.DeserializeObject<DecimalSafe>("{\"IsInf\":false,\"IsNaN\":true,\"Value\":0.0}").IsNaN);
        Assert.IsTrue(System.Text.Json.JsonSerializer.Deserialize<DecimalSafe>("{\"IsInf\":true,\"Value\":0.0,\"IsNaN\":false}").IsInf);

        // The format written before Double existed
        Assert.AreEqual(double.PositiveInfinity, (double)JsonConvert.DeserializeObject<DecimalSafe>("{\"Value\":0.0,\"IsInf\":true,\"IsNaN\":false}"));
        Assert.AreEqual(5m, (decimal)JsonConvert.DeserializeObject<DecimalSafe>("{\"Value\":5,\"IsInf\":false,\"IsNaN\":false}"));
    }

    [TestMethod]
    public void JsonOfConvertedUnitStillConverts()
    {
        // ToUnit keeps the exact Fraction - it has to come back from JSON as a Fraction
        Length meter = Length.FromFoot(1).ToUnit(LengthUnit.Meter);
        Length back = JsonConvert.DeserializeObject<Length>(JsonConvert.SerializeObject(meter))!;

        Assert.AreEqual(1, back.ToUnit(LengthUnit.Foot).As(LengthUnit.Foot));
        Assert.IsTrue(Length.FromFoot(1) == back);
        Assert.AreEqual(JsonConvert.SerializeObject(meter), JsonConvert.SerializeObject(back));
    }

    [TestMethod]
    public void JsonOfFractionUnitPrintsTheSame()
    {
        // No printable symbol and a factor of exactly 1 to SI: ToString converts the exact Fraction to SI.
        // Newtonsoft writes 5 as 5.0 - that scale must not show up after a round trip
        var unit = new UnitSystem(2m, null) * new UnitSystem(0.5m, null);
        var value = new EngineeringUnits.BaseUnit(new Fraction(5), unit);
        var back = JsonConvert.DeserializeObject<EngineeringUnits.BaseUnit>(JsonConvert.SerializeObject(value))!;

        Assert.AreEqual(value.ToString("G"), back.ToString("G"));
        Assert.AreEqual(value.ToString(), back.ToString());
    }

    [TestMethod]
    public void JsonOfZeroWithDefaultValueHandlingIgnore()
    {
        // A zero NEWValue is left out of the JSON and comes back as default(DecimalSafe)
        var settings = new JsonSerializerSettings { DefaultValueHandling = DefaultValueHandling.Ignore };
        Length zero = JsonConvert.DeserializeObject<Length>(JsonConvert.SerializeObject(Length.FromMeter(0), settings), settings)!;

        Assert.AreEqual("0 m", zero.ToString());
        Assert.IsTrue(zero + new Length(1m / 3m, LengthUnit.Meter) == new Length(1m / 3m, LengthUnit.Meter));
    }
}
