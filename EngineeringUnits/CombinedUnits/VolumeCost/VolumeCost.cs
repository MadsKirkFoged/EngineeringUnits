
using EngineeringUnits.Units;


namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class VolumeCost : BaseUnit
{

    public VolumeCost() { }
    public VolumeCost(decimal value, VolumeCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumeCost(double value, VolumeCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumeCost(int value, VolumeCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumeCost(UnknownUnit value) : base(value) { }

    public static VolumeCost From(double value, VolumeCostUnit unit) => new(value, unit);

    public static VolumeCost From(double? value, VolumeCostUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(VolumeCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public VolumeCost ToUnit(VolumeCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static VolumeCost Zero => new(0, VolumeCostUnit.SI);
    public static VolumeCost NaN => new(double.NaN, VolumeCostUnit.SI);

    public static implicit operator VolumeCost(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, VolumeCostUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(VolumeCost Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumeCostUnit>(_unit);    
}
