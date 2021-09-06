using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class SpecificWeight : BaseUnit
    {

        public SpecificWeight() { }
        public SpecificWeight(decimal value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(double value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(int value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificWeight(UnknownUnit value) : base(value) { }

        public SpecificWeight(UnknownUnit value, SpecificWeightUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static SpecificWeight From(double value, SpecificWeightUnit unit) => new SpecificWeight(value, unit);
        public double As(SpecificWeightUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public SpecificWeight ToUnit(SpecificWeightUnit selectedUnit) => new SpecificWeight(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static SpecificWeight Zero => new SpecificWeight(0, SpecificWeightUnit.SI);

        public static implicit operator SpecificWeight(UnknownUnit Unit) => new SpecificWeight(Unit, SpecificWeightUnit.SI);
    }
}
