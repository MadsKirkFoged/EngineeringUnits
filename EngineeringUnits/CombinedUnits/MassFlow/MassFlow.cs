
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MassFlow : BaseUnit
    {

        public MassFlow() { }
        public MassFlow(decimal value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(double value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(int value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlow(UnknownUnit value) : base(value) { }

        public static MassFlow From(double value, MassFlowUnit unit) => new(value, unit);
        public double As(MassFlowUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MassFlow ToUnit(MassFlowUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassFlow Zero => new(0, MassFlowUnit.SI);

        public static implicit operator MassFlow(UnknownUnit Unit) => new(Unit);

        public static implicit operator MassFlow(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassFlowUnit>(_unit);
	}
}

