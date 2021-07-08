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


        /// <summary>
        ///     Get Ratio from CentigramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromCentigramsPerGram(double centigramspergram)
        {
            double value = (double)centigramspergram;
            return new Ratio(value, RatioUnit.CentigramPerGram);
        }
        /// <summary>
        ///     Get Ratio from CentigramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromCentigramsPerKilogram(double centigramsperkilogram)
        {
            double value = (double)centigramsperkilogram;
            return new Ratio(value, RatioUnit.CentigramPerKilogram);
        }
        /// <summary>
        ///     Get Ratio from DecagramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromDecagramsPerGram(double decagramspergram)
        {
            double value = (double)decagramspergram;
            return new Ratio(value, RatioUnit.DecagramPerGram);
        }
        /// <summary>
        ///     Get Ratio from DecagramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromDecagramsPerKilogram(double decagramsperkilogram)
        {
            double value = (double)decagramsperkilogram;
            return new Ratio(value, RatioUnit.DecagramPerKilogram);
        }
        /// <summary>
        ///     Get Ratio from DecigramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromDecigramsPerGram(double decigramspergram)
        {
            double value = (double)decigramspergram;
            return new Ratio(value, RatioUnit.DecigramPerGram);
        }
        /// <summary>
        ///     Get Ratio from DecigramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromDecigramsPerKilogram(double decigramsperkilogram)
        {
            double value = (double)decigramsperkilogram;
            return new Ratio(value, RatioUnit.DecigramPerKilogram);
        }
        
        /// <summary>
        ///     Get Ratio from GramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromGramsPerGram(double gramspergram)
        {
            double value = (double)gramspergram;
            return new Ratio(value, RatioUnit.GramPerGram);
        }
        /// <summary>
        ///     Get Ratio from GramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromGramsPerKilogram(double gramsperkilogram)
        {
            double value = (double)gramsperkilogram;
            return new Ratio(value, RatioUnit.GramPerKilogram);
        }
        /// <summary>
        ///     Get Ratio from HectogramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromHectogramsPerGram(double hectogramspergram)
        {
            double value = (double)hectogramspergram;
            return new Ratio(value, RatioUnit.HectogramPerGram);
        }
        /// <summary>
        ///     Get Ratio from HectogramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromHectogramsPerKilogram(double hectogramsperkilogram)
        {
            double value = (double)hectogramsperkilogram;
            return new Ratio(value, RatioUnit.HectogramPerKilogram);
        }
        /// <summary>
        ///     Get Ratio from KilogramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromKilogramsPerGram(double kilogramspergram)
        {
            double value = (double)kilogramspergram;
            return new Ratio(value, RatioUnit.KilogramPerGram);
        }
        /// <summary>
        ///     Get Ratio from KilogramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromKilogramsPerKilogram(double kilogramsperkilogram)
        {
            double value = (double)kilogramsperkilogram;
            return new Ratio(value, RatioUnit.KilogramPerKilogram);
        }
        /// <summary>
        ///     Get Ratio from MicrogramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromMicrogramsPerGram(double microgramspergram)
        {
            double value = (double)microgramspergram;
            return new Ratio(value, RatioUnit.MicrogramPerGram);
        }
        /// <summary>
        ///     Get Ratio from MicrogramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromMicrogramsPerKilogram(double microgramsperkilogram)
        {
            double value = (double)microgramsperkilogram;
            return new Ratio(value, RatioUnit.MicrogramPerKilogram);
        }
        /// <summary>
        ///     Get Ratio from MilligramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromMilligramsPerGram(double milligramspergram)
        {
            double value = (double)milligramspergram;
            return new Ratio(value, RatioUnit.MilligramPerGram);
        }
        /// <summary>
        ///     Get Ratio from MilligramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromMilligramsPerKilogram(double milligramsperkilogram)
        {
            double value = (double)milligramsperkilogram;
            return new Ratio(value, RatioUnit.MilligramPerKilogram);
        }
        /// <summary>
        ///     Get Ratio from NanogramsPerGram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromNanogramsPerGram(double nanogramspergram)
        {
            double value = (double)nanogramspergram;
            return new Ratio(value, RatioUnit.NanogramPerGram);
        }
        /// <summary>
        ///     Get Ratio from NanogramsPerKilogram.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Ratio FromNanogramsPerKilogram(double nanogramsperkilogram)
        {
            double value = (double)nanogramsperkilogram;
            return new Ratio(value, RatioUnit.NanogramPerKilogram);
        }


    }
}
