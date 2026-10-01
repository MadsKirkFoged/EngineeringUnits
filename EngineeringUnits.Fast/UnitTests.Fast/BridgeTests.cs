using EngineeringUnits.Fast;
using System.Reflection;
using System.Text;
using EU = global::EngineeringUnits;

namespace UnitTests.Fast;

/// <summary>ToFast() / ToClassic() (EngineeringUnits, FastConversions/FastBridge.g.cs) for every quantity, exact in SI.</summary>
[TestClass]
public class BridgeTests
{
    private static readonly double[] Samples =
    [
        0, -0d, 1, -3.7, 21.5, Math.PI, 123.456, 1e-6, 5e5, 1234567.891, 1e-30, 1e-300, double.Epsilon, 1e300,
        double.MaxValue, double.MinValue, double.NaN, double.PositiveInfinity, double.NegativeInfinity,
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
        var info = Quantities.All.Single(q => q.Name == quantity);
        var errors = new StringBuilder();

        foreach (var si in Samples)
        {
            var classic = (EU.BaseUnit)ToClassic(quantity).Invoke(null, [info.FromSI(si)])!;
            var back = (IQuantity)ToFast(quantity).Invoke(null, [classic])!;

            Assert.AreEqual(Original.QuantityType(quantity), classic.GetType());
            if (BitConverter.DoubleToInt64Bits(back.SI) != BitConverter.DoubleToInt64Bits(si))
                errors.AppendLine($"{quantity} {si:R} came back as {back.SI:R}");
            var held = Original.As(classic, quantity, "SI");
            if (BitConverter.DoubleToInt64Bits(held) != BitConverter.DoubleToInt64Bits(si))
                errors.AppendLine($"{quantity} {si:R}: the EngineeringUnits object holds {held:R}");
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    [DynamicData(nameof(AllQuantities))]
    public void ClassicInEveryUnit_ArrivesAsTheSameFastValue(string quantity)
    {
        // An EngineeringUnits value created in any unit lands where Fast puts the same number in that unit. Not the tiny
        // and huge samples: EngineeringUnits does non-SI math in decimal, where 1e-30 ft is 0
        var info = Quantities.All.Single(q => q.Name == quantity);
        var errors = new StringBuilder();

        foreach (var unit in info.Units)
        {
            foreach (var x in Samples.Where(x => x == 0 || Math.Abs(x) is >= 1e-6 and < 1e20))
            {
                var classic = Original.Create(quantity, x, unit.Name);
                var fast = (IQuantity)ToFast(quantity).Invoke(null, [classic])!;
                // Already SI: the stored double itself (the Fraction path goes through decimal: π -> 3.1415926535897927, -0 -> 0)
                var expected = classic.Unit.IsSIUnit() ? x : OriginalExact.As(classic, quantity, "SI");

                if (BitConverter.DoubleToInt64Bits(fast.SI) != BitConverter.DoubleToInt64Bits(expected))
                    errors.AppendLine($"{quantity}.{unit.Name}({x:R}): exact SI {expected:R}, bridge {fast.SI:R}");
                if (!Close.Enough(unit.ToSI(x), fast.SI))
                    errors.AppendLine($"{quantity}.{unit.Name}({x:R}): Fast.From gives {unit.ToSI(x):R}, bridge {fast.SI:R}");
            }
        }

        Assert.AreEqual("", errors.ToString());
    }

    [TestMethod]
    public void ClassicNotANumberInAUnit_StaysNotANumber()
    {
        Assert.IsTrue(double.IsNaN(EU.Length.FromFoot(double.NaN).ToFast().SI));
        Assert.AreEqual(double.PositiveInfinity, EU.Length.FromFoot(double.PositiveInfinity).ToFast().SI);
        Assert.AreEqual(double.NegativeInfinity, EU.Temperature.FromDegreeCelsius(double.NegativeInfinity).ToFast().SI);
    }

    [TestMethod]
    public void ClassicResultOfArithmetic_IsCopiedExactly()
    {
        // The result has a new (SI) unit system, not LengthUnit.SI - As(LengthUnit.SI) would go through decimal and lose it
        foreach (var x in new[] { 1e-20, Math.PI, 1e-160, 7.3e15 })
        {
            var l = EU.Length.FromMeter(x);
            EU.Area a = l * l;
            EU.Length back = a / l;

            Assert.AreEqual(x * x / x, back.ToFast().Meter, $"{x:R}");
        }
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
