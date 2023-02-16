
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Ratio : BaseUnit
    {

        public Ratio() { }
        public Ratio(decimal value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(double value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(int value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(UnknownUnit value) : base(value) { }

        public static Ratio From(double value, RatioUnit unit) => new(value, unit);

        public static Ratio From(double? value, RatioUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(RatioUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Ratio ToUnit(RatioUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Ratio Zero => new(0, RatioUnit.SI);

        public static implicit operator Ratio(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(RatioUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Ratio(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<RatioUnit>(_unit);
	}
}

