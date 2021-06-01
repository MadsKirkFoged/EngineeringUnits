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
            Unit.Temperature = unit;

            //SetLocalValue(value);

            ValueLocalUnit = (decimal)value;
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
