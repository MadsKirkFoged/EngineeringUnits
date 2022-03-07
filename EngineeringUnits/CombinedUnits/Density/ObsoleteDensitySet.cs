using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Density
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Density FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new Density(value, DensityUnit.SI);
        //}

        /// <summary>
        ///     Get Density from CentigramsPerDeciLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentigramsPerDeciLiter->FromCentigramPerDeciLiter")]
        public static Density FromCentigramsPerDeciLiter(double centigramsperdeciliter)
        {
            double value = (double)centigramsperdeciliter;
            return new Density(value, DensityUnit.CentigramPerDeciliter);
        }
        /// <summary>
        ///     Get Density from CentigramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentigramsPerLiter->FromCentigramPerLiter")]
        public static Density FromCentigramsPerLiter(double centigramsperliter)
        {
            double value = (double)centigramsperliter;
            return new Density(value, DensityUnit.CentigramPerLiter);
        }
        /// <summary>
        ///     Get Density from CentigramsPerMilliliter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromCentigramsPerMilliliter->FromCentigramPerMilliliter")]
        public static Density FromCentigramsPerMilliliter(double centigramspermilliliter)
        {
            double value = (double)centigramspermilliliter;
            return new Density(value, DensityUnit.CentigramPerMilliliter);
        }
        /// <summary>
        ///     Get Density from DecigramsPerDeciLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecigramsPerDeciLiter->FromDecigramPerDeciLiter")]
        public static Density FromDecigramsPerDeciLiter(double decigramsperdeciliter)
        {
            double value = (double)decigramsperdeciliter;
            return new Density(value, DensityUnit.DecigramPerDeciliter);
        }
        /// <summary>
        ///     Get Density from DecigramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecigramsPerLiter->FromDecigramPerLiter")]
        public static Density FromDecigramsPerLiter(double decigramsperliter)
        {
            double value = (double)decigramsperliter;
            return new Density(value, DensityUnit.DecigramPerLiter);
        }
        /// <summary>
        ///     Get Density from DecigramsPerMilliliter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromDecigramsPerMilliliter->FromDecigramPerMilliliter")]
        public static Density FromDecigramsPerMilliliter(double decigramspermilliliter)
        {
            double value = (double)decigramspermilliliter;
            return new Density(value, DensityUnit.DecigramPerMilliliter);
        }
        /// <summary>
        ///     Get Density from GramsPerCubicCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerCubicCentimeter->FromGramPerCubicCentimeter")]
        public static Density FromGramsPerCubicCentimeter(double gramspercubiccentimeter)
        {
            double value = (double)gramspercubiccentimeter;
            return new Density(value, DensityUnit.GramPerCubicCentimeter);
        }
        /// <summary>
        ///     Get Density from GramsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerCubicMeter->FromGramPerCubicMeter")]
        public static Density FromGramsPerCubicMeter(double gramspercubicmeter)
        {
            double value = (double)gramspercubicmeter;
            return new Density(value, DensityUnit.GramPerCubicMeter);
        }
        /// <summary>
        ///     Get Density from GramsPerCubicMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerCubicMillimeter->FromGramPerCubicMillimeter")]
        public static Density FromGramsPerCubicMillimeter(double gramspercubicmillimeter)
        {
            double value = (double)gramspercubicmillimeter;
            return new Density(value, DensityUnit.GramPerCubicMillimeter);
        }
        /// <summary>
        ///     Get Density from GramsPerDeciLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerDeciLiter->FromGramPerDeciLiter")]
        public static Density FromGramsPerDeciLiter(double gramsperdeciliter)
        {
            double value = (double)gramsperdeciliter;
            return new Density(value, DensityUnit.GramPerDeciliter);
        }
        /// <summary>
        ///     Get Density from GramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerLiter->FromGramPerLiter")]
        public static Density FromGramsPerLiter(double gramsperliter)
        {
            double value = (double)gramsperliter;
            return new Density(value, DensityUnit.GramPerLiter);
        }
        /// <summary>
        ///     Get Density from GramsPerMilliliter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromGramsPerMilliliter->FromGramPerMilliliter")]
        public static Density FromGramsPerMilliliter(double gramspermilliliter)
        {
            double value = (double)gramspermilliliter;
            return new Density(value, DensityUnit.GramPerMilliliter);
        }
        /// <summary>
        ///     Get Density from KilogramsPerCubicCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerCubicCentimeter->FromKilogramPerCubicCentimeter")]
        public static Density FromKilogramsPerCubicCentimeter(double kilogramspercubiccentimeter)
        {
            double value = (double)kilogramspercubiccentimeter;
            return new Density(value, DensityUnit.KilogramPerCubicCentimeter);
        }
        /// <summary>
        ///     Get Density from KilogramsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerCubicMeter->FromKilogramPerCubicMeter")]
        public static Density FromKilogramsPerCubicMeter(double kilogramspercubicmeter)
        {
            double value = (double)kilogramspercubicmeter;
            return new Density(value, DensityUnit.KilogramPerCubicMeter);
        }
        /// <summary>
        ///     Get Density from KilogramsPerCubicMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerCubicMillimeter->FromKilogramPerCubicMillimeter")]
        public static Density FromKilogramsPerCubicMillimeter(double kilogramspercubicmillimeter)
        {
            double value = (double)kilogramspercubicmillimeter;
            return new Density(value, DensityUnit.KilogramPerCubicMillimeter);
        }
        /// <summary>
        ///     Get Density from KilogramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilogramsPerLiter->FromKilogramPerLiter")]
        public static Density FromKilogramsPerLiter(double kilogramsperliter)
        {
            double value = (double)kilogramsperliter;
            return new Density(value, DensityUnit.KilogramPerLiter);
        }
        /// <summary>
        ///     Get Density from KilopoundsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilopoundsPerCubicFoot->FromKilopoundPerCubicFoot")]
        public static Density FromKilopoundsPerCubicFoot(double kilopoundspercubicfoot)
        {
            double value = (double)kilopoundspercubicfoot;
            return new Density(value, DensityUnit.KilopoundPerCubicFoot);
        }
        /// <summary>
        ///     Get Density from KilopoundsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromKilopoundsPerCubicInch->FromKilopoundPerCubicInch")]
        public static Density FromKilopoundsPerCubicInch(double kilopoundspercubicinch)
        {
            double value = (double)kilopoundspercubicinch;
            return new Density(value, DensityUnit.KilopoundPerCubicInch);
        }
        /// <summary>
        ///     Get Density from MicrogramsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrogramsPerCubicMeter->FromMicrogramPerCubicMeter")]
        public static Density FromMicrogramsPerCubicMeter(double microgramspercubicmeter)
        {
            double value = (double)microgramspercubicmeter;
            return new Density(value, DensityUnit.MicrogramPerCubicMeter);
        }
        /// <summary>
        ///     Get Density from MicrogramsPerDeciLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrogramsPerDeciLiter->FromMicrogramPerDeciLiter")]
        public static Density FromMicrogramsPerDeciLiter(double microgramsperdeciliter)
        {
            double value = (double)microgramsperdeciliter;
            return new Density(value, DensityUnit.MicrogramPerDeciliter);
        }
        /// <summary>
        ///     Get Density from MicrogramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrogramsPerLiter->FromMicrogramPerLiter")]
        public static Density FromMicrogramsPerLiter(double microgramsperliter)
        {
            double value = (double)microgramsperliter;
            return new Density(value, DensityUnit.MicrogramPerLiter);
        }
        /// <summary>
        ///     Get Density from MicrogramsPerMilliliter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMicrogramsPerMilliliter->FromMicrogramPerMilliliter")]
        public static Density FromMicrogramsPerMilliliter(double microgramspermilliliter)
        {
            double value = (double)microgramspermilliliter;
            return new Density(value, DensityUnit.MicrogramPerMilliliter);
        }
        /// <summary>
        ///     Get Density from MilligramsPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramsPerCubicMeter->FromMilligramPerCubicMeter")]
        public static Density FromMilligramsPerCubicMeter(double milligramspercubicmeter)
        {
            double value = (double)milligramspercubicmeter;
            return new Density(value, DensityUnit.MilligramPerCubicMeter);
        }
        /// <summary>
        ///     Get Density from MilligramsPerDeciLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramsPerDeciLiter->FromMilligramPerDeciLiter")]
        public static Density FromMilligramsPerDeciLiter(double milligramsperdeciliter)
        {
            double value = (double)milligramsperdeciliter;
            return new Density(value, DensityUnit.MilligramPerDeciliter);
        }
        /// <summary>
        ///     Get Density from MilligramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramsPerLiter->FromMilligramPerLiter")]
        public static Density FromMilligramsPerLiter(double milligramsperliter)
        {
            double value = (double)milligramsperliter;
            return new Density(value, DensityUnit.MilligramPerLiter);
        }
        /// <summary>
        ///     Get Density from MilligramsPerMilliliter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromMilligramsPerMilliliter->FromMilligramPerMilliliter")]
        public static Density FromMilligramsPerMilliliter(double milligramspermilliliter)
        {
            double value = (double)milligramspermilliliter;
            return new Density(value, DensityUnit.MilligramPerMilliliter);
        }
        /// <summary>
        ///     Get Density from NanogramsPerDeciLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanogramsPerDeciLiter->FromNanogramPerDeciLiter")]
        public static Density FromNanogramsPerDeciLiter(double nanogramsperdeciliter)
        {
            double value = (double)nanogramsperdeciliter;
            return new Density(value, DensityUnit.NanogramPerDeciliter);
        }
        /// <summary>
        ///     Get Density from NanogramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanogramsPerLiter->FromNanogramPerLiter")]
        public static Density FromNanogramsPerLiter(double nanogramsperliter)
        {
            double value = (double)nanogramsperliter;
            return new Density(value, DensityUnit.NanogramPerLiter);
        }
        /// <summary>
        ///     Get Density from NanogramsPerMilliliter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromNanogramsPerMilliliter->FromNanogramPerMilliliter")]
        public static Density FromNanogramsPerMilliliter(double nanogramspermilliliter)
        {
            double value = (double)nanogramspermilliliter;
            return new Density(value, DensityUnit.NanogramPerMilliliter);
        }
        /// <summary>
        ///     Get Density from PicogramsPerDeciLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPicogramsPerDeciLiter->FromPicogramPerDeciLiter")]
        public static Density FromPicogramsPerDeciLiter(double picogramsperdeciliter)
        {
            double value = (double)picogramsperdeciliter;
            return new Density(value, DensityUnit.PicogramPerDeciliter);
        }
        /// <summary>
        ///     Get Density from PicogramsPerLiter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPicogramsPerLiter->FromPicogramPerLiter")]
        public static Density FromPicogramsPerLiter(double picogramsperliter)
        {
            double value = (double)picogramsperliter;
            return new Density(value, DensityUnit.PicogramPerLiter);
        }
        /// <summary>
        ///     Get Density from PicogramsPerMilliliter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPicogramsPerMilliliter->FromPicogramPerMilliliter")]
        public static Density FromPicogramsPerMilliliter(double picogramspermilliliter)
        {
            double value = (double)picogramspermilliliter;
            return new Density(value, DensityUnit.PicogramPerMilliliter);
        }
        /// <summary>
        ///     Get Density from PoundsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsPerCubicFoot->FromPoundPerCubicFoot")]
        public static Density FromPoundsPerCubicFoot(double poundspercubicfoot)
        {
            double value = (double)poundspercubicfoot;
            return new Density(value, DensityUnit.PoundPerCubicFoot);
        }
        /// <summary>
        ///     Get Density from PoundsPerCubicInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsPerCubicInch->FromPoundPerCubicInch")]
        public static Density FromPoundsPerCubicInch(double poundspercubicinch)
        {
            double value = (double)poundspercubicinch;
            return new Density(value, DensityUnit.PoundPerCubicInch);
        }
        /// <summary>
        ///     Get Density from PoundsPerImperialGallon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsPerImperialGallon->FromPoundPerImperialGallon")]
        public static Density FromPoundsPerImperialGallon(double poundsperimperialgallon)
        {
            double value = (double)poundsperimperialgallon;
            return new Density(value, DensityUnit.PoundPerImperialGallon);
        }
        /// <summary>
        ///     Get Density from PoundsPerUSGallon.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromPoundsPerUSGallon->FromPoundPerUSGallon")]
        public static Density FromPoundsPerUSGallon(double poundsperusgallon)
        {
            double value = (double)poundsperusgallon;
            return new Density(value, DensityUnit.PoundPerUSGallon);
        }
        /// <summary>
        ///     Get Density from SlugsPerCubicFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromSlugsPerCubicFoot->FromSlugPerCubicFoot")]
        public static Density FromSlugsPerCubicFoot(double slugspercubicfoot)
        {
            double value = (double)slugspercubicfoot;
            return new Density(value, DensityUnit.SlugPerCubicFoot);
        }
        /// <summary>
        ///     Get Density from TonnesPerCubicCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonnesPerCubicCentimeter->FromTonnePerCubicCentimeter")]
        public static Density FromTonnesPerCubicCentimeter(double tonnespercubiccentimeter)
        {
            double value = (double)tonnespercubiccentimeter;
            return new Density(value, DensityUnit.TonnePerCubicCentimeter);
        }
        /// <summary>
        ///     Get Density from TonnesPerCubicMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonnesPerCubicMeter->FromTonnePerCubicMeter")]
        public static Density FromTonnesPerCubicMeter(double tonnespercubicmeter)
        {
            double value = (double)tonnespercubicmeter;
            return new Density(value, DensityUnit.TonnePerCubicMeter);
        }
        /// <summary>
        ///     Get Density from TonnesPerCubicMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromTonnesPerCubicMillimeter->FromTonnePerCubicMillimeter")]
        public static Density FromTonnesPerCubicMillimeter(double tonnespercubicmillimeter)
        {
            double value = (double)tonnespercubicmillimeter;
            return new Density(value, DensityUnit.TonnePerCubicMillimeter);
        }

    }
}
