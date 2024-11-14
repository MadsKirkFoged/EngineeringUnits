using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MassCostUnitExtension
{

    public static MassCost IfNullSetToZero(this MassCost? local)
    {
        if (local is not null)
        {
            return local;
        }

        return MassCost.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static MassCost? Abs(this MassCost? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               