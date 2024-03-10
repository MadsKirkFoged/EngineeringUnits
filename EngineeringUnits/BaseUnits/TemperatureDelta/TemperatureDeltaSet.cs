using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class TemperatureDelta
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromSI(double si)
    {
        var value = (double)si;
        return new TemperatureDelta(value, TemperatureUnit.SI);
    }

    /// <summary>
    ///     Get Temperature from DegreesCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromDegreesCelsius(double degreescelsius)
    {
        var value = (double)degreescelsius;
        return new TemperatureDelta(value, TemperatureUnit.DegreeCelsius);
    }
    /// <summary>
    ///     Get Temperature from DegreesDelisle.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromDegreesDelisle(double degreesdelisle)
    {
        var value = (double)degreesdelisle;
        return new TemperatureDelta(value, TemperatureUnit.SI);
    }
    /// <summary>
    ///     Get Temperature from DegreesFahrenheit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromDegreesFahrenheit(double degreesfahrenheit)
    {
        var value = (double)degreesfahrenheit;
        return new TemperatureDelta(value, TemperatureUnit.DegreeFahrenheit);
    }

    /// <summary>
    ///     Get Temperature from DegreesNewton.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    /// 
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromDegreesNewton(double degreesnewton)
    {
        var value = (double)degreesnewton;
        return new TemperatureDelta(value, TemperatureUnit.SI);
    }
    /// <summary>
    ///     Get Temperature from DegreesRankine.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromDegreesRankine(double degreesrankine)
    {
        var value = (double)degreesrankine;
        return new TemperatureDelta(value, TemperatureUnit.DegreeRankine);
    }
    /// <summary>
    ///     Get Temperature from DegreesReaumur.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromDegreesReaumur(double degreesreaumur)
    {
        var value = (double)degreesreaumur;
        return new TemperatureDelta(value, TemperatureUnit.SI);
    }
    /// <summary>
    ///     Get Temperature from DegreesRoemer.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    /// 
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromDegreesRoemer(double degreesroemer)
    {
        var value = (double)degreesroemer;
        return new TemperatureDelta(value, TemperatureUnit.SI);
    }
    /// <summary>
    ///     Get Temperature from Kelvins.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromKelvins(double kelvins)
    {
        var value = (double)kelvins;
        return new TemperatureDelta(value, TemperatureUnit.Kelvin);
    }
    /// <summary>
    ///     Get Temperature from MillidegreesCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromMillidegreesCelsius(double millidegreescelsius)
    {
        var value = (double)millidegreescelsius;
        return new TemperatureDelta(value, TemperatureUnit.SI);
    }
    /// <summary>
    ///     Get Temperature from SolarTemperatures.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta FromSolarTemperatures(double solartemperatures)
    {
        var value = (double)solartemperatures;
        return new TemperatureDelta(value, TemperatureUnit.SI);
    }
}
