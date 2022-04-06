
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ThermalResistance : BaseUnit
    {

        public ThermalResistance() { }
        public ThermalResistance(decimal value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalResistance(double value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalResistance(int value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public ThermalResistance(UnknownUnit value) : base(value) { }

        public static ThermalResistance From(double value, ThermalResistanceUnit unit) => new(value, unit);

        public static ThermalResistance From(double? value, ThermalResistanceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(ThermalResistanceUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);
        public ThermalResistance ToUnit(ThermalResistanceUnit selectedUnit) => new(GetValueAs(selectedUnit.Unit), selectedUnit);
        public static ThermalResistance Zero => new(0, ThermalResistanceUnit.SI);

        public static implicit operator ThermalResistance(UnknownUnit Unit)
        {
            UnitCheck(Unit, ThermalResistanceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator ThermalResistance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ThermalResistanceUnit>(_unit);
	}
}

