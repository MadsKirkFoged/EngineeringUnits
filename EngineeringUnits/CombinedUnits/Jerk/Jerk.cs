using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Jerk : BaseUnit
{
    public Jerk() { }
    public Jerk(decimal value, JerkUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Jerk(double value, JerkUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Jerk(int value, JerkUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Jerk(UnknownUnit value) : base(value) { }

    public static Jerk From(double value, JerkUnit unit) => new(value, unit);

    public static Jerk? From(double? value, JerkUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(JerkUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Jerk ToUnit(JerkUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Jerk Zero => new(0, JerkUnit.SI);
    public static Jerk NaN => new(double.NaN, JerkUnit.SI);

    public static implicit operator Jerk?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, JerkUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit?(Jerk? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<JerkUnit>(_unit);
}
