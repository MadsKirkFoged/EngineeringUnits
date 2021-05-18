using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    public enum ElectriccurrentUnit
    {

        [Vector(PreFix.SI, BaseUnits.electricCurrent)] Ampere,
        [Vector(PreFix.centi, BaseUnits.electricCurrent)] Centiampere,
        [Vector(PreFix.kilo, BaseUnits.electricCurrent)] Kiloampere,
        [Vector(PreFix.mega, BaseUnits.electricCurrent)] Megaampere,
        [Vector(PreFix.micro, BaseUnits.electricCurrent)] Microampere,
        [Vector(PreFix.milli, BaseUnits.electricCurrent)] Milliampere,
        [Vector(PreFix.nano, BaseUnits.electricCurrent)] Nanoampere,
        [Vector(PreFix.pico, BaseUnits.electricCurrent)] Picoampere,

    }


 
    

}