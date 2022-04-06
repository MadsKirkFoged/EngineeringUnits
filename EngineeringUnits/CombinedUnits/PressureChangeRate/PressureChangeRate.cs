
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class PressureChangeRate : BaseUnit
    {

        public PressureChangeRate() { }
        public PressureChangeRate(decimal value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(double value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(int value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(UnknownUnit value) : base(value) { }

        public static PressureChangeRate From(double value, PressureChangeRateUnit unit) => new(value, unit);

        public static PressureChangeRate From(double? value, PressureChangeRateUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(PressureChangeRateUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public PressureChangeRate ToUnit(PressureChangeRateUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static PressureChangeRate Zero => new(0, PressureChangeRateUnit.SI);

        public static implicit operator PressureChangeRate(UnknownUnit Unit)
        {
            UnitCheck(Unit, PressureChangeRateUnit.SI);
            return new(Unit);        
        }

        public static implicit operator PressureChangeRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PressureChangeRateUnit>(_unit);
	}
}

