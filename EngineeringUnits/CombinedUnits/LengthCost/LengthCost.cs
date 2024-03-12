using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class LengthCost : BaseUnit
{                   
    public LengthCost() { }
    public LengthCost(decimal value, LengthCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LengthCost(double value, LengthCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LengthCost(int value, LengthCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LengthCost(UnknownUnit value) : base(value) { }

    public static LengthCost From(double value, LengthCostUnit unit) => new(value, unit);

    public static LengthCost? From(double? value, LengthCostUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(LengthCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LengthCost ToUnit(LengthCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LengthCost Zero => new(0, LengthCostUnit.SI);
    public static LengthCost NaN => new(double.NaN, LengthCostUnit.SI);

    public static implicit operator LengthCost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, LengthCostUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit?(LengthCost? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LengthCostUnit>(_unit);    
}
