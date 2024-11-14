using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class MassMomentOfInertiaUnitExtension
{

    public static MassMomentOfInertia IfNullSetToZero(this MassMomentOfInertia? local)
    {
        if (local is not null)
        {
            return local;
        }

        return MassMomentOfInertia.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static MassMomentOfInertia? Abs(this MassMomentOfInertia? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               