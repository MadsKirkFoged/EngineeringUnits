
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Power : BaseUnit
    {

        public Power() { }
        public Power(decimal value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(double value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(int value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Power(UnknownUnit value) : base(value) { }

        public static Power From(double value, PowerUnit unit) => new(value, unit);
        public double As(PowerUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Power ToUnit(PowerUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Power Zero => new(0, PowerUnit.SI);

        public static implicit operator Power(UnknownUnit Unit) => new(Unit);

        public static implicit operator Power(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PowerUnit>(_unit);
	}
}

