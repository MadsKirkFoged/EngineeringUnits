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

        public static Molarity From(double value, MolarityUnit unit) => new(value, unit);
        public double As(MolarityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Molarity ToUnit(MolarityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Molarity Zero => new(0, MolarityUnit.SI);

        public static implicit operator Molarity(UnknownUnit Unit) => new(Unit, MolarityUnit.SI);

    }
}
