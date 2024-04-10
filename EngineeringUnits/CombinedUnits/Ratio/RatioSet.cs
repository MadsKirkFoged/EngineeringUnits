using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class Ratio
{

    /// <summary>
    /// Get Ratio from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static Ratio? FromSI(double? SI)
    {
        if (SI is null)
            return null;
        
        return new Ratio((double)SI, RatioUnit.SI);
    }
    /// <summary>
    /// Get Ratio from DecimalFraction.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecimalFraction))]
    public static Ratio? FromDecimalFraction(double? DecimalFraction)
    {
        if (DecimalFraction is null)
            return null;
        
        return new Ratio((double)DecimalFraction, RatioUnit.DecimalFraction);
    }
    /// <summary>
    /// Get Ratio from PartPerBillion.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PartPerBillion))]
    public static Ratio? FromPartPerBillion(double? PartPerBillion)
    {
        if (PartPerBillion is null)
            return null;
        
        return new Ratio((double)PartPerBillion, RatioUnit.PartPerBillion);
    }
    /// <summary>
    /// Get Ratio from PartPerMillion.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PartPerMillion))]
    public static Ratio? FromPartPerMillion(double? PartPerMillion)
    {
        if (PartPerMillion is null)
            return null;
        
        return new Ratio((double)PartPerMillion, RatioUnit.PartPerMillion);
    }
    /// <summary>
    /// Get Ratio from PartPerThousand.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PartPerThousand))]
    public static Ratio? FromPartPerThousand(double? PartPerThousand)
    {
        if (PartPerThousand is null)
            return null;
        
        return new Ratio((double)PartPerThousand, RatioUnit.PartPerThousand);
    }
    /// <summary>
    /// Get Ratio from PartPerTrillion.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PartPerTrillion))]
    public static Ratio? FromPartPerTrillion(double? PartPerTrillion)
    {
        if (PartPerTrillion is null)
            return null;
        
        return new Ratio((double)PartPerTrillion, RatioUnit.PartPerTrillion);
    }
    /// <summary>
    /// Get Ratio from Percent.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Percent))]
    public static Ratio? FromPercent(double? Percent)
    {
        if (Percent is null)
            return null;
        
        return new Ratio((double)Percent, RatioUnit.Percent);
    }
    /// <summary>
    /// Get Ratio from CentigramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CentigramPerGram))]
    public static Ratio? FromCentigramPerGram(double? CentigramPerGram)
    {
        if (CentigramPerGram is null)
            return null;
        
        return new Ratio((double)CentigramPerGram, RatioUnit.CentigramPerGram);
    }
    /// <summary>
    /// Get Ratio from CentigramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CentigramPerKilogram))]
    public static Ratio? FromCentigramPerKilogram(double? CentigramPerKilogram)
    {
        if (CentigramPerKilogram is null)
            return null;
        
        return new Ratio((double)CentigramPerKilogram, RatioUnit.CentigramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from DecagramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecagramPerGram))]
    public static Ratio? FromDecagramPerGram(double? DecagramPerGram)
    {
        if (DecagramPerGram is null)
            return null;
        
        return new Ratio((double)DecagramPerGram, RatioUnit.DecagramPerGram);
    }
    /// <summary>
    /// Get Ratio from DecagramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecagramPerKilogram))]
    public static Ratio? FromDecagramPerKilogram(double? DecagramPerKilogram)
    {
        if (DecagramPerKilogram is null)
            return null;
        
        return new Ratio((double)DecagramPerKilogram, RatioUnit.DecagramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from DecigramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecigramPerGram))]
    public static Ratio? FromDecigramPerGram(double? DecigramPerGram)
    {
        if (DecigramPerGram is null)
            return null;
        
        return new Ratio((double)DecigramPerGram, RatioUnit.DecigramPerGram);
    }
    /// <summary>
    /// Get Ratio from DecigramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecigramPerKilogram))]
    public static Ratio? FromDecigramPerKilogram(double? DecigramPerKilogram)
    {
        if (DecigramPerKilogram is null)
            return null;
        
        return new Ratio((double)DecigramPerKilogram, RatioUnit.DecigramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from GramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GramPerGram))]
    public static Ratio? FromGramPerGram(double? GramPerGram)
    {
        if (GramPerGram is null)
            return null;
        
        return new Ratio((double)GramPerGram, RatioUnit.GramPerGram);
    }
    /// <summary>
    /// Get Ratio from GramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(GramPerKilogram))]
    public static Ratio? FromGramPerKilogram(double? GramPerKilogram)
    {
        if (GramPerKilogram is null)
            return null;
        
        return new Ratio((double)GramPerKilogram, RatioUnit.GramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from HectogramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(HectogramPerGram))]
    public static Ratio? FromHectogramPerGram(double? HectogramPerGram)
    {
        if (HectogramPerGram is null)
            return null;
        
        return new Ratio((double)HectogramPerGram, RatioUnit.HectogramPerGram);
    }
    /// <summary>
    /// Get Ratio from HectogramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(HectogramPerKilogram))]
    public static Ratio? FromHectogramPerKilogram(double? HectogramPerKilogram)
    {
        if (HectogramPerKilogram is null)
            return null;
        
        return new Ratio((double)HectogramPerKilogram, RatioUnit.HectogramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from KilogramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilogramPerGram))]
    public static Ratio? FromKilogramPerGram(double? KilogramPerGram)
    {
        if (KilogramPerGram is null)
            return null;
        
        return new Ratio((double)KilogramPerGram, RatioUnit.KilogramPerGram);
    }
    /// <summary>
    /// Get Ratio from KilogramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(KilogramPerKilogram))]
    public static Ratio? FromKilogramPerKilogram(double? KilogramPerKilogram)
    {
        if (KilogramPerKilogram is null)
            return null;
        
        return new Ratio((double)KilogramPerKilogram, RatioUnit.KilogramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from MicrogramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicrogramPerGram))]
    public static Ratio? FromMicrogramPerGram(double? MicrogramPerGram)
    {
        if (MicrogramPerGram is null)
            return null;
        
        return new Ratio((double)MicrogramPerGram, RatioUnit.MicrogramPerGram);
    }
    /// <summary>
    /// Get Ratio from MicrogramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicrogramPerKilogram))]
    public static Ratio? FromMicrogramPerKilogram(double? MicrogramPerKilogram)
    {
        if (MicrogramPerKilogram is null)
            return null;
        
        return new Ratio((double)MicrogramPerKilogram, RatioUnit.MicrogramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from MilligramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MilligramPerGram))]
    public static Ratio? FromMilligramPerGram(double? MilligramPerGram)
    {
        if (MilligramPerGram is null)
            return null;
        
        return new Ratio((double)MilligramPerGram, RatioUnit.MilligramPerGram);
    }
    /// <summary>
    /// Get Ratio from MilligramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MilligramPerKilogram))]
    public static Ratio? FromMilligramPerKilogram(double? MilligramPerKilogram)
    {
        if (MilligramPerKilogram is null)
            return null;
        
        return new Ratio((double)MilligramPerKilogram, RatioUnit.MilligramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from NanogramPerGram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(NanogramPerGram))]
    public static Ratio? FromNanogramPerGram(double? NanogramPerGram)
    {
        if (NanogramPerGram is null)
            return null;
        
        return new Ratio((double)NanogramPerGram, RatioUnit.NanogramPerGram);
    }
    /// <summary>
    /// Get Ratio from NanogramPerKilogram.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(NanogramPerKilogram))]
    public static Ratio? FromNanogramPerKilogram(double? NanogramPerKilogram)
    {
        if (NanogramPerKilogram is null)
            return null;
        
        return new Ratio((double)NanogramPerKilogram, RatioUnit.NanogramPerKilogram);
    }
    /// <summary>
    /// Get Ratio from CentilitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CentilitersPerLiter))]
    public static Ratio? FromCentilitersPerLiter(double? CentilitersPerLiter)
    {
        if (CentilitersPerLiter is null)
            return null;
        
        return new Ratio((double)CentilitersPerLiter, RatioUnit.CentilitersPerLiter);
    }
    /// <summary>
    /// Get Ratio from CentilitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(CentilitersPerMililiter))]
    public static Ratio? FromCentilitersPerMililiter(double? CentilitersPerMililiter)
    {
        if (CentilitersPerMililiter is null)
            return null;
        
        return new Ratio((double)CentilitersPerMililiter, RatioUnit.CentilitersPerMililiter);
    }
    /// <summary>
    /// Get Ratio from DecilitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecilitersPerLiter))]
    public static Ratio? FromDecilitersPerLiter(double? DecilitersPerLiter)
    {
        if (DecilitersPerLiter is null)
            return null;
        
        return new Ratio((double)DecilitersPerLiter, RatioUnit.DecilitersPerLiter);
    }
    /// <summary>
    /// Get Ratio from DecilitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(DecilitersPerMililiter))]
    public static Ratio? FromDecilitersPerMililiter(double? DecilitersPerMililiter)
    {
        if (DecilitersPerMililiter is null)
            return null;
        
        return new Ratio((double)DecilitersPerMililiter, RatioUnit.DecilitersPerMililiter);
    }
    /// <summary>
    /// Get Ratio from LitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(LitersPerLiter))]
    public static Ratio? FromLitersPerLiter(double? LitersPerLiter)
    {
        if (LitersPerLiter is null)
            return null;
        
        return new Ratio((double)LitersPerLiter, RatioUnit.LitersPerLiter);
    }
    /// <summary>
    /// Get Ratio from LitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(LitersPerMililiter))]
    public static Ratio? FromLitersPerMililiter(double? LitersPerMililiter)
    {
        if (LitersPerMililiter is null)
            return null;
        
        return new Ratio((double)LitersPerMililiter, RatioUnit.LitersPerMililiter);
    }
    /// <summary>
    /// Get Ratio from MicrolitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicrolitersPerLiter))]
    public static Ratio? FromMicrolitersPerLiter(double? MicrolitersPerLiter)
    {
        if (MicrolitersPerLiter is null)
            return null;
        
        return new Ratio((double)MicrolitersPerLiter, RatioUnit.MicrolitersPerLiter);
    }
    /// <summary>
    /// Get Ratio from MicrolitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MicrolitersPerMililiter))]
    public static Ratio? FromMicrolitersPerMililiter(double? MicrolitersPerMililiter)
    {
        if (MicrolitersPerMililiter is null)
            return null;
        
        return new Ratio((double)MicrolitersPerMililiter, RatioUnit.MicrolitersPerMililiter);
    }
    /// <summary>
    /// Get Ratio from MillilitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MillilitersPerLiter))]
    public static Ratio? FromMillilitersPerLiter(double? MillilitersPerLiter)
    {
        if (MillilitersPerLiter is null)
            return null;
        
        return new Ratio((double)MillilitersPerLiter, RatioUnit.MillilitersPerLiter);
    }
    /// <summary>
    /// Get Ratio from MillilitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(MillilitersPerMililiter))]
    public static Ratio? FromMillilitersPerMililiter(double? MillilitersPerMililiter)
    {
        if (MillilitersPerMililiter is null)
            return null;
        
        return new Ratio((double)MillilitersPerMililiter, RatioUnit.MillilitersPerMililiter);
    }
    /// <summary>
    /// Get Ratio from NanolitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(NanolitersPerLiter))]
    public static Ratio? FromNanolitersPerLiter(double? NanolitersPerLiter)
    {
        if (NanolitersPerLiter is null)
            return null;
        
        return new Ratio((double)NanolitersPerLiter, RatioUnit.NanolitersPerLiter);
    }
    /// <summary>
    /// Get Ratio from NanolitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(NanolitersPerMililiter))]
    public static Ratio? FromNanolitersPerMililiter(double? NanolitersPerMililiter)
    {
        if (NanolitersPerMililiter is null)
            return null;
        
        return new Ratio((double)NanolitersPerMililiter, RatioUnit.NanolitersPerMililiter);
    }
    /// <summary>
    /// Get Ratio from PicolitersPerLiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PicolitersPerLiter))]
    public static Ratio? FromPicolitersPerLiter(double? PicolitersPerLiter)
    {
        if (PicolitersPerLiter is null)
            return null;
        
        return new Ratio((double)PicolitersPerLiter, RatioUnit.PicolitersPerLiter);
    }
    /// <summary>
    /// Get Ratio from PicolitersPerMililiter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(PicolitersPerMililiter))]
    public static Ratio? FromPicolitersPerMililiter(double? PicolitersPerMililiter)
    {
        if (PicolitersPerMililiter is null)
            return null;
        
        return new Ratio((double)PicolitersPerMililiter, RatioUnit.PicolitersPerMililiter);
    }

}