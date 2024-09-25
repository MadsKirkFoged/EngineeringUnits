using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class KinematicViscosityUnitExtension
{

    public static KinematicViscosity IfNullSetToZero(this KinematicViscosity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return KinematicViscosity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static KinematicViscosity? Abs(this KinematicViscosity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               