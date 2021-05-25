using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    //public enum MassUnit
    //{

    //    [Vector(PreFix.centi,   BaseUnits.mass)] Centigram,
    //    [Vector(PreFix.deka,    BaseUnits.mass)] Dekagram,
    //    [Vector(PreFix.deci,    BaseUnits.mass)] Decigram,
    //    [Vector(PreFix.SI,      BaseUnits.mass)] Gram,
    //    [Vector(PreFix.hecto,   BaseUnits.mass)] Hectogram,
    //    [Vector(PreFix.kilo,    BaseUnits.mass)] Kilogram,
    //    [Vector(PreFix.micro,   BaseUnits.mass)] Microgram,
    //    [Vector(PreFix.milli,   BaseUnits.mass)] Milligram,
    //    [Vector(PreFix.nano,    BaseUnits.mass)] Nanogram,

    //    [Vector("t", 1,1000)] Tonne,
    //    [Vector("gr",1, 0.06479891)] Grain,


    //    [Vector("oz",1, (1/16d) * 453.59237)] Ounce,
    //    [Vector("lb",1, 1 *       453.59237)] Pound,
    //    [Vector("st",1, 14 *      453.59237)] Stone,
    //    [Vector("lb",1, 2000 *    453.59237)] ShortTon,

    //    //[Vector(1, "EarthMass", 5.9722*10e24)] EarthMass,


    //}

    public class MassUnit : Enumeration
    {


        public static MassUnit SI = new MassUnit(PreFix.SI, BaseUnits.length);




        protected MassUnit() { }


        public MassUnit(string symbol, decimal a1, decimal a2, bool reversed)
    : base(symbol, a1, a2, reversed)
        {
        }


        public MassUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        //public static IEnumerable<LengthUnit> List()
        //{
        //    return new[] { Inch, Hand, Foot, Yard, Chain, Nauticalmile, LightYear, AstronomicalUnit, Parsec };
        //}
        // Other util methods
    }




}