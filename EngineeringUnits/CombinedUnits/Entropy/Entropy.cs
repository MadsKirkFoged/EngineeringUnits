using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Entropy : BaseUnit
{                   
    public Entropy() { }
    public Entropy(decimal value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Entropy(double value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Entropy(int value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Entropy(UnknownUnit value) : base(value) { }

    public static Entropy From(double value, EntropyUnit unit) => new(value, unit);

    public static Entropy From(double? value, EntropyUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(EntropyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Entropy ToUnit(EntropyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Entropy Zero => new(0, EntropyUnit.SI);
    public static Entropy NaN => new(double.NaN, EntropyUnit.SI);

    public static implicit operator Entropy(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, EntropyUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(Entropy Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EntropyUnit>(_unit);    
}
