using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Area : BaseUnit
    {

        public Area() { }
        public Area(decimal value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Area(double value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Area(int value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Area(UnknownUnit value) : base(value) { }

        public Area(UnknownUnit value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Area From(double value, AreaUnit unit) => new Area(value, unit);
        public double As(AreaUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Area ToUnit(AreaUnit selectedUnit) => new Area(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Area Zero => new Area(0, AreaUnit.SI);

        public static implicit operator Area(UnknownUnit Unit) => new Area(Unit, AreaUnit.SI);
    }
}
