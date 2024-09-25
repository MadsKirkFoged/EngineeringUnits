using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class AreaMomentOfInertiaUnitExtension
{

    public static AreaMomentOfInertia IfNullSetToZero(this AreaMomentOfInertia? local)
    {
        if (local is not null)
        {
            return local;
        }

        return AreaMomentOfInertia.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static AreaMomentOfInertia? Abs(this AreaMomentOfInertia? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               