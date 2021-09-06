using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Angle : BaseUnit
    {

        public Angle() { }
        public Angle(decimal value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(double value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(int value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(UnknownUnit value) : base(value) { }

        public Angle(UnknownUnit value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Angle From(double value, AngleUnit unit) => new Angle(value, unit);
        public double As(AngleUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Angle ToUnit(AngleUnit selectedUnit) => new Angle(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Angle Zero => new Angle(0, AngleUnit.SI);

        public static implicit operator Angle(UnknownUnit Unit) => new Angle(Unit, AngleUnit.SI);

    }
}
