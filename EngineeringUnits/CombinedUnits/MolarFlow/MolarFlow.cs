
using EngineeringUnits.Units;


namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MolarFlow : BaseUnit
{

    public MolarFlow() { }
    public MolarFlow(decimal value, MolarFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarFlow(double value, MolarFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarFlow(int value, MolarFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MolarFlow(UnknownUnit value) : base(value) { }

    public static MolarFlow From(double value, MolarFlowUnit unit) => new(value, unit);

    public static MolarFlow From(double? value, MolarFlowUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(MolarFlowUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MolarFlow ToUnit(MolarFlowUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MolarFlow Zero => new(0, MolarFlowUnit.SI);
    public static MolarFlow NaN => new(double.NaN, MolarFlowUnit.SI);

    public static implicit operator MolarFlow(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, MolarFlowUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(MolarFlow Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarFlowUnit>(_unit);    
}
