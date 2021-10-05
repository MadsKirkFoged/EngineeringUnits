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

        public static Duration From(double value, DurationUnit unit) => new(value, unit);
        public double As(DurationUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Duration ToUnit(DurationUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Duration Zero => new(0, DurationUnit.SI);

        public static implicit operator Duration(UnknownUnit Unit) => new(Unit, DurationUnit.SI);


    }
}
