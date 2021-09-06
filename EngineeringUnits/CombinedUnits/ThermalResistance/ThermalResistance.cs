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

        public static ThermalResistance From(double value, ThermalResistanceUnit unit) => new ThermalResistance(value, unit);
        public double As(ThermalResistanceUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public ThermalResistance ToUnit(ThermalResistanceUnit selectedUnit) => new ThermalResistance(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static ThermalResistance Zero => new ThermalResistance(0, ThermalResistanceUnit.SI);

        public static implicit operator ThermalResistance(UnknownUnit Unit) => new ThermalResistance(Unit, ThermalResistanceUnit.SI);
    }
}
