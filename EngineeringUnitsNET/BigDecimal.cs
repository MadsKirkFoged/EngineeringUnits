using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace EngineeringUnits
{
    /// <summary>
    ///     Arbitrary precision Decimal.
    ///     All operations are exact, except for division. Division never determines more digits than the given precision.
    ///     Based on http://stackoverflow.com/a/4524254
    ///     Author: Jan Christoph Bernack (contact: jc.bernack at googlemail.com)
    /// </summary>
    /// <see cref="http://stackoverflow.com/a/13813535/956364" />
    //[UsedImplicitly]
    public struct BigDecimal : IComparable, IComparable<BigDecimal>
    {
        /// <summary>
        ///     Sets the maximum precision of division operations.
        ///     If AlwaysTruncate is set to true all operations are affected.
        /// </summary>
        public const int Precision = 50;

        public BigDecimal(BigDecimal bigDecimal, Boolean alwaysTruncate = false) : this(bigDecimal.Mantissa, bigDecimal.Exponent, alwaysTruncate) { }

        public BigDecimal(Decimal value, Boolean alwaysTruncate = false) : this((BigDecimal)value, alwaysTruncate) { }

        /// <summary>
        /// </summary>
        /// <param name="mantissa"></param>
        /// <param name="exponent"></param>
        /// <param name="alwaysTruncate">
        ///     Specifies whether the significant digits should be truncated to the given precision after
        ///     each operation.
        /// </param>
        public BigDecimal(BigInteger mantissa, int exponent, Boolean alwaysTruncate = false) : this()
        {
            this.Mantissa = mantissa;
            this.Exponent = exponent;
            this.Normalize();
            if (alwaysTruncate)
            {
                this.Truncate();
            }
        }

        public BigInteger Mantissa { get; set; }
        public int Exponent { get; set; }

        public int CompareTo(object obj)
        {
            if (ReferenceEquals(obj, null) || !(obj is BigDecimal))
            {
                throw new ArgumentException();
            }
            return this.CompareTo((BigDecimal)obj);
        }

        public int CompareTo(BigDecimal other)
        {
            return this < other ? -1 : (this > other ? 1 : 0);
        }

        /// <summary>
        ///     Removes trailing zeros on the mantissa
        /// </summary>
        public void Normalize()
        {
            if (this.Mantissa.IsZero)
            {
                this.Exponent = 0;
            }
            else
            {
                BigInteger remainder = 0;
                while (remainder == 0)
                {
                    var shortened = BigInteger.DivRem(dividend: this.Mantissa, divisor: 10, remainder: out remainder);
                    if (remainder != 0)
                    {
                        continue;
                    }
                    this.Mantissa = shortened;
                    this.Exponent++;
                }
            }
        }

        /// <summary>
        ///     Truncate the number to the given precision by removing the least significant digits.
        /// </summary>
        /// <returns>The truncated number</returns>
        public BigDecimal Truncate(int precision = Precision)
        {
            // copy this instance (remember its a struct)
            var shortened = this;
            // save some time because the number of digits is not needed to remove trailing zeros
            shortened.Normalize();
            // remove the least significant digits, as long as the number of digits is higher than the given Precision
            while (NumberOfDigits(shortened.Mantissa) > precision)
            {
                shortened.Mantissa /= 10;
                shortened.Exponent++;
            }
            return shortened;
        }

        private static int NumberOfDigits(BigInteger value)
        {
            // do not count the sign
            return (value * value.Sign).ToString()
                                       .Length;
        }

        public override string ToString()
        {
            return string.Concat(this.Mantissa.ToString(), "E", this.Exponent);
        }

        public bool Equals(BigDecimal other)
        {
            return other.Mantissa.Equals(this.Mantissa) && other.Exponent == this.Exponent;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            return obj is BigDecimal && this.Equals((BigDecimal)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (this.Mantissa.GetHashCode() * 397) ^ this.Exponent;
            }
        }

        #region Conversions
        public static implicit operator BigDecimal(int value)
        {
            return new BigDecimal(value, 0);
        }

        public static implicit operator BigDecimal(double value)
        {
            var mantissa = (BigInteger)value;
            var exponent = 0;
            double scaleFactor = 1;
            while (Math.Abs(value * scaleFactor - (double)mantissa) > 0)
            {
                exponent -= 1;
                scaleFactor *= 10;
                mantissa = (BigInteger)(value * scaleFactor);
            }
            return new BigDecimal(mantissa, exponent);
        }

        public static implicit operator BigDecimal(Decimal value)
        {
            var mantissa = (BigInteger)value;
            var exponent = 0;
            Decimal scaleFactor = 1;
            while ((Decimal)mantissa != value * scaleFactor)
            {
                exponent -= 1;
                scaleFactor *= 10;
                mantissa = (BigInteger)(value * scaleFactor);
            }
            return new BigDecimal(mantissa, exponent);
        }

        public static explicit operator double(BigDecimal value)
        {
            return (double)value.Mantissa * Math.Pow(10, value.Exponent);
        }

        public static explicit operator float(BigDecimal value)
        {
            return Convert.ToSingle((double)value);
        }

        public static explicit operator Decimal(BigDecimal value)
        {
            return (Decimal)value.Mantissa * (Decimal)Math.Pow(10, value.Exponent);
        }

        public static explicit operator int(BigDecimal value)
        {
            return (int)(value.Mantissa * BigInteger.Pow(10, value.Exponent));
        }

        public static explicit operator uint(BigDecimal value)
        {
            return (uint)(value.Mantissa * BigInteger.Pow(10, value.Exponent));
        }
        #endregion

        #region Operators
        public static BigDecimal operator +(BigDecimal value)
        {
            return value;
        }

        public static BigDecimal operator -(BigDecimal value)
        {
            value.Mantissa *= -1;
            return value;
        }

        public static BigDecimal operator ++(BigDecimal value)
        {
            return value + 1;
        }

        public static BigDecimal operator --(BigDecimal value)
        {
            return value - 1;
        }

        public static BigDecimal operator +(BigDecimal left, BigDecimal right)
        {
            return Add(left, right);
        }

        public static BigDecimal operator -(BigDecimal left, BigDecimal right)
        {
            return Add(left, -right);
        }

        private static BigDecimal Add(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent ? new BigDecimal(AlignExponent(left, right) + right.Mantissa, right.Exponent) : new BigDecimal(AlignExponent(right, left) + left.Mantissa, left.Exponent);
        }

        public static BigDecimal operator *(BigDecimal left, BigDecimal right)
        {
            return new BigDecimal(left.Mantissa * right.Mantissa, left.Exponent + right.Exponent);
        }

        public static BigDecimal operator /(BigDecimal dividend, BigDecimal divisor)
        {
            var exponentChange = Precision - (NumberOfDigits(dividend.Mantissa) - NumberOfDigits(divisor.Mantissa));
            if (exponentChange < 0)
            {
                exponentChange = 0;
            }
            dividend.Mantissa *= BigInteger.Pow(10, exponentChange);
            return new BigDecimal(dividend.Mantissa / divisor.Mantissa, dividend.Exponent - divisor.Exponent - exponentChange);
        }

        public static bool operator ==(BigDecimal left, BigDecimal right)
        {
            return left.Exponent == right.Exponent && left.Mantissa == right.Mantissa;
        }

        public static bool operator !=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent != right.Exponent || left.Mantissa != right.Mantissa;
        }

        public static bool operator <(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent ? AlignExponent(left, right) < right.Mantissa : left.Mantissa < AlignExponent(right, left);
        }

        public static bool operator >(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent ? AlignExponent(left, right) > right.Mantissa : left.Mantissa > AlignExponent(right, left);
        }

        public static bool operator <=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent ? AlignExponent(left, right) <= right.Mantissa : left.Mantissa <= AlignExponent(right, left);
        }

        public static bool operator >=(BigDecimal left, BigDecimal right)
        {
            return left.Exponent > right.Exponent ? AlignExponent(left, right) >= right.Mantissa : left.Mantissa >= AlignExponent(right, left);
        }

        /// <summary>
        ///     Returns the mantissa of value, aligned to the exponent of reference.
        ///     Assumes the exponent of value is larger than of value.
        /// </summary>
        private static BigInteger AlignExponent(BigDecimal value, BigDecimal reference)
        {
            return value.Mantissa * BigInteger.Pow(10, value.Exponent - reference.Exponent);
        }
        #endregion

        #region Additional mathematical functions
        public static BigDecimal Exp(double exponent)
        {
            var tmp = (BigDecimal)1;
            while (Math.Abs(exponent) > 100)
            {
                var diff = exponent > 0 ? 100 : -100;
                tmp *= Math.Exp(diff);
                exponent -= diff;
            }
            return tmp * Math.Exp(exponent);
        }

        public static BigDecimal Pow(double basis, double exponent)
        {
            var tmp = (BigDecimal)1;
            while (Math.Abs(exponent) > 100)
            {
                var diff = exponent > 0 ? 100 : -100;
                tmp *= Math.Pow(basis, diff);
                exponent -= diff;
            }
            return tmp * Math.Pow(basis, exponent);
        }
        #endregion
    }
}
