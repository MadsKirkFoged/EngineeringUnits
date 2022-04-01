using Fractions;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public record LengthUnit : UnitTypebase
    {



        public static readonly LengthUnit Kilometer =           new(PreFix.kilo);
        public static readonly LengthUnit Hectometer =          new(PreFix.hecto);
        public static readonly LengthUnit Meter =               new(PreFix.SI);
        public static readonly LengthUnit SI =                  new(PreFix.SI);
        public static readonly LengthUnit Decimeter =           new(PreFix.deci);
        public static readonly LengthUnit Centimeter =          new(PreFix.centi);
        public static readonly LengthUnit Millimeter =          new(PreFix.milli);
        public static readonly LengthUnit Micrometer =          new(PreFix.micro);
        public static readonly LengthUnit Nanometer =           new(PreFix.nano);
        public static readonly LengthUnit Microinch =           new("µin",          1e-6m *         0.0254m);
        public static readonly LengthUnit Twip =                new("twip",         1/1440m *       0.0254m);
        public static readonly LengthUnit Mil =                 new("mil",          1/1000m *       0.0254m);
        public static readonly LengthUnit DtpPoint =            new("pt",           1/72m *         0.0254m);
        public static readonly LengthUnit DtpPica =             new("pica",         1/6m *          0.0254m);
        public static readonly LengthUnit Inch =                new("in",           1 *             0.0254m);
        public static readonly LengthUnit Hand =                new("h",            4 *             0.0254m);
        public static readonly LengthUnit Foot =                new("ft",           12 *            0.0254m);
        public static readonly LengthUnit Yard =                new("yd",           36 *            0.0254m);
        public static readonly LengthUnit Fathom =              new("fathom",       72 *            0.0254m);
        public static readonly LengthUnit Chain =               new("ch",           792 *           0.0254m);
        public static readonly LengthUnit Shackle =             new("shackle",      1080 *          0.0254m);
        public static readonly LengthUnit Mile =                new("mi",           63360 *         0.0254m);
        public static readonly LengthUnit NauticalMile =        new("NM",           72913.3858m *   0.0254m);
        public static readonly LengthUnit UsSurveyFoot =        new("ftUS",         1200/3937m);
        public static readonly LengthUnit LightYear =           new("ly",           9460730472580800m);
        public static readonly LengthUnit KilolightYear =       new("kly",          9460730472580800m * 1e+3m);
        public static readonly LengthUnit MegalightYear =       new("Mly",          9460730472580800m * 1e+6m);
        public static readonly LengthUnit SolarRadius =         new("R⊙",           6.95510000E+08m);
        public static readonly LengthUnit AstronomicalUnit =    new("au",           149597870700m);
        public static readonly LengthUnit Parsec =              new("pc",           30856775814913673m);
        public static readonly LengthUnit Kiloparsec =          new("kpc",          30856775814913673m * 1e+3m);
        public static readonly LengthUnit Megaparsec =          new("Mpc",          30856775814913673m * 1e+6m);





        public LengthUnit() { }

        public LengthUnit(string NewSymbol, decimal Constant)
        {
            var unit = new RawUnit()
            {
                Symbol=NewSymbol,
                A = new Fraction(Constant),
                UnitType = BaseunitType.length,
                B = 0,
                Count = 1,

            };


            Unit = new UnitSystem(unit);
        }

        public LengthUnit(PreFix SI)
        {

            var unit = new RawUnit()
            {
                Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.length),
                A = new Fraction(PrefixSISize(SI)),
                UnitType = BaseunitType.length,
                B = 0,
                Count = 1,

            };

            Unit = new UnitSystem(unit);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }
    }



}