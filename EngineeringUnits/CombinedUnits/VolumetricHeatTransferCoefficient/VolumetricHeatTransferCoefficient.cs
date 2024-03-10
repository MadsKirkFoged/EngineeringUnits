
using EngineeringUnits.Units;

namespace EngineeringUnits;

//This class is auto-generated, changes to the file will be overwritten!
public partial class VolumetricHeatTransferCoefficient : BaseUnit
{

    public VolumetricHeatTransferCoefficient() { }
    public VolumetricHeatTransferCoefficient(decimal value, VolumetricHeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatTransferCoefficient(double value, VolumetricHeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatTransferCoefficient(int value, VolumetricHeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatTransferCoefficient(UnknownUnit value) : base(value) { }

    public static VolumetricHeatTransferCoefficient From(double value, VolumetricHeatTransferCoefficientUnit unit) => new(value, unit);

    public static VolumetricHeatTransferCoefficient From(double? value, VolumetricHeatTransferCoefficientUnit unit)
    {
        if (value is null || unit is null)
        {
            return null;
        }

        return From((double)value, unit);
    }
    public double As(VolumetricHeatTransferCoefficientUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public VolumetricHeatTransferCoefficient ToUnit(VolumetricHeatTransferCoefficientUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static VolumetricHeatTransferCoefficient Zero => new(0, VolumetricHeatTransferCoefficientUnit.SI);
    public static VolumetricHeatTransferCoefficient NaN => new(double.NaN, VolumetricHeatTransferCoefficientUnit.SI);

    public static implicit operator VolumetricHeatTransferCoefficient(UnknownUnit Unit)
    {
        if (Unit is null)
            return null; 

        GuardAgainst.DifferentUnits(Unit, VolumetricHeatTransferCoefficientUnit.SI);
        return new(Unit);        
    }

    public static implicit operator UnknownUnit(VolumetricHeatTransferCoefficient Unit)
    {            
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumetricHeatTransferCoefficientUnit>(_unit);    
}
