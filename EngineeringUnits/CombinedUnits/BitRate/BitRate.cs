using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class BitRate : BaseUnit
    {

        public BitRate() { }
        public BitRate(decimal value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(double value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(int value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public BitRate(UnknownUnit value) : base(value) { }

        public BitRate(UnknownUnit value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static BitRate From(double value, BitRateUnit unit) => new(value, unit);
        public double As(BitRateUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public BitRate ToUnit(BitRateUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static BitRate Zero => new(0, BitRateUnit.SI);

        public static implicit operator BitRate(UnknownUnit Unit) => new(Unit, BitRateUnit.SI);

    }
}
