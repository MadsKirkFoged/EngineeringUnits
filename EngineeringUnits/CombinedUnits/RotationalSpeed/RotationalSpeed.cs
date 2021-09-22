using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class RotationalSpeed : BaseUnit
    {

        public RotationalSpeed() { }
        public RotationalSpeed(decimal value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public RotationalSpeed(double value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public RotationalSpeed(int value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public RotationalSpeed(UnknownUnit value) : base(value) { }

        public RotationalSpeed(UnknownUnit value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static RotationalSpeed From(double value, RotationalSpeedUnit unit) => new RotationalSpeed(value, unit);
        public double As(RotationalSpeedUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public RotationalSpeed ToUnit(RotationalSpeedUnit selectedUnit) => new RotationalSpeed(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static RotationalSpeed Zero => new RotationalSpeed(0, RotationalSpeedUnit.SI);

        public static implicit operator RotationalSpeed(UnknownUnit Unit) => new RotationalSpeed(Unit, RotationalSpeedUnit.SI);



    }
}
