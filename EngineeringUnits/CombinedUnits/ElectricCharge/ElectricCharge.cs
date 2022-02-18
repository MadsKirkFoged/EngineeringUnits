
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricCharge : BaseUnit
    {

        public ElectricCharge() { }
        public ElectricCharge(decimal value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(double value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(int value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(UnknownUnit value) : base(value) { }

        public static ElectricCharge From(double value, ElectricChargeUnit unit) => new(value, unit);
        public double As(ElectricChargeUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricCharge ToUnit(ElectricChargeUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricCharge Zero => new(0, ElectricChargeUnit.SI);

        public static implicit operator ElectricCharge(UnknownUnit Unit) => new(Unit);

        public static implicit operator ElectricCharge(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricChargeUnit>(_unit);
	}
}

