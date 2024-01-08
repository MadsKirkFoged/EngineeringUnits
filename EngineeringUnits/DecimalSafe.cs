using Fractions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits;
public record DecimalSafe
{
 
    [JsonProperty]
    internal decimal Value { get; init; }

    [JsonProperty]
    internal bool IsInf { get; init; }

    [JsonProperty]
    internal bool IsNaN { get; init; }

    private DecimalSafe()
    {
    }

    public DecimalSafe(decimal value)
    {
        Value = value;
    }

    public DecimalSafe(double value)
    {
        if (double.IsNaN(value))
        {
            IsNaN = true;
            return;
        }

        if (value.IsValueOverDecimalMax())
        {
            IsInf = true;
            return;
        }

        IsInf = false;
        IsNaN = false;
        Value = (decimal)value;
    }

    public DecimalSafe(int value)
    {
        Value = value;
    }

    //public static DecimalSafe operator /(DecimalSafe left, DecimalSafe right)
    //{
    //    return new DecimalSafe(left.Value / right.Value);
    //}

    public static implicit operator DecimalSafe(decimal value) => new DecimalSafe(value);
    public static implicit operator DecimalSafe(double value) => new DecimalSafe(value);
    public static implicit operator DecimalSafe(int value) => new DecimalSafe(value);


    public static implicit operator decimal(DecimalSafe value) => value.Value;

    public static explicit operator double(DecimalSafe value)
    {
        if (value.IsInf)
            return double.PositiveInfinity;

        if (value.IsNaN)
            return double.NaN;

        return (double)value.Value;
    }


    public static explicit operator int(DecimalSafe value) => (int)value.Value;

    public static explicit operator Fraction(DecimalSafe value) => (Fraction)value.Value;


    public override string ToString()
    {
        if (IsInf)
            return double.PositiveInfinity.ToString();

        if (IsNaN)
            return double.NaN.ToString();


        return Value.ToString();
    }

    public string ToString(string format)
    {
        if (IsInf)
            return double.PositiveInfinity.ToString(format);

        if (IsNaN)
            return double.NaN.ToString(format);


        return Value.ToString(format);
    }

    public string ToString(IFormatProvider provider)
    {
        if (IsInf)
            return double.PositiveInfinity.ToString(provider);

        if (IsNaN)
            return double.NaN.ToString(provider);

        return Value.ToString(provider);
    }

    public string ToString(string format, IFormatProvider provider)
    {
        if (IsInf)
            return double.PositiveInfinity.ToString(format, provider);

        if (IsNaN)
            return double.NaN.ToString(format, provider);

        return Value.ToString(format, provider);
    }

    public bool IsZero()
    {
        if (IsNaN || IsInf)
            return false;

        return Value is 0m;
    }

    public bool IsAValue()
    {
        if (IsNaN || IsInf)
            return false;


        return true;
    }

    public bool IsNotAValue()
    {
        return !IsAValue();
    }

}
