using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Ratio : BaseUnit
{                   
    public Ratio() { }
    public Ratio(decimal value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Ratio(double value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Ratio(int value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Ratio(UnknownUnit value) : base(value) { }

    public static Ratio From(double value, RatioUnit unit) => new(value, unit);

    public static Ratio From(double? value, RatioUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(RatioUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Ratio ToUnit(RatioUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Ratio Zero => new(0, RatioUnit.SI);
    public static Ratio NaN => new(double.NaN, RatioUnit.SI);

    public static implicit operator Ratio(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, RatioUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(Ratio Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<RatioUnit>(_unit);    
}
