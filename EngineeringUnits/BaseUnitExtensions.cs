using Fractions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace EngineeringUnits;

public static class BaseUnitExtensions
{
    internal static DecimalSafe ConvertValueInto(this BaseUnit To, BaseUnit From)
    {
        Fraction Factor = From.Unit.ConvertionFactor(To.Unit);

        return (DecimalSafe)(Factor * (Fraction)To.NEWValue);
    }

    public static DecimalSafe GetValueAs2(this BaseUnit From, UnitSystem To)
    {
        if (From.NEWValue.IsNotAValue())
            return From.NEWValue;

        Fraction b1 = To.SumOfBConstants();
        Fraction b2 = From.Unit.SumOfBConstants();

        Fraction y2test2;

        if (b1.IsZero && b2.IsZero)
        {
            Fraction Factor = To.ConvertionFactor(From.Unit);
            y2test2 = Factor * (Fraction)From.NEWValue;
        }
        else
        {

            b1 = To.SumOfBConstants();
            b2 = From.Unit.SumOfBConstants();

            Fraction a2 = From.Unit.SumConstant();
            var x2 = (Fraction)From.NEWValue;

            Fraction a1 = To.SumConstant();

            y2test2 = ((a2*x2) + b2-b1)/a1;

        }

        return (DecimalSafe)y2test2;
    }

    public static Fraction GetValueAs(this BaseUnit From, UnitSystem To)
    {



        Fraction b1 = To.SumOfBConstants();
        Fraction b2 = From.Unit.SumOfBConstants();

        Fraction y2test2;

        if (b1.IsZero && b2.IsZero)
        {
            Fraction Factor = To.ConvertionFactor(From.Unit);
            if (From.testValue is null)
            {
                y2test2 = Factor * (Fraction)From.NEWValue;
            }
            else
            {
                y2test2 = Factor * (Fraction)From.testValue;
            }
        }
        else
        {

            b1 = To.SumOfBConstants();
            b2 = From.Unit.SumOfBConstants();

            Fraction a2 = From.Unit.SumConstant();
            Fraction x2;

            if (From.testValue is not null)
            {
                x2 = (Fraction)From.testValue;
            }
            else
            {
                x2 = (Fraction)From.NEWValue;
            }

            Fraction a1 = To.SumConstant();

            y2test2 = ((a2 * x2) + b2 - b1) / a1;

        }

        return y2test2;
    }

    public static double GetValueAsDouble(this BaseUnit From, UnitSystem To) => (double)From.GetValueAs2(To);

    public static string DisplaySymbol(this BaseUnit From) => From.Unit.ReduceUnits().ToString();

    internal static DecimalSafe GetBaseValue(this BaseUnit From)
    {
        if (From.Unit.IsSIUnit())
            return From.NEWValue;

        return (DecimalSafe)((From.Unit.SumConstant() * (Fraction)From.NEWValue) + From.Unit.SumOfBConstants());
    }

    /// <summary>
    /// Converts the value of the <paramref name="From"/> BaseUnit to the specified <paramref name="UnitSystem"/>.
    /// </summary>
    /// <param name="From">The source BaseUnit.</param>
    /// <param name="b">The target UnitSystem.</param>
    /// <returns>The converted value as a double.</returns>
    public static double As(this BaseUnit From, UnitSystem b) => From.GetValueAsDouble(b);

    /// <summary>
    /// Converts the <paramref name="From"/> Unit to specified <paramref name="UnitSystem"/>.
    /// </summary>
    /// <param name="From">The source BaseUnit.</param>
    /// <param name="selectedUnit">The target UnitSystem.</param>
    /// <returns>The orginal unit converted into a new.</returns>
    [return: NotNullIfNotNull(nameof(From))]
    public static UnknownUnit? ToUnit(this BaseUnit? From, UnitSystem selectedUnit)
    {
        if (From is null)
            return null;

        GuardAgainst.DifferentUnits(From, selectedUnit);

        return new UnknownUnit(From.GetValueAs(selectedUnit), selectedUnit);
    }

