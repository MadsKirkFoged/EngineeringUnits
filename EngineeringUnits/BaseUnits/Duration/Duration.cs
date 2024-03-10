
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Duration : BaseUnit
{

    public Duration() { }
    public Duration(decimal value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Duration(double value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Duration(int value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Duration(UnknownUnit value) : base(value) { }

    public static Duration From(double value, DurationUnit unit) => new(value, unit);

    public static Duration From(double? value, DurationUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(DurationUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Duration ToUnit(DurationUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Duration Zero => new(0, DurationUnit.SI);
    public static Duration NaN => new(double.NaN, DurationUnit.SI);

    public static implicit operator Duration(UnknownUnit Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, DurationUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit(Duration Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<DurationUnit>(_unit);
}
