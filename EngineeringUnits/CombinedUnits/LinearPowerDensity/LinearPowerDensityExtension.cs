using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class LinearPowerDensityUnitExtension
{

    public static LinearPowerDensity IfNullSetToZero(this LinearPowerDensity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return LinearPowerDensity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static LinearPowerDensity? Abs(this LinearPowerDensity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               