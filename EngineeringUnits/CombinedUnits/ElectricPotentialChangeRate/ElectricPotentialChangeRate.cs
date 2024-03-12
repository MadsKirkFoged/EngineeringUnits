using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricPotentialChangeRate : BaseUnit
{
    public ElectricPotentialChangeRate() { }
    public ElectricPotentialChangeRate(decimal value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricPotentialChangeRate(double value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricPotentialChangeRate(int value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricPotentialChangeRate(UnknownUnit value) : base(value) { }

    public static ElectricPotentialChangeRate From(double value, ElectricPotentialChangeRateUnit unit) => new(value, unit);

    public static ElectricPotentialChangeRate? From(double? value, ElectricPotentialChangeRateUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(ElectricPotentialChangeRateUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricPotentialChangeRate ToUnit(ElectricPotentialChangeRateUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricPotentialChangeRate Zero => new(0, ElectricPotentialChangeRateUnit.SI);
    public static ElectricPotentialChangeRate NaN => new(double.NaN, ElectricPotentialChangeRateUnit.SI);

    public static implicit operator ElectricPotentialChangeRate?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricPotentialChangeRateUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit?(ElectricPotentialChangeRate? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricPotentialChangeRateUnit>(_unit);
}
