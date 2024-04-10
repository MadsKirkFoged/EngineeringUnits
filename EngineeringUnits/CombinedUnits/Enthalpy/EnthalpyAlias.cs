using System.Diagnostics.CodeAnalysis;
namespace EngineeringUnits;
// This class is auto-generated, changes to the file will be overwritten!

public partial class Enthalpy : BaseUnit
{
    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Enthalpy?(SpecificEnergy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificEnergy?(Enthalpy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }
}
