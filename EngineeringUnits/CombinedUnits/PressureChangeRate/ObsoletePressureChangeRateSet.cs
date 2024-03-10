using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class PressureChangeRate
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static PressureChangeRate FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new PressureChangeRate(value, PressureChangeRateUnit.SI);
    //}

    /// <summary>
    ///     Get PressureChangeRate from AtmospheresPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAtmospheresPerSecond->FromAtmospherePerSecond")]
    public static PressureChangeRate FromAtmospheresPerSecond(double atmospherespersecond)
    {
        var value = (double)atmospherespersecond;
        return new PressureChangeRate(value, PressureChangeRateUnit.AtmospherePerSecond);
    }

    /// <summary>
    ///     Get PressureChangeRate from KilopascalsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopascalsPerMinute->FromKilopascalPerMinute")]
    public static PressureChangeRate FromKilopascalsPerMinute(double kilopascalsperminute)
    {
        var value = (double)kilopascalsperminute;
        return new PressureChangeRate(value, PressureChangeRateUnit.KilopascalPerMinute);
    }

    /// <summary>
    ///     Get PressureChangeRate from KilopascalsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopascalsPerSecond->FromKilopascalPerSecond")]
    public static PressureChangeRate FromKilopascalsPerSecond(double kilopascalspersecond)
    {
        var value = (double)kilopascalspersecond;
        return new PressureChangeRate(value, PressureChangeRateUnit.KilopascalPerSecond);
    }

    /// <summary>
    ///     Get PressureChangeRate from KilopoundsForcePerSquareInchPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerSquareInchPerMinute->FromKilopoundForcePerSquareInchPerMinute")]
    public static PressureChangeRate FromKilopoundsForcePerSquareInchPerMinute(double kilopoundsforcepersquareinchperminute)
    {
        var value = (double)kilopoundsforcepersquareinchperminute;
        return new PressureChangeRate(value, PressureChangeRateUnit.KilopoundForcePerSquareInchPerMinute);
    }

    /// <summary>
    ///     Get PressureChangeRate from KilopoundsForcePerSquareInchPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilopoundsForcePerSquareInchPerSecond->FromKilopoundForcePerSquareInchPerSecond")]
    public static PressureChangeRate FromKilopoundsForcePerSquareInchPerSecond(double kilopoundsforcepersquareinchpersecond)
    {
        var value = (double)kilopoundsforcepersquareinchpersecond;
        return new PressureChangeRate(value, PressureChangeRateUnit.KilopoundForcePerSquareInchPerSecond);
    }

    /// <summary>
    ///     Get PressureChangeRate from MegapascalsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapascalsPerMinute->FromMegapascalPerMinute")]
    public static PressureChangeRate FromMegapascalsPerMinute(double megapascalsperminute)
    {
        var value = (double)megapascalsperminute;
        return new PressureChangeRate(value, PressureChangeRateUnit.MegapascalPerMinute);
    }

    /// <summary>
    ///     Get PressureChangeRate from MegapascalsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapascalsPerSecond->FromMegapascalPerSecond")]
    public static PressureChangeRate FromMegapascalsPerSecond(double megapascalspersecond)
    {
        var value = (double)megapascalspersecond;
        return new PressureChangeRate(value, PressureChangeRateUnit.MegapascalPerSecond);
    }

    /// <summary>
    ///     Get PressureChangeRate from MegapoundsForcePerSquareInchPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundsForcePerSquareInchPerMinute->FromMegapoundForcePerSquareInchPerMinute")]
    public static PressureChangeRate FromMegapoundsForcePerSquareInchPerMinute(double megapoundsforcepersquareinchperminute)
    {
        var value = (double)megapoundsforcepersquareinchperminute;
        return new PressureChangeRate(value, PressureChangeRateUnit.MegapoundForcePerSquareInchPerMinute);
    }

    /// <summary>
    ///     Get PressureChangeRate from MegapoundsForcePerSquareInchPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegapoundsForcePerSquareInchPerSecond->FromMegapoundForcePerSquareInchPerSecond")]
    public static PressureChangeRate FromMegapoundsForcePerSquareInchPerSecond(double megapoundsforcepersquareinchpersecond)
    {
        var value = (double)megapoundsforcepersquareinchpersecond;
        return new PressureChangeRate(value, PressureChangeRateUnit.MegapoundForcePerSquareInchPerSecond);
    }

    /// <summary>
    ///     Get PressureChangeRate from PascalsPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPascalsPerMinute->FromPascalPerMinute")]
    public static PressureChangeRate FromPascalsPerMinute(double pascalsperminute)
    {
        var value = (double)pascalsperminute;
        return new PressureChangeRate(value, PressureChangeRateUnit.PascalPerMinute);
    }

    /// <summary>
    ///     Get PressureChangeRate from PascalsPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPascalsPerSecond->FromPascalPerSecond")]
    public static PressureChangeRate FromPascalsPerSecond(double pascalspersecond)
    {
        var value = (double)pascalspersecond;
        return new PressureChangeRate(value, PressureChangeRateUnit.PascalPerSecond);
    }

    /// <summary>
    ///     Get PressureChangeRate from PoundsForcePerSquareInchPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerSquareInchPerMinute->FromPoundForcePerSquareInchPerMinute")]
    public static PressureChangeRate FromPoundsForcePerSquareInchPerMinute(double poundsforcepersquareinchperminute)
    {
        var value = (double)poundsforcepersquareinchperminute;
        return new PressureChangeRate(value, PressureChangeRateUnit.PoundForcePerSquareInchPerMinute);
    }

    /// <summary>
    ///     Get PressureChangeRate from PoundsForcePerSquareInchPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromPoundsForcePerSquareInchPerSecond->FromPoundForcePerSquareInchPerSecond")]
    public static PressureChangeRate FromPoundsForcePerSquareInchPerSecond(double poundsforcepersquareinchpersecond)
    {
        var value = (double)poundsforcepersquareinchpersecond;
        return new PressureChangeRate(value, PressureChangeRateUnit.PoundForcePerSquareInchPerSecond);
    }
}
