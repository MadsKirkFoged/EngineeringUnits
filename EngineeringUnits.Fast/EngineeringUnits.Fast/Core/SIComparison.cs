using System;
using System.Runtime.CompilerServices;

namespace EngineeringUnits.Fast;

/// <summary>
/// What ==, !=, &lt;, &gt;, &lt;= and &gt;= on quantities use. EngineeringUnits compares exact fractions, so 16.8833 bar == 1688330 Pa
/// and 1 ft == 12 in are true there. In doubles the two sides can be 1 ulp apart, depending on which unit each came from.
/// So two values within <see cref="RelativeTolerance"/> of each other are equal, and the ordering operators agree with that:
/// equal values are never &lt; or &gt; each other.<br></br>
/// Equals, GetHashCode and CompareTo stay exact on purpose: a tolerance can't be hashed (Dictionary, HashSet, Distinct) and
/// isn't transitive (sorting needs that).
/// </summary>
internal static class SIComparison
{
    /// <summary>1e-12: thousands of ulps, so rounding never makes equal values unequal, and far below anything measurable.</summary>
    public const double RelativeTolerance = 1e-12;

    /// <summary>NaN is never equal. Infinities are only equal to the same infinity. Close to 0 it is still exact (1e-300 != 0).</summary>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Equal(double a, double b, double relativeTolerance = RelativeTolerance)
        => a == b || (double.IsFinite(a) && double.IsFinite(b) && Math.Abs(a - b) <= relativeTolerance * Math.Max(Math.Abs(a), Math.Abs(b)));

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Less(double a, double b) => a < b && !Equal(a, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Greater(double a, double b) => a > b && !Equal(a, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool LessOrEqual(double a, double b) => a <= b || Equal(a, b);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool GreaterOrEqual(double a, double b) => a >= b || Equal(a, b);
}
