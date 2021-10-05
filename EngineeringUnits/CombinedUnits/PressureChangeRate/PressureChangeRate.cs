using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class PressureChangeRate : BaseUnit
    {

        public PressureChangeRate() { }
        public PressureChangeRate(decimal value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(double value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(int value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public PressureChangeRate(UnknownUnit value) : base(value) { }

        public PressureChangeRate(UnknownUnit value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static PressureChangeRate From(double value, PressureChangeRateUnit unit) => new(value, unit);
        public double As(PressureChangeRateUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public PressureChangeRate ToUnit(PressureChangeRateUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static PressureChangeRate Zero => new(0, PressureChangeRateUnit.SI);

        public static implicit operator PressureChangeRate(UnknownUnit Unit) => new(Unit, PressureChangeRateUnit.SI);
    }
}
