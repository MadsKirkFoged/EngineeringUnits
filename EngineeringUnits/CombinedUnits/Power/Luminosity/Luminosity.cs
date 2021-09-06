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


        public static Luminosity From(double value, PowerUnit unit) => new Luminosity(value, unit);
        public double As(PowerUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Luminosity ToUnit(PowerUnit selectedUnit) => new Luminosity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Luminosity Zero => new Luminosity(0, PowerUnit.SI);

        public static implicit operator Luminosity(UnknownUnit Unit)
        {
            Luminosity local = new Luminosity(0, PowerUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
