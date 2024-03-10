using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class ElectricCurrentGradient
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static ElectricCurrentGradient FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.SI);
    //}

    /// <summary>
    ///     Get ElectricCurrentGradient from AmperesPerMicrosecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerMicrosecond->FromAmperePerMicrosecond")]
    public static ElectricCurrentGradient FromAmperesPerMicrosecond(double amperespermicrosecond)
    {
        var value = (double)amperespermicrosecond;
        return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMicrosecond);
    }
    /// <summary>
    ///     Get ElectricCurrentGradient from AmperesPerMillisecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerMillisecond->FromAmperePerMillisecond")]
    public static ElectricCurrentGradient FromAmperesPerMillisecond(double amperespermillisecond)
    {
        var value = (double)amperespermillisecond;
        return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerMillisecond);
    }
    /// <summary>
    ///     Get ElectricCurrentGradient from AmperesPerNanosecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerNanosecond->FromAmperePerNanosecond")]
    public static ElectricCurrentGradient FromAmperesPerNanosecond(double amperespernanosecond)
    {
        var value = (double)amperespernanosecond;
        return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerNanosecond);
    }
    /// <summary>
    ///     Get ElectricCurrentGradient from AmperesPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerSecond->FromAmperePerSecond")]
    public static ElectricCurrentGradient FromAmperesPerSecond(double amperespersecond)
    {
        var value = (double)amperespersecond;
        return new ElectricCurrentGradient(value, ElectricCurrentGradientUnit.AmperePerSecond);
    }
}
