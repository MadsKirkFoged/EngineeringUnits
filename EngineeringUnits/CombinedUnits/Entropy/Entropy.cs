using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Entropy : BaseUnit
    {

        public Entropy() { }
        public Entropy(decimal value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Entropy(double value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Entropy(int value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Entropy(UnknownUnit value) : base(value) { }

        public Entropy(UnknownUnit value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Entropy From(double value, EntropyUnit unit) => new Entropy(value, unit);
        public double As(EntropyUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Entropy ToUnit(EntropyUnit selectedUnit) => new Entropy(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Entropy Zero => new Entropy(0, EntropyUnit.SI);

        public static implicit operator Entropy(UnknownUnit Unit) => new Entropy(Unit, EntropyUnit.SI);


    }
}
