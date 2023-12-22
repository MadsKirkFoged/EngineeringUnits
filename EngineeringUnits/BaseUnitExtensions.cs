using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public static class BaseUnitExtensions
    {
        internal static decimal ConvertValueInto(this BaseUnit To, BaseUnit From)
        {
            Fraction Factor = From.Unit.ConvertionFactor(To.Unit);

            return (decimal)(Factor * (Fraction)To.NEWValue);
        }


        public static decimal GetValueAs(this BaseUnit From, UnitSystem To)
        {
            Fraction b1 = From.Unit.SumOfBConstants();
            Fraction b2 = To.SumOfBConstants();
            Fraction Factor = To.ConvertionFactor(From.Unit);

            Fraction y2test2;

            if (b1.IsZero && b2.IsZero)
            {
                y2test2 = Factor * (Fraction)From.NEWValue;
            }
            else
            {
                Fraction b3test2 = (Factor * (b1 * -1)) + b2;
                y2test2 = (Factor * (Fraction)From.NEWValue) + b3test2;

            } 

            return (decimal)y2test2;
        }

        public static double GetValueAsDouble(this BaseUnit From, UnitSystem To)
        {
            if (From.IsNaN)
                return double.NaN;

            if (From.Inf)
                return double.PositiveInfinity;

            return (double)From.GetValueAs(To);
        }

        public static string DisplaySymbol(this BaseUnit From)
        {
            return From.Unit.ReduceUnits().ToString();
        }

        public static decimal GetBaseValue(this BaseUnit From)
        {
            if (From.Unit.IsSIUnit())
                return From.NEWValue;

            return (decimal)(From.Unit.SumConstant() * (Fraction)From.NEWValue);
        }

        public static double As(this BaseUnit From, UnitSystem b)
        {
            return From.GetValueAsDouble(b);
        }


        /// <returns>Absolute value of your unit</returns>
        /// <param name="a">Source value</param>
        public static UnknownUnit Abs(this BaseUnit a)
        {
            if (a is null)
                return null;

            if (a.GetBaseValue() > 0)
                return new(a);

            return a * -1;

        }

        /// <returns>Absolute value of your units inside the <see langword="List"/> </returns>
        /// <param name="a">Source value</param>
        public static IEnumerable<UnknownUnit> Abs(this IEnumerable<BaseUnit> a)
        {
            return a.Select(x => x.Abs());
        }

        public static UnknownUnit ToUnit(this BaseUnit a, UnitSystem selectedUnit)
        {
            GuardAgainst.DifferentUnits(a, selectedUnit);

            return new(a.GetValueAs(selectedUnit), selectedUnit);
        }


        public static UnknownUnit Pow(this BaseUnit a, int toPower)
        {
            if (a is null)
                return null;

            return toPower switch
            {
                0 => new(1),
                1 => new(a),
                > 1 => a.Pow(toPower - 1) * a,
                < 0 => a.Pow(toPower + 1) / a
            };

        }

        public static UnknownUnit Clamp(this BaseUnit Clamped, BaseUnit Lower, BaseUnit Upper)
        {
            if (Clamped is null || Lower is null || Upper is null)
                return null;

            GuardAgainst.DifferentUnits(Clamped, Lower, Upper);


            if (Upper < Lower)
            {
                //TODO you need max to be larger then min
                return new(Clamped);
            }


            if (Clamped < Lower)
                return new(Lower);


            if (Clamped > Upper)
                return new(Upper);


            return new(Clamped);


        }

        [Obsolete($"This is changing name to: {nameof(Clamp)} to follow System.Math syntax")]
        public static UnknownUnit InRangeOf(this BaseUnit a, BaseUnit Min, BaseUnit Max) => a.Clamp(Min, Max);

        public static bool IsZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() == 0m;
        }

        public static bool IsNotZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return !a.IsZero();
        }

        public static bool IsAboveZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() > 0;
        }

        public static bool IsBelowZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() < 0;
        }

        public static UnknownUnit Sum(this IEnumerable<BaseUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return list.Aggregate(new UnknownUnit(0m, list.First()),
                                (x, y) => x + y);
        }

        public static UnknownUnit Average(this IEnumerable<BaseUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return list.Sum() / list.Count();
        }

        public static UnknownUnit Mean(this IEnumerable<BaseUnit> list)
        {
            if (list is null || !list.Any())
                return null;

            return new(list.OrderBy(x => x)
                       .ToList()
                        [list.Count() / 2]);
        }

        public static UnknownUnit RoundUpToNearest(this IEnumerable<BaseUnit> list, BaseUnit valueToBeRoundedUp)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderBy(x => x))
            {
                if (valueToBeRoundedUp <= item)
                    return new(item);
            }

            return new(list.Max());
            //return valueToBeRoundedUp;
        }

        public static UnknownUnit RoundDownToNearest(this IEnumerable<BaseUnit> list, BaseUnit valueToBeRoundedDown)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderByDescending(x => x))
            {
                if (valueToBeRoundedDown >= item)
                    return new(item);
            }

            return new(list.Min());
            //return valueToBeRoundedUp;
        }

        /// <summary>
        /// Rounds a collection of values to the nearest value, based on a specified reference value.
        /// </summary>
        /// <remarks>
        /// The method calculates the absolute difference between each element in the collection and the specified
        /// reference value, then rounds to the nearest value. The result is the element in the collection that is
        /// closest to the reference value.
        /// </remarks>
        /// <param name="list">The collection of BaseUnits to be rounded.</param>
        /// <param name="valueToBeRoundedDown">The reference value to which elements are rounded.</param>
        /// <returns>
        /// The BaseUnit in the collection that is closest to the specified reference value when rounded to the nearest value.
        /// Returns null if the input collection is null or empty.
        /// </returns>
        public static UnknownUnit RoundToNearest(this IEnumerable<BaseUnit> list, BaseUnit valueToBeRoundedDown)
        {
            //Bedre name FindClosestTo?

            if (list is null || !list.Any())
                return null;

            return new(list.OrderBy(x => (x - valueToBeRoundedDown).Abs()).FirstOrDefault());
        }
        
        [Obsolete("Name has changed to: LowerLimitAt")]
        public static UnknownUnit Minimum(this BaseUnit unit, BaseUnit minimum)
        {
            return unit.LowerLimitAt(minimum);
        }
        [Obsolete("Name has changed to: UpperLimitAt")]
        public static UnknownUnit Maximum(this BaseUnit unit, BaseUnit maximum)
        {
            return unit.UpperLimitAt(maximum);
        }

        /// <summary>
        /// Set a upper limit on a value/calculation.<br></br>
        /// <example>
        ///var l1 = Length.FromMeter(1); <br></br>
        ///var l2 = Length.FromMeter(1); <br></br>
        ///var l3 = (l1 + l2).UpperLimitAt(Length.FromMeter(1)); <br></br>
        ///Sets result to a maximum value of 1 meters
        /// </example>
        /// </summary>
        /// <param name="value">The source value or calculation result.</param>
        /// <param name="limit">The Upper limit to be applied.</param>
        /// <returns>The lesser of the source value or the specified limit. </returns>
        /// <exception cref="WrongUnitException">Thrown when the unit of value and limit are different</exception>
        public static UnknownUnit UpperLimitAt(this BaseUnit unit, BaseUnit limit)
        {
            if (unit is null || limit is null)
                return null;

            if (unit < limit)
                return new(unit);

            return new(limit);
        }

        /// <summary>
        /// Set a lower limit on a value/calculation.<br></br>
        /// <example>
        ///var l1 = Length.FromMeter(1); <br></br>
        ///var l2 = Length.FromMeter(1); <br></br>
        ///var l3 = (l1 + l2).LowerLimitAt(Length.FromMeter(5)); <br></br>
        ///Sets result to a minimum value of 5 meters
        /// </example>
        /// </summary>
        /// <param name="value">The source value or calculation result.</param>
        /// <param name="limit">The lower limit to be applied.</param>
        /// <returns>The greater of the source value or the specified limit. </returns>
        /// <exception cref="WrongUnitException">Thrown when the unit of value and limit are different</exception>
        public static UnknownUnit LowerLimitAt(this BaseUnit value, BaseUnit limit)
        {
            if (value is null || limit is null)
                return null;

            if (value > limit)
                return value.ToUnknownUnit();

            return limit.ToUnknownUnit();
        }


        /// <summary>
        /// Only use this if you are creating new extension functions!<br></br>
        /// Converting from BaseUnit => UnknownUnit
        /// </summary>
        public static UnknownUnit ToUnknownUnit(this BaseUnit unit)
        {
            if (unit is null)
                return null;

            return new(unit);
        }

    }
}
