using Fractions;
using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text.Json.Serialization;

namespace EngineeringUnits;

//The baseunit is inherited by all other unit.
//It stores the value and the unitsystem

[JsonObject(MemberSerialization.Fields)]
public class BaseUnit : IEquatable<BaseUnit>, IComparable, IComparable<BaseUnit>, IFormattable
{

    public UnitSystem Unit { get; init; }

    [JsonProperty]
    [JsonInclude]
    internal DecimalSafe NEWValue { get; init; }

    internal Fraction? testValue { get; init; } = null;

    [Obsolete("Use .As() instead - ex myPower.As(PowerUnit.Watt)")]
    public double Value => (double)this.GetBaseValue();

    public BaseUnit()
    {
        Unit = new UnitSystem();
        NEWValue = 0;
    }

    public BaseUnit(Fraction value, UnitSystem unitSystem)
    {
        Unit = unitSystem;
        NEWValue = value;
        testValue = value;
    }

    public BaseUnit(DecimalSafe value, UnitSystem unitSystem)
    {
        Unit = unitSystem;
        NEWValue = value;
    }
    public BaseUnit(decimal value, UnitSystem unitSystem)
    {
        Unit = unitSystem;
        NEWValue = value;
    }
    public BaseUnit(double value, UnitSystem unitSystem)
    {
        Unit = unitSystem;
        NEWValue = value;
    }
    public BaseUnit(int value, UnitSystem unitSystem)
    {
        Unit = unitSystem;
        NEWValue = value;
    }

    public BaseUnit(UnknownUnit value, UnitSystem unitSystem)
    {
        Unit = unitSystem;
        NEWValue = value.NEWValue;
    }

    public BaseUnit(decimal value) : this(value, new UnitSystem()) { }
    public BaseUnit(double value) : this(value, new UnitSystem()) { }
    public BaseUnit(int value) : this(value, new UnitSystem()) { }

    protected BaseUnit(UnknownUnit unit)
    {
        Unit = unit.Unit;
        NEWValue = unit.NEWValue;
    }
    protected BaseUnit(BaseUnit unit)
    {
        Unit = unit.Unit;
        NEWValue = unit.NEWValue;
    }

    [return: NotNullIfNotNull(nameof(left))]
    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator +(BaseUnit? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] + [{right.Unit}]. Can't add two different units!");

        //if (left.IsNaN() || right.IsNaN())
        //    return new UnknownUnit(double.NaN, left.Unit);
        
        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return new UnknownUnit(left.NEWValue + right.NEWValue, left.Unit);


