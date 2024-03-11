using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricConductivity : BaseUnit
{                   
    public ElectricConductivity() { }
    public ElectricConductivity(decimal value, ElectricConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricConductivity(double value, ElectricConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricConductivity(int value, ElectricConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricConductivity(UnknownUnit value) : base(value) { }

    public static ElectricConductivity From(double value, ElectricConductivityUnit unit) => new(value, unit);

    public static ElectricConductivity From(double? value, ElectricConductivityUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(ElectricConductivityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricConductivity ToUnit(ElectricConductivityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricConductivity Zero => new(0, ElectricConductivityUnit.SI);
    public static ElectricConductivity NaN => new(double.NaN, ElectricConductivityUnit.SI);

    public static implicit operator ElectricConductivity(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, ElectricConductivityUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(ElectricConductivity Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricConductivityUnit>(_unit);    
}
