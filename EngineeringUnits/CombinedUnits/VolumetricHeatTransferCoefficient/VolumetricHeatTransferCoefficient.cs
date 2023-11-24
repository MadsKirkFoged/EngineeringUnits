
using EngineeringUnits.Units;


namespace EngineeringUnits
{
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
        public double As(VolumetricHeatTransferCoefficientUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public VolumetricHeatTransferCoefficient ToUnit(VolumetricHeatTransferCoefficientUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static VolumetricHeatTransferCoefficient Zero => new(0, VolumetricHeatTransferCoefficientUnit.SI);
        public static VolumetricHeatTransferCoefficient NaN => new(double.NaN, VolumetricHeatTransferCoefficientUnit.SI);

        public static implicit operator VolumetricHeatTransferCoefficient(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(VolumetricHeatTransferCoefficientUnit.SI);
            return new(Unit);        
        }

        public static implicit operator VolumetricHeatTransferCoefficient(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumetricHeatTransferCoefficientUnit>(_unit);
	}
}

