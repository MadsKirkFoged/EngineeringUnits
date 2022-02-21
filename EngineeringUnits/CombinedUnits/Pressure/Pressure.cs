
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Pressure : BaseUnit
    {

        public Pressure() { }
        public Pressure(decimal value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Pressure(double value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Pressure(int value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Pressure(UnknownUnit value) : base(value) { }

        public static Pressure From(double value, PressureUnit unit) => new(value, unit);

        public static Pressure From(double? value, PressureUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(PressureUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Pressure ToUnit(PressureUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Pressure Zero => new(0, PressureUnit.SI);

        public static implicit operator Pressure(UnknownUnit Unit) => new(Unit);

        public static implicit operator Pressure(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PressureUnit>(_unit);
	}
}

