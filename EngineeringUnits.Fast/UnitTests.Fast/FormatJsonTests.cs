using EngineeringUnits.Fast;
using System.Globalization;
using System.Text;
using System.Text.Json;
using EU = global::EngineeringUnits;
using EUUnits = global::EngineeringUnits.Units;

using EngineeringUnits.Units.Fast;

namespace UnitTests.Fast;

[TestClass]
public class FormatTests
{
    [TestMethod]
    public void Formats()
    {
        Power p = Power.FromWatt(1234.5678);
        Assert.AreEqual("1235 W", p.ToString());
        Assert.AreEqual("1234.57 W", p.ToString("F2"));
        Assert.AreEqual("1.235 kW", p.ToString(PowerUnit.Kilowatt));
        Assert.AreEqual("1.2 kW", p.ToString(PowerUnit.Kilowatt, "S2"));
        Assert.AreEqual("1235", p.ToString("V4"));
        Assert.AreEqual("W", p.ToString("A"));
        Assert.AreEqual("1234,57 W", p.ToString("F2", CultureInfo.GetCultureInfo("da-DK")));
        // S4 counts the leading zero, same as EngineeringUnits
        Assert.AreEqual("0.305 m", Length.FromFoot(1).ToString());
        Assert.AreEqual("1 ft", Length.FromFoot(1).ToString(LengthUnit.Foot));
    }

    [TestMethod]
    public void UnknownPrintsItsSIValueOnly()
    {
        var text = (MassFlow.FromKilogramPerSecond(2) * Enthalpy.FromJoulePerKilogram(3)).ToString();
        Assert.AreEqual("6 [?]", text);
    }

    [TestMethod]
    [DynamicData(nameof(CrossValidationTests.AllQuantities), typeof(CrossValidationTests))]
    public void ToStringInEveryUnit_MatchesOriginal(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);
        var toString = info.Type.GetMethod("ToString", [Type.GetType($"EngineeringUnits.Units.Fast.{quantity}Unit, EngineeringUnits.Fast")!, typeof(string), typeof(IFormatProvider)])!;
        var errors = new StringBuilder();
        var benign = new StringBuilder();

        foreach (var u in info.Units)
        {
            foreach (var x in new[] { 1.0, 12.5, -3.25 })
            {
                var expected = Original.Create(quantity, x, u.Name).ToString();
                var actual = (string)toString.Invoke(info.FromSI(u.ToSI(x)), [u, null, null])!;
                if (expected == actual)
                    continue;

                var (expectedNumber, expectedSymbol) = Split(expected);
                var (actualNumber, _) = Split(actual);

                // Known difference: the original sometimes prints an equivalent unit's symbol (1 g/mm -> "1 kg/m") and
                // leaves out the symbol of dimensionless units. Fast prints the unit you asked for.
                var equivalent = expectedSymbol.Length == 0
                    || info.Units.Any(o => o.Symbol == expectedSymbol && o.Factor == u.Factor && o.Offset == u.Offset);

                if (expectedNumber == actualNumber && equivalent)
                    benign.AppendLine($"{quantity}.{u.Name}: original '{expected}', fast '{actual}'");
                else
                    errors.AppendLine($"{quantity}.{u.Name} {x}: original '{expected}', fast '{actual}'");
            }
        }

        if (benign.Length > 0)
            Console.WriteLine("Same number, equivalent symbol:\n" + benign);
        Assert.AreEqual("", errors.ToString());

        static (string Number, string Symbol) Split(string text)
        {
            var i = text.IndexOf(' ');
            return i < 0 ? (text, "") : (text[..i], text[(i + 1)..]);
        }
    }
}

[TestClass]
public class JsonTests
{
    private sealed record Pump(Power Power, Length Height, MassFlow? Flow);

    [TestMethod]
    public void RoundTrip()
    {
        var pump = new Pump(Power.FromKilowatt(1.5), Length.FromMeter(12), null);
        var json = JsonSerializer.Serialize(pump);
        Assert.AreEqual("""{"Power":{"Value":1500,"Unit":"W"},"Height":{"Value":12,"Unit":"m"},"Flow":null}""", json);
        Assert.AreEqual(pump, JsonSerializer.Deserialize<Pump>(json));
    }

    [TestMethod]
    public void ReadsOtherUnitsAndNumbers()
    {
        Assert.AreEqual(1500, JsonSerializer.Deserialize<Power>("""{"Value":1.5,"Unit":"kW"}""").Watt, 1e-12);
        Assert.AreEqual(1500, JsonSerializer.Deserialize<Power>("1500").Watt);
        Assert.AreEqual(294.15, JsonSerializer.Deserialize<Temperature>("""{"Value":21,"Unit":"°C"}""").Kelvin, 1e-12);
    }

