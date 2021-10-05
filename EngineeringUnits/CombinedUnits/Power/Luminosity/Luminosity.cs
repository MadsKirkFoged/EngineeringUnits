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


        public static Luminosity From(double value, PowerUnit unit) => new(value, unit);
        public double As(PowerUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);
        public Luminosity ToUnit(PowerUnit selectedUnit) => new(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Luminosity Zero => new(0, PowerUnit.SI);

        public static implicit operator Luminosity(UnknownUnit Unit)
        {
            Luminosity local = new(0, PowerUnit.SI);

            local.Transform(Unit);
            return local;
        }




    }
}
