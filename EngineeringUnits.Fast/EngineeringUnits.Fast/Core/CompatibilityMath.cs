using System;
using System.Collections.Generic;
using System.Linq;

namespace EngineeringUnits.Fast;

/// <summary>
/// Helpers with the same names and behaviour as in EngineeringUnits, so code keeps compiling after the using swap.
/// Generic over the quantity type, so the result is a named quantity again - no <see cref="UnknownUnit"/> to follow.
/// </summary>
public static partial class UnitMath
{
    // ---------- (a, b).Min() / Max() / Sum() / Average() / Mean() - same as EngineeringUnits ----------

    public static T Min<T>(this (T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2], Math.Min);
    public static T Min<T>(this (T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3], Math.Min);
    public static T Min<T>(this (T, T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3, v.Item4], Math.Min);
    public static T Min<T>(this (T, T, T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3, v.Item4, v.Item5], Math.Min);
    public static T Min<T>(this (T, T, T, T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3, v.Item4, v.Item5, v.Item6], Math.Min);

    public static T Max<T>(this (T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2], Math.Max);
    public static T Max<T>(this (T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3], Math.Max);
    public static T Max<T>(this (T, T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3, v.Item4], Math.Max);
    public static T Max<T>(this (T, T, T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3, v.Item4, v.Item5], Math.Max);
    public static T Max<T>(this (T, T, T, T, T, T) v) where T : struct, IQuantity<T> => Pick([v.Item1, v.Item2, v.Item3, v.Item4, v.Item5, v.Item6], Math.Max);

