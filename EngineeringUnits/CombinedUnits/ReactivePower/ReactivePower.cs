
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class ReactivePower : BaseUnit
    {

        public ReactivePower() { }
        public ReactivePower(decimal value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactivePower(double value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactivePower(int value, ReactivePowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ReactivePower(UnknownUnit value) : base(value) { }

        public static ReactivePower From(double value, ReactivePowerUnit unit) => new(value, unit);

        public static ReactivePower From(double? value, ReactivePowerUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ReactivePowerUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ReactivePower ToUnit(ReactivePowerUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ReactivePower Zero => new(0, ReactivePowerUnit.SI);

        public static implicit operator ReactivePower(UnknownUnit Unit)
        {
            Unit.UnitCheck(ReactivePowerUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ReactivePower(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ReactivePowerUnit>(_unit);
	}
}

