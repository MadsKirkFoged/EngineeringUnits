using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class ElectricInductanceUnitExtension
{

    public static ElectricInductance IfNullSetToZero(this ElectricInductance? local)
    {
        if (local is not null)
        {
            return local;
        }

        return ElectricInductance.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static ElectricInductance? Abs(this ElectricInductance? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               