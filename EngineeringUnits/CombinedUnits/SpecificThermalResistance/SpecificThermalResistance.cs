
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class SpecificThermalResistance : BaseUnit
    {

        public SpecificThermalResistance() { }
        public SpecificThermalResistance(decimal value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificThermalResistance(double value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificThermalResistance(int value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificThermalResistance(UnknownUnit value) : base(value) { }

        public static SpecificThermalResistance From(double value, SpecificThermalResistanceUnit unit) => new(value, unit);

        public static SpecificThermalResistance From(double? value, SpecificThermalResistanceUnit unit)
        {
            if (value is null || unit is null)
            {
                return null;
            }

            return From((double)value, unit);
        }
        public double As(SpecificThermalResistanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public SpecificThermalResistance ToUnit(SpecificThermalResistanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static SpecificThermalResistance Zero => new(0, SpecificThermalResistanceUnit.SI);

        public static implicit operator SpecificThermalResistance(UnknownUnit Unit)
        {
            UnitCheck(Unit, SpecificThermalResistanceUnit.SI);
            return new(Unit);        
        }

        public static implicit operator SpecificThermalResistance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException("You need to give it a unit unless you set it to 0(zero)!");
			return Zero;
		}
	public override string GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificThermalResistanceUnit>(_unit);
	}
}

