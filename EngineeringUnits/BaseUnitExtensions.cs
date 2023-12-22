using Fractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringUnits
{
    public static class BaseUnitExtensions
    {
        public static decimal ConvertValueInto(this BaseUnit To, BaseUnit From)
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

        public static UnknownUnit RoundToNearest(this IEnumerable<BaseUnit> list, BaseUnit valueToBeRoundedDown)
        {
            if (list is null || !list.Any())
                return null;

            return new(list.OrderBy(x => (x - valueToBeRoundedDown).Abs()).FirstOrDefault());
        }

        public static UnknownUnit Minimum(this BaseUnit unit, BaseUnit minimum)
        {
            if (unit is null || minimum is null)
                return null;

            if (unit > minimum)
                return new(unit);

            return new(minimum);
        }

        public static UnknownUnit Maximum(this BaseUnit unit, BaseUnit maximum)
        {
            if (unit is null || maximum is null)
                return null;

            if (unit < maximum)
                return new(unit);

            return new(maximum);
        }

        public static UnknownUnit UpperLimit(this BaseUnit unit, BaseUnit limit)
        {
            if (unit is null || limit is null)
                return null;

            if (unit < limit)
                return new(unit);

            return new(limit);
        }

        public static UnknownUnit ToUnknownUnit(this BaseUnit unit)
        {
            if (unit is null)
                return null;

            return new(unit);
        }

    }
}
