
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ElectricResistivity : BaseUnit
{

    public ElectricResistivity() { }
    public ElectricResistivity(decimal value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricResistivity(double value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricResistivity(int value, ElectricResistivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricResistivity(UnknownUnit value) : base(value) { }

    public static ElectricResistivity From(double value, ElectricResistivityUnit unit) => new(value, unit);

    public static ElectricResistivity From(double? value, ElectricResistivityUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(ElectricResistivityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricResistivity ToUnit(ElectricResistivityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricResistivity Zero => new(0, ElectricResistivityUnit.SI);
    public static ElectricResistivity NaN => new(double.NaN, ElectricResistivityUnit.SI);

    public static implicit operator ElectricResistivity(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, ElectricResistivityUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(ElectricResistivity Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricResistivityUnit>(_unit);    
}
