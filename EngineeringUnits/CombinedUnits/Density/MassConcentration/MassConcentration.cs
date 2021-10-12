using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class MassConcentration : BaseUnit
    {

        public MassConcentration()
        {
            //Unit = DensityUnit.SI.Unit.Copy();
        }

        public MassConcentration(decimal value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassConcentration(double value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassConcentration(int value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public MassConcentration(UnknownUnit value) : base(value) { }

        public static MassConcentration From(double value, DensityUnit unit) => new(value, unit);
        public double As(DensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public MassConcentration ToUnit(DensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassConcentration Zero => new(0, DensityUnit.SI);

        public static implicit operator MassConcentration(UnknownUnit Unit) => new(Unit);

        public static implicit operator MassConcentration(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }




    }
}
