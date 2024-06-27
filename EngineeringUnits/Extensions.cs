using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace EngineeringUnits;

public static class Extensions
{

    public static bool IsValueOverDecimalMax(this double value)
    {
        return double.IsInfinity(value) ||
                value > (double)decimal.MaxValue ||
                value < (double)decimal.MinValue ||
                double.IsNaN(value);
    }

    public static IEnumerable<RawUnit> ReduceUnits(this IEnumerable<RawUnit> a)
    {
        return a.GroupBy(x => new { x.UnitType, x.A })
                          .Select(group => group.First()
                                                .CloneWithNewCount(group.Sum(x => x.Count)));

    }

    /// <returns>A SuperScript of an <see langword="int"/>!</returns>
    public static string ToSuperScript(this int number)
    {
        if (number is 0 or 1)
            return "";

        const string SuperscriptDigits =
            "\u2070\u00b9\u00b2\u00b3\u2074\u2075\u2076\u2077\u2078\u2079";

        var Superscript = "";

        if (number < 0)
        {
            //Adds superscript minus
            Superscript = ((char)0x207B).ToString();
            number *= -1;
        }

        Superscript += new string(number.ToString()
                                        .Select(x => SuperscriptDigits[x - '0'])
                                        .ToArray()
                                  );

        return Superscript;
    }

    /// <returns>A <see langword="string"/> of a <see langword="decimal"/> with the Significant Digits of <paramref name="count"/> !</returns>
    /// <param name="local">Source value</param>
    /// <param name="count">Precision of calculation</param>
    public static string DisplaySignificantDigits(this decimal local, int count)
    {

        //Im not sure this is as good of a idea as I first thought..
        //Almost the same as ToString("G" + inset number)

        var test = local.ToString(CultureInfo.InvariantCulture);

        //Is there no dot?
        if (test.Any(x => x == '.') is false)
            return test;

        //Trim trailing zeros
        test = test.TrimEnd('0');

        //Trim ending dot
        test = test.TrimEnd('.');

        //Is there still no dot?
        if (test.Any(x => x == '.') is false)
            return test;

        //Count current decimals
        var CurrentCount = test.Count(x => x is not '.' and not '-');

        //If we want more precision than we have
        if (CurrentCount <= count)
            return test;

        //Count before dot
        var dotIndex = test.IndexOf('.');

        //If it is negative value we apply a offset
        if (test.Any(x => x == '-'))
            dotIndex--;

        //How much precision after the dot are we looking for?
        var PrecisionAfterDot = count - dotIndex;

        if (PrecisionAfterDot < 0)
            PrecisionAfterDot = 0;

        //Round
        var test2 = decimal.Round(local, PrecisionAfterDot, MidpointRounding.AwayFromZero);

        //Calling this method again incase it needs some Trim
        var test3 = test2.DisplaySignificantDigits(count);

        return test3.ToString(CultureInfo.InvariantCulture);
    }

    public static string DisplaySignificantDigits(this DecimalSafe local, int count)
    {

        if (local.IsInf)
        {
            return "Infinity";
            //return double.PositiveInfinity.ToString();
        }

        if (local.IsNaN)
        {           
            return double.NaN.ToString();
        }

        return  ((decimal)local).DisplaySignificantDigits(count);
    }

    public static UnknownUnit AddUnit<T>(this double value, string UnitOfMeasure) where T : UnitTypebase
    {
        T unit = UnitTypebase.GetUnitByString<T>(UnitOfMeasure);

        return new UnknownUnit(value, unit);
    }

    [return: NotNullIfNotNull(nameof(value))]
    public static UnknownUnit? AddUnit<T>(this double? value, string UnitOfMeasure) where T : UnitTypebase
    {
        if (value is null)
            return null;

        return ((double)value).AddUnit<T>(UnitOfMeasure);
    }

    public static List<BaseUnit?> ToList(this (BaseUnit?, BaseUnit?) tuple) => [tuple.Item1, tuple.Item2];
    public static List<BaseUnit?> ToList(this (BaseUnit?, BaseUnit?, BaseUnit?) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3];
    public static List<BaseUnit?> ToList(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4];
    public static List<BaseUnit?> ToList(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5];
    public static List<BaseUnit?> ToList(this (BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?, BaseUnit?) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6];

}
