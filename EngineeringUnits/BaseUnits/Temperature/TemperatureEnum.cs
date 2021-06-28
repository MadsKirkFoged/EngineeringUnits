using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class TemperatureUnit : Enumeration
    {

        public static TemperatureUnit Kelvin =              new TemperatureUnit("K",    1,      1,  0);
        public static TemperatureUnit SI =                  new TemperatureUnit("K",    1,      1,  0);
        public static TemperatureUnit DegreeCelsius =       new TemperatureUnit("°C",   1,      1,  -273.15m);
        public static TemperatureUnit DegreeFahrenheit =    new TemperatureUnit("°F",   5/9m,   1,  (-273.15m*(9/5m))+ 32m);
        public static TemperatureUnit DegreeRankine =       new TemperatureUnit("°R",    5/9m,  1,  0);


        public TemperatureUnit() { }


        public TemperatureUnit(string symbol, decimal a1, decimal a2, decimal b) : base(symbol, a1, a2,b)
        {
            Unit = new UnitSystem();
            Unit.Temperature = (TemperatureUnit)Clone();

            //Beta
            Unit.UnitListBeta.Add(this);
        }


        public TemperatureUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Temperature = (TemperatureUnit)Clone();

            //Beta
            Unit.UnitListBeta.Add(this);
        }

     


        //public static IEnumerable<TemperatureUnit> List()
        //{
        //    return new[] { DegreeCelsius, DegreeFahrenheit, DegreeRankine, Kelvin, };
        //}
       
    }


}