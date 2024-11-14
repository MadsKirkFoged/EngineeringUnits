using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class JerkUnitExtension
{

    public static Jerk IfNullSetToZero(this Jerk? local)
    {
        if (local is not null)
        {
            return local;
        }

        return Jerk.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static Jerk? Abs(this Jerk? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               