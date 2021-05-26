using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AreaUnit : Enumeration
    {


        public static AreaUnit SI = new AreaUnit(LengthUnit.SI);
        public static AreaUnit Yard2 = new AreaUnit(LengthUnit.Yard);
        public static AreaUnit Foot2 = new AreaUnit(LengthUnit.Foot);




        public AreaUnit(LengthUnit length)
        {
            Name = "Area";

            Unit = length.Unit * length.Unit;
        }



        protected AreaUnit() { }




        //public static IEnumerable<LengthUnit> List()
        //{
        //    return new[] { Inch, Hand, Foot, Yard, Chain, Nauticalmile, LightYear, AstronomicalUnit, Parsec };
        //}
        // Other util methods




    }




}