
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class LinearPowerDensity : BaseUnit
    {

        public LinearPowerDensity() { }
        public LinearPowerDensity(decimal value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(double value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(int value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearPowerDensity(UnknownUnit value) : base(value) { }

        public static LinearPowerDensity From(double value, LinearPowerDensityUnit unit) => new(value, unit);

        public static LinearPowerDensity From(double? value, LinearPowerDensityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(LinearPowerDensityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public LinearPowerDensity ToUnit(LinearPowerDensityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static LinearPowerDensity Zero => new(0, LinearPowerDensityUnit.SI);

        public static implicit operator LinearPowerDensity(UnknownUnit Unit)
        {
            Unit.UnitCheck(LinearPowerDensityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator LinearPowerDensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LinearPowerDensityUnit>(_unit);
	}
}

