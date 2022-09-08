
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricResistance : BaseUnit
    {

        public ElectricResistance() { }
        public ElectricResistance(decimal value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(double value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(int value, ElectricResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricResistance(UnknownUnit value) : base(value) { }

        public static ElectricResistance From(double value, ElectricResistanceUnit unit) => new(value, unit);

        public static ElectricResistance From(double? value, ElectricResistanceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricResistanceUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricResistance ToUnit(ElectricResistanceUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricResistance Zero => new(0, ElectricResistanceUnit.SI);

        public static implicit operator ElectricResistance(UnknownUnit Unit)
        {
            Unit.UnitCheck(ElectricResistanceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricResistance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricResistanceUnit>(_unit);
	}
}

