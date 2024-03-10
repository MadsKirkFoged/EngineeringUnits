﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class MassFlow
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static MassFlow FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new MassFlow(value, MassFlowUnit.SI);
    //}

    /// <summary>
    ///     Get MassFlow from CentigramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentigramsPerDay->FromCentigramPerDay")]
    public static MassFlow FromCentigramsPerDay(double centigramsperday)
    {
        var value = (double)centigramsperday;
        return new MassFlow(value, MassFlowUnit.CentigramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from CentigramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentigramsPerSecond->FromCentigramsPerSecond")]
    public static MassFlow FromCentigramsPerSecond(double centigramspersecond)
    {
        var value = (double)centigramspersecond;
        return new MassFlow(value, MassFlowUnit.CentigramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from DecagramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecagramsPerDay->FromDecagramPerDay")]
    public static MassFlow FromDecagramsPerDay(double decagramsperday)
    {
        var value = (double)decagramsperday;
        return new MassFlow(value, MassFlowUnit.DecagramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from DecagramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecagramsPerSecond->FromDecagramPerSecond")]
    public static MassFlow FromDecagramsPerSecond(double decagramspersecond)
    {
        var value = (double)decagramspersecond;
        return new MassFlow(value, MassFlowUnit.DecagramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from DecigramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecigramsPerDay->FromDecigramPerDay")]
    public static MassFlow FromDecigramsPerDay(double decigramsperday)
    {
        var value = (double)decigramsperday;
        return new MassFlow(value, MassFlowUnit.DecigramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from DecigramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecigramsPerSecond->FromDecigramPerSecond")]
    public static MassFlow FromDecigramsPerSecond(double decigramspersecond)
    {
        var value = (double)decigramspersecond;
        return new MassFlow(value, MassFlowUnit.DecigramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from GramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerDay->FromGramPerDay")]
    public static MassFlow FromGramsPerDay(double gramsperday)
    {
        var value = (double)gramsperday;
        return new MassFlow(value, MassFlowUnit.GramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from GramsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerHour->FromGramPerHour")]
    public static MassFlow FromGramsPerHour(double gramsperhour)
    {
        var value = (double)gramsperhour;
        return new MassFlow(value, MassFlowUnit.GramPerHour);
    }

    /// <summary>
    ///     Get MassFlow from GramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromGramsPerSecond->FromGramPerSecond")]
    public static MassFlow FromGramsPerSecond(double gramspersecond)
    {
        var value = (double)gramspersecond;
        return new MassFlow(value, MassFlowUnit.GramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from HectogramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectogramsPerDay->FromHectogramPerDay")]
    public static MassFlow FromHectogramsPerDay(double hectogramsperday)
    {
        var value = (double)hectogramsperday;
        return new MassFlow(value, MassFlowUnit.HectogramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from HectogramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectogramsPerSecond->FromHectogramPerSecond")]
    public static MassFlow FromHectogramsPerSecond(double hectogramspersecond)
    {
        var value = (double)hectogramspersecond;
        return new MassFlow(value, MassFlowUnit.HectogramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from KilogramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerDay->FromKilogramPerDay")]
    public static MassFlow FromKilogramsPerDay(double kilogramsperday)
    {
        var value = (double)kilogramsperday;
        return new MassFlow(value, MassFlowUnit.KilogramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from KilogramsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerHour->FromKilogramPerHour")]
    public static MassFlow FromKilogramsPerHour(double kilogramsperhour)
    {
        var value = (double)kilogramsperhour;
        return new MassFlow(value, MassFlowUnit.KilogramPerHour);
    }

    /// <summary>
    ///     Get MassFlow from KilogramsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerMinute->FromKilogramPerMinute")]
    public static MassFlow FromKilogramsPerMinute(double kilogramsperminute)
    {
        var value = (double)kilogramsperminute;
        return new MassFlow(value, MassFlowUnit.KilogramPerMinute);
    }

    /// <summary>
    ///     Get MassFlow from KilogramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilogramsPerSecond->FromKilogramPerSecond")]
    public static MassFlow FromKilogramsPerSecond(double kilogramspersecond)
    {
        var value = (double)kilogramspersecond;
        return new MassFlow(value, MassFlowUnit.KilogramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from MegagramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegagramsPerDay->FromMegagramPerDay")]
    public static MassFlow FromMegagramsPerDay(double megagramsperday)
    {
        var value = (double)megagramsperday;
        return new MassFlow(value, MassFlowUnit.MegagramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from MegapoundsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundsPerDay->FromMegapoundPerDay")]
    public static MassFlow FromMegapoundsPerDay(double megapoundsperday)
    {
        var value = (double)megapoundsperday;
        return new MassFlow(value, MassFlowUnit.MegapoundPerDay);
    }

    /// <summary>
    ///     Get MassFlow from MegapoundsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundsPerHour->FromMegapoundPerHour")]
    public static MassFlow FromMegapoundsPerHour(double megapoundsperhour)
    {
        var value = (double)megapoundsperhour;
        return new MassFlow(value, MassFlowUnit.MegapoundPerHour);
    }

    /// <summary>
    ///     Get MassFlow from MegapoundsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundsPerMinute->FromMegapoundPerMinute")]
    public static MassFlow FromMegapoundsPerMinute(double megapoundsperminute)
    {
        var value = (double)megapoundsperminute;
        return new MassFlow(value, MassFlowUnit.MegapoundPerMinute);
    }

    /// <summary>
    ///     Get MassFlow from MegapoundsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundsPerSecond->FromMegapoundPerSecond")]
    public static MassFlow FromMegapoundsPerSecond(double megapoundspersecond)
    {
        var value = (double)megapoundspersecond;
        return new MassFlow(value, MassFlowUnit.MegapoundPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from MicrogramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrogramsPerDay->FromMicrogramPerDay")]
    public static MassFlow FromMicrogramsPerDay(double microgramsperday)
    {
        var value = (double)microgramsperday;
        return new MassFlow(value, MassFlowUnit.MicrogramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from MicrogramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrogramsPerSecond->FromMicrogramPerSecond")]
    public static MassFlow FromMicrogramsPerSecond(double microgramspersecond)
    {
        var value = (double)microgramspersecond;
        return new MassFlow(value, MassFlowUnit.MicrogramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from MilligramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligramsPerDay->FromMilligramPerDay")]
    public static MassFlow FromMilligramsPerDay(double milligramsperday)
    {
        var value = (double)milligramsperday;
        return new MassFlow(value, MassFlowUnit.MilligramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from MilligramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMilligramsPerSecond->FromMilligramPerSecond")]
    public static MassFlow FromMilligramsPerSecond(double milligramspersecond)
    {
        var value = (double)milligramspersecond;
        return new MassFlow(value, MassFlowUnit.MilligramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from NanogramsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanogramsPerDay->FromNanogramPerDay")]
    public static MassFlow FromNanogramsPerDay(double nanogramsperday)
    {
        var value = (double)nanogramsperday;
        return new MassFlow(value, MassFlowUnit.NanogramPerDay);
    }

    /// <summary>
    ///     Get MassFlow from NanogramsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanogramsPerSecond->FromNanogramPerSecond")]
    public static MassFlow FromNanogramsPerSecond(double nanogramspersecond)
    {
        var value = (double)nanogramspersecond;
        return new MassFlow(value, MassFlowUnit.NanogramPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from PoundsPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerDay->FromPoundPerDay")]
    public static MassFlow FromPoundsPerDay(double poundsperday)
    {
        var value = (double)poundsperday;
        return new MassFlow(value, MassFlowUnit.PoundPerDay);
    }

    /// <summary>
    ///     Get MassFlow from PoundsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerHour->FromPoundPerHour")]
    public static MassFlow FromPoundsPerHour(double poundsperhour)
    {
        var value = (double)poundsperhour;
        return new MassFlow(value, MassFlowUnit.PoundPerHour);
    }

    /// <summary>
    ///     Get MassFlow from PoundsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerMinute->FromPoundPerMinute")]
    public static MassFlow FromPoundsPerMinute(double poundsperminute)
    {
        var value = (double)poundsperminute;
        return new MassFlow(value, MassFlowUnit.PoundPerMinute);
    }

    /// <summary>
    ///     Get MassFlow from PoundsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsPerSecond->FromPoundPerSecond")]
    public static MassFlow FromPoundsPerSecond(double poundspersecond)
    {
        var value = (double)poundspersecond;
        return new MassFlow(value, MassFlowUnit.PoundPerSecond);
    }

    /// <summary>
    ///     Get MassFlow from ShortTonsPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromShortTonsPerHour->FromShortTonPerHour")]
    public static MassFlow FromShortTonsPerHour(double shorttonsperhour)
    {
        var value = (double)shorttonsperhour;
        return new MassFlow(value, MassFlowUnit.ShortTonPerHour);
    }

    /// <summary>
    ///     Get MassFlow from TonnesPerDay.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesPerDay->FromTonnePerDay")]
    public static MassFlow FromTonnesPerDay(double tonnesperday)
    {
        var value = (double)tonnesperday;
        return new MassFlow(value, MassFlowUnit.TonnePerDay);
    }

    /// <summary>
    ///     Get MassFlow from TonnesPerHour.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromTonnesPerHour->FromTonnePerHour")]
    public static MassFlow FromTonnesPerHour(double tonnesperhour)
    {
        var value = (double)tonnesperhour;
        return new MassFlow(value, MassFlowUnit.TonnePerHour);
    }
}
