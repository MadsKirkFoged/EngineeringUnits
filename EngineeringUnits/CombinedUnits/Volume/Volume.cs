using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class Volume : BaseUnit
{                   
    public Volume() { }
    public Volume(decimal value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Volume(double value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Volume(int value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Volume(UnknownUnit value) : base(value) { }

    public static Volume From(double value, VolumeUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Volume? From(double? value, VolumeUnit? unit)
    {
        if (value is null || unit is null)                           
            return null;                           

        return From((double)value, unit);
    }
    public double As(VolumeUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Volume ToUnit(VolumeUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Volume Zero => new(0, VolumeUnit.SI);
    public static Volume NaN => new(double.NaN, VolumeUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Volume?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, VolumeUnit.SI);
        return new(Unit);        
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Volume? Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumeUnit>(_unit);    
}
