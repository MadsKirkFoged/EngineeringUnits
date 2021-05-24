using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class ElectriccurrentUnit : Enumeration
    {



        public static ElectriccurrentUnit Ampere = new ElectriccurrentUnit(PreFix.SI, BaseUnits.electricCurrent);
        public static ElectriccurrentUnit Centiampere = new ElectriccurrentUnit(PreFix.centi, BaseUnits.electricCurrent);
        public static ElectriccurrentUnit Kiloampere = new ElectriccurrentUnit(PreFix.kilo, BaseUnits.electricCurrent);
        public static ElectriccurrentUnit Megaampere = new ElectriccurrentUnit(PreFix.mega, BaseUnits.electricCurrent);
        public static ElectriccurrentUnit Microampere = new ElectriccurrentUnit(PreFix.micro, BaseUnits.electricCurrent);
        public static ElectriccurrentUnit Milliampere = new ElectriccurrentUnit(PreFix.milli, BaseUnits.electricCurrent);
        public static ElectriccurrentUnit Nanoampere = new ElectriccurrentUnit(PreFix.nano, BaseUnits.electricCurrent);
        public static ElectriccurrentUnit Picoampere = new ElectriccurrentUnit(PreFix.pico, BaseUnits.electricCurrent);


        protected ElectriccurrentUnit() { }


        public ElectriccurrentUnit(string symbol, decimal a1, decimal a2, bool reversed)
    : base(symbol, a1, a2, reversed)
        {
        }


        public ElectriccurrentUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        public static IEnumerable<ElectriccurrentUnit> List()
        {
            return new[] { Ampere, Centiampere, Kiloampere, Megaampere, Microampere, Milliampere, Nanoampere, Picoampere };
        }
        // Other util methods
    }




}