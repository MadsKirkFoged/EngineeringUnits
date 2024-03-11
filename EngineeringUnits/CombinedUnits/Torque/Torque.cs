using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Torque : BaseUnit
{                   
    public Torque() { }
    public Torque(decimal value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Torque(double value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Torque(int value, TorqueUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Torque(UnknownUnit value) : base(value) { }

    public static Torque From(double value, TorqueUnit unit) => new(value, unit);

    public static Torque From(double? value, TorqueUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(TorqueUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Torque ToUnit(TorqueUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Torque Zero => new(0, TorqueUnit.SI);
    public static Torque NaN => new(double.NaN, TorqueUnit.SI);

    public static implicit operator Torque(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, TorqueUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(Torque Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<TorqueUnit>(_unit);    
}
