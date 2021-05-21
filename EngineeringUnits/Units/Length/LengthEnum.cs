using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class LengthUnit : Enumeration
    {



        public static LengthUnit Kilometer = new LengthUnit(PreFix.kilo, BaseUnits.length);
        public static LengthUnit Meter = new LengthUnit(PreFix.SI, BaseUnits.length);
        public static LengthUnit Decimeter = new LengthUnit(PreFix.deci, BaseUnits.length);
        public static LengthUnit Centimeter = new LengthUnit(PreFix.centi, BaseUnits.length);
        public static LengthUnit Millimeter = new LengthUnit(PreFix.milli, BaseUnits.length);
        public static LengthUnit Nanometer = new LengthUnit(PreFix.nano, BaseUnits.length);


        public static LengthUnit Inch = new LengthUnit("in", 1/(0.3048m / 12));
        public static LengthUnit Hand = new LengthUnit("hand", 1/(0.3048m / 3));
        public static LengthUnit Foot = new LengthUnit("ft", 1/0.3048m);
        public static LengthUnit Yard = new LengthUnit("yd", 1/(0.3048m * 3));
        public static LengthUnit Chain = new LengthUnit("ch", 1/(0.3048m * 66));
        public static LengthUnit Mile = new LengthUnit("mi", 1/(0.3048m * 5280m));
        public static LengthUnit Nauticalmile = new LengthUnit("nmi", 1/(0.3048m * 6076));

        public static LengthUnit LightYear = new LengthUnit("ly", 9460730472580800m);
        public static LengthUnit AstronomicalUnit = new LengthUnit("au", 149597870700m);
        public static LengthUnit Parsec = new LengthUnit("pc", 30856775814913673m);



        protected LengthUnit() { }

        public LengthUnit(string symbol, decimal a, decimal b)
            : base(symbol, a, b)
        {
        }

        public LengthUnit(string symbol, decimal a)
    : base(symbol, a)
        {
        }

        public LengthUnit(PreFix SI, BaseUnits baseunit)
: base(SI, baseunit)
        {
        }


        public static IEnumerable<LengthUnit> List()
        {
            return new[] { Inch, Hand, Foot, Yard, Chain, Nauticalmile, LightYear, AstronomicalUnit, Parsec };
        }
        // Other util methods
    }



}