
using EngineeringUnits.Units;


namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class VolumePerLength : BaseUnit
{

    public VolumePerLength() { }
    public VolumePerLength(decimal value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumePerLength(double value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumePerLength(int value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumePerLength(UnknownUnit value) : base(value) { }

    public static VolumePerLength From(double value, VolumePerLengthUnit unit) => new(value, unit);

    public static VolumePerLength From(double? value, VolumePerLengthUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(VolumePerLengthUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public VolumePerLength ToUnit(VolumePerLengthUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static VolumePerLength Zero => new(0, VolumePerLengthUnit.SI);
    public static VolumePerLength NaN => new(double.NaN, VolumePerLengthUnit.SI);

    public static implicit operator VolumePerLength(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, VolumePerLengthUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(VolumePerLength Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumePerLengthUnit>(_unit);    
}
