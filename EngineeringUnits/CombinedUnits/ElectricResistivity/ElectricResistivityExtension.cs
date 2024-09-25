using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ElectricResistivityUnitExtension
{

    public static ElectricResistivity IfNullSetToZero(this ElectricResistivity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ElectricResistivity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ElectricResistivity? Abs(this ElectricResistivity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               