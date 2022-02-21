
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ForceChangeRate : BaseUnit
    {

        public ForceChangeRate() { }
        public ForceChangeRate(decimal value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(double value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(int value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForceChangeRate(UnknownUnit value) : base(value) { }

        public static ForceChangeRate From(double value, ForceChangeRateUnit unit) => new(value, unit);

        public static ForceChangeRate From(double? value, ForceChangeRateUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ForceChangeRateUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ForceChangeRate ToUnit(ForceChangeRateUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ForceChangeRate Zero => new(0, ForceChangeRateUnit.SI);

        public static implicit operator ForceChangeRate(UnknownUnit Unit) => new(Unit);

        public static implicit operator ForceChangeRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ForceChangeRateUnit>(_unit);
	}
}

