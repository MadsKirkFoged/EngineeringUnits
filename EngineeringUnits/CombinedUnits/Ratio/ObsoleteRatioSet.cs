using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Ratio
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Ratio(value, RatioUnit.SI);
    //}

    /// <summary>
    ///     Get Ratio from DecimalFractions.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecimalFractions->FromDecimalFraction")]
    public static Ratio FromDecimalFractions(double decimalfractions)
    {
        var value = (double)decimalfractions;
        return new Ratio(value, RatioUnit.DecimalFraction);
    }
    /// <summary>
    ///     Get Ratio from PartsPerBillion.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPartsPerBillion->FromPartPerBillion")]
    public static Ratio FromPartsPerBillion(double partsperbillion)
    {
        var value = (double)partsperbillion;
        return new Ratio(value, RatioUnit.PartPerBillion);
    }
    /// <summary>
    ///     Get Ratio from PartsPerMillion.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPartsPerMillion->FromPartPerMillion")]
    public static Ratio FromPartsPerMillion(double partspermillion)
    {
        var value = (double)partspermillion;
        return new Ratio(value, RatioUnit.PartPerMillion);
    }
    /// <summary>
    ///     Get Ratio from PartsPerThousand.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPartsPerThousand->FromPartPerThousand")]
    public static Ratio FromPartsPerThousand(double partsperthousand)
    {
        var value = (double)partsperthousand;
        return new Ratio(value, RatioUnit.PartPerThousand);
    }
    /// <summary>
    ///     Get Ratio from PartsPerTrillion.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPartsPerTrillion->FromPartPerTrillion")]
    public static Ratio FromPartsPerTrillion(double partspertrillion)
    {
        var value = (double)partspertrillion;
        return new Ratio(value, RatioUnit.PartPerTrillion);
    }
    /// <summary>
    ///     Get Ratio from Percent.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromPercent(double percent)
    //{
    //    double value = (double)percent;
    //    return new Ratio(value, RatioUnit.Percent);
    //}

    /// <summary>
    ///     Get Ratio from CentigramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentigramsPerGram->FromCentigramPerGram")]
    public static Ratio FromCentigramsPerGram(double centigramspergram)
    {
        var value = (double)centigramspergram;
        return new Ratio(value, RatioUnit.CentigramPerGram);
    }
    /// <summary>
    ///     Get Ratio from CentigramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentigramsPerKilogram->FromCentigramPerKilogram")]
    public static Ratio FromCentigramsPerKilogram(double centigramsperkilogram)
    {
        var value = (double)centigramsperkilogram;
        return new Ratio(value, RatioUnit.CentigramPerKilogram);
    }
    /// <summary>
    ///     Get Ratio from DecagramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecagramsPerGram->FromDecagramPerGram")]
    public static Ratio FromDecagramsPerGram(double decagramspergram)
    {
        var value = (double)decagramspergram;
        return new Ratio(value, RatioUnit.DecagramPerGram);
    }
    /// <summary>
    ///     Get Ratio from DecagramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecagramsPerKilogram->FromDecagramPerKilogram")]
    public static Ratio FromDecagramsPerKilogram(double decagramsperkilogram)
    {
        var value = (double)decagramsperkilogram;
        return new Ratio(value, RatioUnit.DecagramPerKilogram);
    }
    /// <summary>
    ///     Get Ratio from DecigramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecigramsPerGram->FromDecigramPerGram")]
    public static Ratio FromDecigramsPerGram(double decigramspergram)
    {
        var value = (double)decigramspergram;
        return new Ratio(value, RatioUnit.DecigramPerGram);
    }
    /// <summary>
    ///     Get Ratio from DecigramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecigramsPerKilogram->FromDecigramPerKilogram")]
    public static Ratio FromDecigramsPerKilogram(double decigramsperkilogram)
    {
        var value = (double)decigramsperkilogram;
        return new Ratio(value, RatioUnit.DecigramPerKilogram);
    }

    /// <summary>
    ///     Get Ratio from GramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerGram->FromGramPerGram")]
    public static Ratio FromGramsPerGram(double gramspergram)
    {
        var value = (double)gramspergram;
        return new Ratio(value, RatioUnit.GramPerGram);
    }
    /// <summary>
    ///     Get Ratio from GramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerKilogram->FromGramPerKilogram")]
    public static Ratio FromGramsPerKilogram(double gramsperkilogram)
    {
        var value = (double)gramsperkilogram;
        return new Ratio(value, RatioUnit.GramPerKilogram);
    }
    /// <summary>
    ///     Get Ratio from HectogramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectogramsPerGram->FromHectogramPerGram")]
    public static Ratio FromHectogramsPerGram(double hectogramspergram)
    {
        var value = (double)hectogramspergram;
        return new Ratio(value, RatioUnit.HectogramPerGram);
    }
    /// <summary>
    ///     Get Ratio from HectogramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectogramsPerKilogram->FromHectogramPerKilogram")]
    public static Ratio FromHectogramsPerKilogram(double hectogramsperkilogram)
    {
        var value = (double)hectogramsperkilogram;
        return new Ratio(value, RatioUnit.HectogramPerKilogram);
    }
    /// <summary>
    ///     Get Ratio from KilogramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerGram->FromKilogramPerGram")]
    public static Ratio FromKilogramsPerGram(double kilogramspergram)
    {
        var value = (double)kilogramspergram;
        return new Ratio(value, RatioUnit.KilogramPerGram);
    }
    /// <summary>
    ///     Get Ratio from KilogramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerKilogram->FromKilogramPerKilogram")]
    public static Ratio FromKilogramsPerKilogram(double kilogramsperkilogram)
    {
        var value = (double)kilogramsperkilogram;
        return new Ratio(value, RatioUnit.KilogramPerKilogram);
    }
    /// <summary>
    ///     Get Ratio from MicrogramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrogramsPerGram->FromMicrogramPerGram")]
    public static Ratio FromMicrogramsPerGram(double microgramspergram)
    {
        var value = (double)microgramspergram;
        return new Ratio(value, RatioUnit.MicrogramPerGram);
    }
    /// <summary>
    ///     Get Ratio from MicrogramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrogramsPerKilogram->FromMicrogramPerKilogram")]
    public static Ratio FromMicrogramsPerKilogram(double microgramsperkilogram)
    {
        var value = (double)microgramsperkilogram;
        return new Ratio(value, RatioUnit.MicrogramPerKilogram);
    }
    /// <summary>
    ///     Get Ratio from MilligramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligramsPerGram->FromMilligramPerGram")]
    public static Ratio FromMilligramsPerGram(double milligramspergram)
    {
        var value = (double)milligramspergram;
        return new Ratio(value, RatioUnit.MilligramPerGram);
    }
    /// <summary>
    ///     Get Ratio from MilligramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligramsPerKilogram->FromMilligramPerKilogram")]
    public static Ratio FromMilligramsPerKilogram(double milligramsperkilogram)
    {
        var value = (double)milligramsperkilogram;
        return new Ratio(value, RatioUnit.MilligramPerKilogram);
    }
    /// <summary>
    ///     Get Ratio from NanogramsPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanogramsPerGram->FromNanogramPerGram")]
    public static Ratio FromNanogramsPerGram(double nanogramspergram)
    {
        var value = (double)nanogramspergram;
        return new Ratio(value, RatioUnit.NanogramPerGram);
    }
    /// <summary>
    ///     Get Ratio from NanogramsPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanogramsPerKilogram->FromNanogramPerKilogram")]
    public static Ratio FromNanogramsPerKilogram(double nanogramsperkilogram)
    {
        var value = (double)nanogramsperkilogram;
        return new Ratio(value, RatioUnit.NanogramPerKilogram);
    }

    /// <summary>
    ///     Get Ratio from CentilitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromCentilitersPerLiter(double centilitersperliter)
    //{
    //    double value = (double)centilitersperliter;
    //    return new Ratio(value, RatioUnit.CentilitersPerLiter);
    //}
    /// <summary>
    ///     Get Ratio from CentilitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromCentilitersPerMililiter(double centiliterspermililiter)
    //{
    //    double value = (double)centiliterspermililiter;
    //    return new Ratio(value, RatioUnit.CentilitersPerMililiter);
    //}
    /// <summary>
    ///     Get Ratio from DecilitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromDecilitersPerLiter(double decilitersperliter)
    //{
    //    double value = (double)decilitersperliter;
    //    return new Ratio(value, RatioUnit.DecilitersPerLiter);
    //}
    /// <summary>
    ///     Get Ratio from DecilitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromDecilitersPerMililiter(double deciliterspermililiter)
    //{
    //    double value = (double)deciliterspermililiter;
    //    return new Ratio(value, RatioUnit.DecilitersPerMililiter);
    //}

    /// <summary>
    ///     Get Ratio from LitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromLitersPerLiter(double litersperliter)
    //{
    //    double value = (double)litersperliter;
    //    return new Ratio(value, RatioUnit.LitersPerLiter);
    //}
    /// <summary>
    ///     Get Ratio from LitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromLitersPerMililiter(double literspermililiter)
    //{
    //    double value = (double)literspermililiter;
    //    return new Ratio(value, RatioUnit.LitersPerMililiter);
    //}
    /// <summary>
    ///     Get Ratio from MicrolitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromMicrolitersPerLiter(double microlitersperliter)
    //{
    //    double value = (double)microlitersperliter;
    //    return new Ratio(value, RatioUnit.MicrolitersPerLiter);
    //}
    /// <summary>
    ///     Get Ratio from MicrolitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromMicrolitersPerMililiter(double microliterspermililiter)
    //{
    //    double value = (double)microliterspermililiter;
    //    return new Ratio(value, RatioUnit.MicrolitersPerMililiter);
    //}
    /// <summary>
    ///     Get Ratio from MillilitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromMillilitersPerLiter(double millilitersperliter)
    //{
    //    double value = (double)millilitersperliter;
    //    return new Ratio(value, RatioUnit.MillilitersPerLiter);
    //}
    /// <summary>
    ///     Get Ratio from MillilitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromMillilitersPerMililiter(double milliliterspermililiter)
    //{
    //    double value = (double)milliliterspermililiter;
    //    return new Ratio(value, RatioUnit.MillilitersPerMililiter);
    //}
    /// <summary>
    ///     Get Ratio from NanolitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromNanolitersPerLiter(double nanolitersperliter)
    //{
    //    double value = (double)nanolitersperliter;
    //    return new Ratio(value, RatioUnit.NanolitersPerLiter);
    //}
    /// <summary>
    ///     Get Ratio from NanolitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromNanolitersPerMililiter(double nanoliterspermililiter)
    //{
    //    double value = (double)nanoliterspermililiter;
    //    return new Ratio(value, RatioUnit.NanolitersPerMililiter);
    //}

    /// <summary>
    ///     Get Ratio from PicolitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromPicolitersPerLiter(double picolitersperliter)
    //{
    //    double value = (double)picolitersperliter;
    //    return new Ratio(value, RatioUnit.PicolitersPerLiter);
    //}
    /// <summary>
    ///     Get Ratio from PicolitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Ratio FromPicolitersPerMililiter(double picoliterspermililiter)
    //{
    //    double value = (double)picoliterspermililiter;
    //    return new Ratio(value, RatioUnit.PicolitersPerMililiter);
    //}
}
