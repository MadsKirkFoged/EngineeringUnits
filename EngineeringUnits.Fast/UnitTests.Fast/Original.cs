using EngineeringUnits.Fast;
using Fractions;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using EU = global::EngineeringUnits;

namespace UnitTests.Fast;

/// <summary>Talks to the original EngineeringUnits by name, so every Fast quantity can be checked against it.</summary>
internal static class Original
{
    private static readonly Assembly Asm = typeof(EU.BaseUnit).Assembly;

    public static Type QuantityType(string quantity) => Asm.GetType($"EngineeringUnits.{quantity}", throwOnError: true)!;
    public static Type UnitType(string quantity) => Asm.GetType($"EngineeringUnits.Units.{quantity}Unit", throwOnError: true)!;

    public static object Unit(string quantity, string unitName)
    {
        var t = UnitType(quantity);
        return t.GetField(unitName, BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
            ?? t.GetProperty(unitName, BindingFlags.Public | BindingFlags.Static)?.GetValue(null)
            ?? throw new InvalidOperationException($"{quantity}Unit.{unitName} not found");
    }

    public static EU.BaseUnit Create(string quantity, double value, string unitName)
    {
        var ctor = QuantityType(quantity).GetConstructor([typeof(double), UnitType(quantity)])!;
        return (EU.BaseUnit)ctor.Invoke([value, Unit(quantity, unitName)]);
    }

    public static double As(EU.BaseUnit value, string quantity, string unitName)
    {
        var method = QuantityType(quantity).GetMethod("As", [UnitType(quantity)])!;
        return (double)method.Invoke(value, [Unit(quantity, unitName)])!;
    }

    public static string ToString(EU.BaseUnit value) => value.ToString();
}

internal static class Close
{
    /// <summary>Relative comparison, absolute near zero. Both NaN counts as equal.</summary>
    public static bool Enough(double expected, double actual, double relative = 1e-12)
    {
        if (double.IsNaN(expected) && double.IsNaN(actual)) return true;
        if (expected == actual) return true;
        var scale = Math.Max(Math.Abs(expected), Math.Abs(actual));
        return Math.Abs(expected - actual) <= relative * Math.Max(scale, 1e-300);
    }
}

internal static class OriginalExact
{
    /// <summary>
    /// The original's exact Fraction path, rounded once to the nearest double. Its As() goes through decimal, which only keeps
    /// 28 decimal places: 1 µg/day comes back as 1.15740741E-20 instead of 1.1574074074074073E-20.
    /// </summary>
    public static double As(global::EngineeringUnits.BaseUnit value, string quantity, string unitName)
    {
        var unit = (global::EngineeringUnits.UnitTypebase)Original.Unit(quantity, unitName);
        return RoundedOnce(global::EngineeringUnits.BaseUnitExtensions.GetValueAs(value, unit.Unit));
    }

    // 1100 decimal places: more than any double needs, the halfway points between subnormals included (1075)
    private static readonly BigInteger DecimalPlaces = BigInteger.Pow(10, 1100);

    /// <summary>
    /// Rounded once to the nearest double. Fraction.ToDouble() is not: 7 / 10^24 gives 7.000000000000001E-24. Written out to
    /// 1100 decimal places for double.Parse (which rounds correctly), with a 1 at the end when more digits follow - a different
    /// route than EngineeringUnits' own conversion to Fast, which rounds binary integers.
    /// </summary>
    public static double RoundedOnce(Fraction value)
    {
        if (value.Denominator.IsZero)
            return value.ToDouble();    // NaN, ±Infinity

        var digits = BigInteger.DivRem(BigInteger.Abs(value.Numerator) * DecimalPlaces, BigInteger.Abs(value.Denominator), out var rest);
        var sign = value.Numerator.Sign * value.Denominator.Sign < 0 ? "-" : "";
        var text = sign + digits.ToString(CultureInfo.InvariantCulture) + (rest.IsZero ? "E-1100" : "1E-1101");
        return double.Parse(text, NumberStyles.Float, CultureInfo.InvariantCulture);
    }
}
