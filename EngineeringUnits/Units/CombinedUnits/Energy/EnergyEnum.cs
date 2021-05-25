using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class EnergyUnit : Enumeration
    {



        public static EnergyUnit Joule = new EnergyUnit(PreFix.SI, BaseUnits.length);
        public static EnergyUnit SI = new EnergyUnit(PreFix.SI, BaseUnits.length);
        public static EnergyUnit Test = new EnergyUnit(MassUnit.SI, LengthUnit.Meter, DurationUnit.Second);



        protected EnergyUnit() { }

        public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration)
        {



        }



        public EnergyUnit(string symbol, decimal a1, decimal a2, bool reversed)
    : base(symbol, a1, a2, reversed)
        {
        }


        public EnergyUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        //public static IEnumerable<EnergyUnit> List()
        //{
        //    return new[] { Inch, Hand, Foot, Yard, Chain, Nauticalmile, LightYear, AstronomicalUnit, Parsec };
        //}
        // Other util methods
    }



}