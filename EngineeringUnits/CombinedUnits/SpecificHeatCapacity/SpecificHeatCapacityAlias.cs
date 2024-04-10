using System.Diagnostics.CodeAnalysis;
namespace EngineeringUnits;
// This class is auto-generated, changes to the file will be overwritten!

public partial class SpecificHeatCapacity : BaseUnit
{
    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificHeatCapacity?(SpecificEntropy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificEntropy?(SpecificHeatCapacity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }
}
