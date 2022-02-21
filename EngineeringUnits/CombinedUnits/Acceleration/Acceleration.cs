
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Acceleration : BaseUnit
    {

        public Acceleration() { }
        public Acceleration(decimal value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(double value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(int value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(UnknownUnit value) : base(value) { }

        public static Acceleration From(double value, AccelerationUnit unit) => new(value, unit);

        public static Acceleration From(double? value, AccelerationUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(AccelerationUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Acceleration ToUnit(AccelerationUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Acceleration Zero => new(0, AccelerationUnit.SI);

        public static implicit operator Acceleration(UnknownUnit Unit) => new(Unit);

        public static implicit operator Acceleration(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AccelerationUnit>(_unit);
	}
}

