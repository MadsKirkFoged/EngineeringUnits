using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Ratio
    {
        /// <summary>
        ///     Get Ratio from DecimalFractions.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromDecimalFractions(double decimalfractions)
        {
            double value = (double)decimalfractions;
            return new Ratio(value, RatioUnit.DecimalFraction);
        }
        /// <summary>
        ///     Get Ratio from PartsPerBillion.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromPartsPerBillion(double partsperbillion)
        {
            double value = (double)partsperbillion;
            return new Ratio(value, RatioUnit.PartPerBillion);
        }
        /// <summary>
        ///     Get Ratio from PartsPerMillion.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromPartsPerMillion(double partspermillion)
        {
            double value = (double)partspermillion;
            return new Ratio(value, RatioUnit.PartPerMillion);
        }
        /// <summary>
        ///     Get Ratio from PartsPerThousand.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromPartsPerThousand(double partsperthousand)
        {
            double value = (double)partsperthousand;
            return new Ratio(value, RatioUnit.PartPerThousand);
        }
        /// <summary>
        ///     Get Ratio from PartsPerTrillion.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromPartsPerTrillion(double partspertrillion)
        {
            double value = (double)partspertrillion;
            return new Ratio(value, RatioUnit.PartPerTrillion);
        }
        /// <summary>
        ///     Get Ratio from Percent.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromPercent(double percent)
        {
            double value = (double)percent;
            return new Ratio(value, RatioUnit.Percent);
        }

    }
}
