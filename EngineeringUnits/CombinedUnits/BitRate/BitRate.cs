
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class BitRate : BaseUnit
    {

        public BitRate() { }
        public BitRate(decimal value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(double value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(int value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(UnknownUnit value) : base(value) { }

        public static BitRate From(double value, BitRateUnit unit) => new(value, unit);

        public static BitRate From(double? value, BitRateUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(BitRateUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public BitRate ToUnit(BitRateUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static BitRate Zero => new(0, BitRateUnit.SI);

        public static implicit operator BitRate(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(BitRateUnit.SI);
            return new(Unit);        
        }

        public static implicit operator BitRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<BitRateUnit>(_unit);
	}
}

