
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Force : BaseUnit
    {

        public Force() { }
        public Force(decimal value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Force(double value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Force(int value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Force(UnknownUnit value) : base(value) { }

        public static Force From(double value, ForceUnit unit) => new(value, unit);

        public static Force From(double? value, ForceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ForceUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Force ToUnit(ForceUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Force Zero => new(0, ForceUnit.SI);

        public static implicit operator Force(UnknownUnit Unit)
        {
            UnitCheck(Unit, ForceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Force(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ForceUnit>(_unit);
	}
}

