using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class AreaDensity : BaseUnit
    {

        public AreaDensity() { }
        public AreaDensity(decimal value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaDensity(double value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaDensity(int value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public AreaDensity(UnknownUnit value) : base(value) { }

        public AreaDensity(UnknownUnit value, AreaDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static AreaDensity From(double value, AreaDensityUnit unit) => new AreaDensity(value, unit);
        public double As(AreaDensityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public AreaDensity ToUnit(AreaDensityUnit selectedUnit) => new AreaDensity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AreaDensity Zero => new AreaDensity(0, AreaDensityUnit.SI);

        public static implicit operator AreaDensity(UnknownUnit Unit) => new AreaDensity(Unit, AreaDensityUnit.SI);


    }
}
