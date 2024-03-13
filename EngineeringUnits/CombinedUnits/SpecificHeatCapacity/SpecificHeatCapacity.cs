using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class SpecificHeatCapacity : BaseUnit
{                   
    public SpecificHeatCapacity() { }
    public SpecificHeatCapacity(decimal value, SpecificHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificHeatCapacity(double value, SpecificHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificHeatCapacity(int value, SpecificHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificHeatCapacity(UnknownUnit value) : base(value) { }

    public static SpecificHeatCapacity From(double value, SpecificHeatCapacityUnit unit) => new(value, unit);

    public static SpecificHeatCapacity? From(double? value, SpecificHeatCapacityUnit? unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(SpecificHeatCapacityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public SpecificHeatCapacity ToUnit(SpecificHeatCapacityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static SpecificHeatCapacity Zero => new(0, SpecificHeatCapacityUnit.SI);
    public static SpecificHeatCapacity NaN => new(double.NaN, SpecificHeatCapacityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificHeatCapacity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, SpecificHeatCapacityUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(SpecificHeatCapacity? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificHeatCapacityUnit>(_unit);    
}
