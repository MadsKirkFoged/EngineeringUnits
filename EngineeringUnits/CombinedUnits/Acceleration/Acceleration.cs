using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Acceleration : BaseUnit
    {

        public Acceleration() { }
        public Acceleration(decimal value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(double value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(int value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Acceleration(UnknownUnit value) : base(value) { }

        public Acceleration(UnknownUnit value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }

        public static Acceleration From(double value, AccelerationUnit unit) => new(value, unit);
        public double As(AccelerationUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Acceleration ToUnit(AccelerationUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Acceleration Zero => new(0, AccelerationUnit.SI);

        public static implicit operator Acceleration(UnknownUnit Unit) => new(Unit);

        public static implicit operator Acceleration(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }


    }
}
