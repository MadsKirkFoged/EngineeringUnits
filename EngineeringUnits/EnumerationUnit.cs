using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace EngineeringUnits
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
    public class Enumeration :ICloneable
    {

        [JsonProperty(PropertyName = "Q", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string QuantityName { get; set; }

        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue("")]
        public string Symbol { get; init; } 

        //[JsonProperty(PropertyName = "LC", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        //[DefaultValue(1.0d)]
        //public decimal LocalC { get; init; } 

        //[JsonProperty(PropertyName = "GC", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        //[DefaultValue(1.0d)]
        //public decimal GlobalC { get; private  set; }

        [JsonProperty(PropertyName = "NC", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public Fraction NewC { get; set; }

        [JsonProperty(PropertyName = "AC", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        //[DefaultValue(value: Fraction.One)]
        public Fraction ActualC { get; set; } 

        [JsonProperty(PropertyName = "B", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0d)]
        public decimal B { get; init; }

        [JsonProperty(PropertyName = "C", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(1)]
        public int Count { get; set; } //Count

        [JsonIgnore]
        public UnitSystem Unit { get; protected set; }

        public Fraction TotalConstant => Fraction.Pow(NewC, Count);

        [JsonProperty(PropertyName = "Type", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string TypeOfUnit { get; protected set; }



        public Enumeration()
        {
        }


        protected Enumeration(string symbol, decimal a1, decimal a2, decimal b)
        {
            Symbol = symbol;
            //LocalC = a1;
            //GlobalC = a2;
            NewC = new Fraction(a1 * a2);
            B = b;
            ActualC = 1;
            Count = 1;
            TypeOfUnit = GetType().Name;

        }

        protected Enumeration(string symbol, decimal a1, decimal a2)
        {
            Symbol = symbol;
            //LocalC = a1;
            //GlobalC = a2;
            NewC = new Fraction(a1 * a2);
            B = 0;
            ActualC = 1;
            Count = 1;
            TypeOfUnit = GetType().Name;
        }

        protected Enumeration(string symbol, Fraction Constant)
        {
            Symbol = symbol;
            NewC = Constant;
            B = 0;
            ActualC = 1;
            Count = 1;
            TypeOfUnit = GetType().Name;
        }

        protected Enumeration(string symbol, decimal Constant)
        {
            Symbol = symbol;
            NewC = new Fraction(Constant);
            B = 0;
            ActualC = 1;
            Count = 1;
            TypeOfUnit = GetType().Name;
        }

        protected Enumeration(PreFix SI, BaseUnits baseunit)
        {
            //LocalC = PrefixSISize(SI);
            //GlobalC = 1;
            NewC = new Fraction(PrefixSISize(SI));

            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(baseunit);
            B = 0;
            ActualC = 1;
            Count = 1;
            TypeOfUnit = GetType().Name;
        }


        public override string ToString()
        {

            if (Unit.Symbol is not null)
            {
                return $"{Unit.Symbol}";
            }



            return $"{Unit}";
        }

        public string BaseUnitsToString()
        {
            return $"{Unit}";
        }

     
        public override bool Equals(object obj)
        {
            if (obj is not Enumeration)
            {
                return false;
            }
            var typeMatches = GetType().Equals(obj.GetType());
            //var valueMatches = Name.Equals(otherValue.Name);
            return typeMatches;// && valueMatches;
        }

        //public int CompareTo(object other)
        //{
        //    return Name.CompareTo(((Enumeration)other).Name);
        //}

        public static decimal PrefixSISize(PreFix preFix) =>
           preFix switch
           {
               PreFix.yotta => 1e+24m,
               PreFix.zetta => 1e+21m,
               PreFix.exa   => 1e+18m,
               PreFix.peta  => 1e+15m,
               PreFix.tera  => 1e+12m,
               PreFix.giga  => 1e+9m,
               PreFix.mega  => 1e+6m,
               PreFix.kilo  => 1e+3m,
               PreFix.hecto => 1e+2m,
               PreFix.deka  => 1e+1m,
               PreFix.SI    => 1e0m,
               PreFix.deci  => 1e-1m,
               PreFix.centi => 1e-2m,
               PreFix.milli => 1e-3m,
               PreFix.micro => 1e-6m,
               PreFix.nano  => 1e-9m,
               PreFix.pico  => 1e-12m,
               PreFix.femto => 1e-15m,
               PreFix.atto  => 1e-18m,
               PreFix.zepto => 1e-21m,
               PreFix.yocto => 1e-24m,

               _ => 0
           };
        public static string PrefixSISymbol(PreFix preFix) =>
           preFix switch
           {
               PreFix.yotta => "Y",
               PreFix.zetta => "Z",
               PreFix.exa   => "E",
               PreFix.peta  => "P",
               PreFix.tera  => "T",
               PreFix.giga  => "G",
               PreFix.mega  => "M",
               PreFix.kilo  => "k",
               PreFix.hecto => "h",
               PreFix.deka  => "da",
               PreFix.deci  => "d",
               PreFix.centi => "c",
               PreFix.milli => "m",
               PreFix.micro => "µ",
               PreFix.nano  => "n",
               PreFix.pico  => "p",
               PreFix.femto => "f",
               PreFix.atto  => "a",
               PreFix.zepto => "z",
               PreFix.yocto => "y",

               _ => ""
           };
        public static string BaseUnitSISymbol(BaseUnits baseUnits) =>
           baseUnits switch
           {
               BaseUnits.time               => "s",
               BaseUnits.length             => "m",
               BaseUnits.mass               => "g",
               BaseUnits.electricCurrent    => "A",
               BaseUnits.temperature        => "",
               BaseUnits.amountOfSubstance  => "mol",
               BaseUnits.luminousIntensity  => "cd",
               _ => "",
           };

        
        public void SetCombined(decimal correction)
        {
            Fraction correction2 = 1;

            //if (Unit.Combined is object)
              //  correction2 = Unit.Combined.NewC;


            if (correction != 1)
            {
                //Unit.Combined = new CombinedUnit("", (Fraction)correction * correction2);
                
                //New way (now we dont add it 2x times)
                Unit.ListOfUnits.Add(new CombinedUnit("", (Fraction)correction));
            }

        }

        public void SetCombined(PreFix SI)
        {
            SetCombined(PrefixSISize(SI));
        }

        public void SetNewSymbol(string NewSymbol, string CustomAutoSymbol = "Empty")
        {
            if (NewSymbol != "Empty")
                Unit.Symbol = NewSymbol;
            else if (CustomAutoSymbol != "Empty")            
                Unit.Symbol = CustomAutoSymbol;            
            else           
                Unit.Symbol = $"{Unit}";
        }

        public void SetNewSymbol(PreFix SI)
        {
            Unit.Symbol = PrefixSISymbol(SI) + Unit.Symbol;
        }

        public void SetNewGlobalC(decimal globalC) => NewC = new Fraction(globalC);

        public void SetNewGlobalC(Fraction globalC) => NewC = globalC;



        public static T GetUnitByString<T>(string name)
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (field.Name == name)
                    return (T)field.GetValue(field);
            }

            throw new ArgumentException($"Could not find a unit with a name of '{name}'");
        }

        public static List<T> ListOf<T>() where T: Enumeration
        {
            List<T> local = new();

            foreach (var field in typeof(T).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                T localunit = (T)field.GetValue(field);
                localunit.QuantityName = field.Name;

                local.Add(localunit);
            }


            return local;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public static UnitSystem operator *(Enumeration left, Enumeration right) => left.Unit* right.Unit;
        public static UnitSystem operator *(UnitSystem left, Enumeration right) => left * right.Unit;
        public static UnitSystem operator *(Enumeration left, UnitSystem right) => left.Unit * right;

        public static UnitSystem operator /(Enumeration left, Enumeration right) => left.Unit / right.Unit;
        public static UnitSystem operator /(Enumeration left, UnitSystem right) => left.Unit / right;
        public static UnitSystem operator /(UnitSystem left, Enumeration right) => left / right.Unit;

        public UnitSystem Pow(int toPower) =>  Unit.Pow(toPower);




        public override int GetHashCode()
        {
            HashCode hashCode = new();
            hashCode.Add(Symbol);
            hashCode.Add(NewC);
            //hashCode.Add(GlobalC);
            hashCode.Add(ActualC);
            hashCode.Add(B);
            hashCode.Add(Count);
            hashCode.Add(Count);
            //hashCode.Add(Unit.GetHashCode());

            return hashCode.ToHashCode();
        }
    }
}
