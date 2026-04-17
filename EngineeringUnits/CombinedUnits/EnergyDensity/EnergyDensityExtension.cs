using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class EnergyDensityUnitExtension
{

    public static EnergyDensity IfNullSetToZero(this EnergyDensity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return EnergyDensity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static EnergyDensity? Abs(this EnergyDensity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}
