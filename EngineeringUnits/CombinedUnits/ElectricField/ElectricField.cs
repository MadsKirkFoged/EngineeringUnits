
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricField : BaseUnit
    {

        public ElectricField() { }
        public ElectricField(decimal value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(double value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(int value, ElectricFieldUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricField(UnknownUnit value) : base(value) { }

        public static ElectricField From(double value, ElectricFieldUnit unit) => new(value, unit);

        public static ElectricField From(double? value, ElectricFieldUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricFieldUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ElectricField ToUnit(ElectricFieldUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricField Zero => new(0, ElectricFieldUnit.SI);
        public static ElectricField NaN => new(double.NaN, ElectricFieldUnit.SI);

        public static implicit operator ElectricField(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(ElectricFieldUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricField(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricFieldUnit>(_unit);
	}
}

