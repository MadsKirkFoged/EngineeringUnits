
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MolarMass : BaseUnit
    {

        public MolarMass() { }
        public MolarMass(decimal value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarMass(double value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarMass(int value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarMass(UnknownUnit value) : base(value) { }

        public static MolarMass From(double value, MolarMassUnit unit) => new(value, unit);

        public static MolarMass From(double? value, MolarMassUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MolarMassUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public MolarMass ToUnit(MolarMassUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MolarMass Zero => new(0, MolarMassUnit.SI);
        public static MolarMass NaN => new(double.NaN, MolarMassUnit.SI);

        public static implicit operator MolarMass(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(MolarMassUnit.SI);
            return new(Unit);        
        }

        public static implicit operator MolarMass(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MolarMassUnit>(_unit);
	}
}

