using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Magnetization
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Magnetization FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Magnetization(value, MagnetizationUnit.SI);
    //}

    /// <summary>
    ///     Get Magnetization from AmperesPerMeter.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromAmperesPerMeter->FromAmperePerMeter")]
    public static Magnetization FromAmperesPerMeter(double amperespermeter)
    {
        var value = (double)amperespermeter;
        return new Magnetization(value, MagnetizationUnit.AmperePerMeter);
    }
}
