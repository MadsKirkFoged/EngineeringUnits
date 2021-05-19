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


        [Vector(PreFix.kilo, BaseUnits.length)]     Kilometer,
        [Vector(PreFix.SI, BaseUnits.length)]       Meter,
        [Vector(PreFix.deci, BaseUnits.length)]     Decimeter,
        [Vector(PreFix.centi, BaseUnits.length)]    Centimeter,
        [Vector(PreFix.milli, BaseUnits.length)]    Millimeter,
        [Vector(PreFix.nano, BaseUnits.length)]     Nanometer,


        [Vector("in",   12/(0.3048))]               Inch,
        [Vector("hand", 3/(0.3048))]                Hand,
        [Vector("ft",   1/(0.3048 * 1))]            Foot,
        [Vector("yd",   1/(0.3048 * 3))]            Yard,
        [Vector("ch",   1/(0.3048 * 66))]           Chain,
        [Vector("mi",   1/(0.3048 * 5280))]         Mile,
        [Vector("nmi",  1/(0.3048 * 6076))]         Nauticalmile,

        [Vector("ly",  9460730472580800)]           LightYear,
        [Vector("au",  149597870700)]               AstronomicalUnit,
        [Vector("pc", 30856775814913673)]           Parsec,

    }



    

}