using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class KinematicViscosity : BaseUnit
    {

        public KinematicViscosity() { }
        public KinematicViscosity(decimal value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(double value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(int value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public KinematicViscosity(UnknownUnit value) : base(value) { }

        public KinematicViscosity(UnknownUnit value, KinematicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static KinematicViscosity From(double value, KinematicViscosityUnit unit) => new(value, unit);
        public double As(KinematicViscosityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public KinematicViscosity ToUnit(KinematicViscosityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static KinematicViscosity Zero => new(0, KinematicViscosityUnit.SI);

        public static implicit operator KinematicViscosity(UnknownUnit Unit) => new(Unit);

        public static implicit operator KinematicViscosity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
