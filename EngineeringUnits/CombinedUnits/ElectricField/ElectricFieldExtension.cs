using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ElectricFieldUnitExtension
{

    public static ElectricField IfNullSetToZero(this ElectricField? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ElectricField.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ElectricField? Abs(this ElectricField? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               