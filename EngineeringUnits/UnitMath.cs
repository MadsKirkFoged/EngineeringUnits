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
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Sum([SameDimension] this IEnumerable<BaseUnit?> list)
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

    [return: DimensionOf(nameof(x))]
    public static UnknownUnit? Sum([SameDimension] params BaseUnit?[] x) => x.Sum();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Sum([SameDimension] this (BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Sum([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Sum([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Sum([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Sum([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Sum();

    /// <summary>
    /// Calculates the average value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The average value of the <see cref="BaseUnit"/> objects.</returns>
    /// <exception cref="WrongUnitException">Thrown when the unit of value and limit are different</exception>
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Average([SameDimension] this IEnumerable<BaseUnit?> list)
    {
        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        return list.Sum() / list.Count();
    }

    [return: DimensionOf(nameof(x))]
    public static UnknownUnit? Average([SameDimension] params BaseUnit?[] x) => x.Average();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Average([SameDimension] this (BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Average([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Average([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Average([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Average([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Average();

    /// <summary>
    /// Calculates the mean value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The mean value of the <see cref="BaseUnit"/> objects.</returns>
    /// <exception cref="WrongUnitException">Thrown when the unit of value and limit are different</exception>

    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Mean([SameDimension] this IEnumerable<BaseUnit?> list)
    {
        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        return new(list.OrderBy(x => x).ToList()[list.Count() / 2]!);
    }

    [return: DimensionOf(nameof(x))]
    public static UnknownUnit? Mean([SameDimension] params BaseUnit?[] x) => x.Mean();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Mean([SameDimension] this (BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Mean([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Mean([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Mean([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Mean([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Mean();

    /// <summary>
    /// Calculates the minimum value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The minimum value of the <see cref="BaseUnit"/> objects.</returns>
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Min([SameDimension] IEnumerable<BaseUnit?> list) => list.Min().ToUnknownUnit();

    [return: DimensionOf(nameof(x))]
    public static UnknownUnit? Min([SameDimension] params BaseUnit?[] x) => x.Min().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Min([SameDimension] this (BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Min([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Min([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Min([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Min([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Min().ToUnknownUnit();

    /// <summary>
    /// Calculates the maximum value of a collection of <see cref="BaseUnit"/> objects.
    /// </summary>
    /// <param name="list">The collection of <see cref="BaseUnit"/> objects.</param>
    /// <returns>The maximum value of the <see cref="BaseUnit"/> objects.</returns>
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Max([SameDimension] IEnumerable<BaseUnit?> list) => list.Max().ToUnknownUnit();

    [return: DimensionOf(nameof(x))]
    public static UnknownUnit? Max([SameDimension] params BaseUnit?[] x) => x.Max().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Max([SameDimension] this (BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Max([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Max([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Max([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();
    [return: DimensionOf(nameof(list))]
    public static UnknownUnit? Max([SameDimension] this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) list) => list.ToList().Max().ToUnknownUnit();

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
    [return: DimensionOf(nameof(y0))]
    public static UnknownUnit? LinearInterpolation([SameDimension("x")] BaseUnit? x, [SameDimension("x")] BaseUnit? x0, [SameDimension("x")] BaseUnit? x1, [SameDimension("y")] BaseUnit? y0, [SameDimension("y")] BaseUnit? y1)
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
    [return: DimensionOf(nameof(a))]
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

    /// <summary>
    /// Returns the square root your unit.<br></br>
    /// Taking the sqrt of a Negativ number will return null.<br></br>
    /// <example>
    /// Exemple: The square root of an <see cref="Area"/> gives a <see cref="Length"/><br></br>
    /// </example>
    /// </summary>
    /// <param name="a">Source value</param>
    /// <exception cref="WrongUnitException">gg</exception>
    [return: NotNullIfNotNull(nameof(a))]
    [return: DimensionOf(nameof(a), Root = 2)]
    public static UnknownUnit? Sqrt(this BaseUnit? a)
    {
        if (a is null || a.IsBelowZero())
            return null;

        UnitSystem NewUnitSystem = a.Unit.ReduceUnitsHard();
        var value = (decimal)a.GetValueAs(NewUnitSystem);

        return new UnknownUnit(value.Sqrt(), NewUnitSystem.Sqrt());
    }

    /// <returns>Square root of <see langword="decimal"/>!</returns>
    /// <param name="x">Source value</param>
    /// <param name="epsilon">Precision of calculation</param>
    public static decimal Sqrt(this decimal x, decimal epsilon = 0.0M)
    {
        // x - a number, from which we need to calculate the square root
        // epsilon - an accuracy of calculation of the root from our number.
        // The result of the calculations will differ from an actual value
        // of the root on less than epslion.

        if (x < 0)
            throw new OverflowException("Cannot calculate square root from a negative number");

        decimal current = (decimal)Math.Sqrt((double)x), previous;
        do
        {
            previous = current;
            if (previous == 0.0M)
                return 0;

            current = (previous + (x / previous)) / 2;
        }
        while (Math.Abs(previous - current) > epsilon);
        return current;
    }
}
