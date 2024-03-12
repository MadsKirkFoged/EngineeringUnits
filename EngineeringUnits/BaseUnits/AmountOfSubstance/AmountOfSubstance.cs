using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class AmountOfSubstance : BaseUnit
{                   
    public AmountOfSubstance() { }
    public AmountOfSubstance(decimal value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AmountOfSubstance(double value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AmountOfSubstance(int value, AmountOfSubstanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AmountOfSubstance(UnknownUnit value) : base(value) { }

    public static AmountOfSubstance From(double value, AmountOfSubstanceUnit unit) => new(value, unit);

    public static AmountOfSubstance? From(double? value, AmountOfSubstanceUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(AmountOfSubstanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public AmountOfSubstance ToUnit(AmountOfSubstanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static AmountOfSubstance Zero => new(0, AmountOfSubstanceUnit.SI);
    public static AmountOfSubstance NaN => new(double.NaN, AmountOfSubstanceUnit.SI);

    public static implicit operator AmountOfSubstance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, AmountOfSubstanceUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit?(AmountOfSubstance? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AmountOfSubstanceUnit>(_unit);    
}
