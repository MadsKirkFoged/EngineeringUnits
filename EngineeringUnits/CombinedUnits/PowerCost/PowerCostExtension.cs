using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class PowerCostUnitExtension
{

    public static PowerCost IfNullSetToZero(this PowerCost? local)
    {
        if (local is not null)
        {
            return local;
        }

        return PowerCost.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static PowerCost? Abs(this PowerCost? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               