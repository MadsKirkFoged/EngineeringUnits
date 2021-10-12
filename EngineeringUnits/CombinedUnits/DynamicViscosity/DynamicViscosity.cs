using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class DynamicViscosity : BaseUnit
    {

        public DynamicViscosity() { }
        public DynamicViscosity(decimal value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public DynamicViscosity(double value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public DynamicViscosity(int value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public DynamicViscosity(UnknownUnit value) : base(value) { }

        public DynamicViscosity(UnknownUnit value, DynamicViscosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static DynamicViscosity From(double value, DynamicViscosityUnit unit) => new(value, unit);
        public double As(DynamicViscosityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public DynamicViscosity ToUnit(DynamicViscosityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static DynamicViscosity Zero => new(0, DynamicViscosityUnit.SI);

        public static implicit operator DynamicViscosity(UnknownUnit Unit) => new(Unit, DynamicViscosityUnit.SI);

        public static implicit operator DynamicViscosity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
