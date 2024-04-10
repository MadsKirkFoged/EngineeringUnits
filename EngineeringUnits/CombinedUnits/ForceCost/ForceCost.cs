using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class ForceCost : BaseUnit
{
    public ForceCost() { }
    public ForceCost(decimal value, ForceCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceCost(double value, ForceCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceCost(int value, ForceCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceCost(UnknownUnit value) : base(value) { }

    public static ForceCost From(double value, ForceCostUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ForceCost? From(double? value, ForceCostUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ForceCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ForceCost ToUnit(ForceCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ForceCost Zero => new(0, ForceCostUnit.SI);
    public static ForceCost NaN => new(double.NaN, ForceCostUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ForceCost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ForceCostUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ForceCost? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ForceCostUnit>(_unit);
}
