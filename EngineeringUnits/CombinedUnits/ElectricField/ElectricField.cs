using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 1, BaseunitType.mass, 1, BaseunitType.electricCurrent, -1, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ElectricField : BaseUnit
{
    public ElectricField() { }
    public ElectricField(decimal value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricField(double value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricField(int value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricField(UnknownUnit value) : base(value) { }

    public static ElectricField From(double value, ElectricFieldUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ElectricField? From(double? value, ElectricFieldUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ElectricFieldUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricField ToUnit(ElectricFieldUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricField Zero => new(0, ElectricFieldUnit.SI);
    public static ElectricField NaN => new(double.NaN, ElectricFieldUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ElectricField?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricFieldUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ElectricField? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricFieldUnit>(_unit);
}
