
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Illuminance : BaseUnit
    {

        public Illuminance() { }
        public Illuminance(decimal value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(double value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(int value, IlluminanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Illuminance(UnknownUnit value) : base(value) { }

        public static Illuminance From(double value, IlluminanceUnit unit) => new(value, unit);

        public static Illuminance From(double? value, IlluminanceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(IlluminanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Illuminance ToUnit(IlluminanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Illuminance Zero => new(0, IlluminanceUnit.SI);

        public static implicit operator Illuminance(UnknownUnit Unit)
        {
            UnitCheck(Unit, IlluminanceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Illuminance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<IlluminanceUnit>(_unit);
	}
}

