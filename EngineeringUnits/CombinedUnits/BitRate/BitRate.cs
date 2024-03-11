using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class BitRate : BaseUnit
{                   
    public BitRate() { }
    public BitRate(decimal value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BitRate(double value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BitRate(int value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BitRate(UnknownUnit value) : base(value) { }

    public static BitRate From(double value, BitRateUnit unit) => new(value, unit);

    public static BitRate From(double? value, BitRateUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(BitRateUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public BitRate ToUnit(BitRateUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static BitRate Zero => new(0, BitRateUnit.SI);
    public static BitRate NaN => new(double.NaN, BitRateUnit.SI);

    public static implicit operator BitRate(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, BitRateUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(BitRate Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<BitRateUnit>(_unit);    
}
