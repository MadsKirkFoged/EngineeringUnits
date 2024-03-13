using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class MassFlow : BaseUnit
{                   
    public MassFlow() { }
    public MassFlow(decimal value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlow(double value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlow(int value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlow(UnknownUnit value) : base(value) { }

    public static MassFlow From(double value, MassFlowUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static MassFlow? From(double? value, MassFlowUnit? unit)
    {
        if (value is null || unit is null)                           
            return null;                           

        return From((double)value, unit);
    }
    public double As(MassFlowUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MassFlow ToUnit(MassFlowUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MassFlow Zero => new(0, MassFlowUnit.SI);
    public static MassFlow NaN => new(double.NaN, MassFlowUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator MassFlow?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, MassFlowUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(MassFlow? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassFlowUnit>(_unit);    
}
