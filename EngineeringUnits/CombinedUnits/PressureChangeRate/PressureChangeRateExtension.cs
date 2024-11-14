using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class PressureChangeRateUnitExtension
{

    public static PressureChangeRate IfNullSetToZero(this PressureChangeRate? local)
    {
        if (local is not null)
        {
            return local;
        }

        return PressureChangeRate.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static PressureChangeRate? Abs(this PressureChangeRate? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               