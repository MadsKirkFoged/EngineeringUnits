
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ThermalConductivity : BaseUnit
    {

        public ThermalConductivity() { }
        public ThermalConductivity(decimal value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(double value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(int value, ThermalConductivityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalConductivity(UnknownUnit value) : base(value) { }

        public static ThermalConductivity From(double value, ThermalConductivityUnit unit) => new(value, unit);

        public static ThermalConductivity From(double? value, ThermalConductivityUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ThermalConductivityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ThermalConductivity ToUnit(ThermalConductivityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ThermalConductivity Zero => new(0, ThermalConductivityUnit.SI);

        public static implicit operator ThermalConductivity(UnknownUnit Unit) => new(Unit);

        public static implicit operator ThermalConductivity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ThermalConductivityUnit>(_unit);
	}
}

