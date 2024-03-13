using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Temperature : BaseUnit
{                   
    public Temperature() { }
    public Temperature(decimal value, TemperatureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Temperature(double value, TemperatureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Temperature(int value, TemperatureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Temperature(UnknownUnit value) : base(value) { }

    public static Temperature From(double value, TemperatureUnit unit) => new(value, unit);

    public static Temperature? From(double? value, TemperatureUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(TemperatureUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Temperature ToUnit(TemperatureUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Temperature Zero => new(0, TemperatureUnit.SI);
    public static Temperature NaN => new(double.NaN, TemperatureUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Temperature?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, TemperatureUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Temperature? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<TemperatureUnit>(_unit);    
}
