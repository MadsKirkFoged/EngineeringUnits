using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Luminosity : BaseUnit
    {

        public Luminosity()
        {
            Unit = LuminosityUnit.SI.Unit;
        }


        public Luminosity(decimal value, LuminosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(double value, LuminosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(int value, LuminosityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
        public Luminosity(UnknownUnit value) : base(value) { }


        public static Luminosity From(double value, LuminosityUnit unit) => new Luminosity(value, unit);
        public double As(LuminosityUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);
        public Luminosity ToUnit(LuminosityUnit selectedUnit) => new Luminosity(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        public static Luminosity Zero => new Luminosity(0, LuminosityUnit.SI);

        public static implicit operator Luminosity(UnknownUnit Unit) => new Luminosity(Unit);
    }
}
