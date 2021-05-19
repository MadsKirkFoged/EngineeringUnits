using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public enum MassUnit
    {

        [Vector(PreFix.centi,   BaseUnits.mass)] Centigram,
        [Vector(PreFix.deka,    BaseUnits.mass)] Dekagram,
        [Vector(PreFix.deci,    BaseUnits.mass)] Decigram,
        [Vector(PreFix.SI,      BaseUnits.mass)] Gram,
        [Vector(PreFix.hecto,   BaseUnits.mass)] Hectogram,
        [Vector(PreFix.kilo,    BaseUnits.mass)] Kilogram,
        [Vector(PreFix.micro,   BaseUnits.mass)] Microgram,
        [Vector(PreFix.milli,   BaseUnits.mass)] Milligram,
        [Vector(PreFix.nano,    BaseUnits.mass)] Nanogram,

        [Vector("t", 1000)] Tonne,
        [Vector("gr", 0.06479891)] Grain,


        [Vector("oz", (1/16d) * 453.59237)] Ounce,
        [Vector("lb", 1 *       453.59237)] Pound,
        [Vector("st", 14 *      453.59237)] Stone,
        [Vector("lb", 2000 *    453.59237)] ShortTon,

        //[Vector(1, "EarthMass", 5.9722*10e24)] EarthMass,


    }





}