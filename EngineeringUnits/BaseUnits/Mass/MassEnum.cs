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


        public static readonly MassUnit SI =         new(PreFix.kilo,   BaseUnits.mass);
        public static readonly MassUnit Kilogram =   new(PreFix.kilo,   BaseUnits.mass);
        public static readonly MassUnit Picogram =   new(PreFix.pico,   BaseUnits.mass);
        public static readonly MassUnit Centigram =  new(PreFix.centi,  BaseUnits.mass);
        public static readonly MassUnit Decagram =   new(PreFix.deka,   BaseUnits.mass);
        public static readonly MassUnit Decigram =   new(PreFix.deci,   BaseUnits.mass);
        public static readonly MassUnit Gram =       new(PreFix.SI,     BaseUnits.mass);
        public static readonly MassUnit Hectogram =  new(PreFix.hecto,  BaseUnits.mass);
        public static readonly MassUnit Microgram =  new(PreFix.micro,  BaseUnits.mass);
        public static readonly MassUnit Milligram =  new(PreFix.milli,  BaseUnits.mass);
        public static readonly MassUnit Nanogram =   new(PreFix.nano,   BaseUnits.mass);
        public static readonly MassUnit Tonne =      new("t",  1000 * 1000);
        public static readonly MassUnit Kilotonne =  new("kt", 1000 * 1000 * 1000);
        public static readonly MassUnit Megatonne =  new("Mt", 1000 * 1000 * 1e+6m);

        public static readonly MassUnit EarthMass = new("em", 1000 * 5.9722m * 1e24m);


        public static readonly MassUnit Ounce =              new("oz",          1/ 16m * 453.59237m);
        public static readonly MassUnit Pound =              new("lb", 1 * 453.59237m);
        public static readonly MassUnit Stone =              new("st", 14 * 453.59237m);
        public static readonly MassUnit Slug =               new("slug", 32.174m * 453.59237m);
        public static readonly MassUnit ShortHundredweight = new("cwt", 100 * 453.59237m);
        public static readonly MassUnit LongHundredweight =  new("cwt", 112 * 453.59237m);
        public static readonly MassUnit Kilopound =          new("kip", 1000 * 453.59237m);
        public static readonly MassUnit ShortTon =           new("t (short)", 2000 * 453.59237m);
        public static readonly MassUnit LongTon =            new("long tn", 2240 * 453.59237m);

        public static readonly MassUnit Megapound =          new("Mlb", 1e6m * 453.59237m);
        public static readonly MassUnit Grain =              new("gr",       0.06479891m);


        public MassUnit() { }


        public MassUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Mass = (MassUnit)Clone();
        }

        public MassUnit(string symbol, decimal Constant) : base(symbol, Constant)
        {
            Unit = new UnitSystem();
            Unit.Mass = (MassUnit)Clone();
        }


        public MassUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Mass = (MassUnit)Clone();
        }
     
       
    }

}