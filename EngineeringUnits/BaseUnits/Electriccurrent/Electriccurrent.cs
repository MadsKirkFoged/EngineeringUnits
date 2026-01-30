using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 1, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ElectricCurrent : BaseUnit
{
    public ElectricCurrent() { }
    public ElectricCurrent(decimal value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricCurrent(double value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricCurrent(int value, ElectricCurrentUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricCurrent(UnknownUnit value) : base(value) { }

    public static ElectricCurrent From(double value, ElectricCurrentUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ElectricCurrent? From(double? value, ElectricCurrentUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ElectricCurrentUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricCurrent ToUnit(ElectricCurrentUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricCurrent Zero => new(0, ElectricCurrentUnit.SI);
    public static ElectricCurrent NaN => new(double.NaN, ElectricCurrentUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ElectricCurrent?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricCurrentUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ElectricCurrent? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricCurrentUnit>(_unit);
}
