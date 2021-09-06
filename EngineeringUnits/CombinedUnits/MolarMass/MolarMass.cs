using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MolarMass : BaseUnit
    {

        public MolarMass() { }
        public MolarMass(decimal value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarMass(double value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarMass(int value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MolarMass(UnknownUnit value) : base(value) { }

        public MolarMass(UnknownUnit value, MolarMassUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static MolarMass From(double value, MolarMassUnit unit) => new MolarMass(value, unit);
        public double As(MolarMassUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MolarMass ToUnit(MolarMassUnit selectedUnit) => new MolarMass(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MolarMass Zero => new MolarMass(0, MolarMassUnit.SI);

        public static implicit operator MolarMass(UnknownUnit Unit) => new MolarMass(Unit, MolarMassUnit.SI);
    }
}
