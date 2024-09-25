using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MagnetizationUnitExtension
{

    public static Magnetization IfNullSetToZero(this Magnetization? local)
    {
        if (local is not null)
        {
            return local;
        }

        return Magnetization.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static Magnetization? Abs(this Magnetization? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               