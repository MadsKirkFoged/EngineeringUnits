
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class MassFlux : BaseUnit
    {

        public MassFlux() { }
        public MassFlux(decimal value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(double value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(int value, MassFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassFlux(UnknownUnit value) : base(value) { }

        public static MassFlux From(double value, MassFluxUnit unit) => new(value, unit);

        public static MassFlux From(double? value, MassFluxUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MassFluxUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public MassFlux ToUnit(MassFluxUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MassFlux Zero => new(0, MassFluxUnit.SI);
        public static MassFlux NaN => new(double.NaN, MassFluxUnit.SI);

        public static implicit operator MassFlux(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            GuardAgainst.DifferentUnits(Unit, MassFluxUnit.SI);
            return new(Unit);        
        }

        public static implicit operator MassFlux(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassFluxUnit>(_unit);
	}
}

