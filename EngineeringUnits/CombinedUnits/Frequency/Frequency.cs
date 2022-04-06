
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Frequency : BaseUnit
    {

        public Frequency() { }
        public Frequency(decimal value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(double value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(int value, FrequencyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Frequency(UnknownUnit value) : base(value) { }

        public static Frequency From(double value, FrequencyUnit unit) => new(value, unit);

        public static Frequency From(double? value, FrequencyUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(FrequencyUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Frequency ToUnit(FrequencyUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Frequency Zero => new(0, FrequencyUnit.SI);

        public static implicit operator Frequency(UnknownUnit Unit)
        {
            UnitCheck(Unit, FrequencyUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Frequency(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<FrequencyUnit>(_unit);
	}
}

