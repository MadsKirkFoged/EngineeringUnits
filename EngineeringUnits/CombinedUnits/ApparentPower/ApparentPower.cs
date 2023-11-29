
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ApparentPower : BaseUnit
    {

        public ApparentPower() { }
        public ApparentPower(decimal value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(double value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(int value, ApparentPowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ApparentPower(UnknownUnit value) : base(value) { }

        public static ApparentPower From(double value, ApparentPowerUnit unit) => new(value, unit);

        public static ApparentPower From(double? value, ApparentPowerUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ApparentPowerUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public ApparentPower ToUnit(ApparentPowerUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ApparentPower Zero => new(0, ApparentPowerUnit.SI);
        public static ApparentPower NaN => new(double.NaN, ApparentPowerUnit.SI);

        public static implicit operator ApparentPower(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, ApparentPowerUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ApparentPower(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ApparentPowerUnit>(_unit);
	}
}

