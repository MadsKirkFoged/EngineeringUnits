using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
#if NET8_0_OR_GREATER
using System.Numerics;
using Uno.Extensions;
using Uno.Extensions.Specialized;

namespace EngineeringUnits.Numerics;

public static class UnitMathExtensions
{
    // These methods currently longer definition like Sum, Average, Mean can be used with .NET 9.0 or later with System.Numerics.Tensors Nuget package.
    // Sum overload for System.Numerics.INumber<TNumber>
    public static TNumber? Sum<TNumber>(this IEnumerable<TNumber?> values) where TNumber : struct, INumber<TNumber>
    {
        var list = values.Safe().Trim(); // Ensure list is not null and has only non-null items

        if (list.None())
            return default(TNumber);

        TNumber sum = TNumber.Zero;
        list.ForEach(item => sum += item);

        return sum;
    }

    public static TNumber? Sum<TNumber>(params TNumber?[] x) where TNumber : struct, INumber<TNumber>
        => x.Sum();
    public static TNumber? Sum<TNumber>(this (TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2 }.Sum();
    public static TNumber? Sum<TNumber>(this (TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3 }.Sum();
    public static TNumber? Sum<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4 }.Sum();
    public static TNumber? Sum<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5 }.Sum();
    public static TNumber? Sum<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5, list.Item6 }.Sum();

    // Average overload for System.Numerics.INumber<TNumber>
    public static TNumber? Average<TNumber>(this IEnumerable<TNumber?> values) where TNumber : struct, INumber<TNumber>
    {
        // Ensure values is not null and has only non-null items
        IEnumerable<TNumber?> list = values.Safe();

        var sum = list.Sum();
        
        return sum.HasValue ?  sum.Value / TNumber.CreateChecked(list.Count()) : default ;
    }

    public static TNumber? Average<TNumber>(params TNumber?[] x) where TNumber : struct, INumber<TNumber>
        => x.Average();
    public static TNumber? Average<TNumber>(this (TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2 }.Average();
    public static TNumber? Average<TNumber>(this (TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3 }.Average();
    public static TNumber? Average<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4 }.Average();
    public static TNumber? Average<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5 }.Average();
    public static TNumber? Average<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5, list.Item6 }.Average();

    // Median (Mean) overload for System.Numerics.INumber<TNumber>
    public static TNumber? Mean<TNumber>(this IEnumerable<TNumber?> values) where TNumber : struct, INumber<TNumber>
    {
        var list = (IList<TNumber>)values.Safe().Trim(); // Ensure list is not null and has only non-null items
        if (list.Count == 0)
            return default(TNumber);

        var ordered = (IList<TNumber>)list.OrderBy(x => x);

        int count = ordered.Count;
        if (count % 2 == 1)
        {
            return ordered[count / 2];
        }
        else
        {
            return (ordered[(count / 2) - 1] + ordered[count / 2]) / TNumber.CreateChecked(2);
        }
    }

    public static TNumber? Mean<TNumber>(params TNumber?[] x) where TNumber : struct, INumber<TNumber>
        => x.Mean();
    public static TNumber? Mean<TNumber>(this (TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2 }.Mean();
    public static TNumber? Mean<TNumber>(this (TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2, list.Item3 }.Mean();
    public static TNumber? Mean<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4 }.Mean();
    public static TNumber? Mean<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5 }.Mean();
    public static TNumber? Mean<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5, list.Item6 }.Mean();

    // Min overload for System.Numerics.INumber<TNumber>
    //public static TNumber? Min<TNumber>(this IEnumerable<TNumber?> list) where TNumber : struct, INumber<TNumber>
    //{
    //    if (list is null || !list.Any())
    //        return null;

    //    if (list.Any(x => x is null))
    //        return null;

    //    return list.Min();
    //}

    public static TNumber? Min<TNumber>(params TNumber?[] x) where TNumber : struct, INumber<TNumber> 
        => x.Min();
    public static TNumber? Min<TNumber>(this (TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2 }.Min();
    public static TNumber? Min<TNumber>(this (TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2, list.Item3 }.Min();
    public static TNumber? Min<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4 }.Min();
    public static TNumber? Min<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5 }.Min();
    public static TNumber? Min<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5, list.Item6 }.Min();

    // Max overload for System.Numerics.INumber<TNumber>
    public static TNumber? Max<TNumber>(this IEnumerable<TNumber?> values) where TNumber : struct, INumber<TNumber>
    {
        var list = (IList<TNumber>)values.Safe().Trim(); // Ensure list is not null and has only non-null items

        if(list.Count == 0)
            return default(TNumber);

        return list.Max();
    }

    public static TNumber? Max<TNumber>(params TNumber?[] x) where TNumber : struct, INumber<TNumber> => x.Max();
    public static TNumber? Max<TNumber>(this (TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2 }.Max();
    public static TNumber? Max<TNumber>(this (TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3 }.Max();
    public static TNumber? Max<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber>
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4 }.Max();
    public static TNumber? Max<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5 }.Max();
    public static TNumber? Max<TNumber>(this (TNumber?, TNumber?, TNumber?, TNumber?, TNumber?, TNumber?) list) where TNumber : struct, INumber<TNumber> 
        => new[] { list.Item1, list.Item2, list.Item3, list.Item4, list.Item5, list.Item6 }.Max();

    [return: NotNullIfNotNull(nameof(a))]
    public static TNumber? Abs<TNumber>(this TNumber? a) where TNumber : struct, INumberBase<TNumber>
        => !a.HasValue ? null : TNumber.Abs(a.Value);

    public static IEnumerable<TNumber?> Abs<TNumber>(this IEnumerable<TNumber?> a) where TNumber : struct, INumberBase<TNumber>
        => a.Select(x => x.Abs());

    // Sqrt overload for System.Numerics.INumber<TNumber>
    [return: NotNullIfNotNull(nameof(a))]
    public static TNumber? Sqrt<TNumber>(this TNumber? a) where TNumber : struct, IRootFunctions<TNumber>
    {
        if (!a.HasValue || TNumber.IsNegative(a.Value))
            return null;

        return TNumber.Sqrt(a.Value);
    }
}
#endif // NET8_0_OR_GREATER