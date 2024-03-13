using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class PowerDensity : BaseUnit
{                   
    public PowerDensity() { }
    public PowerDensity(decimal value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PowerDensity(double value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PowerDensity(int value, PowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PowerDensity(UnknownUnit value) : base(value) { }

    public static PowerDensity From(double value, PowerDensityUnit unit) => new(value, unit);

    public static PowerDensity? From(double? value, PowerDensityUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(PowerDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public PowerDensity ToUnit(PowerDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static PowerDensity Zero => new(0, PowerDensityUnit.SI);
    public static PowerDensity NaN => new(double.NaN, PowerDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator PowerDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, PowerDensityUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(PowerDensity? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PowerDensityUnit>(_unit);    
}
