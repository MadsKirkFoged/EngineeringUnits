using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Density : BaseUnit
    {

        public Density() { }
        public Density(decimal value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(double value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(int value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Density(UnknownUnit value) : base(value) { }

        public Density(UnknownUnit value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Density From(double value, DensityUnit unit) => new(value, unit);
        public double As(DensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Density ToUnit(DensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Density Zero => new(0, DensityUnit.SI);

        public static implicit operator Density(UnknownUnit Unit) => new(Unit, DensityUnit.SI);

        public static implicit operator Density(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
