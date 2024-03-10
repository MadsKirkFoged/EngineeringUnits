using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class LapseRate
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static LapseRate FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new LapseRate(value, LapseRateUnit.SI);
    //}

    /// <summary>
    ///     Get LapseRate from DegreesCelciusPerKilometer.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDegreesCelciusPerKilometer->FromDegreeCelciusPerKilometer")]
    public static LapseRate FromDegreesCelciusPerKilometer(double degreescelciusperkilometer)
    {
        var value = (double)degreescelciusperkilometer;
        return new LapseRate(value, LapseRateUnit.DegreeCelsiusPerKilometer);
    }
}
