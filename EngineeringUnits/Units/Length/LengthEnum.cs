using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public enum LengthUnit
    {


        [Vector(PreFix.kilo, BaseUnits.length)] Kilometer,
        [Vector(PreFix.SI, BaseUnits.length)] Meter,
        [Vector(PreFix.deci, BaseUnits.length)] Decimeter,
        [Vector(PreFix.centi, BaseUnits.length)] Centimeter,
        [Vector(PreFix.milli, BaseUnits.length)] Millimeter,
        [Vector(PreFix.nano, BaseUnits.length)] Nanometer,


        [Vector(1/12.0, "in",  0.3048)] Inch,
        [Vector(1/3.0, "hand",  0.3048)] Hand,
        [Vector(1, "ft",  0.3048)] Foot,
        [Vector(3, "yd",  0.3048)] Yard,
        [Vector(66, "ch",  0.3048)] Chain,
        [Vector(5280, "mi",  0.3048)] Mile,
        [Vector(6076, "nmi",  0.3048)] Nauticalmile,

        [Vector(1, "ly",  9460730472580800)] LightYear,
        [Vector(1, "au",  149597870700)] AstronomicalUnit,
        [Vector(1, "pc", 30856775814913673)] Parsec,

    }



    

}