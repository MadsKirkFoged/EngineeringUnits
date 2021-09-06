using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarEntropy : BaseUnit
    {

        public MolarEntropy() { }
        public MolarEntropy(decimal value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(double value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(int value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarEntropy(UnknownUnit value) : base(value) { }

        public MolarEntropy(UnknownUnit value, MolarEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MolarEntropy From(double value, MolarEntropyUnit unit) => new MolarEntropy(value, unit);
        public double As(MolarEntropyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MolarEntropy ToUnit(MolarEntropyUnit selectedUnit) => new MolarEntropy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MolarEntropy Zero => new MolarEntropy(0, MolarEntropyUnit.SI);

        public static implicit operator MolarEntropy(UnknownUnit Unit) => new MolarEntropy(Unit, MolarEntropyUnit.SI);

    }
}
