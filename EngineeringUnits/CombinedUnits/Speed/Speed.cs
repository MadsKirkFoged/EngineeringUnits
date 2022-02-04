using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Speed : BaseUnit
    {
        public Speed() { }
        public Speed(decimal value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(double value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(int value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Speed(UnknownUnit value) : base(value) { }

        public Speed(UnknownUnit value, SpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Speed From(double value, SpeedUnit unit) => new(value, unit);
        public double As(SpeedUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Speed ToUnit(SpeedUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Speed Zero => new(0, SpeedUnit.SI);

        public static implicit operator Speed(UnknownUnit Unit) => new(Unit);
        
        public static implicit operator Speed(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }
    }
}
