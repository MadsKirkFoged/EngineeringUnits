using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class LinearDensity : BaseUnit
    {

        public LinearDensity() { }
        public LinearDensity(decimal value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearDensity(double value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearDensity(int value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public LinearDensity(UnknownUnit value) : base(value) { }

        public LinearDensity(UnknownUnit value, LinearDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static LinearDensity From(double value, LinearDensityUnit unit) => new(value, unit);
        public double As(LinearDensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public LinearDensity ToUnit(LinearDensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static LinearDensity Zero => new(0, LinearDensityUnit.SI);

        public static implicit operator LinearDensity(UnknownUnit Unit) => new(Unit, LinearDensityUnit.SI);

    }
}
