using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Acceleration
{
    /// <summary>
    ///     Get Acceleration in CentimetersPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - CentimetersPerSecondSquared->CentimeterPerSecondSquared")]
    public double CentimetersPerSecondSquared => As(AccelerationUnit.CentimeterPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in DecimetersPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - DecimetersPerSecondSquared->DecimeterPerSecondSquared")]
    public double DecimetersPerSecondSquared => As(AccelerationUnit.DecimeterPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in FeetPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - FeetPerSecondSquared->FootPerSecondSquared")]
    public double FeetPerSecondSquared => As(AccelerationUnit.FootPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in InchesPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - InchesPerSecondSquared->InchPerSecondSquared")]
    public double InchesPerSecondSquared => As(AccelerationUnit.InchPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in KilometersPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - KilometersPerSecondSquared->KilometerPerSecondSquared")]
    public double KilometersPerSecondSquared => As(AccelerationUnit.KilometerPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in KnotsPerHour.
    /// </summary>
    [Obsolete("Use without the 's' - KnotsPerHour->KnotPerHour")]
    public double KnotsPerHour => As(AccelerationUnit.KnotPerHour);

    /// <summary>
    ///     Get Acceleration in KnotsPerMinute.
    /// </summary>
    [Obsolete("Use without the 's' - KnotsPerMinute->KnotPerMinute")]
    public double KnotsPerMinute => As(AccelerationUnit.KnotPerMinute);

    /// <summary>
    ///     Get Acceleration in KnotsPerSecond.
    /// </summary>
    [Obsolete("Use without the 's' - KnotsPerSecond->KnotPerSecond")]
    public double KnotsPerSecond => As(AccelerationUnit.KnotPerSecond);

    /// <summary>
    ///     Get Acceleration in MetersPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - MetersPerSecondSquared->MeterPerSecondSquared")]
    public double MetersPerSecondSquared => As(AccelerationUnit.MeterPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in SI Unit (MetersPerSecondSquared).
    /// </summary>
    //public double SI => As(AccelerationUnit.SI);

    /// <summary>
    ///     Get Acceleration in MicrometersPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - MicrometersPerSecondSquared->MicrometerPerSecondSquared")]
    public double MicrometersPerSecondSquared => As(AccelerationUnit.MicrometerPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in MillimetersPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - MillimetersPerSecondSquared->MillimeterPerSecondSquared")]
    public double MillimetersPerSecondSquared => As(AccelerationUnit.MillimeterPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in MillistandardGravity.
    /// </summary>
    //public double MillistandardGravity => As(AccelerationUnit.MillistandardGravity);

    /// <summary>
    ///     Get Acceleration in NanometersPerSecondSquared.
    /// </summary>
    [Obsolete("Use without the 's' - NanometersPerSecondSquared->NanometerPerSecondSquared")]
    public double NanometersPerSecondSquared => As(AccelerationUnit.NanometerPerSecondSquared);

    /// <summary>
    ///     Get Acceleration in StandardGravity.
    /// </summary>
    //public double StandardGravity => As(AccelerationUnit.StandardGravity);

}
