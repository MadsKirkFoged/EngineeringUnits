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

        public static AreaDensity From(double value, AreaDensityUnit unit) => new(value, unit);
        public double As(AreaDensityUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public AreaDensity ToUnit(AreaDensityUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static AreaDensity Zero => new(0, AreaDensityUnit.SI);

        public static implicit operator AreaDensity(UnknownUnit Unit) => new(Unit, AreaDensityUnit.SI);

        public static implicit operator AreaDensity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
