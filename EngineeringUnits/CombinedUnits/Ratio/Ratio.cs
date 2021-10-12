using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class Ratio : BaseUnit
    {

        public Ratio() { }
        public Ratio(decimal value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(double value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(int value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Ratio(UnknownUnit value) : base(value) { }

        public Ratio(UnknownUnit value, RatioUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Ratio From(double value, RatioUnit unit) => new(value, unit);
        public double As(RatioUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Ratio ToUnit(RatioUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Ratio Zero => new(0, RatioUnit.SI);

        public static implicit operator Ratio(UnknownUnit Unit) => new(Unit, RatioUnit.SI);

        public static implicit operator Ratio(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
