using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class TemperatureDeltaUnit : Enumeration
    {



        public static TemperatureDeltaUnit Kelvin =             new TemperatureDeltaUnit("k", 1,1,0);
        public static TemperatureDeltaUnit SI =                 new TemperatureDeltaUnit("k", 1, 1, 0);
        public static TemperatureDeltaUnit DegreeCelsius =      new TemperatureDeltaUnit("°C", 1,1, -273.15m);
        public static TemperatureDeltaUnit DegreeFahrenheit =   new TemperatureDeltaUnit("°F", 5/9m, 1, (-273.15m*(9/5m))+ 32m);
        public static TemperatureDeltaUnit DegreeRankine =      new TemperatureDeltaUnit("°R", 5/9m, 1, 0);


        public TemperatureDeltaUnit() { }


        public TemperatureDeltaUnit(string symbol, decimal a1, decimal a2, decimal b) : base(symbol, a1, a2,b)
        {
            Unit = new UnitSystem();
            Unit.Temperature = (TemperatureUnit)Clone();

            //Beta
            Unit.UnitListBeta.Add(this);
        }


        public TemperatureDeltaUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Temperature = (TemperatureUnit)Clone();

            //Beta
            Unit.UnitListBeta.Add(this);
        }


      
    }


}