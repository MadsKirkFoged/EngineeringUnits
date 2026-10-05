using Fractions;
using System;
using System.Numerics;

namespace EngineeringUnits;

// An exact value rounded once to the nearest double, ties to even - with subnormals, and ±Infinity beyond double.MaxValue.
// Fraction.ToDouble() is not: it truncates (10^30 gives 9.999999999999999E+29) and gives NaN when both terms are beyond double.
internal static class ExactDouble
{
    internal static double From(Fraction value) =>
        value.Denominator.IsZero
            ? value.ToDouble()                                                      // NaN, ±Infinity
            : Divide(value.Numerator, value.Denominator);

    // numerator / denominator: the exact integer quotient is taken to one bit more than the double keeps,
    // the remainder tells whether anything is left below that bit
    internal static double Divide(BigInteger numerator, BigInteger denominator)
    {
        if (numerator.IsZero)
            return 0d;

        if (denominator.Sign < 0)
            (numerator, denominator) = (-numerator, -denominator);

        var n = BigInteger.Abs(numerator);
        double result;

        // 2^e <= n / d < 2^(e + 1)
        var e = BitLength(n) - BitLength(denominator);
        if (e >= 0 ? n < denominator << (int)e : n << (int)-e < denominator)
            e--;

        // The bits the double keeps: 53, fewer for subnormals (their last bit is 2^-1074)
        var keep = Math.Min(53, e + 1075);

        if (keep < 0)
            result = 0d;                                                            // below half of double.Epsilon
        else if (e > 1023)
            result = double.PositiveInfinity;
        else
        {
            // q = n / d * 2^shift has keep + 1 bits, the last one decides the rounding
            var shift = (int)(keep - e);
            var q = BigInteger.DivRem(shift >= 0 ? n << shift : n, shift >= 0 ? denominator : denominator << -shift, out var rest);
            var roundingBit = !q.IsEven;
            q >>= 1;
            if (roundingBit && (!rest.IsZero || !q.IsEven))                         // above half, or half and odd
                q++;

            // q <= 2^53 and the power of two are exact, so is their product - 2^1024 becomes Infinity
            result = (double)(ulong)q * PowerOfTwo(1 - shift);
        }

        return numerator.Sign < 0 ? -result : result;
    }

    // 2^exponent for -1074 <= exponent <= 1023, built from its bits
    private static double PowerOfTwo(int exponent) =>
        exponent >= -1022
            ? BitConverter.Int64BitsToDouble((long)(exponent + 1023) << 52)
            : BitConverter.Int64BitsToDouble(1L << (exponent + 1074));

    // The number of bits of a positive integer
    private static long BitLength(BigInteger value)
    {
#if NET5_0_OR_GREATER
        return (long)value.GetBitLength();
#else
        byte[] bytes = value.ToByteArray();
        int top = bytes.Length - 1;
        while (top > 0 && bytes[top] == 0)
            top--;

        long bits = top * 8L;
        for (int b = bytes[top]; b != 0; b >>= 1)
            bits++;

        return bits;
#endif
    }
}
