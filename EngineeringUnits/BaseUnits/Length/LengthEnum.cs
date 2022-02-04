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



        public static readonly LengthUnit Kilometer =    new(PreFix.kilo,     BaseUnits.length);
        public static readonly LengthUnit Hectometer =   new(PreFix.hecto,    BaseUnits.length);
        public static readonly LengthUnit Meter =        new(PreFix.SI,       BaseUnits.length);
        public static readonly LengthUnit SI =           new(PreFix.SI,       BaseUnits.length);
        public static readonly LengthUnit Decimeter =    new(PreFix.deci,     BaseUnits.length);
        public static readonly LengthUnit Centimeter =   new(PreFix.centi,    BaseUnits.length);
        public static readonly LengthUnit Millimeter =   new(PreFix.milli,    BaseUnits.length);
        public static readonly LengthUnit Micrometer =   new(PreFix.micro,    BaseUnits.length);
        public static readonly LengthUnit Nanometer =    new(PreFix.nano,     BaseUnits.length);
        public static readonly LengthUnit Microinch =    new("µin",       1e-6m * 0.0254m);
        public static readonly LengthUnit Twip =         new("twip",      1/1440m * 0.0254m);
        public static readonly LengthUnit Mil =          new("mil",       1/1000m * 0.0254m);
        public static readonly LengthUnit DtpPoint =     new("pt",        1/72m * 0.0254m);
        public static readonly LengthUnit DtpPica =      new("pica",      1/6m * 0.0254m);
        public static readonly LengthUnit Inch =         new("in",        1,              0.0254m);
        public static readonly LengthUnit Hand =         new("h",         4,              0.0254m);
        public static readonly LengthUnit Foot =         new("ft",        12,             0.0254m);
        public static readonly LengthUnit Yard =         new("yd",        36,             0.0254m);
        public static readonly LengthUnit Fathom =       new("fathom",    72,             0.0254m);
        public static readonly LengthUnit Chain =        new("ch",        792,            0.0254m);
        public static readonly LengthUnit Shackle =      new("shackle",   1080,           0.0254m);
        public static readonly LengthUnit Mile =         new("mi",        63360,          0.0254m);
        public static readonly LengthUnit NauticalMile = new("NM",        72913.3858m,    0.0254m);
        public static readonly LengthUnit UsSurveyFoot = new("ftUS",      1m,             1200/3937m);
        public static readonly LengthUnit LightYear =        new("ly",    1,      9460730472580800m);
        public static readonly LengthUnit KilolightYear =    new("kly",   1e+3m,  9460730472580800m);
        public static readonly LengthUnit MegalightYear =    new("Mly",   1e+6m,  9460730472580800m);
        public static readonly LengthUnit SolarRadius =      new("R⊙",    1,      6.95510000E+08m);
        public static readonly LengthUnit AstronomicalUnit = new("au",    1,      149597870700m);
        public static readonly LengthUnit Parsec =           new("pc",    1,      30856775814913673m);
        public static readonly LengthUnit Kiloparsec =       new("kpc",   1e+3m,  30856775814913673m);
        public static readonly LengthUnit Megaparsec =       new("Mpc",   1e+6m,  30856775814913673m);





        public LengthUnit() { }

        public LengthUnit(string NewSymbol, decimal Constant) : base(NewSymbol, Constant)
        {
            Unit = new UnitSystem();
            Unit.Length = (LengthUnit)Clone();
        }


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