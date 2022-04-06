
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MagneticFlux : BaseUnit
    {

        public MagneticFlux() { }
        public MagneticFlux(decimal value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(double value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(int value, MagneticFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MagneticFlux(UnknownUnit value) : base(value) { }

        public static MagneticFlux From(double value, MagneticFluxUnit unit) => new(value, unit);

        public static MagneticFlux From(double? value, MagneticFluxUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(MagneticFluxUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public MagneticFlux ToUnit(MagneticFluxUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static MagneticFlux Zero => new(0, MagneticFluxUnit.SI);

        public static implicit operator MagneticFlux(UnknownUnit Unit)
        {
            UnitCheck(Unit, MagneticFluxUnit.SI);
            return new(Unit);        
        }

        public static implicit operator MagneticFlux(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MagneticFluxUnit>(_unit);
	}
}

