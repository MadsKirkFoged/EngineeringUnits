
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class HeatFlux : BaseUnit
    {

        public HeatFlux() { }
        public HeatFlux(decimal value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(double value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(int value, HeatFluxUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public HeatFlux(UnknownUnit value) : base(value) { }

        public static HeatFlux From(double value, HeatFluxUnit unit) => new(value, unit);

        public static HeatFlux From(double? value, HeatFluxUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(HeatFluxUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public HeatFlux ToUnit(HeatFluxUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static HeatFlux Zero => new(0, HeatFluxUnit.SI);

        public static implicit operator HeatFlux(UnknownUnit Unit)
        {
            Unit.UnitCheck(HeatFluxUnit.SI);
            return new(Unit);        
        }

        public static implicit operator HeatFlux(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<HeatFluxUnit>(_unit);
	}
}

