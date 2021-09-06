using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class LengthUnit : Enumeration
    {



        public static readonly LengthUnit Kilometer =    new LengthUnit(PreFix.kilo,     BaseUnits.length);
        public static readonly LengthUnit Hectometer =   new LengthUnit(PreFix.hecto,    BaseUnits.length);
        public static readonly LengthUnit Meter =        new LengthUnit(PreFix.SI,       BaseUnits.length);
        public static readonly LengthUnit SI =           new LengthUnit(PreFix.SI,       BaseUnits.length);
        public static readonly LengthUnit Decimeter =    new LengthUnit(PreFix.deci,     BaseUnits.length);
        public static readonly LengthUnit Centimeter =   new LengthUnit(PreFix.centi,    BaseUnits.length);
        public static readonly LengthUnit Millimeter =   new LengthUnit(PreFix.milli,    BaseUnits.length);
        public static readonly LengthUnit Micrometer =   new LengthUnit(PreFix.micro,    BaseUnits.length);
        public static readonly LengthUnit Nanometer =    new LengthUnit(PreFix.nano,     BaseUnits.length);
        public static readonly LengthUnit Microinch =    new LengthUnit("µin",       1e-6m,          0.0254m);
        public static readonly LengthUnit Twip =         new LengthUnit("twip",      1/1440m,        0.0254m);
        public static readonly LengthUnit Mil =          new LengthUnit("mil",       1/1000m,        0.0254m);
        public static readonly LengthUnit DtpPoint =     new LengthUnit("pt",        1/72m,          0.0254m);
        public static readonly LengthUnit DtpPica =      new LengthUnit("pica",      1/6m,           0.0254m);
        public static readonly LengthUnit Inch =         new LengthUnit("in",        1,              0.0254m);
        public static readonly LengthUnit Hand =         new LengthUnit("h",         4,              0.0254m);
        public static readonly LengthUnit Foot =         new LengthUnit("ft",        12,             0.0254m);
        public static readonly LengthUnit Yard =         new LengthUnit("yd",        36,             0.0254m);
        public static readonly LengthUnit Fathom =       new LengthUnit("fathom",    72,             0.0254m);
        public static readonly LengthUnit Chain =        new LengthUnit("ch",        792,            0.0254m);
        public static readonly LengthUnit Shackle =      new LengthUnit("shackle",   1080,           0.0254m);
        public static readonly LengthUnit Mile =         new LengthUnit("mi",        63360,          0.0254m);
        public static readonly LengthUnit NauticalMile = new LengthUnit("NM",        72913.3858m,    0.0254m);
        public static readonly LengthUnit UsSurveyFoot = new LengthUnit("ftUS",      1m,             1200/3937m);
        public static readonly LengthUnit LightYear =        new LengthUnit("ly",    1,      9460730472580800m);
        public static readonly LengthUnit KilolightYear =    new LengthUnit("kly",   1e+3m,  9460730472580800m);
        public static readonly LengthUnit MegalightYear =    new LengthUnit("Mly",   1e+6m,  9460730472580800m);
        public static readonly LengthUnit SolarRadius =      new LengthUnit("R⊙",    1,      6.95510000E+08m);
        public static readonly LengthUnit AstronomicalUnit = new LengthUnit("au",    1,      149597870700m);
        public static readonly LengthUnit Parsec =           new LengthUnit("pc",    1,      30856775814913673m);
        public static readonly LengthUnit Kiloparsec =       new LengthUnit("kpc",   1e+3m,  30856775814913673m);
        public static readonly LengthUnit Megaparsec =       new LengthUnit("Mpc",   1e+6m,  30856775814913673m);





        public LengthUnit() { }


        public LengthUnit(string NewSymbol, decimal a1, decimal a2) : base(NewSymbol, a1, a2)
        {
            Unit = new UnitSystem();
            Unit.Length = (LengthUnit)Clone();

        }


        public LengthUnit(PreFix SI, BaseUnits baseunit) : base(SI, baseunit)
        {
            Unit = new UnitSystem();
            Unit.Length = (LengthUnit)Clone();

        }             


    }



}