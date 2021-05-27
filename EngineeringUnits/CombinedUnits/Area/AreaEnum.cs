using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AreaUnit : Enumeration
    {


        public static AreaUnit Kilometer2 = new AreaUnit(LengthUnit.Kilometer);
        public static AreaUnit Meter2 = new AreaUnit(LengthUnit.Meter);
        public static AreaUnit SI = new AreaUnit(LengthUnit.SI);
        public static AreaUnit Decimeter2 = new AreaUnit(LengthUnit.Decimeter);
        public static AreaUnit Centimeter2 = new AreaUnit(LengthUnit.Centimeter);
        public static AreaUnit Millimeter2 = new AreaUnit(LengthUnit.Millimeter);
        public static AreaUnit Nanometer2 = new AreaUnit(LengthUnit.Nanometer);


        public static AreaUnit Inch2 = new AreaUnit(LengthUnit.Inch);
        public static AreaUnit Hand2 = new AreaUnit(LengthUnit.Hand);
        public static AreaUnit Foot2 = new AreaUnit(LengthUnit.Foot);
        public static AreaUnit Yard2 = new AreaUnit(LengthUnit.Yard);
        public static AreaUnit Chain2 = new AreaUnit(LengthUnit.Chain);
        public static AreaUnit Mile2 = new AreaUnit(LengthUnit.Mile);
        public static AreaUnit Nauticalmile2 = new AreaUnit(LengthUnit.NauticalMile);



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