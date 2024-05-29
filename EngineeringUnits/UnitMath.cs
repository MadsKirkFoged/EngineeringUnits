using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace EngineeringUnits;

public static class UnitMath
{

    /// <summary>
    /// Calculates the sum of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The sum of the <see cref="BaseUnit"/> objects.</returns>
    /// <exception cref="WrongUnitException">Thrown when the unit of value and limit are different</exception>
    public static UnknownUnit? Sum(this IEnumerable<BaseUnit?> list)
    {
        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        // Fix for temperature, albeit not very elegant
        if (list.All(u => u is Temperature))
        {
            return list.Aggregate(new UnknownUnit(0m, list.First()!.ToUnit(TemperatureUnit.SI)),
                                (x, y) => (x + y)!);
        }

        return list.Aggregate(new UnknownUnit(0m, list.First()!),
                            (x, y) => (x + y)!);
    }

    public static UnknownUnit? Sum(params BaseUnit?[] x) => x.Sum();
    public static UnknownUnit? Sum(this (BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    public static UnknownUnit? Sum(this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    public static UnknownUnit? Sum(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    public static UnknownUnit? Sum(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    public static UnknownUnit? Sum(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();

    /// <summary>
    /// Calculates the average value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The average value of the <see cref="BaseUnit"/> objects.</returns>
    /// <exception cref="WrongUnitException">Thrown when the unit of value and limit are different</exception>
    public static UnknownUnit? Average(this IEnumerable<BaseUnit?> list)
    {
        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        return list.Sum() / list.Count();
    }

    public static UnknownUnit? Average(params BaseUnit?[] x) => x.Average();
    public static UnknownUnit? Average(this (BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    public static UnknownUnit? Average(this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    public static UnknownUnit? Average(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    public static UnknownUnit? Average(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    public static UnknownUnit? Average(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();

    /// <summary>
    /// Calculates the mean value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The mean value of the <see cref="BaseUnit"/> objects.</returns>
    /// <exception cref="WrongUnitException">Thrown when the unit of value and limit are different</exception>

    public static UnknownUnit? Mean(this IEnumerable<BaseUnit?> list)
    {
        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        return new(list.OrderBy(x => x).ToList()[list.Count() / 2]!);
    }

    public static UnknownUnit? Mean(params BaseUnit?[] x) => x.Mean();
    public static UnknownUnit? Mean(this (BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    public static UnknownUnit? Mean(this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    public static UnknownUnit? Mean(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    public static UnknownUnit? Mean(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    public static UnknownUnit? Mean(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();

    /// <summary>
    /// Calculates the minimum value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The minimum value of the <see cref="BaseUnit"/> objects.</returns>
    public static UnknownUnit? Min(IEnumerable<BaseUnit?> list) => list.Min().ToUnknownUnit();

    public static UnknownUnit? Min(params BaseUnit?[] x) => x.Min().ToUnknownUnit();
    public static UnknownUnit? Min(this (BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    public static UnknownUnit? Min(this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    public static UnknownUnit? Min(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    public static UnknownUnit? Min(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    public static UnknownUnit? Min(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();

    /// <summary>
    /// Calculates the maximum value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The maximum value of the <see cref="BaseUnit"/> objects.</returns>
    public static UnknownUnit? Max(IEnumerable<BaseUnit?> list) => list.Max().ToUnknownUnit();

    public static UnknownUnit? Max(params BaseUnit?[] x) => x.Max().ToUnknownUnit();
    public static UnknownUnit? Max(this (BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    public static UnknownUnit? Max(this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    public static UnknownUnit? Max(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    public static UnknownUnit? Max(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    public static UnknownUnit? Max(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();

    /// <summary>
    /// Performs linear interpolation between two points.
    /// <code>
    ///    ▲
    /// y1 │             *
    ///    │            /
    ///    │           /
    ///    │          /
    ///    │         /
    /// y  │ - - -  • (x,y)
    ///    │       /
    ///    │      / ¦
    ///    │     /  
    ///    │    /   ¦
    ///  y0│   *    
    ///    │        ¦
    ///    └──────────────────►
    ///        x0   x    x1
    /// </code>
    /// 
    /// </summary>
    /// <param name="x">The x-coordinate of the point to interpolate.</param>
    /// <param name="x0">The x-coordinate of the first reference point.</param>
    /// <param name="x1">The x-coordinate of the second reference point.</param>
    /// <param name="y0">The y-coordinate of the first reference point.</param>
    /// <param name="y1">The y-coordinate of the second reference point.</param>
    /// <returns>y-coordinate.</returns>
    public static UnknownUnit? LinearInterpolation(BaseUnit? x, BaseUnit? x0, BaseUnit? x1, BaseUnit? y0, BaseUnit? y1)
    {

        if (x1 == x0)
        {
            return (y0 + y1) / 2;
        }

        return y0 + ((x - x0) * (y1 - y0) / (x1 - x0));
    }

    /// <summary>
    /// Calculates the absolute value of a <see cref="BaseUnit"/> object.
    /// </summary>
    /// <param name="a">The <see cref="BaseUnit"/> object.</param>
    /// <returns>The absolute value of the <see cref="BaseUnit"/> object.</returns>
    [return: NotNullIfNotNull(nameof(a))]
    public static UnknownUnit? Abs(this BaseUnit? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a.ToUnknownUnit();

        return (-a)!;
    }

    /// <returns>Absolute value of your units inside the <see langword="List"/> </returns>
    /// <param name="a">Source value</param>
    public static IEnumerable<UnknownUnit?> Abs(this IEnumerable<BaseUnit?> a) => a.Select(x => x.Abs());

}
