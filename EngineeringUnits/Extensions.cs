using EngineeringUnits.Units;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace EngineeringUnits
{
    public static class Extensions
    {

        public static bool IsValueOverDecimalMax(this double value)
        {
            return double.IsInfinity(value) ||
                    value > (double)decimal.MaxValue ||
                    value < (double)decimal.MinValue ||
                    double.IsNaN(value);
        }


        /// <summary>
        /// Returns the square root your unit.<br></br>
        /// <example>
        /// Exemple: The square root of an <see cref="Area"/> gives a <see cref="Length"/><br></br>
        /// </example>
        /// </summary>
        /// <param name="a">Source value</param>
        /// <exception cref="WrongUnitException">gg</exception>
        public static UnknownUnit Sqrt(this BaseUnit a)
        {
            if (a is null)
                return null;

            UnitSystem NewUnitSystem = a.Unit.ReduceUnitsHard();
            var value = (decimal)a.GetValueAs(NewUnitSystem);

            return new UnknownUnit(value.Sqrt(), NewUnitSystem.Sqrt());
        }


       

        public static IEnumerable<RawUnit> ReduceUnits(this IEnumerable<RawUnit> a)
        {
            return a.GroupBy(x => new { x.UnitType, x.A })
                              .Select(group => group.First()
                                                    .CloneWithNewCount(group.Sum(x => x.Count)));

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

                current = (previous + x / previous) / 2;
            }
            while (Math.Abs(previous - current) > epsilon);
            return current;
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
            return ((decimal)local).DisplaySignificantDigits(count);
        }


        public static UnknownUnit AddUnit<T>(this double value, string UnitOfMeasure) where T : UnitTypebase
        {
            var unit = UnitTypebase.GetUnitByString<T>(UnitOfMeasure);

            return new UnknownUnit(value, unit);
        }

        public static UnknownUnit AddUnit<T>(this double? value, string UnitOfMeasure) where T : UnitTypebase
        {
            if (value is null)            
                return null;            

            return ((double)value).AddUnit<T>(UnitOfMeasure);
        }


        public static List<BaseUnit> ToList(this (BaseUnit, BaseUnit) tuple) => [tuple.Item1, tuple.Item2];
        public static List<BaseUnit> ToList(this (BaseUnit, BaseUnit, BaseUnit) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3];
        public static List<BaseUnit> ToList(this (BaseUnit, BaseUnit, BaseUnit, BaseUnit) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4];
        public static List<BaseUnit> ToList(this (BaseUnit, BaseUnit, BaseUnit, BaseUnit, BaseUnit) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5];
        public static List<BaseUnit> ToList(this (BaseUnit, BaseUnit, BaseUnit, BaseUnit, BaseUnit, BaseUnit) tuple) => [tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6];

    }
}
