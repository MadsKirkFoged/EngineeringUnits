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

        public static Speed From(double value, SpeedUnit unit) => new Speed(value, unit);
        public double As(SpeedUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Speed ToUnit(SpeedUnit selectedUnit) => new Speed(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Speed Zero => new Speed(0, SpeedUnit.SI);

        public static implicit operator Speed(UnknownUnit Unit) => new Speed(Unit, SpeedUnit.SI);
    }
}
