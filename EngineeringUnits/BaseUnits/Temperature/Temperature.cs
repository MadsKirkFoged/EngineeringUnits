using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Fractions;

namespace EngineeringUnits
{

    public partial class Temperature : BaseUnit
    {

        public Temperature()
        {
            Name = "Temperature";
        }


        public Temperature(double value, TemperatureUnit selectedUnit) :this()
        {

            Unit.Temperature = selectedUnit;
            SetValue(value);

            //Forcing all temperatures to stay in kelvin
            ValueLocalUnit = ToTheOutSide(TemperatureUnit.Kelvin.Unit);
            Unit.Temperature = TemperatureUnit.Kelvin;
            
        }

        public static Temperature From(double value, TemperatureUnit unit) => new Temperature(value, unit);

        public double As(TemperatureUnit ReturnInThisUnit) => (double)ToTheOutSide(ReturnInThisUnit.Unit);


        public static implicit operator Temperature(UnknownUnit Unit)
        {
            Temperature local = new Temperature(0, TemperatureUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
