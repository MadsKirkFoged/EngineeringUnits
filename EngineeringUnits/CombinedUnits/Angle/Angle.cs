using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Angle : BaseUnit
    {

        public Angle() { }
        public Angle(decimal value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(double value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(int value, AngleUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Angle(UnknownUnit value) : base(value) { }

        public static Angle From(double value, AngleUnit unit) => new(value, unit);
        public double As(AngleUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Angle ToUnit(AngleUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Angle Zero => new(0, AngleUnit.SI);

        public static implicit operator Angle(UnknownUnit Unit) => new(Unit);

        public static implicit operator Angle(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

    }
}
