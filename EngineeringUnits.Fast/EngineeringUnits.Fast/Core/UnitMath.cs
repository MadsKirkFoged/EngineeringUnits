using System;

namespace EngineeringUnits.Fast;

/// <summary>
/// Math on quantities. Named quantities get typed overloads (generated); these are the <see cref="UnknownUnit"/> versions.<br></br>
/// The attributes tell the analyzer what unit comes out, so results stay checked.
/// </summary>
public static partial class UnitMath
{
    [return: DimensionOf(nameof(value))]
    public static UnknownUnit Abs(this UnknownUnit value) => new(Math.Abs(value.SI));

    [return: DimensionOf(nameof(value), Root = 2)]
    public static UnknownUnit Sqrt(this UnknownUnit value) => new(Math.Sqrt(value.SI));

    [return: DimensionOf(nameof(value), PowerParameter = nameof(toPower))]
    public static UnknownUnit Pow(this UnknownUnit value, int toPower) => new(Math.Pow(value.SI, toPower));

    [return: DimensionOf(nameof(a))]
    public static UnknownUnit Min([SameDimension] UnknownUnit a, [SameDimension] UnknownUnit b) => a.SI <= b.SI ? a : b;

    [return: DimensionOf(nameof(a))]
    public static UnknownUnit Max([SameDimension] UnknownUnit a, [SameDimension] UnknownUnit b) => a.SI >= b.SI ? a : b;

    // ---------- The same on UnknownUnit? - like EngineeringUnits' BaseUnit? extensions: null in, null out ----------

    [return: DimensionOf(nameof(value))]
    public static UnknownUnit? Abs(this UnknownUnit? value) => value is { } v ? v.Abs() : null;

    [return: DimensionOf(nameof(value), Root = 2)]
    public static UnknownUnit? Sqrt(this UnknownUnit? value) => value is { } v ? v.Sqrt() : null;

    [return: DimensionOf(nameof(value), PowerParameter = nameof(toPower))]
    public static UnknownUnit? Pow(this UnknownUnit? value, int toPower) => value is { } v ? v.Pow(toPower) : null;

    [return: DimensionOf(nameof(value))]
    public static UnknownUnit? Clamp([SameDimension] this UnknownUnit? value, [SameDimension] UnknownUnit? min, [SameDimension] UnknownUnit? max)
    {
        if (value is not { } v)
            return null;
        if (min is { } lo && v.SI < lo.SI)
            v = lo;
        if (max is { } hi && v.SI > hi.SI)
            v = hi;
        return v;
    }

    [return: DimensionOf(nameof(value))]
    public static UnknownUnit? LowerLimitAt([SameDimension] this UnknownUnit? value, [SameDimension] UnknownUnit? limit)
        => value is { } v && limit is { } l ? (v.SI < l.SI ? l : v) : null;

    [return: DimensionOf(nameof(value))]
    public static UnknownUnit? UpperLimitAt([SameDimension] this UnknownUnit? value, [SameDimension] UnknownUnit? limit)
        => value is { } v && limit is { } l ? (v.SI > l.SI ? l : v) : null;

    public static bool IsZero(this UnknownUnit? value) => value is { } v && v.SI == 0;
    public static bool IsNotZero(this UnknownUnit? value) => value is { } v && v.SI != 0;
    public static bool IsAboveZero(this UnknownUnit? value) => value is { } v && v.SI > 0;
    public static bool IsBelowZero(this UnknownUnit? value) => value is { } v && v.SI < 0;
    public static bool IsNaN(this UnknownUnit? value) => value is { } v && double.IsNaN(v.SI);
    /// <summary>True for null, NaN and infinity. (HasValue() can't be offered: UnknownUnit? already has a HasValue property, which only checks for null.)</summary>
    public static bool HasNoValue(this UnknownUnit? value) => value is not { } v || double.IsNaN(v.SI) || double.IsInfinity(v.SI);

    /// <summary>The same value as an <see cref="UnknownUnit"/> - like EngineeringUnits. (A quantity also converts to one implicitly.)</summary>
    [return: DimensionOf(nameof(quantity))]
    public static UnknownUnit ToUnknownUnit<T>(this T quantity) where T : struct, IQuantity<T> => new(quantity.SI);

    [return: DimensionOf(nameof(quantity))]
    public static UnknownUnit? ToUnknownUnit<T>(this T? quantity) where T : struct, IQuantity<T> => quantity is { } q ? new UnknownUnit(q.SI) : null;
}
