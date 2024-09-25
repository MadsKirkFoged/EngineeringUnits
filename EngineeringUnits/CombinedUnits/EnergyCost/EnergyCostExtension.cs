using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class EnergyCostUnitExtension
{

    public static EnergyCost IfNullSetToZero(this EnergyCost? local)
    {
        if (local is not null)
        {
            return local;
        }

        return EnergyCost.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static EnergyCost? Abs(this EnergyCost? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               