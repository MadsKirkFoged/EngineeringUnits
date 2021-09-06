using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Molarity : BaseUnit
    {

        public Molarity() { }
        public Molarity(decimal value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Molarity(double value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Molarity(int value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Molarity(UnknownUnit value) : base(value) { }

        public Molarity(UnknownUnit value, MolarityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Molarity From(double value, MolarityUnit unit) => new Molarity(value, unit);
        public double As(MolarityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Molarity ToUnit(MolarityUnit selectedUnit) => new Molarity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Molarity Zero => new Molarity(0, MolarityUnit.SI);

        public static implicit operator Molarity(UnknownUnit Unit) => new Molarity(Unit, MolarityUnit.SI);

    }
}
