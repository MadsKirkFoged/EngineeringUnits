using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Luminosity : BaseUnit
    {

        public Luminosity()
        {
            Unit = PowerUnit.SI.Unit.Copy();
        }

        public Luminosity(decimal value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(double value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(int value, PowerUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(UnknownUnit value) : base(value) { }


        public static Luminosity From(double value, PowerUnit unit) => new(value, unit);
        public double As(PowerUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Luminosity ToUnit(PowerUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Luminosity Zero => new(0, PowerUnit.SI);

        public static implicit operator Luminosity(UnknownUnit Unit) => new(Unit);

        public static implicit operator Luminosity(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }




    }
}
