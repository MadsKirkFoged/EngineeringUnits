using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class AreaCost : BaseUnit
{
    public AreaCost() { }
    public AreaCost(decimal value, AreaCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaCost(double value, AreaCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaCost(int value, AreaCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaCost(UnknownUnit value) : base(value) { }

    public static AreaCost From(double value, AreaCostUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static AreaCost? From(double? value, AreaCostUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(AreaCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public AreaCost ToUnit(AreaCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static AreaCost Zero => new(0, AreaCostUnit.SI);
    public static AreaCost NaN => new(double.NaN, AreaCostUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator AreaCost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AreaCostUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(AreaCost? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AreaCostUnit>(_unit);
}
