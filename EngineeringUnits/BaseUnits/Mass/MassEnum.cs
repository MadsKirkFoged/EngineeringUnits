using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{


    

    public class MassUnit : Enumeration
    {


        public static readonly MassUnit SI =         new MassUnit(PreFix.kilo,   BaseUnits.mass);
        public static readonly MassUnit Kilogram =   new MassUnit(PreFix.kilo,   BaseUnits.mass);
        public static readonly MassUnit Picogram =   new MassUnit(PreFix.pico,   BaseUnits.mass);
        public static readonly MassUnit Centigram =  new MassUnit(PreFix.centi,  BaseUnits.mass);
        public static readonly MassUnit Decagram =   new MassUnit(PreFix.deka,   BaseUnits.mass);
        public static readonly MassUnit Decigram =   new MassUnit(PreFix.deci,   BaseUnits.mass);
        public static readonly MassUnit Gram =       new MassUnit(PreFix.SI,     BaseUnits.mass);
        public static readonly MassUnit Hectogram =  new MassUnit(PreFix.hecto,  BaseUnits.mass);
        public static readonly MassUnit Microgram =  new MassUnit(PreFix.micro,  BaseUnits.mass);
        public static readonly MassUnit Milligram =  new MassUnit(PreFix.milli,  BaseUnits.mass);
        public static readonly MassUnit Nanogram =   new MassUnit(PreFix.nano,   BaseUnits.mass);
        public static readonly MassUnit Tonne =      new MassUnit("t", 1 , 1000 * 1000);
        public static readonly MassUnit Kilotonne =  new MassUnit("kt", 1, 1000 * 1000*1000);
        public static readonly MassUnit Megatonne =  new MassUnit("Mt", 1, 1000 * 1000 * 1e+6m);


        public static readonly MassUnit EarthMass = new MassUnit("em", 1, 1000 * 5.9722m * 1e24m);


        public static readonly MassUnit Ounce =              new MassUnit("oz",          1/16m,      453.59237m);
        public static readonly MassUnit Pound =              new MassUnit("lb",          1,          453.59237m);
        public static readonly MassUnit Stone =              new MassUnit("st",          14,         453.59237m);
        public static readonly MassUnit Slug =               new MassUnit("slug",        32.174m,    453.59237m);
        public static readonly MassUnit ShortHundredweight = new MassUnit("cwt",         100,        453.59237m);
        public static readonly MassUnit LongHundredweight =  new MassUnit("cwt",         112,        453.59237m);
        public static readonly MassUnit Kilopound =          new MassUnit("kip",         1000,       453.59237m);
        public static readonly MassUnit ShortTon =           new MassUnit("t (short)",   2000,       453.59237m);
        public static readonly MassUnit LongTon =            new MassUnit("long tn",     2240,       453.59237m);

        public static readonly MassUnit Megapound =          new MassUnit("Mlb", 1e6m,   453.59237m);
        public static readonly MassUnit Grain =              new MassUnit("gr",  1,      0.06479891m);


        public MassUnit() { }


        public MassUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Mass = (MassUnit)Clone();


            //Beta
            //Unit.UnitListBeta.Add(this);
        }


        public MassUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Mass = (MassUnit)Clone();


            //Beta
            //Unit.UnitListBeta.Add(this);
        }
     
       
    }

}