
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Angle : BaseUnit
{

    public Angle() { }
    public Angle(decimal value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Angle(double value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Angle(int value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Angle(UnknownUnit value) : base(value) { }

    public static Angle From(double value, AngleUnit unit) => new(value, unit);

    public static Angle From(double? value, AngleUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(AngleUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Angle ToUnit(AngleUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Angle Zero => new(0, AngleUnit.SI);
    public static Angle NaN => new(double.NaN, AngleUnit.SI);

    public static implicit operator Angle(UnknownUnit Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AngleUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit(Angle Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AngleUnit>(_unit);
}
