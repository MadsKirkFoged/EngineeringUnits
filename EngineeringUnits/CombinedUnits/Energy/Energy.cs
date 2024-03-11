using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Energy : BaseUnit
{                   
    public Energy() { }
    public Energy(decimal value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Energy(double value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Energy(int value, EnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Energy(UnknownUnit value) : base(value) { }

    public static Energy From(double value, EnergyUnit unit) => new(value, unit);

    public static Energy From(double? value, EnergyUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(EnergyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Energy ToUnit(EnergyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Energy Zero => new(0, EnergyUnit.SI);
    public static Energy NaN => new(double.NaN, EnergyUnit.SI);

    public static implicit operator Energy(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, EnergyUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(Energy Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EnergyUnit>(_unit);    
}
