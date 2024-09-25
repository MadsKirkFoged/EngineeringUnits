using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MagneticFieldUnitExtension
{

    public static MagneticField IfNullSetToZero(this MagneticField? local)
    {
        if (local is not null)
        {
            return local;
        }

        return MagneticField.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static MagneticField? Abs(this MagneticField? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               