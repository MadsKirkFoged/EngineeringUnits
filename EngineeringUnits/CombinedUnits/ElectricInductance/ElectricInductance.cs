
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricInductance : BaseUnit
    {

        public ElectricInductance() { }
        public ElectricInductance(decimal value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(double value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(int value, ElectricInductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricInductance(UnknownUnit value) : base(value) { }

        public static ElectricInductance From(double value, ElectricInductanceUnit unit) => new(value, unit);

        public static ElectricInductance From(double? value, ElectricInductanceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricInductanceUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public ElectricInductance ToUnit(ElectricInductanceUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricInductance Zero => new(0, ElectricInductanceUnit.SI);
        public static ElectricInductance NaN => new(double.NaN, ElectricInductanceUnit.SI);

        public static implicit operator ElectricInductance(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(ElectricInductanceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricInductance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricInductanceUnit>(_unit);
	}
}

