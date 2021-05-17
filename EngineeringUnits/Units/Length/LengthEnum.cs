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
        [Vector(1000, "km", 1)] Kilometer,
        [Vector(1, "m", 1)] Meter,
        [Vector(0.1, "dm",  1)] Decimeter,
        [Vector(0.01, "cm",  1)] Centimeter,
        [Vector(0.001, "mm",  1)] Millimeter,
        [Vector(0.000000001, "nm",  1)] Nanometer,


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