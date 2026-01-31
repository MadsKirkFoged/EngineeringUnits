using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -2, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class AreaDensity : BaseUnit
{
    public AreaDensity() { }
    public AreaDensity(Fraction value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaDensity(decimal value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaDensity(double value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaDensity(int value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaDensity(UnknownUnit value) : base(value) { }

    public static AreaDensity From(double value, AreaDensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static AreaDensity? From(double? value, AreaDensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(AreaDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public AreaDensity ToUnit(AreaDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static AreaDensity Zero => new(0, AreaDensityUnit.SI);
    public static AreaDensity NaN => new(double.NaN, AreaDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator AreaDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AreaDensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(AreaDensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AreaDensityUnit>(_unit);
}
