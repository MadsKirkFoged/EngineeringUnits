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

        public ThermalResistance(UnknownUnit value, ThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static ThermalResistance From(double value, ThermalResistanceUnit unit) => new(value, unit);
        public double As(ThermalResistanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public ThermalResistance ToUnit(ThermalResistanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ThermalResistance Zero => new(0, ThermalResistanceUnit.SI);

        public static implicit operator ThermalResistance(UnknownUnit Unit) => new(Unit, ThermalResistanceUnit.SI);

        public static implicit operator ThermalResistance(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
