using EngineeringUnits.Units;
using Fractions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public record TemperatureUnit : UnitTypebase
    {

        public static readonly TemperatureUnit Kelvin =              new("K",    1,      1,  0);
        public static readonly TemperatureUnit SI =                  new("K",    1,      1,  0);
        public static readonly TemperatureUnit DegreeCelsius =       new("°C",   1,      1,  -273.15m);
        public static readonly TemperatureUnit DegreeFahrenheit =    new("°F",   5/9m,   1,  (-273.15m*(9/5m))+ 32m);
        public static readonly TemperatureUnit DegreeRankine =       new("°R",    5/9m,  1,  0);


        public TemperatureUnit() { }


        public TemperatureUnit(string symbol, decimal a1, decimal a2, decimal b)
        {
            var unit = new RawUnit()
            {
                Symbol=symbol,
                A = new Fraction(a1 * a2),
                UnitType = BaseunitType.temperature,
                B = b,
                Count = 1,

            };


            Unit = new UnitSystem(unit);

        }

        public TemperatureUnit(PreFix SI)
        {
            var unit = new RawUnit()
            {
                Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.temperature),
                A = new Fraction(PrefixSISize(SI)),
                B = 0,
                Count = 1,
                UnitType = BaseunitType.temperature,

            };

            Unit = new UnitSystem(unit);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }


}