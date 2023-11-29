
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class LuminousFlux : BaseUnit
    {

        public LuminousFlux() { }
        public LuminousFlux(decimal value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(double value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(int value, LuminousFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LuminousFlux(UnknownUnit value) : base(value) { }

        public static LuminousFlux From(double value, LuminousFluxUnit unit) => new(value, unit);

        public static LuminousFlux From(double? value, LuminousFluxUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(LuminousFluxUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit);
        public LuminousFlux ToUnit(LuminousFluxUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static LuminousFlux Zero => new(0, LuminousFluxUnit.SI);
        public static LuminousFlux NaN => new(double.NaN, LuminousFluxUnit.SI);

        public static implicit operator LuminousFlux(UnknownUnit Unit)
        {
            if (Unit is null)
                return null; 

            Unit.UnitCheck(LuminousFluxUnit.SI);
            return new(Unit);        
        }

        public static implicit operator LuminousFlux(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LuminousFluxUnit>(_unit);
	}
}

