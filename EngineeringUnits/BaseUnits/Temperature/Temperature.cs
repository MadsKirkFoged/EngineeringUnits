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
            //SymbolValue = (decimal)value;
            NEWValue = (decimal)value;

            //Forcing all temperatures to stay in kelvin
            //SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            NEWValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public Temperature(double value, TemperatureUnit selectedUnit) :this()
        {

            Unit = selectedUnit.Unit;

            if (double.IsInfinity(value) || value > (double)decimal.MaxValue || value < (double)decimal.MinValue || double.IsNaN(value))
            {
                Inf = true;
                //SymbolValue = 0;
            }
            else
            {
                Inf = false;
                //SymbolValue = (decimal)value;
                NEWValue = (decimal)value;
            }

            //Forcing all temperatures to stay in kelvin
            //ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            //SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            NEWValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            //Unit = TemperatureUnit.Kelvin.Unit.Copy();
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public Temperature(decimal value, TemperatureUnit selectedUnit) : this()
        {

            //Unit = selectedUnit.Unit.Copy();
            Unit = selectedUnit.Unit;
            //SymbolValue = (decimal)value;

            //Forcing all temperatures to stay in kelvin
            //ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            //SymbolValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            NEWValue = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            //Unit = TemperatureUnit.Kelvin.Unit.Copy();
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public Temperature(UnknownUnit value) : base(value) { }

        public static Temperature From(double value, TemperatureUnit unit) => new(value, unit);

        public double As(TemperatureUnit ReturnInThisUnit) => ToTheOutSideDouble(ReturnInThisUnit.Unit);

        public Temperature ToUnit(TemperatureUnit selectedUnit)
        {
            return new Temperature(ToTheOutSide(selectedUnit.Unit), selectedUnit);
        }
        public static Temperature Zero => new(0, TemperatureUnit.SI);

        //public static implicit operator Temperature(UnknownUnit Unit)
        //{
        //    Temperature local = new(0, TemperatureUnit.SI);

        //    local.Transform(Unit);
        //    return local;
        //}

        public static implicit operator Temperature(UnknownUnit Unit) => new(Unit);

        public static implicit operator Temperature(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }



    }
}
