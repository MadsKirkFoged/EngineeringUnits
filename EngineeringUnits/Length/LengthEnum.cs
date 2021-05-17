using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public enum LengthUnits
    {        
        [Vector(1000, "km", UnitSystem.SI, 1)] Kilometer,
        [Vector(1, "m", UnitSystem.SI, 1)] Meter,
        [Vector(0.1, "dm", UnitSystem.SI, 1)] Decimeter,
        [Vector(0.01, "cm", UnitSystem.SI, 1)] Centimeter,
        [Vector(0.001, "mm", UnitSystem.SI, 1)] Milimeter,
        [Vector(0.000000001, "nm", UnitSystem.SI, 1)] Nanometer,


        [Vector(1/12.0, "in", UnitSystem.PI, 0.3048)] Inch,
        [Vector(1/3.0, "hand", UnitSystem.PI, 0.3048)] Hand,
        [Vector(1, "ft", UnitSystem.PI, 0.3048)] Foot,
        [Vector(3, "yd", UnitSystem.PI, 0.3048)] Yard,
        [Vector(66, "ch", UnitSystem.PI, 0.3048)] Chain,
        [Vector(5280, "mi", UnitSystem.PI, 0.3048)] Mile,
        [Vector(6076, "nmi", UnitSystem.PI, 0.3048)] Nauticalmile,

        [Vector(1, "ly", UnitSystem.SI, 9460730472580800)] LightYear,
        [Vector(1, "au", UnitSystem.SI, 149597870700)] AstronomicalUnit,
        [Vector(1, "pc", UnitSystem.SI, 30856775814913673)] Parsec,

    }



    

}