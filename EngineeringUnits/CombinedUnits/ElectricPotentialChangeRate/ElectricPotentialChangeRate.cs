
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ElectricPotentialChangeRate : BaseUnit
    {

        public ElectricPotentialChangeRate() { }
        public ElectricPotentialChangeRate(decimal value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialChangeRate(double value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialChangeRate(int value, ElectricPotentialChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricPotentialChangeRate(UnknownUnit value) : base(value) { }

        public static ElectricPotentialChangeRate From(double value, ElectricPotentialChangeRateUnit unit) => new(value, unit);

        public static ElectricPotentialChangeRate From(double? value, ElectricPotentialChangeRateUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricPotentialChangeRateUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ElectricPotentialChangeRate ToUnit(ElectricPotentialChangeRateUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ElectricPotentialChangeRate Zero => new(0, ElectricPotentialChangeRateUnit.SI);

        public static implicit operator ElectricPotentialChangeRate(UnknownUnit Unit)
        {
            UnitCheck(Unit, ElectricPotentialChangeRateUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricPotentialChangeRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricPotentialChangeRateUnit>(_unit);
	}
}

