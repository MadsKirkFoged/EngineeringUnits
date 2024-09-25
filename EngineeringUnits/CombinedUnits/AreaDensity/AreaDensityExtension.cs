using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class AreaDensityUnitExtension
{

    public static AreaDensity IfNullSetToZero(this AreaDensity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return AreaDensity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static AreaDensity? Abs(this AreaDensity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               