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

        public static LapseRate From(double value, LapseRateUnit unit) => new(value, unit);
        public double As(LapseRateUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public LapseRate ToUnit(LapseRateUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LapseRate Zero => new(0, LapseRateUnit.SI);

        public static implicit operator LapseRate(UnknownUnit Unit) => new(Unit, LapseRateUnit.SI);

        public static implicit operator LapseRate(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
