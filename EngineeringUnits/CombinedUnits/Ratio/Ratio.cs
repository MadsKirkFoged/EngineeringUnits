using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Ratio : BaseUnit
    {

        public Ratio()
        {
            Unit = RatioUnit.SI.Unit;
        }


        public Ratio(decimal value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(double value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(int value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(UnknownUnit value) : base(value) { }


        public static Ratio From(double value, RatioUnit unit) => new Ratio(value, unit);
        public double As(RatioUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Ratio ToUnit(RatioUnit selectedUnit) => new Ratio(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Ratio Zero => new Ratio(0, RatioUnit.SI);

        public static implicit operator Ratio(UnknownUnit Unit) => new Ratio(Unit);
    }
}
