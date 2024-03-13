using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Frequency : BaseUnit
{                   
    public Frequency() { }
    public Frequency(decimal value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Frequency(double value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Frequency(int value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Frequency(UnknownUnit value) : base(value) { }

    public static Frequency From(double value, FrequencyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Frequency? From(double? value, FrequencyUnit? unit)
    {
        if (value is null || unit is null)                           
            return null;                           

        return From((double)value, unit);
    }
    public double As(FrequencyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Frequency ToUnit(FrequencyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Frequency Zero => new(0, FrequencyUnit.SI);
    public static Frequency NaN => new(double.NaN, FrequencyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Frequency?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, FrequencyUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Frequency? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<FrequencyUnit>(_unit);    
}
