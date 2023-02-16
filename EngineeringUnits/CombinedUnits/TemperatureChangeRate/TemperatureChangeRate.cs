
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class TemperatureChangeRate : BaseUnit
    {

        public TemperatureChangeRate() { }
        public TemperatureChangeRate(decimal value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TemperatureChangeRate(double value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TemperatureChangeRate(int value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public TemperatureChangeRate(UnknownUnit value) : base(value) { }

        public static TemperatureChangeRate From(double value, TemperatureChangeRateUnit unit) => new(value, unit);

        public static TemperatureChangeRate From(double? value, TemperatureChangeRateUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(TemperatureChangeRateUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static TemperatureChangeRate Zero => new(0, TemperatureChangeRateUnit.SI);

        public static implicit operator TemperatureChangeRate(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(TemperatureChangeRateUnit.SI);
            return new(Unit);        
        }

        public static implicit operator TemperatureChangeRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<TemperatureChangeRateUnit>(_unit);
	}
}

