using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Ratio
{
    /// <summary>
    ///     Get Ratio in DecimalFractions.
    /// </summary>
    [Obsolete("Use without the 's' - DecimalFractions->DecimalFraction")]
    public double DecimalFractions => As(RatioUnit.DecimalFraction);

    /// <summary>
    ///     Get Ratio in PartsPerBillion.
    /// </summary>
    [Obsolete("Use without the 's' - PartsPerBillion->PartPerBillion")]
    public double PartsPerBillion => As(RatioUnit.PartPerBillion);

    /// <summary>
    ///     Get Ratio in PartsPerMillion.
    /// </summary>
    [Obsolete("Use without the 's' - PartsPerMillion->PartPerMillion")]
    public double PartsPerMillion => As(RatioUnit.PartPerMillion);

    /// <summary>
    ///     Get Ratio in PartsPerThousand.
    /// </summary>
    [Obsolete("Use without the 's' - PartsPerThousand->PartPerThousand")]
    public double PartsPerThousand => As(RatioUnit.PartPerThousand);

    /// <summary>
    ///     Get Ratio in PartsPerTrillion.
    /// </summary>
    [Obsolete("Use without the 's' - PartsPerTrillion->PartPerTrillion")]
    public double PartsPerTrillion => As(RatioUnit.PartPerTrillion);

    /// <summary>
    ///     Get Ratio in Percent.
    /// </summary>
    //public double Percent => As(RatioUnit.Percent);

    /// <summary>
    ///     Get MassFraction in CentigramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - CentigramsPerGram->CentigramPerGram")]
    public double CentigramsPerGram => As(RatioUnit.CentigramPerGram);

    /// <summary>
    ///     Get MassFraction in CentigramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - CentigramsPerKilogram->CentigramPerKilogram")]
    public double CentigramsPerKilogram => As(RatioUnit.CentigramPerKilogram);

    /// <summary>
    ///     Get MassFraction in DecagramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - DecagramsPerGram->DecagramPerGram")]
    public double DecagramsPerGram => As(RatioUnit.DecagramPerGram);

    /// <summary>
    ///     Get MassFraction in DecagramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - DecagramsPerKilogram->DecagramPerKilogram")]
    public double DecagramsPerKilogram => As(RatioUnit.DecagramPerKilogram);

    /// <summary>
    ///     Get MassFraction in DecigramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - DecigramsPerGram->DecigramPerGram")]
    public double DecigramsPerGram => As(RatioUnit.DecigramPerGram);

    /// <summary>
    ///     Get MassFraction in DecigramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - DecigramsPerKilogram->DecigramPerKilogram")]
    public double DecigramsPerKilogram => As(RatioUnit.DecigramPerKilogram);

    /// <summary>
    ///     Get MassFraction in GramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - GramsPerGram->GramPerGram")]
    public double GramsPerGram => As(RatioUnit.GramPerGram);

    /// <summary>
    ///     Get MassFraction in GramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - GramsPerKilogram->GramPerKilogram")]
    public double GramsPerKilogram => As(RatioUnit.GramPerKilogram);

    /// <summary>
    ///     Get MassFraction in HectogramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - HectogramsPerGram->HectogramPerGram")]
    public double HectogramsPerGram => As(RatioUnit.HectogramPerGram);

    /// <summary>
    ///     Get MassFraction in HectogramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - HectogramsPerKilogram->HectogramPerKilogram")]
    public double HectogramsPerKilogram => As(RatioUnit.HectogramPerKilogram);

    /// <summary>
    ///     Get MassFraction in KilogramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - KilogramsPerGram->KilogramPerGram")]
    public double KilogramsPerGram => As(RatioUnit.KilogramPerGram);

    /// <summary>
    ///     Get MassFraction in KilogramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - KilogramsPerKilogram->KilogramPerKilogram")]
    public double KilogramsPerKilogram => As(RatioUnit.KilogramPerKilogram);

    /// <summary>
    ///     Get MassFraction in MicrogramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - MicrogramsPerGram->MicrogramPerGram")]
    public double MicrogramsPerGram => As(RatioUnit.MicrogramPerGram);

    /// <summary>
    ///     Get MassFraction in MicrogramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - MicrogramsPerKilogram->MicrogramPerKilogram")]
    public double MicrogramsPerKilogram => As(RatioUnit.MicrogramPerKilogram);

    /// <summary>
    ///     Get MassFraction in MilligramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - MilligramsPerGram->MilligramPerGram")]
    public double MilligramsPerGram => As(RatioUnit.MilligramPerGram);

    /// <summary>
    ///     Get MassFraction in MilligramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - MilligramsPerKilogram->MilligramPerKilogram")]
    public double MilligramsPerKilogram => As(RatioUnit.MilligramPerKilogram);

    /// <summary>
    ///     Get MassFraction in NanogramsPerGram.
    /// </summary>
    [Obsolete("Use without the 's' - NanogramsPerGram->NanogramPerGram")]
    public double NanogramsPerGram => As(RatioUnit.NanogramPerGram);

    /// <summary>
    ///     Get MassFraction in NanogramsPerKilogram.
    /// </summary>
    [Obsolete("Use without the 's' - NanogramsPerKilogram->NanogramPerKilogram")]
    public double NanogramsPerKilogram => As(RatioUnit.NanogramPerKilogram);

    /// <summary>
    ///     Get Ratio in CentilitersPerLiter.
    /// </summary>
    //public double CentilitersPerLiter => As(RatioUnit.CentilitersPerLiter);

    ///// <summary>
    /////     Get Ratio in CentilitersPerMililiter.
    ///// </summary>
    //public double CentilitersPerMililiter => As(RatioUnit.CentilitersPerMililiter);

    ///// <summary>
    /////     Get Ratio in DecilitersPerLiter.
    ///// </summary>
    //public double DecilitersPerLiter => As(RatioUnit.DecilitersPerLiter);

    ///// <summary>
    /////     Get Ratio in DecilitersPerMililiter.
    ///// </summary>
    //public double DecilitersPerMililiter => As(RatioUnit.DecilitersPerMililiter);

    ///// <summary>
    /////     Get Ratio in LitersPerLiter.
    ///// </summary>
    //public double LitersPerLiter => As(RatioUnit.LitersPerLiter);

    ///// <summary>
    /////     Get Ratio in SI unit.
    ///// </summary>
    //public double SI => As(RatioUnit.SI);

    ///// <summary>
    /////     Get Ratio in LitersPerMililiter.
    ///// </summary>
    //public double LitersPerMililiter => As(RatioUnit.LitersPerMililiter);

    ///// <summary>
    /////     Get Ratio in MicrolitersPerLiter.
    ///// </summary>
    //public double MicrolitersPerLiter => As(RatioUnit.MicrolitersPerLiter);

    ///// <summary>
    /////     Get Ratio in MicrolitersPerMililiter.
    ///// </summary>
    //public double MicrolitersPerMililiter => As(RatioUnit.MicrolitersPerMililiter);

    ///// <summary>
    /////     Get Ratio in MillilitersPerLiter.
    ///// </summary>
    //public double MillilitersPerLiter => As(RatioUnit.MillilitersPerLiter);

    ///// <summary>
    /////     Get Ratio in MillilitersPerMililiter.
    ///// </summary>
    //public double MillilitersPerMililiter => As(RatioUnit.MillilitersPerMililiter);

    ///// <summary>
    /////     Get Ratio in NanolitersPerLiter.
    ///// </summary>
    //public double NanolitersPerLiter => As(RatioUnit.NanolitersPerLiter);

    ///// <summary>
    /////     Get Ratio in NanolitersPerMililiter.
    ///// </summary>
    //public double NanolitersPerMililiter => As(RatioUnit.NanolitersPerMililiter);

    ///// <summary>
    /////     Get Ratio in PicolitersPerLiter.
    ///// </summary>
    //public double PicolitersPerLiter => As(RatioUnit.PicolitersPerLiter);

    ///// <summary>
    /////     Get Ratio in PicolitersPerMililiter.
    ///// </summary>
    //public double PicolitersPerMililiter => As(RatioUnit.PicolitersPerMililiter);

}
