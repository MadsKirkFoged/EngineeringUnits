
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class RotationalSpeed : BaseUnit
    {

        public RotationalSpeed() { }
        public RotationalSpeed(decimal value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public RotationalSpeed(double value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public RotationalSpeed(int value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public RotationalSpeed(UnknownUnit value) : base(value) { }

        public static RotationalSpeed From(double value, RotationalSpeedUnit unit) => new(value, unit);

        public static RotationalSpeed From(double? value, RotationalSpeedUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(RotationalSpeedUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public RotationalSpeed ToUnit(RotationalSpeedUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static RotationalSpeed Zero => new(0, RotationalSpeedUnit.SI);

        public static implicit operator RotationalSpeed(UnknownUnit Unit)
        {
            UnitCheck(Unit, RotationalSpeedUnit.SI);
            return new(Unit);        
        }

        public static implicit operator RotationalSpeed(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<RotationalSpeedUnit>(_unit);
	}
}

