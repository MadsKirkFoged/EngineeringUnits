using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Information
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromSI(double si)
        {
            double value = (double)si;
            return new Information(value, InformationUnit.SI);
        }

        /// <summary>
        ///     Get Information from Bits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromBits(double bits)
        {
            decimal value = (decimal)bits;
            return new Information(value, InformationUnit.Bit);
        }
        /// <summary>
        ///     Get Information from Bytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromBytes(double bytes)
        {
            decimal value = (decimal)bytes;
            return new Information(value, InformationUnit.Byte);
        }
        /// <summary>
        ///     Get Information from Exabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExabits(double exabits)
        {
            decimal value = (decimal)exabits;
            return new Information(value, InformationUnit.Exabit);
        }
        /// <summary>
        ///     Get Information from Exabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExabytes(double exabytes)
        {
            decimal value = (decimal)exabytes;
            return new Information(value, InformationUnit.Exabyte);
        }
        /// <summary>
        ///     Get Information from Exbibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExbibits(double exbibits)
        {
            decimal value = (decimal)exbibits;
            return new Information(value, InformationUnit.Exbibit);
        }
        /// <summary>
        ///     Get Information from Exbibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromExbibytes(double exbibytes)
        {
            decimal value = (decimal)exbibytes;
            return new Information(value, InformationUnit.Exbibyte);
        }
        /// <summary>
        ///     Get Information from Gibibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGibibits(double gibibits)
        {
            decimal value = (decimal)gibibits;
            return new Information(value, InformationUnit.Gibibit);
        }
        /// <summary>
        ///     Get Information from Gibibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGibibytes(double gibibytes)
        {
            decimal value = (decimal)gibibytes;
            return new Information(value, InformationUnit.Gibibyte);
        }
        /// <summary>
        ///     Get Information from Gigabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGigabits(double gigabits)
        {
            decimal value = (decimal)gigabits;
            return new Information(value, InformationUnit.Gigabit);
        }
        /// <summary>
        ///     Get Information from Gigabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromGigabytes(double gigabytes)
        {
            decimal value = (decimal)gigabytes;
            return new Information(value, InformationUnit.Gigabyte);
        }
        /// <summary>
        ///     Get Information from Kibibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKibibits(double kibibits)
        {
            decimal value = (decimal)kibibits;
            return new Information(value, InformationUnit.Kibibit);
        }
        /// <summary>
        ///     Get Information from Kibibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKibibytes(double kibibytes)
        {
            decimal value = (decimal)kibibytes;
            return new Information(value, InformationUnit.Kibibyte);
        }
        /// <summary>
        ///     Get Information from Kilobits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKilobits(double kilobits)
        {
            decimal value = (decimal)kilobits;
            return new Information(value, InformationUnit.Kilobit);
        }
        /// <summary>
        ///     Get Information from Kilobytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromKilobytes(double kilobytes)
        {
            decimal value = (decimal)kilobytes;
            return new Information(value, InformationUnit.Kilobyte);
        }
        /// <summary>
        ///     Get Information from Mebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMebibits(double mebibits)
        {
            decimal value = (decimal)mebibits;
            return new Information(value, InformationUnit.Mebibit);
        }
        /// <summary>
        ///     Get Information from Mebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMebibytes(double mebibytes)
        {
            decimal value = (decimal)mebibytes;
            return new Information(value, InformationUnit.Mebibyte);
        }
        /// <summary>
        ///     Get Information from Megabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMegabits(double megabits)
        {
            decimal value = (decimal)megabits;
            return new Information(value, InformationUnit.Megabit);
        }
        /// <summary>
        ///     Get Information from Megabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromMegabytes(double megabytes)
        {
            decimal value = (decimal)megabytes;
            return new Information(value, InformationUnit.Megabyte);
        }
        /// <summary>
        ///     Get Information from Pebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPebibits(double pebibits)
        {
            decimal value = (decimal)pebibits;
            return new Information(value, InformationUnit.Pebibit);
        }
        /// <summary>
        ///     Get Information from Pebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPebibytes(double pebibytes)
        {
            decimal value = (decimal)pebibytes;
            return new Information(value, InformationUnit.Pebibyte);
        }
        /// <summary>
        ///     Get Information from Petabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPetabits(double petabits)
        {
            decimal value = (decimal)petabits;
            return new Information(value, InformationUnit.Petabit);
        }
        /// <summary>
        ///     Get Information from Petabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromPetabytes(double petabytes)
        {
            decimal value = (decimal)petabytes;
            return new Information(value, InformationUnit.Petabyte);
        }
        /// <summary>
        ///     Get Information from Tebibits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTebibits(double tebibits)
        {
            decimal value = (decimal)tebibits;
            return new Information(value, InformationUnit.Tebibit);
        }
        /// <summary>
        ///     Get Information from Tebibytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTebibytes(double tebibytes)
        {
            decimal value = (decimal)tebibytes;
            return new Information(value, InformationUnit.Tebibyte);
        }
        /// <summary>
        ///     Get Information from Terabits.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTerabits(double terabits)
        {
            decimal value = (decimal)terabits;
            return new Information(value, InformationUnit.Terabit);
        }
        /// <summary>
        ///     Get Information from Terabytes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Information FromTerabytes(double terabytes)
        {
            decimal value = (decimal)terabytes;
            return new Information(value, InformationUnit.Terabyte);
        }

    }
}
