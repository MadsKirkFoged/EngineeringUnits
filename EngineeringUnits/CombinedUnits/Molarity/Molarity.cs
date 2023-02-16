
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Molarity : BaseUnit
    {

        public Molarity() { }
        public Molarity(decimal value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Molarity(double value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Molarity(int value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Molarity(UnknownUnit value) : base(value) { }

        public static Molarity From(double value, MolarityUnit unit) => new(value, unit);

        public static Molarity From(double? value, MolarityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MolarityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Molarity ToUnit(MolarityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Molarity Zero => new(0, MolarityUnit.SI);

        public static implicit operator Molarity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(MolarityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Molarity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarityUnit>(_unit);
	}
}

