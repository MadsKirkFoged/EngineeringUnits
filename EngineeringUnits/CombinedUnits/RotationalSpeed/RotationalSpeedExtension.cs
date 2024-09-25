using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class RotationalSpeedUnitExtension
{

    public static RotationalSpeed IfNullSetToZero(this RotationalSpeed? local)
    {
        if (local is not null)
        {
            return local;
        }

        return RotationalSpeed.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static RotationalSpeed? Abs(this RotationalSpeed? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               