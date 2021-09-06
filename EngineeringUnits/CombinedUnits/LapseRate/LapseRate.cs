using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class LapseRate : BaseUnit
    {

        public LapseRate() { }
        public LapseRate(decimal value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LapseRate(double value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LapseRate(int value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LapseRate(UnknownUnit value) : base(value) { }

        public LapseRate(UnknownUnit value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static LapseRate From(double value, LapseRateUnit unit) => new LapseRate(value, unit);
        public double As(LapseRateUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public LapseRate ToUnit(LapseRateUnit selectedUnit) => new LapseRate(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LapseRate Zero => new LapseRate(0, LapseRateUnit.SI);

        public static implicit operator LapseRate(UnknownUnit Unit) => new LapseRate(Unit, LapseRateUnit.SI);

    }
}
