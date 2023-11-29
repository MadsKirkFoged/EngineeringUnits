
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Speed : BaseUnit
    {

        public Speed() { }
        public Speed(decimal value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(double value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(int value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(UnknownUnit value) : base(value) { }

        public static Speed From(double value, SpeedUnit unit) => new(value, unit);

        public static Speed From(double? value, SpeedUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpeedUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public Speed ToUnit(SpeedUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Speed Zero => new(0, SpeedUnit.SI);
        public static Speed NaN => new(double.NaN, SpeedUnit.SI);

        public static implicit operator Speed(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(SpeedUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Speed(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpeedUnit>(_unit);
	}
}

