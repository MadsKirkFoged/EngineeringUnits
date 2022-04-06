
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class TorquePerLength : BaseUnit
    {

        public TorquePerLength() { }
        public TorquePerLength(decimal value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TorquePerLength(double value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TorquePerLength(int value, TorquePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TorquePerLength(UnknownUnit value) : base(value) { }

        public static TorquePerLength From(double value, TorquePerLengthUnit unit) => new(value, unit);

        public static TorquePerLength From(double? value, TorquePerLengthUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(TorquePerLengthUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public TorquePerLength ToUnit(TorquePerLengthUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static TorquePerLength Zero => new(0, TorquePerLengthUnit.SI);

        public static implicit operator TorquePerLength(UnknownUnit Unit)
        {
            UnitCheck(Unit, TorquePerLengthUnit.SI);
            return new(Unit);        
        }

        public static implicit operator TorquePerLength(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<TorquePerLengthUnit>(_unit);
	}
}

