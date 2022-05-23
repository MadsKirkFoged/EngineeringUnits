
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Area : BaseUnit
    {

        public Area() { }
        public Area(decimal value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Area(double value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Area(int value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Area(UnknownUnit value) : base(value) { }

        public static Area From(double value, AreaUnit unit) => new(value, unit);

        public static Area From(double? value, AreaUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(AreaUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public Area ToUnit(AreaUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Area Zero => new(0, AreaUnit.SI);

        public static implicit operator Area(UnknownUnit Unit)
        {
            UnitCheck(Unit, AreaUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Area(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AreaUnit>(_unit);
	}
}

