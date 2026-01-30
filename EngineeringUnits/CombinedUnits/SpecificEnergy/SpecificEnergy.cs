using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class SpecificEnergy : BaseUnit
{
    public SpecificEnergy() { }
    public SpecificEnergy(decimal value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificEnergy(double value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificEnergy(int value, SpecificEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificEnergy(UnknownUnit value) : base(value) { }

    public static SpecificEnergy From(double value, SpecificEnergyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static SpecificEnergy? From(double? value, SpecificEnergyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(SpecificEnergyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public SpecificEnergy ToUnit(SpecificEnergyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static SpecificEnergy Zero => new(0, SpecificEnergyUnit.SI);
    public static SpecificEnergy NaN => new(double.NaN, SpecificEnergyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificEnergy?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, SpecificEnergyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(SpecificEnergy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificEnergyUnit>(_unit);
}
