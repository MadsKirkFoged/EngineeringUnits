using EngineeringUnits.Units;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

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
        public static UnknownUnit Sqrt(this UnknownUnit a)
        {
            if (a is null)
                return null;

            UnitSystem NewUnitSystem = a.Unit.ReduceUnitsHard();
            var value = a.BaseUnit.GetValueAs(NewUnitSystem);

            return new UnknownUnit(value.Sqrt(), NewUnitSystem.Sqrt());
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
            var value = a.GetValueAs(NewUnitSystem);

            return new UnknownUnit(value.Sqrt(), NewUnitSystem.Sqrt());
        }

        /// <summary>
        /// Obs: You are only using this, if you are creating new mathematical operations!<br></br>
        /// <example>
        /// After doing mathematical operations, the <see langword="List"/> inside <see cref="UnitSystem"/> might contain multiply of the same <see cref="RawUnit"/><br></br>
        /// Example: If the <see langword="List"/> contains two <see cref="RawUnit"/> of 'Meter'. This will merge it into one and increase the Count to 2.
        /// </example>
        /// </summary>
        /// <returns>A <see cref="UnitSystem"/> that is cleaned up without any lose of information</returns>
        /// <param name="a">Source value</param>
        public static UnitSystem ReduceUnits(this UnitSystem a)
        {

            var NewUnitList = a.ListOfUnits.ReduceUnits();


            return new(NewUnitList.ToList(), a.Symbol);
        }

        public static List<RawUnit> ReduceUnits2(this List<RawUnit> a)
        {
            var test = a.GroupBy(x => x.UnitType);

            var NewUnitList = new List<RawUnit>();

            foreach (var GroupOfTypes in test)
            {

                if (GroupOfTypes.Count() <= 1)
                {
                    //just add the unit
                    NewUnitList.Add(GroupOfTypes.First());
                }
                else
                {

                    var groupOfSameConstant = GroupOfTypes
                        .Select(x => x)
                        .GroupBy(x => x.A);


                    foreach (var item in groupOfSameConstant)
                    {

                        var NewCount = item.Sum(x => x.Count);

                        RawUnit NewUnit = item.First().CloneWithNewCount(NewCount);

                        NewUnitList.Add(NewUnit);

                    }
                }

            }

            return NewUnitList;
        }

        public static IEnumerable<RawUnit> ReduceUnits(this IEnumerable<RawUnit> a)
        {
            return a.GroupBy(x => new { x.UnitType, x.A })
                              .Select(group => group.First()
                                                    .CloneWithNewCount(group.Sum(x => x.Count)));

        }

        public static IEnumerable<T> SelectIfMultiple<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
        {
            return source
                .GroupBy(keySelector)
                .Where(group => group.Count() > 1)
                .SelectMany(group => group);
        }


        /// <summary>
        /// Obs: You are only using this, if you are creating new mathematical operations!<br></br>
        /// For now this is only used when taking the square root!
        /// <example>
        /// After doing mathematical operations, the <see langword="List"/> inside <see cref="UnitSystem"/> might contain multiply of the same <see cref="RawUnit"/><br></br>
        /// Example: If the <see langword="List"/> contains two <see cref="RawUnit"/> One of 'Meter' and One of 'Foot'. This will merge it into one and increase the Count to 2.
        /// </example>
        /// </summary>
        /// <returns>A <see cref="UnitSystem"/> that is cleaned up. Beware this can lose information</returns>
        /// <param name="a">Source value</param>
        public static UnitSystem ReduceUnitsHard(this UnitSystem a)
        {

            //This reduces units of the same baseunit-type but with different types 

            var test = a.ListOfUnits.GroupBy(x => x.UnitType);

            var NewUnitList = new List<RawUnit>();

            foreach (var GroupOfTypes in test)
            {

                if (GroupOfTypes.Count() <= 1)
                {
                    //just add the unit
                    NewUnitList.Add(GroupOfTypes.First());
                }
                else
                {
                    var TotalCount = GroupOfTypes.Aggregate(0, (a, b) => a + b.Count);
                    NewUnitList.Add(GroupOfTypes.First().CloneWithNewCount(TotalCount));

                }

            }

            return new(NewUnitList);
        }

        //public static decimal Normalize(this decimal value)
        //{
        //    return value / 1.000000000000000000000000000000000m;
        //}


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


        /// <returns>Absolute value of your unit</returns>
        /// <param name="a">Source value</param>
        public static UnknownUnit Abs(this BaseUnit a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return a;

            return a * -1;

        }

        /// <returns>Absolute value of your unit</returns>
        /// <param name="a">Source value</param>
        public static UnknownUnit Abs(this UnknownUnit a)
        {
            if (a is null)
                return null;

            return a.BaseUnit.Abs();
        }

        /// <returns>Absolute value of your units inside the <see langword="List"/> </returns>
        /// <param name="a">Source value</param>
        public static IEnumerable<UnknownUnit> Abs(this IEnumerable<BaseUnit> a)
        {
            return a.Select(x=> x.Abs());
        }

        /// <returns>Absolute value of your units inside the <see langword="List"/> </returns>
        /// <param name="a">Source value</param>
        public static IEnumerable<UnknownUnit> Abs(this IEnumerable<UnknownUnit> a)
        {
            return a.Select(x => x.Abs());
        }


        public static UnknownUnit ToUnit(this BaseUnit a, UnitSystem selectedUnit)
        {
            GuardAgainst.DifferentUnits(a, selectedUnit);

            return new(a.GetValueAs(selectedUnit), selectedUnit);
        }
        public static UnknownUnit ToUnit(this UnknownUnit a, UnitSystem selectedUnit)
        {
            GuardAgainst.DifferentUnits(a, selectedUnit);

            return new(a.BaseUnit.GetValueAs(selectedUnit), selectedUnit);
        }

        public static UnknownUnit Pow(this BaseUnit a, int toPower)
        {
            if (a is null)
                return null;

            return toPower switch
            {
                0 => 1,
                1 => a,
                > 1 => a.Pow(toPower - 1) * a,
                < 0 => a.Pow(toPower + 1) / a
            };

        }

        public static UnitSystem Pow(this UnitSystem a, int toPower)
        {
            return toPower switch
            {
                0 => new UnitSystem(),
                1 => a,
                > 1 => a.Pow(toPower - 1) * a,
                < 0 => a.Pow(toPower + 1) / a
            };

        }

        public static UnknownUnit Pow(this UnknownUnit a, int toPower)
        {
            if (a is null)
                return null;

            return a.BaseUnit.Pow(toPower);
        }
        public static UnitSystem Pow(this UnitTypebase a, int toPower)
        {
            return a.Unit.Pow(toPower);
        }


 
        public static UnknownUnit Clamp(this BaseUnit Clamped, UnknownUnit Lower, UnknownUnit Upper)
        {
            if (Clamped is null || Lower is null || Upper is null)
                return null;

            GuardAgainst.DifferentUnits(Clamped, Lower, Upper);


            if (Upper < Lower)
            {
                //TODO you need max to be larger then min
                return Clamped;
            }


            if (Clamped < Lower)
                return Lower;


            if (Clamped > Upper)
                return Upper;


            return Clamped;


        }


        public static UnknownUnit Clamp(this UnknownUnit Clamped, UnknownUnit Lower, UnknownUnit Upper) => Clamped.BaseUnit.Clamp(Lower, Upper);




        [Obsolete($"This is changing name to: {nameof(Clamp)} to follow System.Math syntax")]
        public static UnknownUnit InRangeOf(this BaseUnit a, UnknownUnit Min, UnknownUnit Max) => a.Clamp(Min, Max);

        [Obsolete($"This is changing name to: {nameof(Clamp)} to follow System.Math syntax")]
        public static UnknownUnit InRangeOf(this UnknownUnit a, UnknownUnit Min, UnknownUnit Max) => a.Clamp(Min, Max);
 

        public static bool IsZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() == 0m;
        }
        public static bool IsZero(this UnknownUnit a)
        {
            if (a is null)
                return false;

            return a.BaseUnit.IsZero();
        }

        public static bool IsNotZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return !a.IsZero();
        }
        public static bool IsNotZero(this UnknownUnit a)
        {
            if (a is null)
                return false;

            return a.BaseUnit.IsNotZero();
        }

        public static bool IsAboveZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() > 0;
        }
        public static bool IsAboveZero(this UnknownUnit a)
        {
            if (a is null)
                return false;

            return a.BaseUnit.IsAboveZero();
        }

        public static bool IsBelowZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() < 0;
        }
        public static bool IsBelowZero(this UnknownUnit a)
        {
            if (a is null)
                return false;

            return a.BaseUnit.IsBelowZero();
        }


        public static UnknownUnit Sum(this IEnumerable<BaseUnit> list)
        {
            if (list is null || !list.Any())
                return null;

             return list.Aggregate(new UnknownUnit(0m, list.First()),
                                 (x, y) => x + y);
        }
        public static UnknownUnit Sum(this IEnumerable<UnknownUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return list.Aggregate(new UnknownUnit(0m, list.First().BaseUnit.Unit),
                                 (x, y) => x + y);
        }

        public static UnknownUnit Average(this IEnumerable<BaseUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return list.Sum() / list.Count();
        }
        public static UnknownUnit Average(this IEnumerable<UnknownUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return list.Sum() / list.Count();
        }


        public static UnknownUnit Mean(this IEnumerable<UnknownUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return list.OrderBy(x => x)
                       .ToList()[list.Count() / 2];
        }

        public static UnknownUnit Mean(this IEnumerable<BaseUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return list.OrderBy(x => x)
                       .ToList()
                        [list.Count() / 2];
        }


        public static UnknownUnit RoundUpToNearest(this IEnumerable<UnknownUnit> list, UnknownUnit valueToBeRoundedUp)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderBy(x => x))
            {
                if (valueToBeRoundedUp <= item)                
                    return item;                
            }

            return list.Max();
            //return valueToBeRoundedUp;
        }
        public static UnknownUnit RoundUpToNearest(this IEnumerable<BaseUnit> list, UnknownUnit valueToBeRoundedUp)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderBy(x => x))
            {
                if (valueToBeRoundedUp <= item)                
                    return item;                
            }

            return list.Max();
            //return valueToBeRoundedUp;
        }

        public static UnknownUnit RoundDownToNearest(this IEnumerable<UnknownUnit> list, UnknownUnit valueToBeRoundedDown)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderByDescending(x => x))
            {
                if (valueToBeRoundedDown >= item)
                    return item;
            }

            return list.Min();
            //return valueToBeRoundedUp;
        }
        public static UnknownUnit RoundDownToNearest(this IEnumerable<BaseUnit> list, UnknownUnit valueToBeRoundedDown)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderByDescending(x => x))
            {
                if (valueToBeRoundedDown >= item)
                    return item;
            }

            return list.Min();
            //return valueToBeRoundedUp;
        }

        public static UnknownUnit RoundToNearest(this IEnumerable<BaseUnit> list, UnknownUnit valueToBeRoundedDown)
        {
            if (list is null || !list.Any())
                return null;

            return list.OrderBy(x => (x - valueToBeRoundedDown).Abs()).FirstOrDefault();
        }

        //public static void ShouldHaveSameUnits(UnitSystem a, UnitSystem b)
        //{
        //    if (a != b)
        //        throw new WrongUnitException($"This is NOT a [{b}] as expected! Your Unit is a [{a}]");
        //}

        //public static void ShouldHaveSameUnits(UnitSystem a, UnitSystem b, UnitSystem c)
        //{
        //    ShouldHaveSameUnits(a, b);
        //    ShouldHaveSameUnits(a, c);
        //}


        //public static void UnitCheck(this IUnitSystem a, IUnitSystem b)
        //{
        //    if (a.Unit != b.Unit)
        //        throw new WrongUnitException($"This is NOT a [{b.Unit}] as expected! Your Unit is a [{a.Unit}]");
        //}

        //public static void UnitCheck(this UnitSystem a, UnitSystem b)
        //{
        //    if (a != b)
        //        throw new WrongUnitException($"This is NOT a [{b}] as expected! Your Unit is a [{a}]");
        //}

        //public static void UnitCheck(this BaseUnit a, UnitSystem b)
        //{
        //    if (a.Unit != b)
        //        throw new WrongUnitException($"This is NOT a [{b}] as expected! Your Unit is a [{a.Unit}]");
        //}


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

        //[Obsolete("Method1 is deprecated, please use Method2 instead.")]
        public static UnknownUnit Minimum(this UnknownUnit unit, UnknownUnit minimum)
        {
            if (unit is null || minimum is null)
                return null;

            if (unit > minimum)            
                return unit;

            return minimum;
        }

        public static UnknownUnit Minimum(this BaseUnit unit, UnknownUnit minimum)
        {
            if (unit is null || minimum is null)
                return null;

            if (unit > minimum)
                return unit;

            return minimum;
        }

        public static UnknownUnit Maximum(this UnknownUnit unit, UnknownUnit maximum)
        {
            if (unit is null || maximum is null)
                return null;

            if (unit < maximum)
                return unit;

            return maximum;
        }

        public static UnknownUnit Maximum(this BaseUnit unit, UnknownUnit maximum)
        {
            if (unit is null || maximum is null)
                return null;


            if (unit < maximum)
                return unit;

            return maximum;
        }



        //public static UnknownUnit LowerLimit(this UnknownUnit unit, UnknownUnit minimum)
        //{
        //    if (unit is null || minimum is null)
        //        return null;

        //    if (unit > minimum)
        //        return unit;

        //    return minimum;
        //}

        //public static UnknownUnit LowerLimit(this BaseUnit unit, UnknownUnit minimum)
        //{
        //    return ((UnknownUnit)unit).LowerLimit(minimum);
        //}

        //public static UnknownUnit LowerLimit(this UnknownUnit unit, BaseUnit minimum)
        //{
        //    return unit.LowerLimit((UnknownUnit)minimum);
        //}

        //public static UnknownUnit LowerLimit(this BaseUnit unit, BaseUnit minimum)
        //{
        //    return ((UnknownUnit)unit).LowerLimit((UnknownUnit)minimum);
        //}


    }
}