        try
        {

            if (left.Unit.SumOfBConstants() != Fraction.Zero || right.Unit.SumOfBConstants() != Fraction.Zero)
            {

                //Working with B-Constants units does not really make sense to show as unit after a calculation

                //Check if there is a similarly unit but without the B-Constant
                if (right.Unit.SumOfBConstants() == Fraction.Zero)
                {

                    DecimalSafe leftvalue = left.GetValueAs(right);
                    Fraction br = right.Unit.SumOfBConstants() / right.Unit.SumConstant();
                    var valuer = right.NEWValue + leftvalue + br.ToDecimal();
                    return new UnknownUnit(valuer, right.Unit);
                }
                else if (left.Unit.SumOfBConstants() != Fraction.Zero && right.Unit.SumOfBConstants() != Fraction.Zero)
                {
                    UnitSystem NewUnit = left.Unit.GetWithOutOffset();
                    DecimalSafe NewValue = left.GetValueAs(NewUnit);
                    left = new UnknownUnit(NewValue, NewUnit);
                }

                DecimalSafe rightvalue = right.GetValueAs(left);
                Fraction b = left.Unit.SumOfBConstants() / left.Unit.SumConstant();
                var value = left.NEWValue + rightvalue + b.ToDecimal();
                return new UnknownUnit(value, left.Unit);

            }



            return new UnknownUnit(left.NEWValue + right.ConvertValueInto(left), left.Unit);
        }
        catch (OverflowException)
        {
            return new UnknownUnit(double.PositiveInfinity, left.Unit + right.Unit);
        }
    }

    [return: NotNullIfNotNull(nameof(local))]
    public static UnknownUnit operator +(BaseUnit local)
    {
        return new(local);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator +(int? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((double)left) + right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator +(BaseUnit? left, int? right)
    {
        if (left is null || right is null)
            return null;

        return left + new BaseUnit((int)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator +(double? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((double)left) + right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator +(BaseUnit? left, double? right)
    {
        if (left is null || right is null)
            return null;

        return left + new BaseUnit((double)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator +(decimal? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((decimal)left) + right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator +(BaseUnit? left, decimal? right)
    {
        if (left is null || right is null)
            return null;

        return left + new BaseUnit((decimal)right);
    }

    [return: NotNullIfNotNull(nameof(left))]
    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator -(BaseUnit? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] - [{right.Unit}]. Can't subtract two different units!");
        

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return new UnknownUnit(left.NEWValue - right.NEWValue, left.Unit);

        try
        {
            if (left.Unit.SumOfBConstants() != Fraction.Zero || right.Unit.SumOfBConstants() != Fraction.Zero)
            {

                //Working with B-Constants units does not really make sense to show as unit after a calculation

                //Check if there is a similarly unit but without the B-Constant
                if (right.Unit.SumOfBConstants() == Fraction.Zero)
                {

                    DecimalSafe leftvalue = left.GetValueAs(right);
                    Fraction br = right.Unit.SumOfBConstants() / right.Unit.SumConstant();
                    var valuer = leftvalue - right.NEWValue + br.ToDecimal();
                    return new UnknownUnit(valuer, right.Unit);
                }
                else if (left.Unit.SumOfBConstants() != Fraction.Zero && right.Unit.SumOfBConstants() != Fraction.Zero)
                {
                    UnitSystem NewUnit = left.Unit.GetWithOutOffset();
                    DecimalSafe NewValue = left.GetValueAs(NewUnit);
                    left = new BaseUnit(NewValue, NewUnit);
                }

                DecimalSafe rightvalue = right.GetValueAs(left);
                Fraction b = left.Unit.SumOfBConstants() / left.Unit.SumConstant();
                var value = left.NEWValue - rightvalue + b.ToDecimal();
                return new UnknownUnit(value, left.Unit);

            }



            return new UnknownUnit(left.NEWValue - right.ConvertValueInto(left), left.Unit);

        }
        catch (OverflowException)
        {
            return new UnknownUnit(double.PositiveInfinity, left.Unit - right.Unit);
        }
    }

    [return: NotNullIfNotNull(nameof(local))]
    public static UnknownUnit? operator -(BaseUnit? local)
    {
        if (local is null)
            return null;

        return (local * -1)!;
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator -(int? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((int)left) - right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator -(BaseUnit? left, int? right)
    {
        if (left is null || right is null)
            return null;

        return left - new BaseUnit((int)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator -(double? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((double)left) - right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator -(BaseUnit? left, double? right)
    {
        if (left is null || right is null)
            return null;

        return left - new BaseUnit((double)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator -(decimal? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((decimal)left) - right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator -(BaseUnit? left, decimal? right)
    {
        if (left is null || right is null)
            return null;

        return left - new BaseUnit((decimal)right);
    }

    [return: NotNullIfNotNull(nameof(left))]
    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator *(BaseUnit? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;


        //if (left.IsNaN() || right.IsNaN())
        //    return new UnknownUnit(double.NaN, left.Unit * right.Unit);

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())        
            return new UnknownUnit(left!.NEWValue * right!.NEWValue, left.Unit * right.Unit);
        

            try
        {
            
                if (left.Unit.SumOfBConstants() != Fraction.Zero || right.Unit.SumOfBConstants() != Fraction.Zero)
            {
                //Showing a unit like °C as °C^2 is not very useful (As I understand the conversion between °k^2 and °C^2 is not linear)
                //Therefore we will convert these units to their base unit

                if (left.Unit.SumOfBConstants() != Fraction.Zero)
                {
                    //Set value to the base unit
                    var LeftValue = left.GetBaseValue();

                    //Set unit to the base unit
                    UnitSystem Leftunit = left.Unit.GetSIUnitsystem();

                    left= new UnknownUnit(LeftValue, Leftunit).IntelligentCast();
                }

                if (right.Unit.SumOfBConstants() != Fraction.Zero)
                {
                    //Set value to the base unit
                    var rightValue = right.GetBaseValue();

                    //Set unit to the base unit
                    UnitSystem rightunit = right.Unit.GetSIUnitsystem();

                    right= new UnknownUnit(rightValue, rightunit).IntelligentCast();
                }

                //return new UnknownUnit(left.NEWValue * right.NEWValue, left.Unit * right.Unit);
            }

            return new UnknownUnit(left!.NEWValue * right!.NEWValue, left.Unit * right.Unit);
        }
        catch (OverflowException)
        {
            return new UnknownUnit(double.PositiveInfinity, left!.Unit * right!.Unit);
        }
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator *(BaseUnit? left, int? right)
    {
        if (left is null || right is null)
            return null;

        return (left * new BaseUnit((int)right))!;
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator *(int? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((int)left) * right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator *(BaseUnit? left, double? right)
    {
        if (left is null || right is null)
            return null;

        return left * new BaseUnit((double)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator *(double? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((double)left) * right;
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator *(decimal? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((decimal)left) * right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator *(BaseUnit? left, decimal? right)
    {
        if (left is null || right is null)
            return null;

        return left * new BaseUnit((decimal)right);
    }


    //public static UnknownUnit? operator /(BaseUnit? left, Ratio? right)
    //{ 
    //    return left / (decimal)right;
    //}

    [return: NotNullIfNotNull(nameof(left))]
    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator /(BaseUnit? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        //if (left.IsNaN() || right.IsNaN())
        //    return new UnknownUnit(double.NaN, left.Unit / right.Unit);
        
        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())        
            return new UnknownUnit(left!.NEWValue / right!.NEWValue, left.Unit / right.Unit);
                

        try
        {
            if (left.Unit.SumOfBConstants() != Fraction.Zero || right.Unit.SumOfBConstants() != Fraction.Zero)
            {
                //Showing a unit like °C as °C^2 is not very useful (As I understand the conversion between °k^2 and °C^2 is not linear)
                //Therefore we will convert these units to their base unit

                if (left.Unit.SumOfBConstants() != Fraction.Zero)
                {
                    //Set value to the base unit
                    var LeftValue = left.GetBaseValue();

                    //Set unit to the base unit
                    UnitSystem Leftunit = left.Unit.GetSIUnitsystem();

                    left= new UnknownUnit(LeftValue, Leftunit).IntelligentCast();
                }

                if (right.Unit.SumOfBConstants() != Fraction.Zero)
                {
                    //Set value to the base unit
                    var rightValue = right.GetBaseValue();

                    //Set unit to the base unit
                    UnitSystem rightunit = right.Unit.GetSIUnitsystem();

                    right= new UnknownUnit(rightValue, rightunit).IntelligentCast();
                }
            }

            return new UnknownUnit(left!.NEWValue / right!.NEWValue, left.Unit / right.Unit);
        }
        catch (OverflowException)
        {
            return new UnknownUnit(double.PositiveInfinity, left!.Unit / right!.Unit);
        }
        catch (DivideByZeroException)
        {
            return new UnknownUnit(double.PositiveInfinity, left!.Unit / right!.Unit);
        }
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator /(BaseUnit? left, int? right)
    {
        if (left is null || right is null)
            return null;

        return left / new BaseUnit((int)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator /(int? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((int)left) / right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator /(BaseUnit? left, double? right)
    {
        if (left is null || right is null)
            return null;

        return left / new BaseUnit((double)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator /(double? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((double)left) / right;
    }

    [return: NotNullIfNotNull(nameof(left))]
    public static UnknownUnit? operator /(BaseUnit? left, decimal? right)
    {
        if (left is null || right is null)
            return null;

        return left / new BaseUnit((decimal)right);
    }

    [return: NotNullIfNotNull(nameof(right))]
    public static UnknownUnit? operator /(decimal? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return null;

        return new BaseUnit((decimal)left) / right;
    }

    public static bool operator ==(BaseUnit? left, BaseUnit? right)
    {
        if (left is null && right is null)
            return true;
        if (left is null || right is null)
            return false;

        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] == [{right.Unit}]. Can't compare two different units!");

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return left.NEWValue == right.NEWValue;

        return left.NEWValue == right.GetValueAs(left.Unit);
    }
    public static bool operator !=(BaseUnit? left, BaseUnit? right)
    {
        if (left is null && right is null)
            return false;
        if (left is null || right is null)
            return true;

        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] != [{right.Unit}]. Can't compare two different units!");

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return left.NEWValue != right.NEWValue;

        return left.NEWValue != right.GetValueAs(left.Unit);
    }
    public static bool operator <=(BaseUnit? left, BaseUnit? right)
    {
        if (left is null && right is null)
            return true;
        if (left is null || right is null)
            return false;

        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] <= [{right.Unit}]. Can't compare two different units!");

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return left.NEWValue <= right.NEWValue;

        return left.NEWValue <= right.GetValueAs(left.Unit);
    }
    public static bool operator >=(BaseUnit? left, BaseUnit? right)
    {
        if (left is null && right is null)
            return true;
        if (left is null || right is null)
            return false;

        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] >= [{right.Unit}]. Can't compare two different units!");

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return left.NEWValue >= right.NEWValue;

        return left.NEWValue >= right.GetValueAs(left.Unit);
    }
    public static bool operator <(BaseUnit? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return false;

        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] < [{right.Unit}]. Can't compare two different units!");

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return left.NEWValue < right.NEWValue;

        return left.NEWValue < right.GetValueAs(left.Unit);
    }
    public static bool operator >(BaseUnit? left, BaseUnit? right)
    {
        if (left is null || right is null)
            return false;


        if (left.Unit != right.Unit)
            throw new WrongUnitException($"Trying to do [{left.Unit}] > [{right.Unit}]. Can't compare two different units!");

        if (left.Unit.IsSIUnit() && right.Unit.IsSIUnit())
            return left.NEWValue > right.NEWValue;

        return left.NEWValue > right.GetValueAs(left.Unit);
    }

    [return: NotNullIfNotNull(nameof(unit))]
    public static implicit operator UnitSystem?(BaseUnit? unit)
    {
        if (unit is null)
            return null;

        return unit.Unit;
    }

    //public static implicit operator int(BaseUnit Unit)
    //{
    //    if (UnitSystemExtensions.UnitsystemForDouble != Unit)
    //        throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");

    //    return (int)Unit.GetValueAs(UnitSystemExtensions.UnitsystemForDouble);
    //}
    //public static implicit operator double(BaseUnit Unit)
    //{
    //    if (UnitSystemExtensions.UnitsystemForDouble != Unit)
    //        throw new WrongUnitException($"This is NOT a double [-] as expected! Your Unit is a [{Unit.Unit}] ");

    //    return Unit.GetValueAsDouble(UnitSystemExtensions.UnitsystemForDouble);
    //}
    //public static implicit operator decimal(BaseUnit Unit)
    //{
    //    if (new UnitSystem() != Unit.Unit)
    //        throw new WrongUnitException($"This is NOT a decimal [-] as expected! Your Unit is a [{Unit.Unit}] ");

    //    return Unit.GetValueAs(new UnitSystem());
    //}

    /// <summary>
    ///     Gets the default string representation of value and unit.
    /// </summary>
    /// <returns>String representation.</returns>
    public override string ToString() => ToString("g4");

    /// <summary>
    ///     Gets the default string representation of value and unit using the given format provider.
    /// </summary>
    /// <returns>String representation.</returns>
    /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.InvariantCulture" /> if null.</param>
    public virtual string ToString(IFormatProvider provider) => ToString("g4", provider);

    /// <summary>
    /// Gets the string representation of this instance in the specified format string using <see cref="CultureInfo.InvariantCulture" />.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <returns>The string representation.</returns>
    public virtual string ToString(string format) => ToString(format, CultureInfo.InvariantCulture);

    /// <summary>
    /// Gets the string representation of this instance in the specified format string using the specified format provider, or <see cref="CultureInfo.CurrentUICulture" /> if null.
    /// </summary>
    /// <param name="format">The format string.</param>
    /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="CultureInfo.CurrentUICulture" /> if null.</param>
    /// <returns>The string representation.</returns>
    public virtual string ToString(string? format, IFormatProvider? provider)
    {

        if (format is null)
            format = "g4";

        if (provider is null)
            provider = CultureInfo.InvariantCulture;

        string FormatUnit = "C";
        if (format.ToLower().EndsWith("p"))
        {
            format = format.TrimEnd('p').TrimEnd('p');
            FormatUnit = "P";
        }

        if (format is "")
            format = "g4";

        DecimalSafe NewNEWValue = NEWValue;

        //Convert unit to string
        var GetUnit = Unit.Symbol;

        if (GetUnit is null)
            GetUnit = GetStandardSymbol(Unit, FormatUnit);

        // If GetUnit is still null it could not find a standard symbol
        // --> convert it to SI
        if (GetUnit is null)
        {
            UnitSystem NewUnit = Unit.GetSIUnitsystem();
            NewNEWValue = this.GetValueAs(NewUnit);
            GetUnit = GetStandardSymbol(NewUnit, FormatUnit);
        }

        //Convert value to string
        var value = format[0] switch
        {
            'A'or'a' => "",
            'U'or'u' => "",
            'Q'or'q' => "",
            'V'or'v' => NewNEWValue.DisplaySignificantDigits(int.Parse(format.Remove(0, 1))),
            'S'or's' => NewNEWValue.DisplaySignificantDigits(int.Parse(format.Remove(0, 1))),
            _ => NewNEWValue.ToString(format, provider),
        };

        var unit = format[0] switch
        {
            'A'or'a' => GetUnit,
            'U'or'u' => GetUnit,
            'Q'or'q' => GetUnit,
            'V'or'v' => "",
            _ => $" {GetUnit}",
        };

        //Merge       
        return $"{value}{unit}".Trim();
    }

    public override int GetHashCode()
    {
        HashCode hashCode = new();
        hashCode.Add(NEWValue);
        hashCode.Add(Unit.GetHashCode());

        return hashCode.ToHashCode();
    }

    public static string? GetStandardSymbol<T>(UnitSystem _unit, string? format = null )
        where T : UnitTypebase
    {
        //This check the list of Predefined unit and if it finds a match it returns that Symbol
        return UnitTypebase.ListOf<T>()
            .Find(x => x.Unit.SumConstant() == _unit.SumConstant() &&
                       x.Unit.SumOfBConstants() == _unit.SumOfBConstants())?
            .Unit.ToString(format, null);
    }
    public virtual string? GetStandardSymbol(UnitSystem _unit) => _unit.ToString("C", null);
    public virtual string? GetStandardSymbol(UnitSystem _unit, string format) => _unit.ToString(format, null);

    public override bool Equals(object? obj)
    {
        //Check for null and compare run-time types.
        if ((obj == null) || !GetType().Equals(obj.GetType()))
            return false;
        else
            return this == (BaseUnit)obj;
    }
    public bool Equals(BaseUnit? other) => this == other;

    public int CompareTo(object? obj)
    {
        var local = (BaseUnit?)obj;

        return CompareTo(local);
    }
    public int CompareTo(BaseUnit? other)
    {
        if (other is null)
            throw new NullReferenceException();

        if (Unit != other.Unit)
            throw new WrongUnitException($"Cant do CompareTo on two differnt units!");

        return (this - other)!.AsSI switch
        {
            0m => 0,
            <0m => -1,
            >0m => 1,
        };
    }

    public decimal AsSI => this.GetBaseValue();

}
