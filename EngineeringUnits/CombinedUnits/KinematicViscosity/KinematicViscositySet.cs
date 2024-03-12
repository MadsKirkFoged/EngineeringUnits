using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class KinematicViscosity
{

    /// <summary>
    /// Get KinematicViscosity from SI.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SI))]
    public static KinematicViscosity? FromSI(double? SI)
    {
        if (SI is null)
            return null;

        return new KinematicViscosity((double)SI, KinematicViscosityUnit.SI);
    }
    /// <summary>
    /// Get KinematicViscosity from SquareMeterPerSecond.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(SquareMeterPerSecond))]
    public static KinematicViscosity? FromSquareMeterPerSecond(double? SquareMeterPerSecond)
    {
        if (SquareMeterPerSecond is null)
            return null;

        return new KinematicViscosity((double)SquareMeterPerSecond, KinematicViscosityUnit.SquareMeterPerSecond);
    }
    /// <summary>
    /// Get KinematicViscosity from Stokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Stokes))]
    public static KinematicViscosity? FromStokes(double? Stokes)
    {
        if (Stokes is null)
            return null;

        return new KinematicViscosity((double)Stokes, KinematicViscosityUnit.Stokes);
    }
    /// <summary>
    /// Get KinematicViscosity from Centistokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Centistokes))]
    public static KinematicViscosity? FromCentistokes(double? Centistokes)
    {
        if (Centistokes is null)
            return null;

        return new KinematicViscosity((double)Centistokes, KinematicViscosityUnit.Centistokes);
    }
    /// <summary>
    /// Get KinematicViscosity from Decistokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Decistokes))]
    public static KinematicViscosity? FromDecistokes(double? Decistokes)
    {
        if (Decistokes is null)
            return null;

        return new KinematicViscosity((double)Decistokes, KinematicViscosityUnit.Decistokes);
    }
    /// <summary>
    /// Get KinematicViscosity from Kilostokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Kilostokes))]
    public static KinematicViscosity? FromKilostokes(double? Kilostokes)
    {
        if (Kilostokes is null)
            return null;

        return new KinematicViscosity((double)Kilostokes, KinematicViscosityUnit.Kilostokes);
    }
    /// <summary>
    /// Get KinematicViscosity from Microstokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Microstokes))]
    public static KinematicViscosity? FromMicrostokes(double? Microstokes)
    {
        if (Microstokes is null)
            return null;

        return new KinematicViscosity((double)Microstokes, KinematicViscosityUnit.Microstokes);
    }
    /// <summary>
    /// Get KinematicViscosity from Millistokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Millistokes))]
    public static KinematicViscosity? FromMillistokes(double? Millistokes)
    {
        if (Millistokes is null)
            return null;

        return new KinematicViscosity((double)Millistokes, KinematicViscosityUnit.Millistokes);
    }
    /// <summary>
    /// Get KinematicViscosity from Nanostokes.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [return: NotNullIfNotNull(nameof(Nanostokes))]
    public static KinematicViscosity? FromNanostokes(double? Nanostokes)
    {
        if (Nanostokes is null)
            return null;

        return new KinematicViscosity((double)Nanostokes, KinematicViscosityUnit.Nanostokes);
    }
}