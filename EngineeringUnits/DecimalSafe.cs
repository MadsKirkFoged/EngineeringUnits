using Fractions;
using Newtonsoft.Json;
using System;

namespace EngineeringUnits;
public readonly record struct DecimalSafe
{

    [JsonProperty]
    public decimal Value { get; init; }

    [JsonProperty]
    public bool IsInf { get; init; }

    [JsonProperty]
    public bool IsNaN { get; init; }

    public DecimalSafe()
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

    public DecimalSafe(Fraction value)
    {
        try
        {
            Value = (decimal)value;
        }
        catch (OverflowException)
        {
            IsInf = true;
        }
    }

    public static DecimalSafe operator +(DecimalSafe left, DecimalSafe right)
    {
        if (left.IsInf || right.IsInf)        
            return new DecimalSafe() {IsInf = true};

        if (left.IsNaN || right.IsNaN)
            return new DecimalSafe() { IsNaN = true };

        return new DecimalSafe(left.Value + right.Value);
    }

    public static DecimalSafe operator -(DecimalSafe left, DecimalSafe right)
    {
        if (left.IsInf || right.IsInf)
            return new DecimalSafe() { IsInf = true };

        if (left.IsNaN || right.IsNaN)
            return new DecimalSafe() { IsNaN = true };

        return new DecimalSafe(left.Value - right.Value);
    }

    public static DecimalSafe operator *(DecimalSafe left, DecimalSafe right)
    {
        if (left.IsInf || right.IsInf)
            return new DecimalSafe() { IsInf = true };

        if (left.IsNaN || right.IsNaN)
            return new DecimalSafe() { IsNaN = true };

        return new DecimalSafe(left.Value * right.Value);
    }

    public static DecimalSafe operator /(DecimalSafe left, DecimalSafe right)
    {
        // Cover NaN
        if (left.IsNaN || right.IsNaN)
            return new DecimalSafe() { IsNaN = true };

        // Cover all cases with Infinity
        if (left.IsInf)
        {
            // Inf / Inf = NaN
            if (right.IsInf)
                return new DecimalSafe() { IsNaN = true };

            // Inf / n = Inf
            return new DecimalSafe() { IsInf = true };
        }
        else
        {
            // n / Inf = 0
            if (right.IsInf)
                return new DecimalSafe(0.0);
        }

        try
        {
            return new DecimalSafe(left.Value / right.Value);

        }
        catch (DivideByZeroException)
        {
            // Cover cases with zero division
            // 0 / 0 = NaN
            if (left.Value == 0)
                return new DecimalSafe() { IsNaN = true };

            // n / 0 = Inf
            return new DecimalSafe() { IsInf = true };
        }
        catch (OverflowException)
        {
            return new DecimalSafe() { IsInf = true };
        }
    }

    public static bool operator <=(DecimalSafe left, DecimalSafe right)
    {
        if (left.IsNaN || right.IsNaN)
            return false;

        if (left.IsInf && right.IsInf)
            return true;

        if (left.HasValue() && right.IsInf)
            return true;

        if (left.IsInf && right.HasValue())
            return false;



        return left.Value <= right.Value;
    }

    public static bool operator <(DecimalSafe left, DecimalSafe right)
    {
        if (left.IsNaN || right.IsNaN)
            return false;

        if (left.IsInf && right.IsInf)
            return false;

        if (left.HasValue() && right.IsInf)
            return true;

        if (left.IsInf && right.HasValue())
            return false;


        return left.Value < right.Value;
    }


    public static bool operator >=(DecimalSafe left, DecimalSafe right)
    {
        if (left.IsNaN || right.IsNaN)
            return false;

        if (left.IsInf && right.IsInf)
            return true;

        if (left.HasValue() && right.IsInf)
            return false;

        if (left.IsInf && right.HasValue())
            return true;



        return left.Value >= right.Value;
    }

    public static bool operator >(DecimalSafe left, DecimalSafe right)
    {
        if (left.IsNaN || right.IsNaN)
            return false;

        if (left.IsInf && right.IsInf)
            return false;

        if (left.HasValue() && right.IsInf)
            return false;

        if (left.IsInf && right.HasValue())
            return true;


        return left.Value > right.Value;
    }


    public static implicit operator DecimalSafe(decimal value)
    {
        return new DecimalSafe(value);
    }

    public static implicit operator DecimalSafe(double value)
    {
        return new DecimalSafe(value);
    }

    public static implicit operator DecimalSafe(int value)
    {
        return new DecimalSafe(value);
    }

    public static implicit operator DecimalSafe(Fraction value)
    {
        return new DecimalSafe(value);
    }


    public static implicit operator decimal(DecimalSafe value)
    {
        if (value.IsInf)
        {
            throw new InvalidOperationException("Cannot convert infinite value to decimal.");
        }

        if (value.IsNaN)
        {
            throw new InvalidOperationException("Cannot convert NaN value to decimal.");
        }

        return value.Value;
    }

    public static explicit operator double(DecimalSafe value)
    {
        if (value.IsInf)
            return double.PositiveInfinity;

        if (value.IsNaN)
            return double.NaN;

        return (double)value.Value;
    }

    public static explicit operator int(DecimalSafe value)
    {
        return (int)value.Value;
    }

    public static explicit operator Fraction(DecimalSafe value)
    {
        return (Fraction)value.Value;
    }

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

    public bool HasValue()
    {
        if (IsNaN || IsInf)
            return false;

        return true;
    }

    public bool IsNotAValue() => !HasValue();

}
