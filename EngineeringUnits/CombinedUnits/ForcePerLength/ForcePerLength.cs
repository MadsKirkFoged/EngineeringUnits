
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ForcePerLength : BaseUnit
    {

        public ForcePerLength() { }
        public ForcePerLength(decimal value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(double value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(int value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ForcePerLength(UnknownUnit value) : base(value) { }

        public static ForcePerLength From(double value, ForcePerLengthUnit unit) => new(value, unit);

        public static ForcePerLength From(double? value, ForcePerLengthUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ForcePerLengthUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ForcePerLength ToUnit(ForcePerLengthUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ForcePerLength Zero => new(0, ForcePerLengthUnit.SI);

        public static implicit operator ForcePerLength(UnknownUnit Unit)
        {
            UnitCheck(Unit, ForcePerLengthUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ForcePerLength(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ForcePerLengthUnit>(_unit);
	}
}

