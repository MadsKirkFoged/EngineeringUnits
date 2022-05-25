
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Capacitance : BaseUnit
    {

        public Capacitance() { }
        public Capacitance(decimal value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Capacitance(double value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Capacitance(int value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Capacitance(UnknownUnit value) : base(value) { }

        public static Capacitance From(double value, CapacitanceUnit unit) => new(value, unit);

        public static Capacitance From(double? value, CapacitanceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(CapacitanceUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Capacitance ToUnit(CapacitanceUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Capacitance Zero => new(0, CapacitanceUnit.SI);

        public static implicit operator Capacitance(UnknownUnit Unit)
        {
            UnitCheck(Unit, CapacitanceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Capacitance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<CapacitanceUnit>(_unit);
	}
}

