using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{


    //public enum LuminousIntensityUnit
    //{

    //    [Vector(PreFix.SI, BaseUnits.luminousIntensity)] Candela,



    //}


    public class LuminousIntensityUnit : Enumeration
    {




        public static LuminousIntensityUnit SI = new LuminousIntensityUnit(PreFix.SI, BaseUnits.luminousIntensity);
        



        protected LuminousIntensityUnit() { }


        public LuminousIntensityUnit(string symbol, decimal a1, decimal a2, bool reversed)
    : base(symbol, a1, a2, reversed)
        {
        }


        public LuminousIntensityUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        public static IEnumerable<LuminousIntensityUnit> List()
        {
            return new[] { SI };
        }
        // Other util methods
    }


}