using Fractions;
using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;
using Stj = System.Text.Json.Serialization;

namespace EngineeringUnits;

// Holds a decimal whenever decimal can hold the value, so all math is exact decimal math: 0.1 + 0.2 == 0.3.
// A double becomes a decimal when it comes in: (decimal)double keeps 15 significant digits - the digits the user typed.
// Only what decimal can't hold stays a double: NaN, ±Infinity and values beyond ±7.9e28.
// decimal op decimal -> decimal (spills over to double on overflow)
// anything else      -> double math, and a result that fits in decimal again becomes a decimal
// The flag marks the double, so default(DecimalSafe) is decimal 0 - also in arrays and in JSON without a Value.
// Fields are deliberately not overlapped - an explicit layout stops the JIT from keeping the struct in registers
public readonly struct DecimalSafe : IEquatable<DecimalSafe>
{
    private readonly double _d;
    private readonly decimal _m;
    private readonly bool _isDouble;

    private const double DecimalMax = (double)decimal.MaxValue;

    // JSON: Value, IsInf and IsNaN as always, plus Double for a value decimal can't hold (sign of an infinity,
    // values beyond decimal). IsInf is written for values beyond decimal too, so older versions read them as Infinity
    // (as they held them), not as 0. Each init only sets its own part, so the order of the properties doesn't matter.

    [JsonProperty(Order = 1)]
    [Stj.JsonPropertyOrder(1)]
    public decimal Value
    {
        get => _isDouble ? 0m : _m;
        init => _m = value;
    }

    [JsonIgnore]
    [Stj.JsonIgnore]
    public bool IsInf
    {
        get => _isDouble && double.IsInfinity(_d);
        init { if (value && !_isDouble) { _d = double.PositiveInfinity; _isDouble = true; } }
    }

    [JsonProperty(nameof(IsInf), Order = 2)]
    [Stj.JsonInclude]
    [Stj.JsonPropertyName(nameof(IsInf))]
    [Stj.JsonPropertyOrder(2)]
    internal bool IsInfJson
    {
        get => _isDouble && !double.IsNaN(_d);
        init { if (value && !_isDouble) { _d = double.PositiveInfinity; _isDouble = true; } }
    }

    [JsonProperty(Order = 3)]
    [Stj.JsonPropertyOrder(3)]
    public bool IsNaN
    {
        get => _isDouble && double.IsNaN(_d);
        init { if (value && !_isDouble) { _d = double.NaN; _isDouble = true; } }
    }

    [JsonProperty(Order = 4, NullValueHandling = NullValueHandling.Ignore)]
    [Stj.JsonInclude]
    [Stj.JsonPropertyOrder(4)]
    [Stj.JsonIgnore(Condition = Stj.JsonIgnoreCondition.WhenWritingNull)]
    [Stj.JsonNumberHandling(Stj.JsonNumberHandling.AllowNamedFloatingPointLiterals)]
    internal double? Double
    {
        get => _isDouble ? _d : null;
        init
        {
            if (value is not double d)
                return;

            if (Math.Abs(d) < DecimalMax)
            {
                _m = (decimal)d;
                _isDouble = false;
            }
            else
            {
                _d = d;
                _isDouble = true;
            }
        }
    }

    [JsonIgnore]
    [Stj.JsonIgnore]
    public bool IsDecimal => !_isDouble;

    public DecimalSafe()
    {
    }

    public DecimalSafe(decimal value)
    {
        _m = value;
    }

    public DecimalSafe(double value)
    {
        // False for NaN and ±Infinity
        if (Math.Abs(value) < DecimalMax)
        {
            _m = (decimal)value;
        }
        else
        {
            _d = value;
            _isDouble = true;
        }
    }

    public DecimalSafe(int value)
    {
        _m = value;
    }

    public DecimalSafe(Fraction value)
    {
        try
        {
            _m = (decimal)value;
        }
        catch
        {
            // Too large for decimal (or NaN/Infinity): kept as a double - the nearest one, still finite when a double can hold it.
            // Beyond decimal means at least decimal.MaxValue + 0.5, and the nearest double to that is 2^96 or more
            this = new DecimalSafe(ExactDouble.From(value));
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private double AsDouble() => _isDouble ? _d : (double)_m;

    // Only for comparing when at least one side is a double. That double is NaN, ±Infinity or beyond decimal,
    // so it is never equal to a decimal and is larger than every decimal when it is positive -
    // comparing it to 0 instead of the decimal gives the exact answer (rounding the decimal to double would not)
    private double OrderValue => _isDouble ? _d : 0d;

    // The decimal exactly as the Fraction round trip (decimal)(Fraction)value gives it back: trailing zeros removed
    // (1.50 -> 1.5, 5.00 -> 5) and every zero as 0. The scale matters - (double) of the same number can differ in the last bit.
    // Lets a conversion by a factor of exactly 1 skip the Fraction math.
    internal static decimal Normalize(decimal value)
    {
#if NET
        Span<int> bits = stackalloc int[4];
        decimal.GetBits(value, bits);
#else
        int[] bits = decimal.GetBits(value);
#endif
        uint lo = (uint)bits[0], mid = (uint)bits[1], hi = (uint)bits[2];
        int scale = (bits[3] >> 16) & 0xFF;

        if ((lo | mid | hi) == 0)
            return 0m;

        // No trailing zero to remove: no decimals, or the 96 bit integer doesn't end in 0 (2^32 and 2^64 both end in 6)
        if (scale == 0 || (lo + 6UL * mid + 6UL * hi) % 10 != 0)
            return value;

        int newScale = scale;
        while (newScale > 0)
        {
            // Divide the 96 bit integer by 10, and keep it only when nothing is left over
            ulong rest = hi;
            uint newHi = (uint)(rest / 10);
            rest = ((rest % 10) << 32) | mid;
            uint newMid = (uint)(rest / 10);
            rest = ((rest % 10) << 32) | lo;
            uint newLo = (uint)(rest / 10);

            if (rest % 10 != 0)
                break;

            hi = newHi;
            mid = newMid;
            lo = newLo;
            newScale--;
        }

        return newScale == scale ? value : new decimal((int)lo, (int)mid, (int)hi, bits[3] < 0, (byte)newScale);
    }

    // This value as a conversion by a factor of exactly 1 gives it back
    internal DecimalSafe Normalized() => _isDouble ? this : new DecimalSafe(Normalize(_m));

    // decimal op decimal is the normal case. Its try/catch (overflow) lives in a separate method,
    // since a try/catch would block inlining of the operator.
    // On overflow the exact result is rounded once to double: (double)left * (double)right could land below decimal.MaxValue.
    // Anything with a double in it (NaN, ±Infinity, beyond decimal) is double math.

    public static DecimalSafe operator +(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? Add(left._m, right._m) : new DecimalSafe(left.AsDouble() + right.AsDouble());

    private static DecimalSafe Add(decimal left, decimal right)
    {
        try { return new DecimalSafe(left + right); }
        catch (OverflowException) { return new DecimalSafe((Fraction)left + (Fraction)right); }
    }

    public static DecimalSafe operator -(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? Sub(left._m, right._m) : new DecimalSafe(left.AsDouble() - right.AsDouble());

    private static DecimalSafe Sub(decimal left, decimal right)
    {
        try { return new DecimalSafe(left - right); }
        catch (OverflowException) { return new DecimalSafe((Fraction)left - (Fraction)right); }
    }

    public static DecimalSafe operator -(DecimalSafe value) => value._isDouble ? new DecimalSafe(-value._d) : new DecimalSafe(-value._m);

    public static DecimalSafe operator *(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? Mul(left._m, right._m) : new DecimalSafe(left.AsDouble() * right.AsDouble());

    private static DecimalSafe Mul(decimal left, decimal right)
    {
        try { return new DecimalSafe(left * right); }
        catch (OverflowException) { return new DecimalSafe((Fraction)left * (Fraction)right); }
    }

    public static DecimalSafe operator /(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? Div(left._m, right._m) : new DecimalSafe(left.AsDouble() / right.AsDouble());

    private static DecimalSafe Div(decimal left, decimal right)
    {
        // n / 0 = ±Infinity, 0 / 0 = NaN
        if (right == 0m)
            return new DecimalSafe((double)left / 0d);

        try { return new DecimalSafe(left / right); }
        catch (OverflowException) { return new DecimalSafe((Fraction)left / (Fraction)right); }
    }

    public static bool operator <=(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? left._m <= right._m : left.OrderValue <= right.OrderValue;

    public static bool operator <(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? left._m < right._m : left.OrderValue < right.OrderValue;

    public static bool operator >=(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? left._m >= right._m : left.OrderValue >= right.OrderValue;

    public static bool operator >(DecimalSafe left, DecimalSafe right) =>
        !(left._isDouble | right._isDouble) ? left._m > right._m : left.OrderValue > right.OrderValue;

    public static bool operator ==(DecimalSafe left, DecimalSafe right) => left.Equals(right);
    public static bool operator !=(DecimalSafe left, DecimalSafe right) => !left.Equals(right);

    // A decimal never equals a double (see OrderValue). NaN equals NaN, as it always has here
    public bool Equals(DecimalSafe other)
    {
        if (!(_isDouble | other._isDouble))
            return _m == other._m;

        return _isDouble & other._isDouble && _d.Equals(other._d);
    }

    public override bool Equals(object? obj) => obj is DecimalSafe other && Equals(other);

    // Equal decimals with a different scale (1.5 and 1.50) must hash the same.
    // decimal.GetHashCode ignores trailing zeros on .NET Core - .NET Framework hashes through double, so normalize first
    public override int GetHashCode()
    {
        // Every NaN equals every NaN - .NET Framework hashes NaN with its sign bit
        if (_isDouble)
            return double.IsNaN(_d) ? double.NaN.GetHashCode() : _d.GetHashCode();

#if NETSTANDARD2_0
        return Normalize(_m).GetHashCode();
#else
        return _m.GetHashCode();
#endif
    }

    public static implicit operator DecimalSafe(decimal value) => new(value);
    public static implicit operator DecimalSafe(double value) => new(value);
    public static implicit operator DecimalSafe(int value) => new(value);
    public static implicit operator DecimalSafe(Fraction value) => new(value);

    public static implicit operator decimal(DecimalSafe value)
    {
        if (!value._isDouble)
            return value._m;

        if (double.IsInfinity(value._d))
            throw new InvalidOperationException("Cannot convert infinite value to decimal.");

        if (double.IsNaN(value._d))
            throw new InvalidOperationException("Cannot convert NaN value to decimal.");

        throw new InvalidOperationException("Cannot convert a value beyond the decimal range to decimal.");
    }

    public static explicit operator double(DecimalSafe value) => value.AsDouble();

    // NaN, ±Infinity and values beyond decimal give 0, as they always have
    public static explicit operator int(DecimalSafe value) => value._isDouble ? 0 : (int)value._m;

    public static explicit operator Fraction(DecimalSafe value)
    {
        if (!value._isDouble)
            return (Fraction)value._m;

        if (double.IsNaN(value._d))
            return Fraction.NaN;

        if (double.IsPositiveInfinity(value._d))
            return Fraction.PositiveInfinity;

        if (double.IsNegativeInfinity(value._d))
            return Fraction.NegativeInfinity;

        return Fraction.FromDouble(value._d);
    }

    public override string ToString() => _isDouble ? _d.ToString() : _m.ToString();

    public string ToString(string format) => _isDouble ? _d.ToString(format) : _m.ToString(format);

    public string ToString(IFormatProvider provider) => _isDouble ? _d.ToString(provider) : _m.ToString(provider);

    public string ToString(string format, IFormatProvider provider) => _isDouble ? _d.ToString(format, provider) : _m.ToString(format, provider);

    public bool IsZero() => _isDouble ? _d == 0d : _m == 0m;

    public bool HasValue() => !_isDouble || !(double.IsNaN(_d) || double.IsInfinity(_d));

    public bool IsNotAValue() => !HasValue();
}
