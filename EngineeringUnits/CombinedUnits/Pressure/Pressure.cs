using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Pressure : BaseUnit
    {

        public Pressure() { }
        public Pressure(decimal value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Pressure(double value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Pressure(int value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Pressure(UnknownUnit value) : base(value) { }

        public Pressure(UnknownUnit value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Pressure From(double value, PressureUnit unit) => new Pressure(value, unit);
        public double As(PressureUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Pressure ToUnit(PressureUnit selectedUnit) => new Pressure(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Pressure Zero => new Pressure(0, PressureUnit.SI);

        public static implicit operator Pressure(UnknownUnit Unit) => new Pressure(Unit, PressureUnit.SI);
    }
}
