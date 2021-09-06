using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Duration : BaseUnit
    {

        public Duration() { }
        public Duration(decimal value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(double value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(int value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Duration(UnknownUnit value) : base(value) { }

        public Duration(UnknownUnit value, DurationUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Duration From(double value, DurationUnit unit) => new Duration(value, unit);
        public double As(DurationUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Duration ToUnit(DurationUnit selectedUnit) => new Duration(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Duration Zero => new Duration(0, DurationUnit.SI);

        public static implicit operator Duration(UnknownUnit Unit) => new Duration(Unit, DurationUnit.SI);


    }
}
