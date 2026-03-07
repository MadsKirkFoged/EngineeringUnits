using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ThermalConductanceUnitExtension
{

    public static ThermalConductance IfNullSetToZero(this ThermalConductance? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ThermalConductance.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ThermalConductance? Abs(this ThermalConductance? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}
