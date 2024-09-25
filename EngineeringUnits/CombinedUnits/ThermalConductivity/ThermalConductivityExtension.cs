using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ThermalConductivityUnitExtension
{

    public static ThermalConductivity IfNullSetToZero(this ThermalConductivity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ThermalConductivity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ThermalConductivity? Abs(this ThermalConductivity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               