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

        public static Area From(double value, AreaUnit unit) => new(value, unit);
        public double As(AreaUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Area ToUnit(AreaUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Area Zero => new(0, AreaUnit.SI);

        public static implicit operator Area(UnknownUnit Unit) => new(Unit);

        public static implicit operator Area(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
