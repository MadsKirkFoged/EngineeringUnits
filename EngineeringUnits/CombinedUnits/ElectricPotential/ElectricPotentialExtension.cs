using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ElectricPotentialUnitExtension
{

    public static ElectricPotential IfNullSetToZero(this ElectricPotential? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ElectricPotential.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ElectricPotential? Abs(this ElectricPotential? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               