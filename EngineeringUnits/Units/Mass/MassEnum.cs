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

        [Vector(PreFix.centi, BaseUnits.mass)] Centigram,
        [Vector(PreFix.deka, BaseUnits.mass)] Dekagram,
        [Vector(PreFix.deci, BaseUnits.mass)] Decigram,
        [Vector(PreFix.SI, BaseUnits.mass)] Gram,
        [Vector(PreFix.hecto, BaseUnits.mass)] Hectogram,
        [Vector(PreFix.kilo, BaseUnits.mass)] Kilogram,
        [Vector(PreFix.micro, BaseUnits.mass)] Microgram,
        [Vector(PreFix.milli, BaseUnits.mass)] Milligram,
        [Vector(PreFix.nano, BaseUnits.mass)] Nanogram,

        [Vector(1000, "t", 1)] Tonne,
        [Vector(0.06479891, "gr", 1)] Grain,


        [Vector(1/16d, "oz", 453.59237)] Ounce,
        [Vector(1, "lb", 453.59237)] Pound,
        [Vector(14, "st", 453.59237)] Stone,
        [Vector(2000, "lb", 453.59237)] ShortTon,

        //[Vector(1, "EarthMass", 5.9722*10e24)] EarthMass,


    }





}