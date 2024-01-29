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


        public static DecimalSafe GetValueAs(this BaseUnit From, UnitSystem To)
        {
            if (From.NEWValue.IsNotAValue())            
                return From.NEWValue;
            


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
            return (double)From.GetValueAs(To);
        }

        public static string DisplaySymbol(this BaseUnit From)
        {
            return From.Unit.ReduceUnits().ToString();
        }

        internal static decimal GetBaseValue(this BaseUnit From)
        {
            if (From.Unit.IsSIUnit())
                return From.NEWValue;

            return (decimal)(From.Unit.SumConstant() * (Fraction)From.NEWValue);
        }

       
        /// <summary>
        /// Converts the value of the <paramref name="From"/> BaseUnit to the specified <paramref name="UnitSystem"/>.
        /// </summary>
        /// <param name="From">The source BaseUnit.</param>
        /// <param name="b">The target UnitSystem.</param>
        /// <returns>The converted value as a double.</returns>
        public static double As(this BaseUnit From, UnitSystem b)
        {
            return From.GetValueAsDouble(b);
        }



        /// <summary>
        /// Converts the <paramref name="From"/> Unit to specified <paramref name="UnitSystem"/>.
        /// </summary>
        /// <param name="From">The source BaseUnit.</param>
        /// <param name="selectedUnit">The target UnitSystem.</param>
        /// <returns>The orginal unit converted into a new.</returns>
        public static UnknownUnit ToUnit(this BaseUnit From, UnitSystem selectedUnit)
        {
            GuardAgainst.DifferentUnits(From, selectedUnit);

            return new UnknownUnit(From.GetValueAs(selectedUnit), selectedUnit);
        }


        /// <summary>
        /// Raises the <paramref name="a"/> BaseUnit to the power of <paramref name="toPower"/>.
        /// </summary>
        /// <param name="a">The source BaseUnit.</param>
        /// <param name="toPower">The power to raise the BaseUnit to.</param>
        /// <returns>The result of raising the BaseUnit to the specified power.</returns>
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

        /// <summary>
        /// Clamps the value of the <paramref name="Clamped"/> between the <paramref name="Lower"/> and <paramref name="Upper"/> limits.
        /// </summary>
        /// <param name="Clamped">The value to be clamped.</param>
        /// <param name="Lower">The lower limit BaseUnit.</param>
        /// <param name="Upper">The upper limit BaseUnit.</param>
        /// <returns>The clamped value between lower and upper limits.</returns>
        public static UnknownUnit Clamp(this BaseUnit Clamped, BaseUnit Lower, BaseUnit Upper)
        {
            if (Clamped is null || Lower is null || Upper is null)
                return null;

            GuardAgainst.DifferentUnits(Clamped, Lower, Upper);


            if (Upper < Lower)
            {
                //TODO you need max to be larger then min
                return Clamped.ToUnknownUnit();
            }


            if (Clamped < Lower)
                return Lower.ToUnknownUnit();


            if (Clamped > Upper)
                return Upper.ToUnknownUnit();


            return Clamped.ToUnknownUnit();
        }

        [Obsolete($"This is changing name to: {nameof(Clamp)} to follow System.Math syntax")]
        public static UnknownUnit InRangeOf(this BaseUnit a, BaseUnit Min, BaseUnit Max) => a.Clamp(Min, Max);



        /// <summary>
        /// Determines whether the specified Unit is equal to zero.
        /// </summary>
        /// <param name="a">The BaseUnit to check.</param>
        /// <returns>True if the BaseUnit is equal to zero; otherwise, false.</returns>
        public static bool IsZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() == 0m;
        }

        /// <summary>
        /// Determines whether the specified Unit is not equal to zero.
        /// </summary>
        /// <param name="a">The BaseUnit to check.</param>
        /// <returns>True if the BaseUnit is not equal to zero; otherwise, false.</returns>
        public static bool IsNotZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return !a.IsZero();
        }

        /// <summary>
        /// Determines whether the specified Unit is above zero.
        /// </summary>
        /// <param name="a">The BaseUnit to check.</param>
        /// <returns>True if the BaseUnit is above zero; otherwise, false.</returns>
        public static bool IsAboveZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() > 0;
        }

        /// <summary>
        /// Determines whether the specified Unit is below zero.
        /// </summary>
        /// <param name="a">The BaseUnit to check.</param>
        /// <returns>True if the BaseUnit is below zero; otherwise, false.</returns>
        public static bool IsBelowZero(this BaseUnit a)
        {
            if (a is null)
                return false;

            return a.GetBaseValue() < 0;
        }

        /// <summary>
        /// Determines whether the specified Unit is NaN.
        /// </summary>
        /// <param name="a">The BaseUnit to check.</param>
        /// <returns>True if the BaseUnit is NaN; otherwise, false.</returns>
        public static bool IsNaN(this BaseUnit a)
        {
            if (a is null)
                return false;

            //return double.IsNaN(a.Value); // TODO: avoid using deprecated .Value here
            //return double.IsNaN(a.GetValueAsDouble(UnitSystemExtensions.UnitsystemForDouble));
            return double.IsNaN(a.As(UnitSystemExtensions.UnitsystemForDouble));
        }



        /// <summary>
        /// Finds the value in the list closest and above to the specified reference value. <br></br>
        /// <example>
        /// <br></br> Simple example: <br></br>
        ///[1,2,4,7].RoundUpToNearest(5) <br></br>
        ///--> returns 7; <br></br>
        /// </example>
        /// </summary> 
        /// <param name="list">The collection of BaseUnits.</param>
        /// <param name="valueToBeRoundedUp">The reference value.</param>
        public static UnknownUnit RoundUpToNearest(this IEnumerable<BaseUnit> list, BaseUnit valueToBeRoundedUp)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderBy(x => x))
            {
                if (valueToBeRoundedUp <= item)
                    return new(item);
            }

            return list.Max().ToUnknownUnit();
        }

        /// <summary>
        /// Finds the value in the list closest and below to the specified reference value. <br></br>
        /// <example>
        /// <br></br> Simple example: <br></br>
        ///[1,2,4,7].RoundDownToNearest(5) <br></br>
        ///--> returns 4; <br></br>
        /// </example>
        /// </summary> 
        /// <param name="list">The collection of BaseUnits.</param>
        /// <param name="valueToBeRoundedDown">The reference value.</param>
        public static UnknownUnit RoundDownToNearest(this IEnumerable<BaseUnit> list, BaseUnit valueToBeRoundedDown)
        {
            if (list is null || !list.Any())
                return null;

            foreach (var item in list.OrderByDescending(x => x))
            {
                if (valueToBeRoundedDown >= item)
                    return new(item);
            }

            return list.Min().ToUnknownUnit();
            //return valueToBeRoundedUp;
        }

        /// <summary>
        /// Finds the value in the list closest to the specified reference value. <br></br>
        /// <example>
        /// <br></br> Simple example: <br></br>
        ///[1,2,4,7].RoundToNearest(5) <br></br>
        ///--> returns 4; <br></br>
        /// </example>
        /// </summary> 
        /// <param name="list">The collection of BaseUnits.</param>
        /// <param name="valueToBeRounded">The reference value.</param>
        public static UnknownUnit RoundToNearest(this IEnumerable<BaseUnit> list, BaseUnit valueToBeRounded)
        {
            //Bedre name FindClosestTo?

            if (list is null || !list.Any())
                return null;

            return new(list.OrderBy(x => (x - valueToBeRounded).Abs()).FirstOrDefault());
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
