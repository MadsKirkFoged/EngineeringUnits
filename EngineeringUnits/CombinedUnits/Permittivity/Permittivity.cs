
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Permittivity : BaseUnit
    {

        public Permittivity() { }
        public Permittivity(decimal value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(double value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(int value, PermittivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Permittivity(UnknownUnit value) : base(value) { }

        public static Permittivity From(double value, PermittivityUnit unit) => new(value, unit);

        public static Permittivity From(double? value, PermittivityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(PermittivityUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public Permittivity ToUnit(PermittivityUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static Permittivity Zero => new(0, PermittivityUnit.SI);
        public static Permittivity NaN => new(double.NaN, PermittivityUnit.SI);

        public static implicit operator Permittivity(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, PermittivityUnit.SI);
            return new(Unit);        
        }

        public static implicit operator Permittivity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PermittivityUnit>(_unit);
	}
}