    [TestMethod]
    public void WrongUnit_Throws()
    {
        Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<Power>("""{"Value":1,"Unit":"m"}"""));
        // No parser: text is not accepted
        Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<Power>("\"1.5 kW\""));
        // Exact symbols only
        Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<Power>("""{"Value":1,"Unit":"kilowatt"}"""));
    }

    /// <summary>EngineeringUnits gives HectocubicMeter (100 m³) and CubicHectometer (10⁶ m³) the same symbol - never guess.</summary>
    [TestMethod]
    public void AmbiguousSymbol_Throws()
    {
        var e = Assert.ThrowsExactly<JsonException>(() => JsonSerializer.Deserialize<Volume>("""{"Value":2,"Unit":"hm³"}"""));
        StringAssert.Contains(e.Message, "ambiguous");
        Assert.AreEqual(2, JsonSerializer.Deserialize<Volume>("""{"Value":2,"Unit":"m³"}""").CubicMeter);
    }

    [TestMethod]
    public void NaNAndInfinity()
    {
        var json = JsonSerializer.Serialize(Power.NaN);
        Assert.IsTrue(JsonSerializer.Deserialize<Power>(json).IsNaN());
        Assert.IsTrue(JsonSerializer.Deserialize<Power>(JsonSerializer.Serialize(Power.PositiveInfinity)).IsInfinity());
    }
}

[TestClass]
public class ConstantsTests
{
    [TestMethod]
    public void TypedConstants_MatchOriginal()
    {
        Assert.AreEqual(299792458, Constants.SpeedOfLight.MeterPerSecond);
        Assert.AreEqual(9.80665, Constants.StandardGravity.MeterPerSecondSquared, 1e-15);
        Energy e = Mass.FromKilogram(1) * Constants.SpeedOfLight.Pow(2);
        Assert.AreEqual(8.987551787368176e16, e.Joule, 1);
    }

    [TestMethod]
    public void AllConstants_MatchOriginal()
    {
        var errors = new StringBuilder();
        foreach (var field in typeof(Constants).GetFields())
        {
            var fast = field.GetValue(null) switch
            {
                IQuantity q => q.SI,
                UnknownUnit u => u.SI,   // internal, visible to the tests
                _ => double.NaN,
            };
            var original = (EU.BaseUnit)typeof(EU.Constants).GetProperty(field.Name)!.GetValue(null)!;
            var expected = global::EngineeringUnits.BaseUnitExtensions.GetValueAs(original, global::EngineeringUnits.UnitSystemExtensions.GetSIUnitsystem(original.Unit)).ToDouble();
            if (!Close.Enough(expected, fast))
                errors.AppendLine($"{field.Name}: original {expected:R}, fast {fast:R}");
        }

        Assert.AreEqual("", errors.ToString());
    }
}

[TestClass]
public class MathTests
{
    [TestMethod]
    public void AbsClampMinMax()
    {
        MassFlow m = MassFlow.FromKilogramPerSecond(-10);
        Assert.AreEqual(10, m.Abs().KilogramPerSecond);

        Power min = Power.FromWatt(-5), max = Power.FromWatt(5);
        Assert.AreEqual(5, Power.FromWatt(19).Clamp(min, max).Watt);
        Assert.AreEqual(-5, Power.FromWatt(-19).Clamp(min, max).Watt);
        Assert.AreEqual(-5, Power.Min(min, max).Watt);
        Assert.AreEqual(5, Power.Max(min, max).Watt);
    }

    [TestMethod]
    public void Sequences()
    {
        var list = new List<Length> { Length.FromMeter(5), Length.FromMeter(15), Length.FromMeter(10) };
        Assert.AreEqual(30, list.Sum().Meter);
        Assert.AreEqual(10, list.Average().Meter);
        Assert.AreEqual(5, list.Min().Meter);
        Assert.AreEqual(15, list.Max().Meter);
        Assert.ThrowsExactly<InvalidOperationException>(() => new List<Length>().Average());
    }

    [TestMethod]
    public void PowSqrt()
    {
        Length l1 = Length.FromFoot(54.3);
        Area a1 = l1.Pow(2);
        Length l2 = a1.Sqrt();
        Volume v = l1.Pow(3);
        Assert.AreEqual(54.3, l2.Foot, 1e-12);
        Assert.AreEqual(Math.Pow(54.3 * 0.3048, 3), v.CubicMeter, 1e-9);
    }

    private static T GenericSum<T>(IEnumerable<T> values) where T : System.Numerics.IAdditionOperators<T, T, T>, System.Numerics.IAdditiveIdentity<T, T>
    {
        var sum = T.AdditiveIdentity;
        foreach (var v in values) sum += v;
        return sum;
    }

    private static T Lerp<T>(T a, T b, double t) where T : struct, IQuantity<T>
        => T.FromSI(a.SI + ((b.SI - a.SI) * t));

    [TestMethod]
    public void GenericMath()
    {
        Assert.AreEqual(6, GenericSum([Power.FromWatt(1), Power.FromWatt(2), Power.FromWatt(3)]).Watt);
        Assert.AreEqual(15, Lerp(Temperature.FromDegreeCelsius(10), Temperature.FromDegreeCelsius(20), 0.5).DegreeCelsius, 1e-12);
    }
}
