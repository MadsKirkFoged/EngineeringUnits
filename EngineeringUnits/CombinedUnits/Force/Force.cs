using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Force : BaseUnit
{                   
    public Force() { }
    public Force(decimal value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Force(double value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Force(int value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Force(UnknownUnit value) : base(value) { }

    public static Force From(double value, ForceUnit unit) => new(value, unit);

    public static Force From(double? value, ForceUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(ForceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Force ToUnit(ForceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Force Zero => new(0, ForceUnit.SI);
    public static Force NaN => new(double.NaN, ForceUnit.SI);

    public static implicit operator Force(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, ForceUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(Force Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ForceUnit>(_unit);    
}
