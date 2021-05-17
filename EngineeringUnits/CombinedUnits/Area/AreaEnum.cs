using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public enum AreaUnits
    {
        [Vector(1000, "km", UnitSystem.SI, 1)] Kilometer,
        [Vector(1, "m", UnitSystem.SI, 1)] Meter,
        [Vector(0.01, "cm", UnitSystem.SI, 1)] Centimeter,
        [Vector(0.001, "mm", UnitSystem.SI, 1)] Milimeter,


        [Vector(1, "ft", UnitSystem.PI, 0.3048)] Foot,
        [Vector(1/12.0, "in", UnitSystem.PI, 0.3048)] Inch,
        [Vector(3, "yd", UnitSystem.PI, 0.3048 * 0.3048)] Yard,
        [Vector(66, "ch", UnitSystem.PI, 0.3048 * 0.3048)] chain,
        [Vector(5280, "mi", UnitSystem.PI, 0.3048 * 0.3048)] mile,

    }

    



}