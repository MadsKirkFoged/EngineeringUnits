﻿using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class TemperatureChangeRate
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static TemperatureChangeRate FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new TemperatureChangeRate(value, TemperatureChangeRateUnit.SI);
    //}

    /// <summary>
    ///     Get TemperatureChangeRate from CentidegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCentidegreesCelsiusPerSecond->FromCentidegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromCentidegreesCelsiusPerSecond(double centidegreescelsiuspersecond)
    {
        var value = (double)centidegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from DecadegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecadegreesCelsiusPerSecond->FromDecadegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromDecadegreesCelsiusPerSecond(double decadegreescelsiuspersecond)
    {
        var value = (double)decadegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from DecidegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDecidegreesCelsiusPerSecond->FromDecidegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromDecidegreesCelsiusPerSecond(double decidegreescelsiuspersecond)
    {
        var value = (double)decidegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from DegreesCelsiusPerMinute.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDegreesCelsiusPerMinute->FromDegreeCelsiusPerMinute")]
    public static TemperatureChangeRate FromDegreesCelsiusPerMinute(double degreescelsiusperminute)
    {
        var value = (double)degreescelsiusperminute;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from DegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromDegreesCelsiusPerSecond->FromDegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromDegreesCelsiusPerSecond(double degreescelsiuspersecond)
    {
        var value = (double)degreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from HectodegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromHectodegreesCelsiusPerSecond->FromHectodegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromHectodegreesCelsiusPerSecond(double hectodegreescelsiuspersecond)
    {
        var value = (double)hectodegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from KilodegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilodegreesCelsiusPerSecond->FromKilodegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromKilodegreesCelsiusPerSecond(double kilodegreescelsiuspersecond)
    {
        var value = (double)kilodegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from MicrodegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMicrodegreesCelsiusPerSecond->FromMicrodegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromMicrodegreesCelsiusPerSecond(double microdegreescelsiuspersecond)
    {
        var value = (double)microdegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from MillidegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMillidegreesCelsiusPerSecond->FromMillidegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromMillidegreesCelsiusPerSecond(double millidegreescelsiuspersecond)
    {
        var value = (double)millidegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);
    }

    /// <summary>
    ///     Get TemperatureChangeRate from NanodegreesCelsiusPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromNanodegreesCelsiusPerSecond->FromNanodegreeCelsiusPerSecond")]
    public static TemperatureChangeRate FromNanodegreesCelsiusPerSecond(double nanodegreescelsiuspersecond)
    {
        var value = (double)nanodegreescelsiuspersecond;
        return new TemperatureChangeRate(value, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);
    }
}
