using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 1, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ElectricCurrentDensity : BaseUnit
{
    public ElectricCurrentDensity() { }
    public ElectricCurrentDensity(decimal value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricCurrentDensity(double value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricCurrentDensity(int value, ElectricCurrentDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricCurrentDensity(UnknownUnit value) : base(value) { }

    public static ElectricCurrentDensity From(double value, ElectricCurrentDensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ElectricCurrentDensity? From(double? value, ElectricCurrentDensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ElectricCurrentDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricCurrentDensity ToUnit(ElectricCurrentDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricCurrentDensity Zero => new(0, ElectricCurrentDensityUnit.SI);
    public static ElectricCurrentDensity NaN => new(double.NaN, ElectricCurrentDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ElectricCurrentDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricCurrentDensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ElectricCurrentDensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricCurrentDensityUnit>(_unit);
}
