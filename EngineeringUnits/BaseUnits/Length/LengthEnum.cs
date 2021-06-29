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



        public static LengthUnit Kilometer =    new LengthUnit(PreFix.kilo,     BaseUnits.length);
        public static LengthUnit Hectometer =   new LengthUnit(PreFix.hecto,    BaseUnits.length);
        public static LengthUnit Meter =        new LengthUnit(PreFix.SI,       BaseUnits.length);
        public static LengthUnit SI =           new LengthUnit(PreFix.SI,       BaseUnits.length);
        public static LengthUnit Decimeter =    new LengthUnit(PreFix.deci,     BaseUnits.length);
        public static LengthUnit Centimeter =   new LengthUnit(PreFix.centi,    BaseUnits.length);
        public static LengthUnit Millimeter =   new LengthUnit(PreFix.milli,    BaseUnits.length);
        public static LengthUnit Micrometer =   new LengthUnit(PreFix.micro,    BaseUnits.length);
        public static LengthUnit Nanometer =    new LengthUnit(PreFix.nano,     BaseUnits.length);

        public static LengthUnit Microinch =    new LengthUnit("µin",       1e-6m,          0.0254m);
        public static LengthUnit Twip =         new LengthUnit("twip",      1/1440m,        0.0254m);
        public static LengthUnit Mil =          new LengthUnit("mil",       1/1000m,        0.0254m);
        public static LengthUnit DtpPoint =     new LengthUnit("pt",        1/72m,          0.0254m);
        public static LengthUnit DtpPica =      new LengthUnit("pica",      1/6m,           0.0254m);
        public static LengthUnit Inch =         new LengthUnit("in",        1,              0.0254m);
        public static LengthUnit Hand =         new LengthUnit("h",         4,              0.0254m);
        public static LengthUnit Foot =         new LengthUnit("ft",        12,             0.0254m);
        public static LengthUnit Yard =         new LengthUnit("yd",        36,             0.0254m);
        public static LengthUnit Fathom =       new LengthUnit("fathom",    72,             0.0254m);
        public static LengthUnit Chain =        new LengthUnit("ch",        792,            0.0254m);
        public static LengthUnit Shackle =      new LengthUnit("shackle",   1080,           0.0254m);
        public static LengthUnit Mile =         new LengthUnit("mi",        63360,          0.0254m);
        public static LengthUnit NauticalMile = new LengthUnit("NM",        72913.3858m,    0.0254m);
        public static LengthUnit UsSurveyFoot = new LengthUnit("ftUS",      1m,             1200/3937m);

        public static LengthUnit LightYear =        new LengthUnit("ly",    1,      9460730472580800m);
        public static LengthUnit KilolightYear =    new LengthUnit("kly",   1e+3m,  9460730472580800m);
        public static LengthUnit MegalightYear =    new LengthUnit("Mly",   1e+6m,  9460730472580800m);
        public static LengthUnit SolarRadius =      new LengthUnit("R⊙",    1,      6.95510000E+08m);
        public static LengthUnit AstronomicalUnit = new LengthUnit("au",    1,      149597870700m);
        public static LengthUnit Parsec =           new LengthUnit("pc",    1,      30856775814913673m);
        public static LengthUnit Kiloparsec =       new LengthUnit("kpc",   1e+3m,  30856775814913673m);
        public static LengthUnit Megaparsec =       new LengthUnit("Mpc",   1e+6m,  30856775814913673m);



        public LengthUnit() { }


        public LengthUnit(string NewSymbol, decimal a1, decimal a2) : base(NewSymbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Length = (LengthUnit)Clone();

            //Beta
            //Unit.UnitListBeta.Add(this);

        }


        public LengthUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Length = (LengthUnit)Clone();


            //Beta
            //Unit.UnitListBeta.Add(this);

        }             


    }



}