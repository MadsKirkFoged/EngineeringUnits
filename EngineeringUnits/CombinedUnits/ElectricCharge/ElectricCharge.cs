
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ElectricCharge : BaseUnit
    {

        public ElectricCharge() { }
        public ElectricCharge(decimal value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(double value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(int value, ElectricChargeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ElectricCharge(UnknownUnit value) : base(value) { }

        public static ElectricCharge From(double value, ElectricChargeUnit unit) => new(value, unit);

        public static ElectricCharge From(double? value, ElectricChargeUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ElectricChargeUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public ElectricCharge ToUnit(ElectricChargeUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ElectricCharge Zero => new(0, ElectricChargeUnit.SI);
        public static ElectricCharge NaN => new(double.NaN, ElectricChargeUnit.SI);

        public static implicit operator ElectricCharge(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, ElectricChargeUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ElectricCharge(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricChargeUnit>(_unit);
	}
}

