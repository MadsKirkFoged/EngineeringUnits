
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Mass : BaseUnit
    {

        public Mass() { }
        public Mass(decimal value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Mass(double value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Mass(int value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Mass(UnknownUnit value) : base(value) { }

        public static Mass From(double value, MassUnit unit) => new(value, unit);
        public double As(MassUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Mass ToUnit(MassUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Mass Zero => new(0, MassUnit.SI);

        public static implicit operator Mass(UnknownUnit Unit) => new(Unit);

        public static implicit operator Mass(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassUnit>(_unit);
	}
}

