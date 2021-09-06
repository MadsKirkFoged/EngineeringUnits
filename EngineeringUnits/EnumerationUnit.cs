using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System;
using System.ComponentModel;

namespace EngineeringUnits
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public class Enumeration :ICloneable
    {

        [JsonProperty(PropertyName = "Q", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public string QuantityName { get; set; } //QuantityName

        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue("")]
        public string Symbol { get; private set; } //Symbol

        [JsonProperty(PropertyName = "LC", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(1.0d)]
        public decimal LocalC { get; private set; } //LocalC

        [JsonProperty(PropertyName = "GC", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(1.0d)]
        public decimal GlobalC { get; private  set; } //GlobalC

        [JsonProperty(PropertyName = "AC", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        //[DefaultValue(value: Fraction.One)]
        public Fraction ActualC { get; set; } //ActualC

        [JsonProperty(PropertyName = "B", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0d)]
        public decimal B { get; private set; }

        [JsonProperty(PropertyName = "C", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(1)]
        public int Count { get; set; } //Count

        [JsonIgnore]
        public UnitSystem Unit { get; protected set; }


        public Enumeration()
        {
        }


        protected Enumeration(string symbol, decimal a1, decimal a2, decimal b)
        {
            Symbol = symbol;
            LocalC = a1;
            GlobalC = a2;
            B = b;
            ActualC = 1;
            Count = 1;

        }

        protected Enumeration(string symbol, decimal a1, decimal a2)
        {
            Symbol = symbol;
            LocalC = a1;
            GlobalC = a2;
            B = 0;
            ActualC = 1;
            Count = 1;
        }

        protected Enumeration(PreFix SI, BaseUnits baseunit)
        {
            LocalC = PrefixSISize(SI);
            GlobalC = 1;
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(baseunit);
            B = 0;
            ActualC = 1;
            Count = 1;
        }


        public override string ToString()
        {

            if (Unit.Symbol is object)
            {
                return $"{Unit.Symbol}";
            }



            return $"{Unit}";
        }

        public string BaseUnitsToString()
        {
            return $"{Unit}";
        }

        //public static IEnumerable<T> GetAll<T>() where T : Enumeration, new()
        //{
        //    var type = typeof(T);
        //    var fields = type.GetTypeInfo().GetFields(BindingFlags.Public |
        //        BindingFlags.Static |
        //        BindingFlags.DeclaredOnly);
        //    foreach (var info in fields)
        //    {
        //        var instance = new T();
        //        var locatedValue = info.GetValue(instance) as T;
        //        if (locatedValue != null)
        //        {
        //            yield return locatedValue;
        //        }
        //    }
        //}

        public override bool Equals(object obj)
        {
            var otherValue = obj as Enumeration;
            if (otherValue == null)
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

        //public decimal PrefixSISize(PreFix preFix) =>
        //   preFix switch
        //   {
        //       PreFix.yotta => 1e+24m,
        //       PreFix.zetta => 1e+21m,
        //       PreFix.exa => 1e+18m,
        //       PreFix.peta => 1e+15m,
        //       PreFix.tera => 1e+12m,
        //       PreFix.giga => 1e+9m,
        //       PreFix.mega => 1e+6m,
        //       PreFix.kilo => 1e+3m,
        //       PreFix.hecto => 1e+2m,
        //       PreFix.deka => 1e+1m,
        //       PreFix.SI => 1e0m,
        //       PreFix.deci => 1e-1m,
        //       PreFix.centi => 1e-2m,
        //       PreFix.milli => 1e-3m,
        //       PreFix.micro => 1e-6m,
        //       PreFix.nano => 1e-9m,
        //       PreFix.pico => 1e-12m,
        //       PreFix.femto => 1e-15m,
        //       PreFix.atto => 1e-18m,
        //       PreFix.zepto => 1e-21m,
        //       PreFix.yocto => 1e-24m,

        //       _ => 0
        //   };


        public decimal PrefixSISize(PreFix preFix)
        {
            switch (preFix)
            {
                case PreFix.yotta:
                    return 1e+24m;
                case PreFix.zetta:
                    return 1e+21m;
                case PreFix.exa:
                    return 1e+18m;
                case PreFix.peta:
                    return 1e+15m;
                case PreFix.tera:
                    return 1e+12m;
                case PreFix.giga:
                    return 1e+9m;
                case PreFix.mega:
                    return 1e+6m;
                case PreFix.kilo:
                    return 1e+3m;
                case PreFix.hecto:
                    return 1e+2m;
                case PreFix.deka:
                    return 1e+1m;
                case PreFix.SI:
                    return 1e+0m;
                case PreFix.deci:
                    return 1e-1m;
                case PreFix.centi:
                    return 1e-2m;
                case PreFix.milli:
                    return 1e-3m;
                case PreFix.micro:
                    return 1e-6m;
                case PreFix.nano:
                    return 1e-9m;
                case PreFix.pico:
                    return 1e-12m;
                case PreFix.femto:
                    return 1e-15m;
                case PreFix.atto:
                    return 1e-18m;
                case PreFix.zepto:
                    return 1e-21m;
                case PreFix.yocto:
                    return 1e-24m;
                default:
                    return 0;
            }

        }
   


        //public string PrefixSISymbol(PreFix preFix) =>
        //   preFix switch
        //   {
        //       PreFix.yotta => "Y",
        //       PreFix.zetta => "Z",
        //       PreFix.exa => "E",
        //       PreFix.peta => "P",
        //       PreFix.tera => "T",
        //       PreFix.giga => "G",
        //       PreFix.mega => "M",
        //       PreFix.kilo => "k",
        //       PreFix.hecto => "h",
        //       PreFix.deka => "da",
        //       PreFix.deci => "d",
        //       PreFix.centi => "c",
        //       PreFix.milli => "m",
        //       PreFix.micro => "µ",
        //       PreFix.nano => "n",
        //       PreFix.pico => "p",
        //       PreFix.femto => "f",
        //       PreFix.atto => "a",
        //       PreFix.zepto => "z",
        //       PreFix.yocto => "y",

        //       _ => ""
        //   };

        public string PrefixSISymbol(PreFix preFix)
        {
            switch (preFix)
            {
                case PreFix.yotta:
                    return "Y";
                case PreFix.zetta:
                    return "Z";
                case PreFix.exa:
                    return "E";
                case PreFix.peta:
                    return "P";
                case PreFix.tera:
                    return "T";
                case PreFix.giga:
                    return "G";
                case PreFix.mega:
                    return "M";
                case PreFix.kilo:
                    return "k";
                case PreFix.hecto:
                    return "h";
                case PreFix.deka:
                    return "da";
                case PreFix.SI:
                    return "";
                case PreFix.deci:
                    return "d";
                case PreFix.centi:
                    return "c";
                case PreFix.milli:
                    return "m";
                case PreFix.micro:
                    return "µ";
                case PreFix.nano:
                    return "n";
                case PreFix.pico:
                    return "p";
                case PreFix.femto:
                    return "f";
                case PreFix.atto:
                    return "a";
                case PreFix.zepto:
                    return "z";
                case PreFix.yocto:
                    return "y";
                default:
                    return "";
            }
        }





        //public string BaseUnitSISymbol(BaseUnits baseUnits) =>
        //   baseUnits switch
        //   {
        //       BaseUnits.time => "s",
        //       BaseUnits.length => "m",
        //       BaseUnits.mass => "g",
        //       BaseUnits.electricCurrent => "A",
        //       BaseUnits.temperature => "",
        //       BaseUnits.amountOfSubstance => "mol",
        //       BaseUnits.luminousIntensity => "cd",
        //       _ => "",
        //   };

        public string BaseUnitSISymbol(BaseUnits baseUnits)
        {

            switch (baseUnits)
            {
                case BaseUnits.time:
                    return "s";
                case BaseUnits.length:
                    return "m";
                case BaseUnits.mass:
                    return "g";
                case BaseUnits.electricCurrent:
                    return "A";
                case BaseUnits.temperature:
                    return "";
                case BaseUnits.amountOfSubstance:
                    return "mol";
                case BaseUnits.luminousIntensity:
                    return "cd";
                default:
                    return ""; ;
            }


        }



        public void SetCombined(decimal correction)
        {
            decimal correction2 = 1;

            if (Unit.Combined is object)
                correction2 = Unit.Combined.GlobalC;


            if (correction != 1)
                Unit.Combined = new CombinedUnit("", 1, correction * correction2);

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

        public void SetNewGlobalC(decimal globalC) => GlobalC = globalC;

        
           

        //public Enumeration Clone() 
        //{
        //    return new Enumeration()
        //    {
        //        //Name = Name,
        //        Symbol = Symbol,
        //        LocalC = LocalC,
        //        GlobalC = GlobalC,
        //        B = B,
        //        Count = Count,
        //        ActualC = ActualC,
        //    };
        //}




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
            List<T> local = new List<T>();

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
        





    }
}
