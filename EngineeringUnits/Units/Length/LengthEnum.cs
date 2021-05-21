using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{

    public abstract class Enumeration : IComparable
    {
        public string Name { get; private set; }
        public string Symbol { get; private set; }
        public decimal A { get; private set; }
        public decimal B { get; private set; }

        protected Enumeration()
        {
        }

        protected Enumeration(string symbol, decimal a, decimal b)
        {
            Symbol = symbol;
            A = a;
            B = b;
        }

        protected Enumeration(string symbol, decimal a)
        {
            Symbol = symbol;
            A = a;
            B = 0;
        }

        protected Enumeration(PreFix SI, BaseUnits baseunit)
        {
            A = PrefixSISize(SI);
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(baseunit);
            B = 0;
        }

        public override string ToString()
        {
            return Name;
        }

        public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
        {
            var type = typeof(T);
            var fields = type.GetTypeInfo().GetFields(BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.DeclaredOnly);
            foreach (var info in fields)
            {
                var instance = new T();
                var locatedValue = info.GetValue(instance) as T;
                if (locatedValue != null)
                {
                    yield return locatedValue;
                }
            }
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;
            if (otherValue == null)
            {
                return false;
            }
            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Name.Equals(otherValue.Name);
            return typeMatches && valueMatches;
        }

        public int CompareTo(object other)
        {
            return Name.CompareTo(((Enumeration)other).Name);
        }

        public decimal PrefixSISize(PreFix preFix) =>
           preFix switch
           {
               PreFix.yotta => 1e+24m,
               PreFix.zetta => 1e+21m,
               PreFix.exa => 1e+18m,
               PreFix.peta => 1e+15m,
               PreFix.tera => 1e+12m,
               PreFix.giga => 1e+9m,
               PreFix.mega => 1e+6m,
               PreFix.kilo => 1e+3m,
               PreFix.hecto => 1e+2m,
               PreFix.deka => 1e+1m,
               PreFix.SI => 1e0m,
               PreFix.deci => 1e-1m,
               PreFix.centi => 1e-2m,
               PreFix.milli => 1e-3m,
               PreFix.micro => 1e-6m,
               PreFix.nano => 1e-9m,
               PreFix.pico => 1e-12m,
               PreFix.femto => 1e-15m,
               PreFix.atto => 1e-18m,
               PreFix.zepto => 1e-21m,
               PreFix.yocto => 1e-24m,

               _ => 0
           };

        public string PrefixSISymbol(PreFix preFix) =>
           preFix switch
           {
               PreFix.yotta => "Y",
               PreFix.zetta => "Z",
               PreFix.exa => "E",
               PreFix.peta => "P",
               PreFix.tera => "T",
               PreFix.giga => "G",
               PreFix.mega => "M",
               PreFix.kilo => "k",
               PreFix.hecto => "h",
               PreFix.deka => "da",
               PreFix.deci => "d",
               PreFix.centi => "c",
               PreFix.milli => "m",
               PreFix.micro => "µ",
               PreFix.nano => "n",
               PreFix.pico => "p",
               PreFix.femto => "f",
               PreFix.atto => "a",
               PreFix.zepto => "z",
               PreFix.yocto => "y",

               _ => ""
           };


        public string BaseUnitSISymbol(BaseUnits baseUnits) =>
           baseUnits switch
           {
               BaseUnits.time => "t",
               BaseUnits.length => "m",
               BaseUnits.mass => "g",
               BaseUnits.electricCurrent => "A",
               BaseUnits.temperature => "",
               BaseUnits.amountOfSubstance => "",
               BaseUnits.luminousIntensity => "cd",
               _ => "",
           };
    }


    public class LengthUnit : Enumeration
    {



        public static LengthUnit Kilometer = new LengthUnit(PreFix.kilo, BaseUnits.length);
        public static LengthUnit Meter = new LengthUnit(PreFix.SI, BaseUnits.length);
        public static LengthUnit Decimeter = new LengthUnit(PreFix.deci, BaseUnits.length);
        public static LengthUnit Centimeter = new LengthUnit(PreFix.centi, BaseUnits.length);
        public static LengthUnit Millimeter = new LengthUnit(PreFix.milli, BaseUnits.length);
        public static LengthUnit Nanometer = new LengthUnit(PreFix.nano, BaseUnits.length);


        public static LengthUnit Inch = new LengthUnit("in", 0.3048m / 12);
        public static LengthUnit Hand = new LengthUnit("hand", 0.3048m / 3);
        public static LengthUnit Foot = new LengthUnit("ft", 0.3048m);
        public static LengthUnit Yard = new LengthUnit("yd", 0.3048m * 3);
        public static LengthUnit Chain = new LengthUnit("ch", 0.3048m * 66);
        public static LengthUnit Mile = new LengthUnit("mi", 0.3048m * 5280m);
        public static LengthUnit Nauticalmile = new LengthUnit("nmi", 0.3048m * 6076);

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