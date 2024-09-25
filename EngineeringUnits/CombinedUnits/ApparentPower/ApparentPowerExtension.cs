using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ApparentPowerUnitExtension
{

    public static ApparentPower IfNullSetToZero(this ApparentPower? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ApparentPower.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ApparentPower? Abs(this ApparentPower? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               