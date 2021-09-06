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


        public static MassConcentration From(double value, DensityUnit unit) => new MassConcentration(value, unit);
        public double As(DensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public MassConcentration ToUnit(DensityUnit selectedUnit) => new MassConcentration(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static MassConcentration Zero => new MassConcentration(0, DensityUnit.SI);

        public static implicit operator MassConcentration(UnknownUnit Unit)
        {
            MassConcentration local = new MassConcentration(0, DensityUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
