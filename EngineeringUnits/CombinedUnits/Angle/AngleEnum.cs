using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class AngleUnit : Enumeration
    {

        public static readonly AngleUnit SI = new AngleUnit();
        public static readonly AngleUnit Arcminute = new AngleUnit("'", 1/60m);
        public static readonly AngleUnit Arcsecond = new AngleUnit("″", 1/3600m);
        
        public static readonly AngleUnit Gradian = new AngleUnit("g", 0.9m);

        public static readonly AngleUnit Radian = new AngleUnit("rad", (decimal)(180 / Math.PI));
        public static readonly AngleUnit Centiradian = new AngleUnit(PreFix.centi, Radian);
        public static readonly AngleUnit Deciradian = new AngleUnit(PreFix.deci, Radian);
        public static readonly AngleUnit Microradian = new AngleUnit(PreFix.micro, Radian);
        public static readonly AngleUnit Milliradian = new AngleUnit(PreFix.milli, Radian);
        public static readonly AngleUnit Nanoradian = new AngleUnit(PreFix.nano, Radian);

        public static readonly AngleUnit Degree = new AngleUnit("°");
        public static readonly AngleUnit Microdegree = new AngleUnit(PreFix.micro, Degree);
        public static readonly AngleUnit Millidegree = new AngleUnit(PreFix.milli, Degree);
        public static readonly AngleUnit Nanodegree = new AngleUnit(PreFix.nano, Degree);

        public static readonly AngleUnit Revolution = new AngleUnit("r", 360m);
        //public static readonly AngleUnit Tilt = new AngleUnit("", Math.Asin(_value)*180/Math.PI); //TODO How do we do this?



        public AngleUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }       

        public AngleUnit(PreFix SI, AngleUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

    }




}