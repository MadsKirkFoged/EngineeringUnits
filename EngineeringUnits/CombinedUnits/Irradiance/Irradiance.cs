using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Irradiance : BaseUnit
{                   
    public Irradiance() { }
    public Irradiance(decimal value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Irradiance(double value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Irradiance(int value, IrradianceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Irradiance(UnknownUnit value) : base(value) { }

    public static Irradiance From(double value, IrradianceUnit unit) => new(value, unit);

    public static Irradiance? From(double? value, IrradianceUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(IrradianceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Irradiance ToUnit(IrradianceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Irradiance Zero => new(0, IrradianceUnit.SI);
    public static Irradiance NaN => new(double.NaN, IrradianceUnit.SI);

    public static implicit operator Irradiance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, IrradianceUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit?(Irradiance? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<IrradianceUnit>(_unit);    
}
