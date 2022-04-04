using EngineeringUnits.Units;
using Fractions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
    public record MassUnit : UnitTypebase
    {


        public static readonly MassUnit SI =         new(PreFix.kilo);
        public static readonly MassUnit Kilogram =   new(PreFix.kilo);
        public static readonly MassUnit Picogram =   new(PreFix.pico);
        public static readonly MassUnit Centigram =  new(PreFix.centi);
        public static readonly MassUnit Decagram =   new(PreFix.deka);
        public static readonly MassUnit Decigram =   new(PreFix.deci);
        public static readonly MassUnit Gram =       new(PreFix.SI);
        public static readonly MassUnit Hectogram =  new(PreFix.hecto);
        public static readonly MassUnit Microgram =  new(PreFix.micro);
        public static readonly MassUnit Milligram =  new(PreFix.milli);
        public static readonly MassUnit Nanogram =   new(PreFix.nano);
        public static readonly MassUnit Tonne =      new("t",  1e+6m);
        public static readonly MassUnit Kilotonne =  new("kt", 1e+9m);
        public static readonly MassUnit Megatonne =  new("Mt", 1e+12m);

        public static readonly MassUnit EarthMass = new("em", 1000 * 5.9722m * 1e24m);


        public static readonly MassUnit Ounce =              new("oz",          1/ 16m *    453.59237m);
        public static readonly MassUnit Pound =              new("lb",          1 *         453.59237m);
        public static readonly MassUnit Stone =              new("st",          14 *        453.59237m);
        public static readonly MassUnit Slug =               new("slug",        32.174m *   453.59237m);
        public static readonly MassUnit ShortHundredweight = new("cwt",         100 *       453.59237m);
        public static readonly MassUnit LongHundredweight =  new("cwt",         112 *       453.59237m);
        public static readonly MassUnit Kilopound =          new("kip",         1000 *      453.59237m);
        public static readonly MassUnit ShortTon =           new("t (short)",   2000 *      453.59237m);
        public static readonly MassUnit LongTon =            new("long tn",     2240 *      453.59237m);
        public static readonly MassUnit Megapound =          new("Mlb",         1e6m *      453.59237m);

        public static readonly MassUnit Grain =              new("gr",       0.06479891m);


        public MassUnit() { }


        public MassUnit(string symbol, decimal Constant)
        {
            var unit = new RawUnit()
            {
                Symbol=symbol,
                A = new Fraction(Constant),
                UnitType = BaseunitType.mass,
                B = 0,
                Count = 1,

            };


            Unit = new UnitSystem(unit);
        }


        public MassUnit(PreFix SI)
        {
            var unit = new RawUnit()
            {
                Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.mass),
                A = new Fraction(PrefixSISize(SI)),
                B = 0,
                Count = 1,
                UnitType = BaseunitType.mass,

            };

            Unit = new UnitSystem(unit);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
            {
                return $"{Unit.Symbol}";
            }


            return $"{Unit}";
        }


    }

}