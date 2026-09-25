using Fractions;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace EngineeringUnits;

// Stores either a double or a decimal - whatever the value was created with.
// double op double   -> double (fast path, IEEE semantics for NaN/Inf)
// decimal op decimal -> decimal (spills over to double on overflow)
// mixed              -> double (a result can't be more precise than its least precise input)
// BaseUnit decides when exact math is needed: anything involving non-SI units turns doubles into decimals first (ToExact)
// Fields are deliberately not overlapped - an explicit layout stops the JIT from keeping the struct in registers
public readonly struct DecimalSafe : IEquatable<DecimalSafe>
{
    private readonly double _d;
    private readonly decimal _m;
    private readonly bool _isDecimal;

    private const double DecimalMax = (double)decimal.MaxValue;

    [JsonProperty]
    public decimal Value
    {
        get => _isDecimal ? _m : HasValue() && Math.Abs(_d) < DecimalMax ? ToDecimal(_d) : 0m;
        init { _m = value; _isDecimal = true; }
    }

    [JsonProperty]
    public bool IsInf
    {
        get => !_isDecimal && double.IsInfinity(_d);
        init { if (value) { _d = double.PositiveInfinity; _isDecimal = false; } }
    }

    [JsonProperty]
    public bool IsNaN
    {
        get => !_isDecimal && double.IsNaN(_d);
        init { if (value) { _d = double.NaN; _isDecimal = false; } }
    }

    [JsonIgnore]
    public bool IsDecimal => _isDecimal;

    public DecimalSafe()
    {
        _m = 0m;
        _isDecimal = true;
    }

    public DecimalSafe(decimal value)
    {
        _m = value;
        _isDecimal = true;
    }

    public DecimalSafe(double value)
    {
        _d = value;
        _isDecimal = false;
    }

    public DecimalSafe(int value)
    {
        _m = value;
        _isDecimal = true;
    }

    public DecimalSafe(Fraction value)
    {
        try
        {
            _m = (decimal)value;
            _isDecimal = true;
        }
        catch
        {
            _d = value.IsNaN ? double.NaN : value.IsNegative ? double.NegativeInfinity : double.PositiveInfinity;
            _isDecimal = false;
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private double AsDouble() => _isDecimal ? (double)_m : _d;

    // The value as a decimal when it fits. Used before exact (unit converting) math.
    internal DecimalSafe ToExact()
    {
        if (_isDecimal || !HasValue() || Math.Abs(_d) >= DecimalMax)
            return this;

        return new DecimalSafe(ToDecimal(_d));
    }

    // A typed-in value like 3.87 becomes exactly 3.87m: (decimal)double rounds to 15 significant digits,
    // and when that gives the same double back, those digits are what the user meant.
    // A computed value like 3.87 / 2.78 needs up to 17 digits - there the rest is added from the residual,
    // so the decimal holds the full precision of the double.
    private static decimal ToDecimal(double value)
    {
        decimal rounded = (decimal)value;
        double back = (double)rounded;

        if (back == value)
            return rounded;

        return rounded + (decimal)(value - back);
    }

    // Each operator keeps the double-double case inline and moves everything else
    // into a non-inlined helper, since a try/catch would block inlining of the operator

    public static DecimalSafe operator +(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal | right._isDecimal))
            return new DecimalSafe(left._d + right._d);

        return AddSlow(left, right);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DecimalSafe AddSlow(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal & right._isDecimal))
            return new DecimalSafe(left.AsDouble() + right.AsDouble());

        try { return new DecimalSafe(left._m + right._m); }
        catch (OverflowException) { return new DecimalSafe((double)left._m + (double)right._m); }
    }

    public static DecimalSafe operator -(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal | right._isDecimal))
            return new DecimalSafe(left._d - right._d);

        return SubSlow(left, right);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DecimalSafe SubSlow(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal & right._isDecimal))
            return new DecimalSafe(left.AsDouble() - right.AsDouble());

        try { return new DecimalSafe(left._m - right._m); }
        catch (OverflowException) { return new DecimalSafe((double)left._m - (double)right._m); }
    }

    public static DecimalSafe operator -(DecimalSafe value) => value._isDecimal ? new DecimalSafe(-value._m) : new DecimalSafe(-value._d);

    public static DecimalSafe operator *(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal | right._isDecimal))
            return new DecimalSafe(left._d * right._d);

        return MulSlow(left, right);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DecimalSafe MulSlow(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal & right._isDecimal))
            return new DecimalSafe(left.AsDouble() * right.AsDouble());

        try { return new DecimalSafe(left._m * right._m); }
        catch (OverflowException) { return new DecimalSafe((double)left._m * (double)right._m); }
    }

    public static DecimalSafe operator /(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal | right._isDecimal))
            return new DecimalSafe(left._d / right._d);

        return DivSlow(left, right);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DecimalSafe DivSlow(DecimalSafe left, DecimalSafe right)
    {
        if (!(left._isDecimal & right._isDecimal))
            return new DecimalSafe(left.AsDouble() / right.AsDouble());

        if (right._m == 0m)
            return new DecimalSafe((double)left._m / 0d);

        try { return new DecimalSafe(left._m / right._m); }
        catch (OverflowException) { return new DecimalSafe((double)left._m / (double)right._m); }
    }

    public static bool operator <=(DecimalSafe left, DecimalSafe right) =>
        left._isDecimal & right._isDecimal ? left._m <= right._m : left.AsDouble() <= right.AsDouble();

    public static bool operator <(DecimalSafe left, DecimalSafe right) =>
        left._isDecimal & right._isDecimal ? left._m < right._m : left.AsDouble() < right.AsDouble();

    public static bool operator >=(DecimalSafe left, DecimalSafe right) =>
        left._isDecimal & right._isDecimal ? left._m >= right._m : left.AsDouble() >= right.AsDouble();

    public static bool operator >(DecimalSafe left, DecimalSafe right) =>
        left._isDecimal & right._isDecimal ? left._m > right._m : left.AsDouble() > right.AsDouble();

    public static bool operator ==(DecimalSafe left, DecimalSafe right) => left.Equals(right);
    public static bool operator !=(DecimalSafe left, DecimalSafe right) => !left.Equals(right);

    public bool Equals(DecimalSafe other)
    {
        if (_isDecimal & other._isDecimal)
            return _m == other._m;

        return AsDouble().Equals(other.AsDouble());
    }

    public override bool Equals(object? obj) => obj is DecimalSafe other && Equals(other);

    public override int GetHashCode() => AsDouble().GetHashCode();

    public static implicit operator DecimalSafe(decimal value) => new(value);
    public static implicit operator DecimalSafe(double value) => new(value);
    public static implicit operator DecimalSafe(int value) => new(value);
    public static implicit operator DecimalSafe(Fraction value) => new(value);

    public static implicit operator decimal(DecimalSafe value)
    {
        if (value._isDecimal)
            return value._m;

        if (double.IsInfinity(value._d))
            throw new InvalidOperationException("Cannot convert infinite value to decimal.");

        if (double.IsNaN(value._d))
            throw new InvalidOperationException("Cannot convert NaN value to decimal.");

        return ToDecimal(value._d);
    }

    public static explicit operator double(DecimalSafe value) => value.AsDouble();

    public static explicit operator int(DecimalSafe value) => value._isDecimal ? (int)value._m : (int)value._d;

    public static explicit operator Fraction(DecimalSafe value)
    {
        if (value._isDecimal)
            return (Fraction)value._m;

        if (double.IsNaN(value._d))
            return Fraction.NaN;

        if (double.IsPositiveInfinity(value._d))
            return Fraction.PositiveInfinity;

        if (double.IsNegativeInfinity(value._d))
            return Fraction.NegativeInfinity;

        if (Math.Abs(value._d) < DecimalMax)
            return (Fraction)ToDecimal(value._d);

        return Fraction.FromDouble(value._d);
    }

    public override string ToString() => _isDecimal ? _m.ToString() : _d.ToString();

    public string ToString(string format) => _isDecimal ? _m.ToString(format) : _d.ToString(format);

    public string ToString(IFormatProvider provider) => _isDecimal ? _m.ToString(provider) : _d.ToString(provider);

    public string ToString(string format, IFormatProvider provider) => _isDecimal ? _m.ToString(format, provider) : _d.ToString(format, provider);

    public bool IsZero() => _isDecimal ? _m == 0m : _d == 0d;

    public bool HasValue() => _isDecimal || !(double.IsNaN(_d) || double.IsInfinity(_d));

    public bool IsNotAValue() => !HasValue();
}
