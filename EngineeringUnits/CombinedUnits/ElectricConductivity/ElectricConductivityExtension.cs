using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ElectricConductivityUnitExtension
{

    public static ElectricConductivity IfNullSetToZero(this ElectricConductivity? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ElectricConductivity.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ElectricConductivity? Abs(this ElectricConductivity? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               