
using EngineeringUnits.Units;


namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class PowerCost : BaseUnit
{

    public PowerCost() { }
    public PowerCost(decimal value, PowerCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PowerCost(double value, PowerCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PowerCost(int value, PowerCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PowerCost(UnknownUnit value) : base(value) { }

    public static PowerCost From(double value, PowerCostUnit unit) => new(value, unit);

    public static PowerCost From(double? value, PowerCostUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(PowerCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public PowerCost ToUnit(PowerCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static PowerCost Zero => new(0, PowerCostUnit.SI);
    public static PowerCost NaN => new(double.NaN, PowerCostUnit.SI);

    public static implicit operator PowerCost(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, PowerCostUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(PowerCost Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PowerCostUnit>(_unit);    
}
