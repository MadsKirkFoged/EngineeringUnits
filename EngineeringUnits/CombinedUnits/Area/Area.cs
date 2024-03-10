
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Area : BaseUnit
{

    public Area() { }
    public Area(decimal value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Area(double value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Area(int value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Area(UnknownUnit value) : base(value) { }

    public static Area From(double value, AreaUnit unit) => new(value, unit);

    public static Area From(double? value, AreaUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(AreaUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Area ToUnit(AreaUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Area Zero => new(0, AreaUnit.SI);
    public static Area NaN => new(double.NaN, AreaUnit.SI);

    public static implicit operator Area(UnknownUnit Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AreaUnit.SI);
        return new(Unit);
    }

    public static implicit operator UnknownUnit(Area Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AreaUnit>(_unit);
}
