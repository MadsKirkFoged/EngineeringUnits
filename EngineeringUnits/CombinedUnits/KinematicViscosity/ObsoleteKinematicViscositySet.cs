using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class KinematicViscosity
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.SI);
    //}

    /// <summary>
    ///     Get KinematicViscosity from Centistokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromCentistokes(double centistokes)
    //{
    //    double value = (double)centistokes;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.Centistokes);
    //}
    ///// <summary>
    /////     Get KinematicViscosity from Decistokes.
    ///// </summary>
    ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromDecistokes(double decistokes)
    //{
    //    double value = (double)decistokes;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.Decistokes);
    //}
    ///// <summary>
    /////     Get KinematicViscosity from Kilostokes.
    ///// </summary>
    ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromKilostokes(double kilostokes)
    //{
    //    double value = (double)kilostokes;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.Kilostokes);
    //}
    ///// <summary>
    /////     Get KinematicViscosity from Microstokes.
    ///// </summary>
    ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromMicrostokes(double microstokes)
    //{
    //    double value = (double)microstokes;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.Microstokes);
    //}
    ///// <summary>
    /////     Get KinematicViscosity from Millistokes.
    ///// </summary>
    ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromMillistokes(double millistokes)
    //{
    //    double value = (double)millistokes;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.Millistokes);
    //}
    ///// <summary>
    /////     Get KinematicViscosity from Nanostokes.
    ///// </summary>
    ///// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromNanostokes(double nanostokes)
    //{
    //    double value = (double)nanostokes;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.Nanostokes);
    //}
    ///// <summary>
    ///     Get KinematicViscosity from SquareMetersPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromSquareMetersPerSecond->FromSquareMeterPerSecond")]
    public static KinematicViscosity FromSquareMetersPerSecond(double squaremeterspersecond)
    {
        var value = (double)squaremeterspersecond;
        return new KinematicViscosity(value, KinematicViscosityUnit.SquareMeterPerSecond);
    }
    /// <summary>
    ///     Get KinematicViscosity from Stokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static KinematicViscosity FromStokes(double stokes)
    //{
    //    double value = (double)stokes;
    //    return new KinematicViscosity(value, KinematicViscosityUnit.Stokes);
    //}

}
