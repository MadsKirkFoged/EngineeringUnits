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



        public static TemperatureDeltaUnit Kelvin = new TemperatureDeltaUnit("k", 1,1,0);
        public static TemperatureDeltaUnit SI = new TemperatureDeltaUnit("k", 1, 1, 0);
        public static TemperatureDeltaUnit DegreeCelsius = new TemperatureDeltaUnit("°C", 1,1, -273.15m);
        public static TemperatureDeltaUnit DegreeFahrenheit = new TemperatureDeltaUnit("°F", 5/9m, 1, (-273.15m*(9/5m))+ 32m);
        public static TemperatureDeltaUnit DegreeRankine = new TemperatureDeltaUnit("°R", 5/9m, 1, 0);


        public TemperatureDeltaUnit() { }


        public TemperatureDeltaUnit(string symbol, decimal a1, decimal a2, decimal b) : base(symbol, a1, a2,b)
        {
            SetUnitSystem();
        }


        public TemperatureDeltaUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();
        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.Temperature = this.Copy();
            Unit.Temperature.Count = 1;
            Unit.Temperature.ActualC = 1;
            Count = 1;
            Unit.Temperature.Name = "TemperatureDelta";
            Name = "TemperatureDelta";
        }


        public static IEnumerable<TemperatureDeltaUnit> List()
        {
            return new[] { DegreeCelsius, DegreeFahrenheit, DegreeRankine, Kelvin, };
        }
        // Other util methods
        public TemperatureUnit Copy()
        {
            return new TemperatureUnit
            {
                Name = Name,
                Symbol = Symbol,
                LocalC = LocalC,
                GlobalC = GlobalC,
                B = B,
                Count = Count,
                ActualC = ActualC,
            };
        }
    }


}