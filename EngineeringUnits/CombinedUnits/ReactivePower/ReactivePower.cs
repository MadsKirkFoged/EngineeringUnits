using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class ReactivePower : BaseUnit
{                   
    public ReactivePower() { }
    public ReactivePower(decimal value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ReactivePower(double value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ReactivePower(int value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ReactivePower(UnknownUnit value) : base(value) { }

    public static ReactivePower From(double value, ReactivePowerUnit unit) => new(value, unit);

    public static ReactivePower? From(double? value, ReactivePowerUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(ReactivePowerUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ReactivePower ToUnit(ReactivePowerUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ReactivePower Zero => new(0, ReactivePowerUnit.SI);
    public static ReactivePower NaN => new(double.NaN, ReactivePowerUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ReactivePower?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, ReactivePowerUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ReactivePower? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ReactivePowerUnit>(_unit);    
}
