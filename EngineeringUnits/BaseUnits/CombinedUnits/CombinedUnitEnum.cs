using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class CombinedUnit : Enumeration
    {




        public CombinedUnit() { }


        public CombinedUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            SetUnitSystem();
        }


        public CombinedUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();
        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.Combined = this.Copy();
            Unit.Combined.Count = 1;
            Count = 1;
            ActualC = 1;
        }

       
        //public static IEnumerable<CombinedUnit> List()
        //{
        //    return new[] { Inch, Hand, Foot, Yard, Chain, NauticalMile, LightYear, AstronomicalUnit, Parsec };
        //}



        public CombinedUnit Copy()
        {
            return new CombinedUnit
            {
                Name = Name,
                Symbol = Symbol,
                LocalC = LocalC,
                GlobalC = GlobalC,
                B = B,
                Count = Count,
                ActualC = ActualC,
            };
        }


    }



}