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

        public static MolarMass From(double value, MolarMassUnit unit) => new(value, unit);
        public double As(MolarMassUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MolarMass ToUnit(MolarMassUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MolarMass Zero => new(0, MolarMassUnit.SI);

        public static implicit operator MolarMass(UnknownUnit Unit) => new(Unit, MolarMassUnit.SI);

        public static implicit operator MolarMass(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
