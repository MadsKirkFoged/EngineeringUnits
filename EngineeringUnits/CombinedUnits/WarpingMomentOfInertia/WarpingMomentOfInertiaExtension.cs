using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class WarpingMomentOfInertiaUnitExtension
{

    public static WarpingMomentOfInertia IfNullSetToZero(this WarpingMomentOfInertia? local)
    {
        if (local is not null)
        {
            return local;
        }

        return WarpingMomentOfInertia.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static WarpingMomentOfInertia? Abs(this WarpingMomentOfInertia? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               