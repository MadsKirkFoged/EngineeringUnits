
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Density
    {

 

            /// <summary>
            ///     Get Density from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromSI(double SI)
            {
                double value= (double)SI;
                return new Density(value, DensityUnit.SI);
            }
            /// <summary>
            ///     Get Density from CentigramPerDeciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromCentigramPerDeciliter(double CentigramPerDeciliter)
            {
                double value= (double)CentigramPerDeciliter;
                return new Density(value, DensityUnit.CentigramPerDeciliter);
            }
            /// <summary>
            ///     Get Density from CentigramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromCentigramPerLiter(double CentigramPerLiter)
            {
                double value= (double)CentigramPerLiter;
                return new Density(value, DensityUnit.CentigramPerLiter);
            }
            /// <summary>
            ///     Get Density from CentigramPerMilliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromCentigramPerMilliliter(double CentigramPerMilliliter)
            {
                double value= (double)CentigramPerMilliliter;
                return new Density(value, DensityUnit.CentigramPerMilliliter);
            }
            /// <summary>
            ///     Get Density from DecigramPerDeciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromDecigramPerDeciliter(double DecigramPerDeciliter)
            {
                double value= (double)DecigramPerDeciliter;
                return new Density(value, DensityUnit.DecigramPerDeciliter);
            }
            /// <summary>
            ///     Get Density from DecigramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromDecigramPerLiter(double DecigramPerLiter)
            {
                double value= (double)DecigramPerLiter;
                return new Density(value, DensityUnit.DecigramPerLiter);
            }
            /// <summary>
            ///     Get Density from DecigramPerMilliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromDecigramPerMilliliter(double DecigramPerMilliliter)
            {
                double value= (double)DecigramPerMilliliter;
                return new Density(value, DensityUnit.DecigramPerMilliliter);
            }
            /// <summary>
            ///     Get Density from DecigramPerMicroliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromDecigramPerMicroliter(double DecigramPerMicroliter)
            {
                double value= (double)DecigramPerMicroliter;
                return new Density(value, DensityUnit.DecigramPerMicroliter);
            }
            /// <summary>
            ///     Get Density from GramPerCubicCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromGramPerCubicCentimeter(double GramPerCubicCentimeter)
            {
                double value= (double)GramPerCubicCentimeter;
                return new Density(value, DensityUnit.GramPerCubicCentimeter);
            }
            /// <summary>
            ///     Get Density from GramPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromGramPerCubicMeter(double GramPerCubicMeter)
            {
                double value= (double)GramPerCubicMeter;
                return new Density(value, DensityUnit.GramPerCubicMeter);
            }
            /// <summary>
            ///     Get Density from GramPerCubicMillimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromGramPerCubicMillimeter(double GramPerCubicMillimeter)
            {
                double value= (double)GramPerCubicMillimeter;
                return new Density(value, DensityUnit.GramPerCubicMillimeter);
            }
            /// <summary>
            ///     Get Density from GramPerDeciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromGramPerDeciliter(double GramPerDeciliter)
            {
                double value= (double)GramPerDeciliter;
                return new Density(value, DensityUnit.GramPerDeciliter);
            }
            /// <summary>
            ///     Get Density from GramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromGramPerLiter(double GramPerLiter)
            {
                double value= (double)GramPerLiter;
                return new Density(value, DensityUnit.GramPerLiter);
            }
            /// <summary>
            ///     Get Density from GramPerMilliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromGramPerMilliliter(double GramPerMilliliter)
            {
                double value= (double)GramPerMilliliter;
                return new Density(value, DensityUnit.GramPerMilliliter);
            }
            /// <summary>
            ///     Get Density from GramPerMicroliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromGramPerMicroliter(double GramPerMicroliter)
            {
                double value= (double)GramPerMicroliter;
                return new Density(value, DensityUnit.GramPerMicroliter);
            }
            /// <summary>
            ///     Get Density from KilogramPerCubicCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromKilogramPerCubicCentimeter(double KilogramPerCubicCentimeter)
            {
                double value= (double)KilogramPerCubicCentimeter;
                return new Density(value, DensityUnit.KilogramPerCubicCentimeter);
            }
            /// <summary>
            ///     Get Density from KilogramPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromKilogramPerCubicMeter(double KilogramPerCubicMeter)
            {
                double value= (double)KilogramPerCubicMeter;
                return new Density(value, DensityUnit.KilogramPerCubicMeter);
            }
            /// <summary>
            ///     Get Density from KilogramPerCubicMillimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromKilogramPerCubicMillimeter(double KilogramPerCubicMillimeter)
            {
                double value= (double)KilogramPerCubicMillimeter;
                return new Density(value, DensityUnit.KilogramPerCubicMillimeter);
            }
            /// <summary>
            ///     Get Density from KilogramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromKilogramPerLiter(double KilogramPerLiter)
            {
                double value= (double)KilogramPerLiter;
                return new Density(value, DensityUnit.KilogramPerLiter);
            }
            /// <summary>
            ///     Get Density from KilopoundPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromKilopoundPerCubicFoot(double KilopoundPerCubicFoot)
            {
                double value= (double)KilopoundPerCubicFoot;
                return new Density(value, DensityUnit.KilopoundPerCubicFoot);
            }
            /// <summary>
            ///     Get Density from KilopoundPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromKilopoundPerCubicInch(double KilopoundPerCubicInch)
            {
                double value= (double)KilopoundPerCubicInch;
                return new Density(value, DensityUnit.KilopoundPerCubicInch);
            }
            /// <summary>
            ///     Get Density from MicrogramPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMicrogramPerCubicMeter(double MicrogramPerCubicMeter)
            {
                double value= (double)MicrogramPerCubicMeter;
                return new Density(value, DensityUnit.MicrogramPerCubicMeter);
            }
            /// <summary>
            ///     Get Density from MicrogramPerDeciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMicrogramPerDeciliter(double MicrogramPerDeciliter)
            {
                double value= (double)MicrogramPerDeciliter;
                return new Density(value, DensityUnit.MicrogramPerDeciliter);
            }
            /// <summary>
            ///     Get Density from MicrogramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMicrogramPerLiter(double MicrogramPerLiter)
            {
                double value= (double)MicrogramPerLiter;
                return new Density(value, DensityUnit.MicrogramPerLiter);
            }
            /// <summary>
            ///     Get Density from MicrogramPerMilliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMicrogramPerMilliliter(double MicrogramPerMilliliter)
            {
                double value= (double)MicrogramPerMilliliter;
                return new Density(value, DensityUnit.MicrogramPerMilliliter);
            }
            /// <summary>
            ///     Get Density from MicrogramPerMicroliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMicrogramPerMicroliter(double MicrogramPerMicroliter)
            {
                double value= (double)MicrogramPerMicroliter;
                return new Density(value, DensityUnit.MicrogramPerMicroliter);
            }
            /// <summary>
            ///     Get Density from MilligramPerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMilligramPerCubicMeter(double MilligramPerCubicMeter)
            {
                double value= (double)MilligramPerCubicMeter;
                return new Density(value, DensityUnit.MilligramPerCubicMeter);
            }
            /// <summary>
            ///     Get Density from MilligramPerDeciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMilligramPerDeciliter(double MilligramPerDeciliter)
            {
                double value= (double)MilligramPerDeciliter;
                return new Density(value, DensityUnit.MilligramPerDeciliter);
            }
            /// <summary>
            ///     Get Density from MilligramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMilligramPerLiter(double MilligramPerLiter)
            {
                double value= (double)MilligramPerLiter;
                return new Density(value, DensityUnit.MilligramPerLiter);
            }
            /// <summary>
            ///     Get Density from MilligramPerMilliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMilligramPerMilliliter(double MilligramPerMilliliter)
            {
                double value= (double)MilligramPerMilliliter;
                return new Density(value, DensityUnit.MilligramPerMilliliter);
            }
            /// <summary>
            ///     Get Density from MilligramPerMicroliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromMilligramPerMicroliter(double MilligramPerMicroliter)
            {
                double value= (double)MilligramPerMicroliter;
                return new Density(value, DensityUnit.MilligramPerMicroliter);
            }
            /// <summary>
            ///     Get Density from NanogramPerDeciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromNanogramPerDeciliter(double NanogramPerDeciliter)
            {
                double value= (double)NanogramPerDeciliter;
                return new Density(value, DensityUnit.NanogramPerDeciliter);
            }
            /// <summary>
            ///     Get Density from NanogramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromNanogramPerLiter(double NanogramPerLiter)
            {
                double value= (double)NanogramPerLiter;
                return new Density(value, DensityUnit.NanogramPerLiter);
            }
            /// <summary>
            ///     Get Density from NanogramPerMilliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromNanogramPerMilliliter(double NanogramPerMilliliter)
            {
                double value= (double)NanogramPerMilliliter;
                return new Density(value, DensityUnit.NanogramPerMilliliter);
            }
            /// <summary>
            ///     Get Density from NanogramPerMicroliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromNanogramPerMicroliter(double NanogramPerMicroliter)
            {
                double value= (double)NanogramPerMicroliter;
                return new Density(value, DensityUnit.NanogramPerMicroliter);
            }
            /// <summary>
            ///     Get Density from PicogramPerDeciliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPicogramPerDeciliter(double PicogramPerDeciliter)
            {
                double value= (double)PicogramPerDeciliter;
                return new Density(value, DensityUnit.PicogramPerDeciliter);
            }
            /// <summary>
            ///     Get Density from PicogramPerLiter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPicogramPerLiter(double PicogramPerLiter)
            {
                double value= (double)PicogramPerLiter;
                return new Density(value, DensityUnit.PicogramPerLiter);
            }
            /// <summary>
            ///     Get Density from PicogramPerMilliliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPicogramPerMilliliter(double PicogramPerMilliliter)
            {
                double value= (double)PicogramPerMilliliter;
                return new Density(value, DensityUnit.PicogramPerMilliliter);
            }
            /// <summary>
            ///     Get Density from PicogramPerMicroliter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPicogramPerMicroliter(double PicogramPerMicroliter)
            {
                double value= (double)PicogramPerMicroliter;
                return new Density(value, DensityUnit.PicogramPerMicroliter);
            }
            /// <summary>
            ///     Get Density from PoundPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPoundPerCubicFoot(double PoundPerCubicFoot)
            {
                double value= (double)PoundPerCubicFoot;
                return new Density(value, DensityUnit.PoundPerCubicFoot);
            }
            /// <summary>
            ///     Get Density from PoundPerCubicInch.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPoundPerCubicInch(double PoundPerCubicInch)
            {
                double value= (double)PoundPerCubicInch;
                return new Density(value, DensityUnit.PoundPerCubicInch);
            }
            /// <summary>
            ///     Get Density from PoundPerImperialGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPoundPerImperialGallon(double PoundPerImperialGallon)
            {
                double value= (double)PoundPerImperialGallon;
                return new Density(value, DensityUnit.PoundPerImperialGallon);
            }
            /// <summary>
            ///     Get Density from PoundPerUSGallon.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromPoundPerUSGallon(double PoundPerUSGallon)
            {
                double value= (double)PoundPerUSGallon;
                return new Density(value, DensityUnit.PoundPerUSGallon);
            }
            /// <summary>
            ///     Get Density from SlugPerCubicFoot.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromSlugPerCubicFoot(double SlugPerCubicFoot)
            {
                double value= (double)SlugPerCubicFoot;
                return new Density(value, DensityUnit.SlugPerCubicFoot);
            }
            /// <summary>
            ///     Get Density from TonnePerCubicCentimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromTonnePerCubicCentimeter(double TonnePerCubicCentimeter)
            {
                double value= (double)TonnePerCubicCentimeter;
                return new Density(value, DensityUnit.TonnePerCubicCentimeter);
            }
            /// <summary>
            ///     Get Density from TonnePerCubicMeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromTonnePerCubicMeter(double TonnePerCubicMeter)
            {
                double value= (double)TonnePerCubicMeter;
                return new Density(value, DensityUnit.TonnePerCubicMeter);
            }
            /// <summary>
            ///     Get Density from TonnePerCubicMillimeter.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static Density FromTonnePerCubicMillimeter(double TonnePerCubicMillimeter)
            {
                double value= (double)TonnePerCubicMillimeter;
                return new Density(value, DensityUnit.TonnePerCubicMillimeter);
            }
    }
}


