using EngineeringUnits.Units;

namespace EngineeringUnits
{

    public partial class SpecificEntropy : BaseUnit
    {
        public SpecificEntropy() { }
        public SpecificEntropy(decimal value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(double value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(int value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public SpecificEntropy(UnknownUnit value) : base(value) { }

        public SpecificEntropy(UnknownUnit value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static SpecificEntropy From(double value, SpecificEntropyUnit unit) => new SpecificEntropy(value, unit);
        public double As(SpecificEntropyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public SpecificEntropy ToUnit(SpecificEntropyUnit selectedUnit) => new SpecificEntropy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static SpecificEntropy Zero => new SpecificEntropy(0, SpecificEntropyUnit.SI);

        public static implicit operator SpecificEntropy(UnknownUnit Unit) => new SpecificEntropy(Unit, SpecificEntropyUnit.SI);
    }
}
