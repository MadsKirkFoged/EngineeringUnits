using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ForceChangeRate
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ForceChangeRate FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ForceChangeRate(value, ForceChangeRateUnit.SI);
    //}

    /// <summary>
    ///     Get ForceChangeRate from CentinewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentinewtonsPerSecond->FromCentinewtonPerSecond")]
    public static ForceChangeRate FromCentinewtonsPerSecond(double centinewtonspersecond)
    {
        var value = (double)centinewtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.CentinewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from DecanewtonsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecanewtonsPerMinute->FromDecanewtonPerMinute")]
    public static ForceChangeRate FromDecanewtonsPerMinute(double decanewtonsperminute)
    {
        var value = (double)decanewtonsperminute;
        return new ForceChangeRate(value, ForceChangeRateUnit.DecanewtonPerMinute);
    }
    /// <summary>
    ///     Get ForceChangeRate from DecanewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecanewtonsPerSecond->FromDecanewtonPerSecond")]
    public static ForceChangeRate FromDecanewtonsPerSecond(double decanewtonspersecond)
    {
        var value = (double)decanewtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.DecanewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from DecinewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecinewtonsPerSecond->FromDecinewtonPerSecond")]
    public static ForceChangeRate FromDecinewtonsPerSecond(double decinewtonspersecond)
    {
        var value = (double)decinewtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.DecinewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from KilonewtonsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerMinute->FromKilonewtonPerMinute")]
    public static ForceChangeRate FromKilonewtonsPerMinute(double kilonewtonsperminute)
    {
        var value = (double)kilonewtonsperminute;
        return new ForceChangeRate(value, ForceChangeRateUnit.KilonewtonPerMinute);
    }
    /// <summary>
    ///     Get ForceChangeRate from KilonewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilonewtonsPerSecond->FromKilonewtonPerSecond")]
    public static ForceChangeRate FromKilonewtonsPerSecond(double kilonewtonspersecond)
    {
        var value = (double)kilonewtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.KilonewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from KilopoundsForcePerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerMinute->FromKilopoundForcePerMinute")]
    public static ForceChangeRate FromKilopoundsForcePerMinute(double kilopoundsforceperminute)
    {
        var value = (double)kilopoundsforceperminute;
        return new ForceChangeRate(value, ForceChangeRateUnit.KilopoundForcePerMinute);
    }
    /// <summary>
    ///     Get ForceChangeRate from KilopoundsForcePerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerSecond->FromKilopoundForcePerSecond")]
    public static ForceChangeRate FromKilopoundsForcePerSecond(double kilopoundsforcepersecond)
    {
        var value = (double)kilopoundsforcepersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.KilopoundForcePerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from MicronewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicronewtonsPerSecond->FromMicronewtonPerSecond")]
    public static ForceChangeRate FromMicronewtonsPerSecond(double micronewtonspersecond)
    {
        var value = (double)micronewtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.MicronewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from MillinewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillinewtonsPerSecond->FromMillinewtonPerSecond")]
    public static ForceChangeRate FromMillinewtonsPerSecond(double millinewtonspersecond)
    {
        var value = (double)millinewtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.MillinewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from NanonewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanonewtonsPerSecond->FromNanonewtonPerSecond")]
    public static ForceChangeRate FromNanonewtonsPerSecond(double nanonewtonspersecond)
    {
        var value = (double)nanonewtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.NanonewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from NewtonsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerMinute->FromNewtonPerMinute")]
    public static ForceChangeRate FromNewtonsPerMinute(double newtonsperminute)
    {
        var value = (double)newtonsperminute;
        return new ForceChangeRate(value, ForceChangeRateUnit.NewtonPerMinute);
    }
    /// <summary>
    ///     Get ForceChangeRate from NewtonsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNewtonsPerSecond->FromNewtonPerSecond")]
    public static ForceChangeRate FromNewtonsPerSecond(double newtonspersecond)
    {
        var value = (double)newtonspersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.NewtonPerSecond);
    }
    /// <summary>
    ///     Get ForceChangeRate from PoundsForcePerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerMinute->FromPoundForcePerMinute")]
    public static ForceChangeRate FromPoundsForcePerMinute(double poundsforceperminute)
    {
        var value = (double)poundsforceperminute;
        return new ForceChangeRate(value, ForceChangeRateUnit.PoundForcePerMinute);
    }
    /// <summary>
    ///     Get ForceChangeRate from PoundsForcePerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerSecond->FromPoundForcePerSecond")]
    public static ForceChangeRate FromPoundsForcePerSecond(double poundsforcepersecond)
    {
        var value = (double)poundsforcepersecond;
        return new ForceChangeRate(value, ForceChangeRateUnit.PoundForcePerSecond);
    }
}
