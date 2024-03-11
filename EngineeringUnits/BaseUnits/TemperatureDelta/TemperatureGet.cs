using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class TemperatureDelta
{

    /// <summary>
    ///     Get Temperature in DegreesCelsius.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double DegreesCelsius => As(TemperatureUnit.DegreeCelsius);

    /// <summary>
    ///     Get Temperature in DegreesDelisle.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double DegreesDelisle;

    /// <summary>
    ///     Get Temperature in DegreesFahrenheit.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double DegreesFahrenheit => As(TemperatureUnit.DegreeFahrenheit);

    /// <summary>
    ///     Get Temperature in DegreesNewton.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double DegreesNewton;

    /// <summary>
    ///     Get Temperature in DegreesRankine.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double DegreesRankine => As(TemperatureUnit.DegreeRankine);

    /// <summary>
    ///     Get Temperature in DegreesReaumur.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double DegreesReaumur;

    /// <summary>
    ///     Get Temperature in DegreesRoemer.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double DegreesRoemer;

    /// <summary>
    ///     Get Temperature in Kelvins.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double Kelvins => As(TemperatureUnit.Kelvin);

    /// <summary>
    ///     Get Temperature in SI Unit (Kelvin).
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double SI => As(TemperatureUnit.SI);

    /// <summary>
    ///     Get Temperature in MillidegreesCelsius.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double MillidegreesCelsius;

    /// <summary>
    ///     Get Temperature in SolarTemperatures.
    /// </summary>
    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double SolarTemperatures;

}
