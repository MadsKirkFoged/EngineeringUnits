using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Capacitance : BaseUnit
    {

        public Capacitance() { }
        public Capacitance(decimal value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Capacitance(double value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Capacitance(int value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Capacitance(UnknownUnit value) : base(value) { }

        public Capacitance(UnknownUnit value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Capacitance From(double value, CapacitanceUnit unit) => new(value, unit);
        public double As(CapacitanceUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Capacitance ToUnit(CapacitanceUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Capacitance Zero => new(0, CapacitanceUnit.SI);

        public static implicit operator Capacitance(UnknownUnit Unit) => new(Unit, CapacitanceUnit.SI);


    }
}
