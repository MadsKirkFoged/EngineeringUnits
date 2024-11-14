using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ThermalResistanceUnitExtension
{

    public static ThermalResistance IfNullSetToZero(this ThermalResistance? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ThermalResistance.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ThermalResistance? Abs(this ThermalResistance? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               