using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class LuminousFluxUnitExtension
{

    public static LuminousFlux IfNullSetToZero(this LuminousFlux? local)
    {
        if (local is not null)
        {
            return local;
        }

        return LuminousFlux.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static LuminousFlux? Abs(this LuminousFlux? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               