using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Angle
{
    /// <summary>
    ///     Get Angle in Arcminutes.
    /// </summary>
    [Obsolete("Use without the 's' - Arcminutes->Arcminute")]
    public double Arcminutes => As(AngleUnit.Arcminute);

    /// <summary>
    ///     Get Angle in Arcseconds.
    /// </summary>
    [Obsolete("Use without the 's' - Arcseconds->Arcsecond")]
    public double Arcseconds => As(AngleUnit.Arcsecond);

    /// <summary>
    ///     Get Angle in Centiradians.
    /// </summary>
    [Obsolete("Use without the 's' - Centiradians->Centiradian")]
    public double Centiradians => As(AngleUnit.Centiradian);

    /// <summary>
    ///     Get Angle in Deciradians.
    /// </summary>
    [Obsolete("Use without the 's' - Deciradians->Deciradian")]
    public double Deciradians => As(AngleUnit.Deciradian);

    /// <summary>
    ///     Get Angle in Degrees.
    /// </summary>
    [Obsolete("Use without the 's' - Degrees->Degree")]
    public double Degrees => As(AngleUnit.Degree);

    /// <summary>
    ///     Get Angle in Gradians.
    /// </summary>
    [Obsolete("Use without the 's' - Gradians->Gradian")]
    public double Gradians => As(AngleUnit.Gradian);

    /// <summary>
    ///     Get Angle in Microdegrees.
    /// </summary>
    [Obsolete("Use without the 's' - Microdegrees->Microdegree")]
    public double Microdegrees => As(AngleUnit.Microdegree);

    /// <summary>
    ///     Get Angle in Microradians.
    /// </summary>
    [Obsolete("Use without the 's' - Microradians->Microradian")]
    public double Microradians => As(AngleUnit.Microradian);

    /// <summary>
    ///     Get Angle in Millidegrees.
    /// </summary>
    [Obsolete("Use without the 's' - Millidegrees->Millidegree")]
    public double Millidegrees => As(AngleUnit.Millidegree);

    /// <summary>
    ///     Get Angle in Milliradians.
    /// </summary>
    [Obsolete("Use without the 's' - Milliradians->Milliradian")]
    public double Milliradians => As(AngleUnit.Milliradian);

    /// <summary>
    ///     Get Angle in Nanodegrees.
    /// </summary>
    [Obsolete("Use without the 's' - Nanodegrees->Nanodegree")]
    public double Nanodegrees => As(AngleUnit.Nanodegree);

    /// <summary>
    ///     Get Angle in Nanoradians.
    /// </summary>
    [Obsolete("Use without the 's' - Nanoradians->Nanoradian")]
    public double Nanoradians => As(AngleUnit.Nanoradian);

    /// <summary>
    ///     Get Angle in Radians.
    /// </summary>
    [Obsolete("Use without the 's' - Radians->Radian")]
    public double Radians => As(AngleUnit.Radian);

    /// <summary>
    ///     Get Angle in SI Unit (Radians).
    /// </summary>
    //public double SI => As(AngleUnit.SI);

    /// <summary>
    ///     Get Angle in Revolutions.
    /// </summary>
    [Obsolete("Use without the 's' - Revolutions->Revolution")]
    public double Revolutions => As(AngleUnit.Revolution);

    /// <summary>
    ///     Get Angle in Tilt.
    /// </summary>
    //public double Tilt => As(AngleUnit.Tilt);

}
