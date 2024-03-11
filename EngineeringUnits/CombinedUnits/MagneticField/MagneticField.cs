using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MagneticField : BaseUnit
{                   
    public MagneticField() { }
    public MagneticField(decimal value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MagneticField(double value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MagneticField(int value, MagneticFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MagneticField(UnknownUnit value) : base(value) { }

    public static MagneticField From(double value, MagneticFieldUnit unit) => new(value, unit);

    public static MagneticField From(double? value, MagneticFieldUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(MagneticFieldUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MagneticField ToUnit(MagneticFieldUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MagneticField Zero => new(0, MagneticFieldUnit.SI);
    public static MagneticField NaN => new(double.NaN, MagneticFieldUnit.SI);

    public static implicit operator MagneticField(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, MagneticFieldUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(MagneticField Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MagneticFieldUnit>(_unit);    
}
