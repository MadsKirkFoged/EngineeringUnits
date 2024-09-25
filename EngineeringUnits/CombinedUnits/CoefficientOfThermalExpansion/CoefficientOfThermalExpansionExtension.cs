using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public static class CoefficientOfThermalExpansionUnitExtension
{

    public static CoefficientOfThermalExpansion IfNullSetToZero(this CoefficientOfThermalExpansion? local)
    {
        if (local is not null)
        {
            return local;
        }

        return CoefficientOfThermalExpansion.Zero;
    }


    /// <summary>
    /// Returns the absolute value
    /// </summary>
    [return: NotNullIfNotNull(nameof(a))]
    public static CoefficientOfThermalExpansion? Abs(this CoefficientOfThermalExpansion? a)
    {
        if (a is null)
            return null;

        if (a.GetBaseValue() > 0)
            return a;

        return (-a)!;
    }

}               