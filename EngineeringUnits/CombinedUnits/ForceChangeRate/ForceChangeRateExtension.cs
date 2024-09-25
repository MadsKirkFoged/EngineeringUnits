using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ForceChangeRateUnitExtension
{

    public static ForceChangeRate IfNullSetToZero(this ForceChangeRate? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ForceChangeRate.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ForceChangeRate? Abs(this ForceChangeRate? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               