    public static T Sum<T>(this (T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Item1.SI + v.Item2.SI);
    public static T Sum<T>(this (T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Item1.SI + v.Item2.SI + v.Item3.SI);
    public static T Sum<T>(this (T, T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Item1.SI + v.Item2.SI + v.Item3.SI + v.Item4.SI);
    public static T Sum<T>(this (T, T, T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Item1.SI + v.Item2.SI + v.Item3.SI + v.Item4.SI + v.Item5.SI);
    public static T Sum<T>(this (T, T, T, T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Item1.SI + v.Item2.SI + v.Item3.SI + v.Item4.SI + v.Item5.SI + v.Item6.SI);

    public static T Average<T>(this (T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Sum().SI / 2);
    public static T Average<T>(this (T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Sum().SI / 3);
    public static T Average<T>(this (T, T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Sum().SI / 4);
    public static T Average<T>(this (T, T, T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Sum().SI / 5);
    public static T Average<T>(this (T, T, T, T, T, T) v) where T : struct, IQuantity<T> => T.FromSI(v.Sum().SI / 6);

    public static T Mean<T>(this (T, T) v) where T : struct, IQuantity<T> => new[] { v.Item1, v.Item2 }.Mean();
    public static T Mean<T>(this (T, T, T) v) where T : struct, IQuantity<T> => new[] { v.Item1, v.Item2, v.Item3 }.Mean();
    public static T Mean<T>(this (T, T, T, T) v) where T : struct, IQuantity<T> => new[] { v.Item1, v.Item2, v.Item3, v.Item4 }.Mean();
    public static T Mean<T>(this (T, T, T, T, T) v) where T : struct, IQuantity<T> => new[] { v.Item1, v.Item2, v.Item3, v.Item4, v.Item5 }.Mean();
    public static T Mean<T>(this (T, T, T, T, T, T) v) where T : struct, IQuantity<T> => new[] { v.Item1, v.Item2, v.Item3, v.Item4, v.Item5, v.Item6 }.Mean();

    /// <summary>The middle value (median), like EngineeringUnits' Mean: the element at Count / 2 after sorting.</summary>
    public static T Mean<T>(this IEnumerable<T> values) where T : struct, IQuantity<T>
    {
        var sorted = values.Select(v => v.SI).OrderBy(x => x).ToList();
        if (sorted.Count == 0)
            throw new InvalidOperationException("Sequence contains no elements");
        return T.FromSI(sorted[sorted.Count / 2]);
    }

    private static T Pick<T>(ReadOnlySpan<T> values, Func<double, double, double> pick) where T : struct, IQuantity<T>
    {
        var result = values[0].SI;
        for (int i = 1; i < values.Length; i++)
            result = pick(result, values[i].SI);
        return T.FromSI(result);
    }

    // ---------- Rounding to a list of standard sizes (pipe sizes, pump sizes, ...) ----------

    /// <summary>The smallest value in <paramref name="sizes"/> that is at least <paramref name="value"/> (or the largest size).</summary>
    public static T RoundUpToNearest<T>(this IEnumerable<T> sizes, T value) where T : struct, IQuantity<T>
    {
        var list = NonEmpty(sizes);
        var above = list.Where(x => x.SI >= value.SI).ToList();
        return above.Count == 0 ? MaxOf(list) : MinOf(above);
    }

    /// <summary>The largest value in <paramref name="sizes"/> that is at most <paramref name="value"/> (or the smallest size).</summary>
    public static T RoundDownToNearest<T>(this IEnumerable<T> sizes, T value) where T : struct, IQuantity<T>
    {
        var list = NonEmpty(sizes);
        var below = list.Where(x => x.SI <= value.SI).ToList();
        return below.Count == 0 ? MinOf(list) : MaxOf(below);
    }

    /// <summary>The value in <paramref name="sizes"/> closest to <paramref name="value"/>.</summary>
    public static T RoundToNearest<T>(this IEnumerable<T> sizes, T value) where T : struct, IQuantity<T>
        => NonEmpty(sizes).OrderBy(x => Math.Abs(x.SI - value.SI)).First();

    // Nullable versions - same rules as EngineeringUnits: null when the value is null, the list is empty or has a null in it

    public static T? RoundUpToNearest<T>(this IEnumerable<T?> sizes, T? value) where T : struct, IQuantity<T>
        => AllValues(sizes, value) is { } list && value is { } v ? list.RoundUpToNearest(v) : null;

    public static T? RoundUpToNearest<T>(this IEnumerable<T> sizes, T? value) where T : struct, IQuantity<T>
        => sizes.Select(x => (T?)x).RoundUpToNearest(value);

    public static T? RoundDownToNearest<T>(this IEnumerable<T?> sizes, T? value) where T : struct, IQuantity<T>
        => AllValues(sizes, value) is { } list && value is { } v ? list.RoundDownToNearest(v) : null;

    public static T? RoundDownToNearest<T>(this IEnumerable<T> sizes, T? value) where T : struct, IQuantity<T>
        => sizes.Select(x => (T?)x).RoundDownToNearest(value);

    public static T? RoundToNearest<T>(this IEnumerable<T?> sizes, T? value) where T : struct, IQuantity<T>
        => AllValues(sizes, value) is { } list && value is { } v ? list.RoundToNearest(v) : null;

    public static T? RoundToNearest<T>(this IEnumerable<T> sizes, T? value) where T : struct, IQuantity<T>
        => sizes.Select(x => (T?)x).RoundToNearest(value);

    private static List<T>? AllValues<T>(IEnumerable<T?> sizes, T? value) where T : struct
    {
        if (value is null)
            return null;
        var list = sizes.ToList();
        return list.Count == 0 || list.Any(x => x is null) ? null : list.Select(x => x!.Value).ToList();
    }

    private static List<T> NonEmpty<T>(IEnumerable<T> values)
    {
        var list = values.ToList();
        if (list.Count == 0)
            throw new InvalidOperationException("Sequence contains no elements");
        return list;
    }

    private static T MinOf<T>(List<T> list) where T : struct, IQuantity<T> => list.OrderBy(x => x.SI).First();
    private static T MaxOf<T>(List<T> list) where T : struct, IQuantity<T> => list.OrderBy(x => x.SI).Last();

    // ---------- LinearInterpolation - same as EngineeringUnits ----------

    /// <summary>y at <paramref name="x"/> on the line through (x0, y0) and (x1, y1). If x0 == x1 the average of y0 and y1.</summary>
    public static TY LinearInterpolation<TX, TY>(TX x, TX x0, TX x1, TY y0, TY y1)
        where TX : struct, IQuantity<TX>
        where TY : struct, IQuantity<TY>
    {
        if (x1.SI == x0.SI)
            return TY.FromSI((y0.SI + y1.SI) / 2);

        return TY.FromSI(y0.SI + ((x.SI - x0.SI) * (y1.SI - y0.SI) / (x1.SI - x0.SI)));
    }

    /// <summary>Nullable version: null when any input is null.</summary>
    public static TY? LinearInterpolation<TX, TY>(TX? x, TX? x0, TX? x1, TY? y0, TY? y1)
        where TX : struct, IQuantity<TX>
        where TY : struct, IQuantity<TY>
        => x is { } a && x0 is { } b && x1 is { } c && y0 is { } d && y1 is { } e ? LinearInterpolation(a, b, c, d, e) : null;

    // Mixed nullable/non-nullable arguments (e.g. a Temperature? x with Temperature x0/x1): C# can't infer TY from a
    // non-nullable argument into a TY? parameter, so these cover the two usual mixes
    public static TY? LinearInterpolation<TX, TY>(TX? x, TX? x0, TX? x1, TY y0, TY y1)
        where TX : struct, IQuantity<TX>
        where TY : struct, IQuantity<TY>
        => LinearInterpolation(x, x0, x1, (TY?)y0, (TY?)y1);

    public static TY? LinearInterpolation<TX, TY>(TX x, TX x0, TX x1, TY? y0, TY? y1)
        where TX : struct, IQuantity<TX>
        where TY : struct, IQuantity<TY>
        => LinearInterpolation((TX?)x, (TX?)x0, (TX?)x1, y0, y1);
}

/// <summary>Trigonometry on angles - same as EngineeringUnits' AngleMath (including the double? return type).</summary>
public static class AngleMath
{
    public static double? Sin(this Angle a) => Math.Sin(a.Radian);
    public static double? Cos(this Angle a) => Math.Cos(a.Radian);
    public static double? Tan(this Angle a) => Math.Tan(a.Radian);
    public static double? Sinh(this Angle a) => Math.Sinh(a.Radian);
    public static double? Cosh(this Angle a) => Math.Cosh(a.Radian);
    public static double? Tanh(this Angle a) => Math.Tanh(a.Radian);

    public static double? Sin(this Angle? a) => a is { } v ? Math.Sin(v.Radian) : null;
    public static double? Cos(this Angle? a) => a is { } v ? Math.Cos(v.Radian) : null;
    public static double? Tan(this Angle? a) => a is { } v ? Math.Tan(v.Radian) : null;
    public static double? Sinh(this Angle? a) => a is { } v ? Math.Sinh(v.Radian) : null;
    public static double? Cosh(this Angle? a) => a is { } v ? Math.Cosh(v.Radian) : null;
    public static double? Tanh(this Angle? a) => a is { } v ? Math.Tanh(v.Radian) : null;
}

/// <summary>Circle areas - same as EngineeringUnits' AreaExtra.</summary>
public static class AreaExtra
{
    public static Area FromCircleDiameter(this Length diameter) => FromCircleRadius(diameter / 2);
    public static Area FromCircleRadius(this Length radius) => radius * radius * Math.PI;
    public static Area? FromCircleDiameter(this Length? diameter) => diameter is { } d ? FromCircleDiameter(d) : null;
    public static Area? FromCircleRadius(this Length? radius) => radius is { } r ? FromCircleRadius(r) : null;
}

public readonly partial struct Area
{
    public static Area FromCircleDiameter(Length diameter) => AreaExtra.FromCircleDiameter(diameter);
    public static Area FromCircleRadius(Length radius) => AreaExtra.FromCircleRadius(radius);
    public static Area? FromCircleDiameter(Length? diameter) => AreaExtra.FromCircleDiameter(diameter);
    public static Area? FromCircleRadius(Length? radius) => AreaExtra.FromCircleRadius(radius);
}
