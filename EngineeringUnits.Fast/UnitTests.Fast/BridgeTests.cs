using EngineeringUnits.Fast;
using System.Globalization;
using System.Reflection;
using System.Text;
using EU = global::EngineeringUnits;

namespace UnitTests.Fast;

/// <summary>
/// ToFast() / ToClassic() (EngineeringUnits, FastConversions/FastBridge.g.cs) for every quantity, in SI: ToFast() rounds the exact
/// value once, ToClassic() gives the shortest decimal that rounds back to the same double.
/// </summary>
[TestClass]
public class BridgeTests
{
    private static readonly double[] Samples =
    [
        0, -0d, 1, -3.7, 21.5, Math.PI, 123.456, 0.1 + 0.2, 1e-6, 5e5, 1234567.891, 6.02214076e23, 1.2345678901234567e-12,
        1e-30, 1e-300, double.Epsilon, 1e300, double.MaxValue, double.MinValue, double.NaN, double.PositiveInfinity, double.NegativeInfinity,
    ];

    public static IEnumerable<object[]> AllQuantities() => Quantities.All.Select(q => new object[] { q.Name });

    private static MethodInfo ToFast(string quantity) =>
        typeof(FastBridgeExtensions).GetMethod("ToFast", [Original.QuantityType(quantity)])
        ?? throw new InvalidOperationException($"No ToFast for {quantity}");

    private static MethodInfo ToClassic(string quantity) =>
        typeof(FastBridgeExtensions).GetMethod("ToClassic", [Quantities.All.Single(q => q.Name == quantity).Type])
        ?? throw new InvalidOperationException($"No ToClassic for {quantity}");

