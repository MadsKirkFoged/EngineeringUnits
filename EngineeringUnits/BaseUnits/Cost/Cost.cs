using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 1)]
public partial class Cost : BaseUnit
{
    public Cost() { }
    public Cost(decimal value, CostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Cost(double value, CostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Cost(int value, CostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Cost(UnknownUnit value) : base(value) { }

    public static Cost From(double value, CostUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Cost? From(double? value, CostUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(CostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Cost ToUnit(CostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Cost Zero => new(0, CostUnit.SI);
    public static Cost NaN => new(double.NaN, CostUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Cost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, CostUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Cost? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<CostUnit>(_unit);
}
