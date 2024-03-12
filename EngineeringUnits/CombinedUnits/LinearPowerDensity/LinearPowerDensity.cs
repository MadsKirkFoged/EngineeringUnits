using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class LinearPowerDensity : BaseUnit
{                   
    public LinearPowerDensity() { }
    public LinearPowerDensity(decimal value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearPowerDensity(double value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearPowerDensity(int value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearPowerDensity(UnknownUnit value) : base(value) { }

    public static LinearPowerDensity From(double value, LinearPowerDensityUnit unit) => new(value, unit);

    public static LinearPowerDensity? From(double? value, LinearPowerDensityUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(LinearPowerDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LinearPowerDensity ToUnit(LinearPowerDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LinearPowerDensity Zero => new(0, LinearPowerDensityUnit.SI);
    public static LinearPowerDensity NaN => new(double.NaN, LinearPowerDensityUnit.SI);

    public static implicit operator LinearPowerDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, LinearPowerDensityUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit?(LinearPowerDensity? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LinearPowerDensityUnit>(_unit);    
}