    /// <summary>
    /// Raises the <paramref name="a"/> BaseUnit to the power of <paramref name="toPower"/>.
    /// </summary>
    /// <param name="a">The source BaseUnit.</param>
    /// <param name="toPower">The power to raise the BaseUnit to.</param>
    /// <returns>The result of raising the BaseUnit to the specified power.</returns>
    [return: NotNullIfNotNull(nameof(a))]
    public static UnknownUnit? Pow(this BaseUnit? a, int toPower)
    {
        if (a is null)
            return null;

        return toPower switch
        {
            0 => new(1d, new UnitSystem()),
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
    [return: NotNullIfNotNull(nameof(Clamped))]
    public static UnknownUnit? Clamp(this BaseUnit? Clamped, BaseUnit? Lower, BaseUnit? Upper)
    {
        if (Clamped is null)
            return null;

        if (Lower is null && Upper is null)
            return Clamped.ToUnknownUnit();

        GuardAgainst.DifferentUnitsButIgnoreNull(Clamped, Lower, Upper);

        if (Lower is null)
        {
            if (Clamped > Upper)
                return Upper.ToUnknownUnit();

            return Clamped.ToUnknownUnit();
        }

        if (Upper is null)
        {
            if (Clamped < Lower)
                return Lower.ToUnknownUnit();

            return Clamped.ToUnknownUnit();
        }

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
    public static UnknownUnit? InRangeOf(this BaseUnit? a, BaseUnit? Min, BaseUnit? Max) => a.Clamp(Min, Max);

    /// <summary>
    /// Determines whether the specified Unit is equal to zero.
    /// </summary>
    /// <param name="a">The BaseUnit to check.</param>
    /// <returns>True if the BaseUnit is equal to zero; otherwise, false.</returns>
    public static bool IsZero(this BaseUnit? a)
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
    public static bool IsNotZero(this BaseUnit? a)
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
    public static bool IsAboveZero(this BaseUnit? a)
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
    public static bool IsBelowZero(this BaseUnit? a)
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
    public static bool IsNaN(this BaseUnit? a)
    {
        if (a is null)
            return false;

        return a.NEWValue.IsNaN;
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
    public static UnknownUnit? RoundUpToNearest(this IEnumerable<BaseUnit?> list, BaseUnit? valueToBeRoundedUp)
    {
        if (valueToBeRoundedUp is null)
            return null;

        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        if (valueToBeRoundedUp > list.Max())
            return list.Max().ToUnknownUnit();

        return list.Where(x => x >= valueToBeRoundedUp)
                         .OrderBy(x => x)
                         .First()
                         .ToUnknownUnit();
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
    public static UnknownUnit? RoundDownToNearest(this IEnumerable<BaseUnit?> list, BaseUnit? valueToBeRoundedDown)
    {
        if (valueToBeRoundedDown is null)
            return null;

        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        if (valueToBeRoundedDown < list.Min())
            return list.Min().ToUnknownUnit();

        return list.Where(x => x <= valueToBeRoundedDown)
                         .OrderByDescending(x => x)
                         .First()
                         .ToUnknownUnit();
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
    public static UnknownUnit? RoundToNearest(this IEnumerable<BaseUnit> list, BaseUnit? valueToBeRounded)
    {
        if (valueToBeRounded is null)
            return null;

        if (list.Any() is false)
            return null;

        if (list.Any(x => x is null))
            return null;

        if (valueToBeRounded > list.Max())
            return list.Max().ToUnknownUnit();

        if (valueToBeRounded < list.Min())
            return list.Min().ToUnknownUnit();

        BaseUnit? test = list.OrderBy(x => (x - valueToBeRounded).Abs())
                             .First();

        return test.ToUnknownUnit();
    }

    [Obsolete("Name has changed to: LowerLimitAt")]
    public static UnknownUnit? Minimum(this BaseUnit? unit, BaseUnit? minimum) => unit.LowerLimitAt(minimum);
    [Obsolete("Name has changed to: UpperLimitAt")]
    public static UnknownUnit? Maximum(this BaseUnit? unit, BaseUnit? maximum) => unit.UpperLimitAt(maximum);

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
    [return: NotNullIfNotNull(nameof(unit))]
    public static UnknownUnit? UpperLimitAt(this BaseUnit? unit, BaseUnit? limit)
    {
        if (unit is null || limit is null)
            return null;

        if (unit < limit)
            return unit.ToUnknownUnit();

        return limit.ToUnknownUnit();
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

    [return: NotNullIfNotNull(nameof(value))]
    public static UnknownUnit? LowerLimitAt(this BaseUnit? value, BaseUnit? limit)
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
    [return: NotNullIfNotNull(nameof(unit))]
    public static UnknownUnit? ToUnknownUnit(this BaseUnit? unit)
    {
        if (unit is null)
            return null;

        return new(unit);
    }

    /// <summary>
    /// Checks if the Unit has a value.
    /// </summary>
    /// <param name="unit">The Unit to check.</param>
    /// <returns>True if the BaseUnit has a value; false if null, inf or NaN.</returns>
    public static bool HasValue([NotNullWhen(true)] this BaseUnit? unit)
    {
        if (unit is null)
            return false;

        return unit.NEWValue.HasValue();
    }

    /// <summary>
    /// Checks if the Unit has a value.
    /// </summary>
    /// <param name="unit">The Unit to check.</param>
    /// <returns>False if the BaseUnit has a value; True if null, inf or NaN.</returns>
    public static bool HasNoValue([NotNullWhen(false)] this BaseUnit? unit) => !unit.HasValue();


    [return: NotNullIfNotNull(nameof(unit))]
    public static UnknownUnit? ConvertToSI(this BaseUnit? unit)
    {
        if (unit is null)
            return null;

        if (unit.Unit.IsSIUnit())
            return unit.ToUnknownUnit();


        var unitsystem = unit.Unit.GetSIUnitsystem();
        var value = unit.GetBaseValue();


        return new(value, unitsystem);
    }

    /// <summary>
    /// Round a <paramref name="value"/> to the nearest <paramref name="roundVal"/>
    /// </summary>
    /// <param name="value">Value to round</param>
    /// <param name="roundVal"></param>
    [return: NotNullIfNotNull(nameof(value))]
    public static UnknownUnit? RoundTo<T>(this T? value, T? roundVal) where T : BaseUnit
    {
        if (value is null)
            return null;
        if (roundVal is null)
            return new(value);

        return Math.Round((double)(Ratio)(value / roundVal)) * roundVal;
    }

    /// <summary>
    /// Round a <paramref name="value"/> up to the nearest <paramref name="roundVal"/>
    /// </summary>
    /// <param name="value">Value to round</param>
    /// <param name="roundVal"></param>
    [return: NotNullIfNotNull(nameof(value))]
    public static UnknownUnit? CeilingTo<T>(this T? value, T? roundVal) where T : BaseUnit
    {
        if (value is null)
            return null;
        if (roundVal is null)
            return new(value);

        return Math.Ceiling((double)(Ratio)(value / roundVal)) * roundVal;
    }

    /// <summary>
    /// Round a <paramref name="value"/> down to the nearest <paramref name="roundVal"/>
    /// </summary>
    /// <param name="value">Value to round</param>
    /// <param name="roundVal"></param>
    [return: NotNullIfNotNull(nameof(value))]
    public static UnknownUnit? FloorTo<T>(this T? value, T? roundVal) where T : BaseUnit
    {
        if (value is null)
            return null;
        if (roundVal is null)
            return new(value);

        return Math.Floor((double)(Ratio)(value / roundVal)) * roundVal;
    }



    public static BaseUnit TryCastToKnownUnit(this UnknownUnit local)
    {

        var Hit = local.IntelligentCast();

        if (Hit is null)
        {
            return local;
        }

        return Hit;
    }


}
