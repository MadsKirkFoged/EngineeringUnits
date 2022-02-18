
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class VolumeFlow : BaseUnit
    {

        public VolumeFlow() { }
        public VolumeFlow(decimal value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(double value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(int value, VolumeFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public VolumeFlow(UnknownUnit value) : base(value) { }

        public static VolumeFlow From(double value, VolumeFlowUnit unit) => new(value, unit);
        public double As(VolumeFlowUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public VolumeFlow ToUnit(VolumeFlowUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static VolumeFlow Zero => new(0, VolumeFlowUnit.SI);

        public static implicit operator VolumeFlow(UnknownUnit Unit) => new(Unit);

        public static implicit operator VolumeFlow(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumeFlowUnit>(_unit);
	}
}

