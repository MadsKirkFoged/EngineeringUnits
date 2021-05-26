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
            Count = 1;
        }


        public static IEnumerable<TemperatureUnit> List()
        {
            return new[] { Kelvin, DegreeCelsius, DegreeFahrenheit };
        }
        // Other util methods
        public TemperatureUnit Copy()
        {
            return new TemperatureUnit
            {
                Name = Name,
                Symbol = Symbol,
                A1 = A1,
                A2 = A2,
                B = B,
                Count = Count
            };
        }
    }


}