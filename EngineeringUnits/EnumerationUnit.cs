using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{

    public class Enumeration : IComparable
    {
        public string Name { get; protected set; }
        public string Symbol { get; protected set; }
        public decimal A1 { get; protected set; }
        public decimal A2 { get; protected set; }
        public decimal B { get; protected set; }

        public int Count { get; set; }

        public bool ReversedA { get; protected set; }

        public UnitSystem Unit { get; protected set; }


        protected Enumeration()
        {
        }


        protected Enumeration(string symbol, decimal a1, decimal a2, decimal b)
        {
            Symbol = symbol;
            A1 = a1;
            A2 = a2;
            B = b;
            ReversedA = true;
        }

        protected Enumeration(string symbol, decimal a1, decimal a2)
        {
            Symbol = symbol;
            A1 = a1;
            A2 = a2;
            B = 0;
        }

        protected Enumeration(PreFix SI, BaseUnits baseunit)
        {
            A1 = PrefixSISize(SI);
            A2 = 1;
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
}
