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


        public Temperature(double value, TemperatureUnit unit) :this()
        {

            //Normally done like this
            Unit.Temperature = unit;
            ValueLocalUnit = (decimal)value;

            //but this temperature we have to convert into kelvin first
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();
            ReturnInThisUnitSystem.Temperature = TemperatureUnit.Kelvin;
            ReturnInThisUnitSystem.Temperature.Count = 1;

            //Forcing all temperatures to stay in kelvin
            ValueLocalUnit = GetDecimal(ReturnInThisUnitSystem);
            Unit.Temperature = TemperatureUnit.Kelvin;
        }

        public static Temperature From(double value, TemperatureUnit unit)
        {
            return new Temperature(value, unit);
        }

        public double As(TemperatureUnit ReturnInThisUnit)
        {
            UnitSystem ReturnInThisUnitSystem = new UnitSystem();

            ReturnInThisUnitSystem.Temperature = ReturnInThisUnit;
            ReturnInThisUnitSystem.Temperature.Count = 1;


            return (double)ToTheOutSide(ReturnInThisUnitSystem);
        }




        //Every units needs this
        public static implicit operator Temperature(UnknownUnit Unit)
        {
            Temperature local = new Temperature(0, TemperatureUnit.SI);

            local.Transform(Unit);
            return local;
        }



    }
}
