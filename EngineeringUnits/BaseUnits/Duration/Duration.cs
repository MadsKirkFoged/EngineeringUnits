
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Duration : BaseUnit
    {

        public Duration() { }
        public Duration(decimal value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(double value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(int value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(UnknownUnit value) : base(value) { }

        public static Duration From(double value, DurationUnit unit) => new(value, unit);

        public static Duration From(double? value, DurationUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(DurationUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Duration ToUnit(DurationUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Duration Zero => new(0, DurationUnit.SI);

        public static implicit operator Duration(UnknownUnit Unit) => new(Unit);

        public static implicit operator Duration(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<DurationUnit>(_unit);
	}
}

