using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class LinearDensityUnitExtension
{

    public static LinearDensity IfNullSetToZero(this LinearDensity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return LinearDensity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static LinearDensity? Abs(this LinearDensity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               