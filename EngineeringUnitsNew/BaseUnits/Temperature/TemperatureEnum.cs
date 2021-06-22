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



        public static TemperatureUnit Kelvin = new TemperatureUnit("k", 1,1,0);
        public static TemperatureUnit SI = new TemperatureUnit("k", 1, 1, 0);
        public static TemperatureUnit DegreeCelsius = new TemperatureUnit("°C", 1,1, -273.15m);
        public static TemperatureUnit DegreeFahrenheit = new TemperatureUnit("°F", 5/9m, 1, (-273.15m*(9/5m))+ 32m);
        public static TemperatureUnit DegreeRankine = new TemperatureUnit("°R", 5/9m, 1, 0);


        public TemperatureUnit() { }


        public TemperatureUnit(string symbol, decimal a1, decimal a2, decimal b) : base(symbol, a1, a2,b)
        {
            SetUnitSystem();
        }


        public TemperatureUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
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
            Unit.Temperature.Name = "Temperature";
            Name = "Temperature";
        }


        public static IEnumerable<TemperatureUnit> List()
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