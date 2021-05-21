using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    //public enum TemperatureUnit
    //{



    //    [Vector("k" , 1         , 0)]                       Kelvin,
    //    [Vector("°C", 1         , -273.15)]                 DegreeCelsius,
    //    [Vector("°F", (9/5d)    ,  (-273.15*(9/5d))+32)]    DegreeFahrenheit,

    //}


    public class TemperatureUnit : Enumeration
    {



        public static TemperatureUnit Kelvin = new TemperatureUnit("k", 1);
        public static TemperatureUnit DegreeCelsius = new TemperatureUnit("°C", 1, -273.15m);
        public static TemperatureUnit DegreeFahrenheit = new TemperatureUnit("°F", 9/5m, (-273.15m*(9/5m))+ 32m);



        protected TemperatureUnit() { }

        public TemperatureUnit(string symbol, decimal a, decimal b)
            : base(symbol, a, b)
        {
        }

        public TemperatureUnit(string symbol, decimal a)
    : base(symbol, a)
        {
        }

        public TemperatureUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        public static IEnumerable<TemperatureUnit> List()
        {
            return new[] { Kelvin, DegreeCelsius, DegreeFahrenheit };
        }
        // Other util methods
    }


}