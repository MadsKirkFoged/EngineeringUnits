using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Speed : BaseUnit
{                   
    public Speed() { }
    public Speed(decimal value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Speed(double value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Speed(int value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Speed(UnknownUnit value) : base(value) { }

    public static Speed From(double value, SpeedUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Speed? From(double? value, SpeedUnit? unit)
    {
        if (value is null || unit is null)                           
            return null;                           

        return From((double)value, unit);
    }
    public double As(SpeedUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Speed ToUnit(SpeedUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Speed Zero => new(0, SpeedUnit.SI);
    public static Speed NaN => new(double.NaN, SpeedUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Speed?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, SpeedUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Speed? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpeedUnit>(_unit);    
}
