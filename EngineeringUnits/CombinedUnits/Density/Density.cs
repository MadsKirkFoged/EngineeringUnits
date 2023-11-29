
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Density : BaseUnit
    {

        public Density() { }
        public Density(decimal value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(double value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(int value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(UnknownUnit value) : base(value) { }

        public static Density From(double value, DensityUnit unit) => new(value, unit);

        public static Density From(double? value, DensityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(DensityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public Density ToUnit(DensityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Density Zero => new(0, DensityUnit.SI);
        public static Density NaN => new(double.NaN, DensityUnit.SI);

        public static implicit operator Density(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(DensityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Density(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<DensityUnit>(_unit);
	}
}

