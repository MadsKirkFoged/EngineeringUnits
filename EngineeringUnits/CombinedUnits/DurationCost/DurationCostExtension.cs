using System;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class DurationCostUnitExtension
{

    public static DurationCost IfNullSetToZero(this DurationCost? local)
    {
        if (local is not null)
        {
            return local;
        }

        return DurationCost.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static DurationCost? Abs(this DurationCost? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               