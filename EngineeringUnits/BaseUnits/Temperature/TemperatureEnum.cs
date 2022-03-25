using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class TemperatureUnit : UnitEnumbase
    {

        public static readonly TemperatureUnit Kelvin =              new("K",    1,      1,  0);
        public static readonly TemperatureUnit SI =                  new("K",    1,      1,  0);
        public static readonly TemperatureUnit DegreeCelsius =       new("°C",   1,      1,  -273.15m);
        public static readonly TemperatureUnit DegreeFahrenheit =    new("°F",   5/9m,   1,  (-273.15m*(9/5m))+ 32m);
        public static readonly TemperatureUnit DegreeRankine =       new("°R",    5/9m,  1,  0);


        public TemperatureUnit() { }


        public TemperatureUnit(string symbol, decimal a1, decimal a2, decimal b) : base(symbol, new Fraction(a1 * a2), BaseunitType.temperature, b )
        {
            Unit = new UnitSystem(this);
            
        }

        public TemperatureUnit(PreFix SI) : base(SI, BaseunitType.temperature)
        {
            Unit = new UnitSystem(this);
        }

     
       
    }


}