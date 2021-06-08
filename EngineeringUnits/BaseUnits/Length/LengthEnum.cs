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
        public static LengthUnit Hectometer = new LengthUnit(PreFix.hecto, BaseUnits.length);
        public static LengthUnit Meter = new LengthUnit(PreFix.SI, BaseUnits.length);
        public static LengthUnit SI = new LengthUnit(PreFix.SI, BaseUnits.length);
        public static LengthUnit Decimeter = new LengthUnit(PreFix.deci, BaseUnits.length);
        public static LengthUnit Centimeter = new LengthUnit(PreFix.centi, BaseUnits.length);
        public static LengthUnit Millimeter = new LengthUnit(PreFix.milli, BaseUnits.length);
        public static LengthUnit Micrometer = new LengthUnit(PreFix.micro, BaseUnits.length);
        public static LengthUnit Nanometer = new LengthUnit(PreFix.nano, BaseUnits.length);


        public static LengthUnit Inch = new LengthUnit("in", 1, 0.0254m);
        public static LengthUnit Hand = new LengthUnit("hand", 4, 0.0254m);
        public static LengthUnit Foot = new LengthUnit("ft", 12, 0.0254m);
        public static LengthUnit Yard = new LengthUnit("yd", 36, 0.0254m);
        public static LengthUnit Chain = new LengthUnit("ch", 792, 0.0254m);
        public static LengthUnit Mile = new LengthUnit("mi", 63360, 0.0254m);
        public static LengthUnit NauticalMile = new LengthUnit("nmi", 72913.3858m, 0.0254m);



        public static LengthUnit LightYear = new LengthUnit("ly",1, 9460730472580800m);
        public static LengthUnit AstronomicalUnit = new LengthUnit("au",1, 149597870700m);
        public static LengthUnit Parsec = new LengthUnit("pc",1, 30856775814913673m);



        public LengthUnit() { }


        public LengthUnit(string symbol, decimal a1, decimal a2) : base(symbol, a1, a2)
        {
            SetUnitSystem();

        }


        public LengthUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            SetUnitSystem();

        }

        public void SetUnitSystem()
        {
            Unit = new UnitSystem();
            Unit.Length = this.Copy();
            Unit.Length.Count = 1;
            Unit.Length.ActualC = 1;
            Unit.Length.Name = "Length";
            Name = "Length";
            Count = 1;
            ActualC = 1;
        }

       
        public static IEnumerable<LengthUnit> List()
        {
            return new[] { Inch, Hand, Foot, Yard, Chain, NauticalMile, LightYear, AstronomicalUnit, Parsec };
        }



        public LengthUnit Copy()
        {
            return new LengthUnit
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