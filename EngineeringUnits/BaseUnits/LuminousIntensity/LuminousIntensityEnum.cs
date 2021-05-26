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



        public LuminousIntensityUnit() { }


        public LuminousIntensityUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            SetUnitSystem();
        }


        public LuminousIntensityUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();
        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.LuminousIntensity = this.Copy();
            Unit.LuminousIntensity.Count = 1;
            Count = 1;
        }

        public static IEnumerable<LuminousIntensityUnit> List()
        {
            return new[] { SI };
        }
        // Other util methods
        public LuminousIntensityUnit Copy()
        {
            return new LuminousIntensityUnit
            {
                Name = Name,
                Symbol = Symbol,
                A1 = A1,
                A2 = A2,
                B = B,
                Count = Count
            };
        }
    }


}