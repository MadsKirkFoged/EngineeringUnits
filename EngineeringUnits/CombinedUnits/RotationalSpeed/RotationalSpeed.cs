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

        public static RotationalSpeed From(double value, RotationalSpeedUnit unit) => new(value, unit);
        public double As(RotationalSpeedUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public RotationalSpeed ToUnit(RotationalSpeedUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static RotationalSpeed Zero => new(0, RotationalSpeedUnit.SI);

        public static implicit operator RotationalSpeed(UnknownUnit Unit) => new(Unit);

        public static implicit operator RotationalSpeed(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
