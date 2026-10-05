using Fractions;
using System;
using System.Numerics;

namespace EngineeringUnits;

// (decimal)(factor * (Fraction)value + offset) - the core of every unit conversion - without BigInteger.
// Fraction reduces the result to lowest terms and Fraction.ToDecimal then does (decimal)numerator / (decimal)denominator.
// Lowest terms are unique, so working them out with 128 bit integers gives the very same numerator and denominator,
// and the same decimal division gives the very same decimal. When a number does not fit, the caller uses Fraction.
internal static class ExactProduct
{
#if NET7_0_OR_GREATER
    // Needs UInt128 - on older targets every Try method returns false
    internal const bool IsAvailable = true;

    private static readonly UInt128[] PowersOf5 = CreatePowersOf5();

    private static UInt128[] CreatePowersOf5()
    {
        var powers = new UInt128[29];
        powers[0] = 1;
        for (int i = 1; i < powers.Length; i++)
            powers[i] = powers[i - 1] * 5;
        return powers;
    }

    // (decimal)(factor * (Fraction)value)
    internal static bool TryMultiply(Fraction factor, decimal value, out decimal result)
    {
        result = 0m;

        if (!TryProduct(factor, value, out bool negative, out UInt128 top, out UInt128 bottom))
            return false;

        return TryToDecimal(negative, top, bottom, out result);
    }

    // (decimal)(factor * (Fraction)value + offset)
    internal static bool TryMultiplyAdd(Fraction factor, decimal value, Fraction offset, out decimal result)
    {
        result = 0m;

        if (!TryTerms(offset, out bool offsetNegative, out ulong offsetTop, out ulong offsetBottom))
            return false;

        if (!TryProduct(factor, value, out bool negative, out UInt128 top, out UInt128 bottom))
            return false;

        if (offsetTop == 0)
            return TryToDecimal(negative, top, bottom, out result);

        if (top == 0)
            return TryToDecimal(offsetNegative, offsetTop, offsetBottom, out result);

        // top/bottom + offsetTop/offsetBottom, both in lowest terms:
        // over the common denominator the sum shares no factor with bottom/common or offsetBottom/common - only with common
        ulong common = Gcd(offsetBottom, Remainder(bottom, offsetBottom));
        ulong offsetFactor = offsetBottom / common;
        UInt128 bottomFactor = bottom / common;

        if (BitLength(top) + BitLength(offsetFactor) > 127 ||
            BitLength(bottomFactor) + BitLength(offsetTop) > 127 ||
            BitLength(bottom) + BitLength(offsetFactor) > 127)
            return false;

        UInt128 first = top * offsetFactor;
        UInt128 second = bottomFactor * offsetTop;
        bottom *= offsetFactor;

        if (negative == offsetNegative)
            top = first + second;
        else if (first >= second)
            top = first - second;
        else
        {
            top = second - first;
            negative = offsetNegative;
        }

        if (top != 0 && common != 1)
        {
            ulong shared = Gcd(common, Remainder(top, common));
            top /= shared;
            bottom /= shared;
        }

        return TryToDecimal(negative, top, bottom, out result);
    }

    // Numerator and denominator of a Fraction in lowest terms with a positive denominator, both no larger than 64 bits
    private static bool TryTerms(Fraction fraction, out bool negative, out ulong top, out ulong bottom)
    {
        negative = false;
        top = 0;
        bottom = 0;

        if (fraction.State != FractionState.IsNormalized)
            return false;

        BigInteger numerator = fraction.Numerator;
        BigInteger denominator = fraction.Denominator;

        if (denominator.Sign <= 0 || denominator.GetBitLength() > 64)
            return false;

        negative = numerator.Sign < 0;
        if (negative)
            numerator = -numerator;

        if (numerator.GetBitLength() > 64)
            return false;

        top = (ulong)numerator;
        bottom = (ulong)denominator;
        return true;
    }

    // factor * value in lowest terms: sign, numerator and denominator (0 is 0/1)
    private static bool TryProduct(Fraction factor, decimal value, out bool negative, out UInt128 top, out UInt128 bottom)
    {
        top = 0;
        bottom = 1;

        if (!TryTerms(factor, out bool factorNegative, out ulong numerator, out ulong denominator) || numerator == 0)
        {
            negative = false;
            return false;
        }

        Span<int> bits = stackalloc int[4];
        decimal.GetBits(value, bits);
        UInt128 mantissa = new((uint)bits[2], ((ulong)(uint)bits[1] << 32) | (uint)bits[0]);
        int scale = (bits[3] >> 16) & 0xFF;
        negative = (bits[3] < 0) ^ factorNegative;

        // factor * 0 = 0
        if (mantissa == 0)
        {
            negative = false;
            return true;
        }

        // value = mantissa / 10^scale = mantissa / (2^twos * 5^fives) - remove what the two have in common
        int twos = Math.Min((int)UInt128.TrailingZeroCount(mantissa), scale);
        mantissa >>= twos;
        twos = scale - twos;

        int fives = scale;
        while (fives > 0 && TryDivideBy5(ref mantissa))
            fives--;

        // The factor's numerator against the value's denominator (2^twos * 5^fives)
        int numeratorTwos = Math.Min(BitOperations.TrailingZeroCount(numerator), twos);
        numerator >>= numeratorTwos;
        twos -= numeratorTwos;

        while (fives > 0 && numerator % 5 == 0)
        {
            numerator /= 5;
            fives--;
        }

        // The value's numerator against the factor's denominator
        if (denominator != 1)
        {
            ulong common = Gcd(denominator, Remainder(mantissa, denominator));
            if (common != 1)
            {
                denominator /= common;
                mantissa /= common;
            }
        }

        // Both must fit in a decimal (96 bits)
        if (BitLength(mantissa) + BitLength(numerator) > 97)
            return false;
        top = mantissa * numerator;

        bottom = PowersOf5[fives];
        if (BitLength(bottom) + BitLength(denominator) + twos > 97)
            return false;
        bottom = (bottom * denominator) << twos;

        return (top >> 96) == 0 && (bottom >> 96) == 0;
    }

