using EngineeringUnits.Units;


namespace EngineeringUnits
{

    public partial class Temperature : BaseUnit
    {

        public Temperature()
        {
            //Unit = TemperatureUnit.SI.Unit.Copy();
        }

        public Temperature(int value, TemperatureUnit selectedUnit) : this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all temperatures to stay in kelvin
            //ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            //Unit = TemperatureUnit.Kelvin.Unit.Copy();
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public Temperature(double value, TemperatureUnit selectedUnit) :this()
        {

            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all temperatures to stay in kelvin
            //ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            //Unit = TemperatureUnit.Kelvin.Unit.Copy();
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public Temperature(decimal value, TemperatureUnit selectedUnit) : this()
        {

            //Unit = selectedUnit.Unit.Copy();
            Unit = selectedUnit.Unit;
            SetValue(value);

            //Forcing all temperatures to stay in kelvin
            //ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            //Unit = TemperatureUnit.Kelvin.Unit.Copy();
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public static Temperature From(double value, TemperatureUnit unit) => new Temperature(value, unit);

        public double As(TemperatureUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);

        public Temperature ToUnit(TemperatureUnit selectedUnit)
        {
            return new Temperature(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }
        public static Temperature Zero => new Temperature(0, TemperatureUnit.SI);

        public static implicit operator Temperature(UnknownUnit Unit)
        {
            Temperature local = new Temperature(0, TemperatureUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
