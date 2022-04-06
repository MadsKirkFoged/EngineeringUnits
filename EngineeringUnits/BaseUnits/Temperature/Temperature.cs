using EngineeringUnits.Units;
using System;
using System.Diagnostics;

namespace EngineeringUnits
{

    public partial class Temperature : BaseUnit
    {
        private TemperatureUnit PublicUnit { get; init; }
        private decimal PublicValue { get; init; }

        private bool NoRunback { get; init; }



        public Temperature() {}

        public Temperature(int value, TemperatureUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            NEWValue = value;

            //Public view of tempature
            if (selectedUnit.Unit.IsSIUnit() is false)
            {
                PublicUnit = selectedUnit;
                PublicValue = value;
            }            

            //Forcing all temperatures to stay in kelvin for calculations

            NEWValue = GetValueAs(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public Temperature(double value, TemperatureUnit selectedUnit) :this()
        {



            //Public view of tempature
            if (selectedUnit.Unit.IsSIUnit() is false)
            {
                PublicUnit = selectedUnit;                
            }


            if (double.IsInfinity(value) || value > (double)decimal.MaxValue || value < (double)decimal.MinValue || double.IsNaN(value))
            {
                Inf = true;
            }
            else
            {
                Inf = false;
                //SymbolValue = (decimal)value;
                NEWValue = (decimal)value;
                PublicValue = (decimal)value;
            }

            //Forcing all temperatures to stay in kelvin
            Unit = selectedUnit.Unit;
            NEWValue = GetValueAs(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        public Temperature(decimal value, TemperatureUnit selectedUnit) : this()
        {
            Unit = selectedUnit.Unit;
            NEWValue = value;

            //Public view of tempature
            if (selectedUnit.Unit.IsSIUnit() is false)
            {
                PublicUnit = selectedUnit;
                PublicValue = value;
            }

            //Forcing all temperatures to stay in kelvin for calculations
            NEWValue = GetValueAs(TemperatureUnit.Kelvin.Unit);
            Unit = TemperatureUnit.Kelvin.Unit;

        }

        private Temperature(decimal value, TemperatureUnit selectedUnit, bool noRunback = true) : this()
        {
            NoRunback = noRunback;
            NEWValue = value;
            Unit = selectedUnit.Unit;
        }


        

        public Temperature(UnknownUnit value) : base(value) { }

        public static Temperature From(double value, TemperatureUnit unit) => new(value, unit);

        public double As(TemperatureUnit ReturnInThisUnit) => GetValueAsDouble(ReturnInThisUnit.Unit);

        public Temperature ToUnit(TemperatureUnit selectedUnit)
        {
            return new Temperature(GetValueAs(selectedUnit.Unit), selectedUnit, false);
        }
        public static Temperature Zero => new(0, TemperatureUnit.SI);

        public static implicit operator Temperature(UnknownUnit Unit) => new(Unit);

        public static implicit operator Temperature(int zero)
        {
            if (zero != 0)
                throw new WrongUnitException($"You need to give it a unit unless you set it to 0 (zero)!");

            return Zero;
        }

        public override string ToString()
        {
            if (!NoRunback && PublicUnit is not null)
            {
                return new Temperature(PublicValue, PublicUnit, true).ToString();               
            
            }

            return base.ToString();             
        }

        public override string ToString(string format, IFormatProvider provider)
        {
            if (!NoRunback && PublicUnit is not null)
            {
                return new Temperature(PublicValue, PublicUnit, true).ToString(format, provider);

            }

            return base.ToString(format, provider);



        }


    }
}