    // As Fraction.ToDecimal: a whole number as it is, otherwise (decimal)numerator / (decimal)denominator
    private static bool TryToDecimal(bool negative, UInt128 top, UInt128 bottom, out decimal result)
    {
        result = 0m;

        if ((top >> 96) != 0 || (bottom >> 96) != 0)
            return false;

        if (top == 0)
            return true;

        // A denominator of only 2s and 5s (ex 0.3048 = 381/1250): the quotient is a decimal with a finite number of digits,
        // which the decimal division returns exactly and without trailing zeros (as DecimalSafe.Normalize relies on too).
        // Expanding the fraction to a power of ten gives it without dividing - no trailing zeros, since top shares no factor with bottom.
        int twos = (int)UInt128.TrailingZeroCount(bottom);
        UInt128 rest = bottom >> twos;
        int fives = 0;
        while (fives <= 28 && TryDivideBy5(ref rest))
            fives++;

        if (rest == 1)
        {
            int scale = Math.Max(twos, fives);
            if (scale <= 28 && BitLength(top) + BitLength(PowersOf5[scale - fives]) + (scale - twos) <= 97)
            {
                UInt128 mantissa = (top * PowersOf5[scale - fives]) << (scale - twos);
                if ((mantissa >> 96) == 0)
                {
                    result = new decimal((int)(uint)mantissa, (int)(uint)(mantissa >> 32), (int)(uint)(mantissa >> 64), negative, (byte)scale);
                    return true;
                }
            }
        }

        var topDecimal = new decimal((int)(uint)top, (int)(uint)(top >> 32), (int)(uint)(top >> 64), negative, 0);

        result = bottom == 1
            ? topDecimal
            : topDecimal / new decimal((int)(uint)bottom, (int)(uint)(bottom >> 32), (int)(uint)(bottom >> 64), false, 0);

        return true;
    }

    private static int BitLength(UInt128 value) => 128 - (int)UInt128.LeadingZeroCount(value);
    private static int BitLength(ulong value) => 64 - BitOperations.LeadingZeroCount(value);

    // Divides a number below 2^96 by 5 when nothing is left over. Constant divisors become multiplications.
    private static bool TryDivideBy5(ref UInt128 number)
    {
        ulong upper = (ulong)(number >> 64);
        ulong lower = (ulong)number;

        if (upper == 0)
        {
            if (lower % 5 != 0)
                return false;

            number = lower / 5;
            return true;
        }

        // 2^32 leaves 1 when divided by 5, so the sum of the 32 bit parts leaves the same as the number
        if ((upper + (lower >> 32) + (uint)lower) % 5 != 0)
            return false;

        ulong rest = upper;
        ulong high = rest / 5;
        rest = ((rest % 5) << 32) | (lower >> 32);
        ulong middle = rest / 5;
        rest = ((rest % 5) << 32) | (uint)lower;
        number = new UInt128(high, (middle << 32) | (rest / 5));
        return true;
    }

    private static ulong Remainder(UInt128 number, ulong divisor)
    {
        ulong upper = (ulong)(number >> 64);
        return upper == 0 ? (ulong)number % divisor : (ulong)(number % divisor);
    }

    // Binary gcd - no divisions
    private static ulong Gcd(ulong a, ulong b)
    {
        if (a == 0)
            return b;
        if (b == 0)
            return a;

        int shift = BitOperations.TrailingZeroCount(a | b);
        a >>= BitOperations.TrailingZeroCount(a);

        do
        {
            b >>= BitOperations.TrailingZeroCount(b);
            if (a > b)
                (a, b) = (b, a);
            b -= a;
        }
        while (b != 0);

        return a << shift;
    }
#else
    internal const bool IsAvailable = false;

    internal static bool TryMultiply(Fraction factor, decimal value, out decimal result)
    {
        result = 0m;
        return false;
    }

    internal static bool TryMultiplyAdd(Fraction factor, decimal value, Fraction offset, out decimal result)
    {
        result = 0m;
        return false;
    }
#endif
}
