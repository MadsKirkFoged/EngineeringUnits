using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class LuminousIntensityUnitExtension
{

    public static LuminousIntensity IfNullSetToZero(this LuminousIntensity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return LuminousIntensity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static LuminousIntensity? Abs(this LuminousIntensity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               