    [TestMethod]
    public void EveryQuantityHasBothDirections()
    {
        foreach (var q in Quantities.All)
        {
            Assert.AreEqual(q.Type, ToFast(q.Name).ReturnType, q.Name);
            Assert.AreEqual(Original.QuantityType(q.Name), ToClassic(q.Name).ReturnType, q.Name);
        }
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void FastToClassicToFast_IsBitExact(string quantity)
    {
        // EngineeringUnits holds the shortest decimal that rounds back to the double, its round-trip ("R") digits. Decimal keeps
        // 28 decimal places, so 1e-30, 1e-300 and double.Epsilon (below half the last one) arrive as 0, see
        // TinyValues_AreRoundedTo28DecimalPlaces. NaN, ±Infinity and values beyond decimal (1e300, ±double.MaxValue) stay doubles
        var info = Quantities.All.Single(q => q.Name == quantity);
        var siUnit = ((EU.UnitTypebase)Original.Unit(quantity, "SI")).Unit;
        var errors = new StringBuilder();

        foreach (var si in Samples)
        {
            var classic = (EU.BaseUnit)ToClassic(quantity).Invoke(null, [info.FromSI(si)])!;
            var back = (IQuantity)ToFast(quantity).Invoke(null, [classic])!;
            var expected = Math.Abs(si) < 5e-29 ? Math.CopySign(0, si) : si;

            Assert.AreEqual(Original.QuantityType(quantity), classic.GetType());
            if (BitConverter.DoubleToInt64Bits(back.SI) != BitConverter.DoubleToInt64Bits(expected))
                errors.AppendLine($"{quantity} {si:R} came back as {back.SI:R}");

            if (Math.Abs(si) < (double)decimal.MaxValue)
            {
                var held = (decimal)EU.BaseUnitExtensions.GetValueAs(classic, siUnit);
                var shortest = decimal.Parse(si.ToString("R", CultureInfo.InvariantCulture), NumberStyles.Float, CultureInfo.InvariantCulture);
                if (held != shortest)
                    errors.AppendLine($"{quantity} {si:R}: the EngineeringUnits object holds {held}, not {shortest}");
            }
            else
            {
                var held = Original.As(classic, quantity, "SI");
                if (BitConverter.DoubleToInt64Bits(held) != BitConverter.DoubleToInt64Bits(si))
                    errors.AppendLine($"{quantity} {si:R}: the EngineeringUnits object holds {held:R}");
            }
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    public void RandomDoubles_RoundTripThroughTheShortestDecimal()
    {
        // Typed values (up to 15 digits) and doubles with all 53 bits, from 1e-12 (where all digits fit decimal) to 7.9e28
        var rnd = new Random(42);
        var siUnit = EU.Units.LengthUnit.SI.Unit;
        var errors = new StringBuilder();

        for (int i = 0; i < 20000; i++)
        {
            var si = i % 2 == 0
                ? double.Parse(FormattableString.Invariant($"{rnd.NextInt64(-999_999_999_999_999, 1_000_000_000_000_000)}E{rnd.Next(-27, 14)}"), CultureInfo.InvariantCulture)
                : Math.ScaleB(rnd.Next(2) == 0 ? -1 - rnd.NextDouble() : 1 + rnd.NextDouble(), rnd.Next(-40, 96));
            if (!(Math.Abs(si) >= 1e-12 || si == 0))
                continue;

            var classic = Length.FromSI(si).ToClassic();
            var back = classic.ToFast().SI;
            if (BitConverter.DoubleToInt64Bits(back) != BitConverter.DoubleToInt64Bits(si))
                errors.AppendLine($"{si:R} came back as {back:R}");

            var held = (decimal)EU.BaseUnitExtensions.GetValueAs(classic, siUnit);
            var shortest = decimal.Parse(si.ToString("R", CultureInfo.InvariantCulture), NumberStyles.Float, CultureInfo.InvariantCulture);
            if (held != shortest)
                errors.AppendLine($"{si:R}: the EngineeringUnits object holds {held}");
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    public void ToClassic_GivesTheShortestDecimal()
    {
        // 0.1 arrives as 0.1m, so EngineeringUnits' decimal math gives what its users expect
        Assert.IsTrue(Length.FromMeter(0.1).ToClassic() + Length.FromMeter(0.2).ToClassic() == EU.Length.FromMeter(0.3));

        // A double result keeps all its digits: 0.1 + 0.2 in Fast is 0.30000000000000004, not 0.3
        var sum = (Length.FromMeter(0.1) + Length.FromMeter(0.2)).ToClassic();
        Assert.IsFalse(sum == EU.Length.FromMeter(0.3));
        Assert.AreEqual(0.30000000000000004, sum.ToFast().Meter);
    }

    [TestMethod]
    public void TinyValues_AreRoundedTo28DecimalPlaces()
    {
        // Decimal keeps 28 decimal places, the same as for any value given to EngineeringUnits: digits beyond are rounded off.
        // Only values below 1e-12 can have them
        Assert.AreEqual(1.2345678901234567e-12, Length.FromMeter(1.2345678901234567e-12).ToClassic().ToFast().Meter);
        Assert.AreEqual(1.23456789e-20, Length.FromMeter(1.2345678901234567e-20).ToClassic().ToFast().Meter);
        Assert.AreEqual(3e-28, Length.FromMeter(2.6e-28).ToClassic().ToFast().Meter);
        Assert.AreEqual(0, Length.FromMeter(4e-29).ToClassic().ToFast().Meter);
        Assert.AreEqual(BitConverter.DoubleToInt64Bits(-0d), BitConverter.DoubleToInt64Bits(Length.FromMeter(-1e-30).ToClassic().ToFast().Meter));
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void ClassicInEveryUnit_ArrivesAsTheSameFastValue(string quantity)
    {
        // An EngineeringUnits value created in any unit lands where Fast puts the same number in that unit. Not the tiny
        // samples: EngineeringUnits does the math in decimal, where 1e-30 ft is 0. The huge ones it keeps as a double
        var info = Quantities.All.Single(q => q.Name == quantity);
        var errors = new StringBuilder();

        foreach (var unit in info.Units)
        {
            foreach (var x in Samples.Where(x => x == 0 || Math.Abs(x) >= 1e-6))
            {
                var classic = Original.Create(quantity, x, unit.Name);
                var fast = (IQuantity)ToFast(quantity).Invoke(null, [classic])!;
                // The exact SI value of what EngineeringUnits holds, rounded once. It keeps 15 significant digits of x, in SI units
                // too: π -> 3.14159265358979, -0 -> 0
                var expected = OriginalExact.As(classic, quantity, "SI");

                if (BitConverter.DoubleToInt64Bits(fast.SI) != BitConverter.DoubleToInt64Bits(expected))
                    errors.AppendLine($"{quantity}.{unit.Name}({x:R}): exact SI {expected:R}, bridge {fast.SI:R}");
                // Not beyond 1e20: Fast's own double math can overflow on the way (double.MaxValue in a unit)
                if (Math.Abs(x) < 1e20 && !Close.Enough(unit.ToSI(x), fast.SI))
                    errors.AppendLine($"{quantity}.{unit.Name}({x:R}): Fast.From gives {unit.ToSI(x):R}, bridge {fast.SI:R}");
            }
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    public void ClassicInAnotherUnit_IsRoundedOnce()
    {
        // 101.3 psi is exactly 9012096992517773 / 12903200000 Pa. Fraction.ToDouble() would give 698438.9137979549, 1 ulp off
        Assert.AreEqual(698438.913797955, EU.Pressure.FromPoundForcePerSquareInch(101.3).ToFast().SI);
    }

    [TestMethod]
    public void ClassicCreatedFromAFraction_UsesTheFraction()
    {
        // ToUnit keeps the exact Fraction: 1 µg/day is 1/86400000000000 kg/s, of which decimal's 28 decimal places keep 15 digits
        var perDay = EU.MassFlow.FromMicrogramPerDay(1);
        var perSecond = perDay.ToUnit(EU.Units.MassFlowUnit.SI);

        Assert.AreEqual(1.0 / 86400000000000, perSecond.ToFast().SI);
        Assert.AreEqual(BitConverter.DoubleToInt64Bits(perDay.ToFast().SI), BitConverter.DoubleToInt64Bits(perSecond.ToFast().SI));
    }

    [TestMethod]
    public void ClassicNotANumberInAUnit_StaysNotANumber()
    {
        Assert.IsTrue(double.IsNaN(EU.Length.FromFoot(double.NaN).ToFast().SI));
        Assert.AreEqual(double.PositiveInfinity, EU.Length.FromFoot(double.PositiveInfinity).ToFast().SI);
        Assert.AreEqual(double.NegativeInfinity, EU.Temperature.FromDegreeCelsius(double.NegativeInfinity).ToFast().SI);
    }

    [TestMethod]
    public void ClassicResultOfArithmetic_IsRoundedOnce()
    {
        // EngineeringUnits does the math in decimal, the result is rounded once. It has a new (SI) unit system, not LengthUnit.SI
        foreach (var x in new[] { 1e-7, Math.PI, 1.0 / 7, 123.456789 })
        {
            var l = EU.Length.FromMeter(x);
            EU.Area a = l * l;
            EU.Length back = a / l;

            // (decimal)x: the 15 significant digits EngineeringUnits keeps of a double. 1/7 gives 0.1428571428571429999999999997,
            // which (double)decimal would make 0.14285714285714302
            var held = (decimal)x * (decimal)x / (decimal)x;
            var expected = double.Parse(held.ToString(CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            Assert.AreEqual(BitConverter.DoubleToInt64Bits(expected), BitConverter.DoubleToInt64Bits(back.ToFast().Meter), $"{x:R}");
        }

        // 0.3333333333333333333333333333m, which (double)decimal would make 0.33333333333333337
        EU.Length third = EU.Length.FromMeter(1) / 3;
        Assert.AreEqual(1.0 / 3, third.ToFast().Meter);

        // 7.3e15² is beyond decimal: EngineeringUnits goes on in double, the double is copied. 7.3e15 fits decimal again
        var big = EU.Length.FromMeter(7.3e15);
        EU.Area bigArea = big * big;
        EU.Length bigBack = bigArea / big;
        Assert.AreEqual(7.3e15 * 7.3e15, bigArea.ToFast().SquareMeter);
        Assert.AreEqual(7.3e15, bigBack.ToFast().Meter);
    }

    [TestMethod]
    public void Offsets_AndExchangeRates_GoThroughSI()
    {
        Assert.AreEqual(21.5, EU.Temperature.FromDegreeCelsius(21.5).ToFast().DegreeCelsius, 1e-12);
        Assert.AreEqual(70.7, Temperature.FromDegreeFahrenheit(70.7).ToClassic().As(EU.Units.TemperatureUnit.DegreeFahrenheit), 1e-12);

        // Fast has no exchange-rate units, the bridge still converts a € value to SI ($) at EngineeringUnits' rate
        var euro = new EU.Cost(100, EU.Units.CostUnit.Euro);
        Assert.AreEqual(euro.As(EU.Units.CostUnit.SI), euro.ToFast().SI, 1e-9);
    }

    [TestMethod]
    public void Null_PassesThroughWithTheNullConditionalOperator()
    {
        EU.Length? classicNull = null;
        Length? fastNull = null;

        Assert.IsNull(classicNull?.ToFast());
        Assert.IsNull(fastNull?.ToClassic());
        Assert.ThrowsExactly<ArgumentNullException>(() => classicNull!.ToFast());

        EU.Length? classic = EU.Length.FromMeter(2);
        Length? fast = Length.FromMeter(3);
        Assert.AreEqual(2, classic?.ToFast().Meter);
        Assert.AreEqual(3, fast?.ToClassic().As(EU.Units.LengthUnit.Meter));
    }

    [TestMethod]
    public void ConvertedAndUnconvertedCodeMeetAtTheBoundary()
    {
        // A converted method called from code that still uses EngineeringUnits, and the other way round
        static Power Converted(MassFlow m, SpecificEntropy cp, Temperature dT) => m * cp * dT;
        static EU.Power Unconverted(EU.MassFlow m, EU.SpecificEntropy cp, EU.Temperature t1, EU.Temperature t2) => m * cp * (t2 - t1);

        var cp = EU.SpecificEntropy.FromKilojoulePerKilogramKelvin(4.18);
        var t1 = EU.Temperature.FromDegreeCelsius(10);
        var t2 = EU.Temperature.FromDegreeCelsius(35);

        Power fast = Converted(EU.MassFlow.FromKilogramPerSecond(2).ToFast(), cp.ToFast(), t2.ToFast() - t1.ToFast());
        EU.Power classic = Unconverted(MassFlow.FromKilogramPerSecond(2).ToClassic(), cp, t1, t2);

        Assert.AreEqual(209, fast.Kilowatt, 1e-9);
        Assert.AreEqual(209, classic.As(EU.Units.PowerUnit.Kilowatt), 1e-9);
        Assert.AreEqual(classic.ToFast().SI, fast.SI, 1e-9);
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void ToClassic_PrintsLikeFast(string quantity)
    {
        var info = Quantities.All.Single(q => q.Name == quantity);

        foreach (var si in new[] { 0, 1, 123.456, -0.5 })
        {
            var fast = info.FromSI(si);
            var classic = (EU.BaseUnit)ToClassic(quantity).Invoke(null, [fast])!;
            Assert.AreEqual(classic.ToString(), fast.ToString(), quantity);
        }
    }
}
