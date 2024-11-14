using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ForceCostUnitExtension
{

    public static ForceCost IfNullSetToZero(this ForceCost? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ForceCost.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ForceCost? Abs(this ForceCost? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               