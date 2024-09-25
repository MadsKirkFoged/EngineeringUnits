using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ElectricResistanceUnitExtension
{

    public static ElectricResistance IfNullSetToZero(this ElectricResistance? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ElectricResistance.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ElectricResistance? Abs(this ElectricResistance? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               