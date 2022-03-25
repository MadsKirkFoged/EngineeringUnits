using Fractions;
using Newtonsoft.Json;
using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace EngineeringUnits
{
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
    public class UnitEnumbase :ICloneable, IUnitSystem
    {

        [JsonIgnore]
        public string QuantityName { get; set; }

        [JsonProperty(PropertyName = "S", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue("")]
        public string Symbol { get; init; } 

        [JsonProperty(PropertyName = "A", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public Fraction A { get; init; }

        [JsonProperty(PropertyName = "B", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue(0d)]
        public decimal B { get; init; }

        [JsonProperty(PropertyName = "C", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)][DefaultValue(1)]
        public int Count { get; init; } 

        [JsonIgnore]
        public UnitSystem Unit { get; init; }

        [JsonIgnore]
        public Fraction TotalConstant => Fraction.Pow(A, Count);

        [JsonProperty(PropertyName = "Type", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        public BaseunitType UnitType { get; init; }

        [JsonIgnore]
        public bool IsSI { get; init; }



        public UnitEnumbase()
        {
        }


        protected UnitEnumbase(string symbol, Fraction Constant, BaseunitType baseunit, decimal b = 0m)
        {
            Symbol = symbol;
            A = Constant;
            B = b;
            Count = 1;
            UnitType = baseunit;
            if (A == Fraction.One)
                IsSI = true;
        }


        protected UnitEnumbase(PreFix SI, BaseunitType baseunit)
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(baseunit);
            A = new Fraction(PrefixSISize(SI));
            B = 0;
            Count = 1;
            UnitType = baseunit;
            if (A == Fraction.One)
                this.IsSI = true;

        }
        protected UnitEnumbase(PreFix SI, UnitEnumbase baseunit)
        {
            if (baseunit.Unit.Symbol is null)
                Unit = new UnitSystem(baseunit.Unit * PrefixSISize(SI), PrefixSISymbol(SI) + $"{baseunit.Unit}");
            else
                Unit = new UnitSystem(baseunit.Unit * PrefixSISize(SI), PrefixSISymbol(SI) + baseunit.Unit.Symbol);
            
        }

        protected UnitEnumbase(UnitEnumbase unit, string NewSymbol, decimal correction)
        {
            Unit = new UnitSystem(unit * correction, NewSymbol);
        }

        private UnitEnumbase(UnitEnumbase unit, bool ReverseCount)
        {
            //Used for cloning
            QuantityName = unit.QuantityName;
            Symbol = unit.Symbol;
            A = unit.A;
            B = unit.B;

            if (ReverseCount)            
                Count = unit.Count*-1;            
            else
                Count = unit.Count;

            if (unit.Unit is not null)            
                Unit = new UnitSystem(unit.Unit, unit.Symbol);            

            UnitType = unit.UnitType;

            if (A == Fraction.One)
                IsSI = true;
        }

        public UnitEnumbase(UnitEnumbase unit, int NewCount) : this(unit, false)
        {
            Count = NewCount;
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
            {
                return $"{Unit.Symbol}";
            }


            return $"{Unit}";            
        }
        
     
        public override bool Equals(object obj)
        {
            if (obj is not UnitEnumbase)
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
        public static string BaseUnitSISymbol(BaseunitType baseUnits) =>
           baseUnits switch
           {
               BaseunitType.time               => "s",
               BaseunitType.length             => "m",
               BaseunitType.mass               => "g",
               BaseunitType.electricCurrent    => "A",
               BaseunitType.temperature        => "",
               BaseunitType.amountOfSubstance  => "mol",
               BaseunitType.luminousIntensity  => "cd",
               _ => "",
           };
        public string GetNewSymbol(PreFix SI)
        {
            if (Unit.Symbol is null)            
                return PrefixSISymbol(SI) + $"{Unit}";            
            else            
                return PrefixSISymbol(SI) + Unit.Symbol;       
        }

        public static T GetUnitByString<T>(string name)
            where T:UnitEnumbase
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (field.Name == name)
                    return (T)field.GetValue(field);
            }

            throw new ArgumentException($"Could not find a unit with a name of '{name}'");
        }

        public static List<T> ListOf<T>() where T: UnitEnumbase
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
            return new UnitEnumbase(this, false);
        }

        public UnitEnumbase CloneAndReverseCount()
        {
            return new UnitEnumbase(this, true);
        }


        public static UnitSystem operator *(UnitEnumbase left, UnitEnumbase right) => left.Unit* right.Unit;
        public static UnitSystem operator *(UnitSystem left, UnitEnumbase right) => left * right.Unit;
        public static UnitSystem operator *(UnitEnumbase left, UnitSystem right) => left.Unit * right;

        public static UnitSystem operator *(decimal left, UnitEnumbase right) => left * right.Unit;
        public static UnitSystem operator *(UnitEnumbase left, decimal right) => left.Unit * right;

        public static UnitSystem operator /(UnitEnumbase left, UnitEnumbase right) => left.Unit / right.Unit;
        public static UnitSystem operator /(UnitEnumbase left, UnitSystem right) => left.Unit / right;
        public static UnitSystem operator /(UnitSystem left, UnitEnumbase right) => left / right.Unit;


        private int HashCode;

        public override int GetHashCode()
        {

            if (HashCode == 0)
            {

                unchecked // Overflow is fine, just wrap
                {
                    int hash = (int)2166136261;
                    // Suitable nullity checks etc, of course :)
                    hash = (hash * 16777619) ^ A.GetHashCode();
                    hash = (hash * 45476689) ^ B.GetHashCode();
                    hash = (hash * 16777619) ^ Count.GetHashCode();
                    hash = (hash * 16777619) ^ UnitType.GetHashCode();

                    //int unittype = TypeOfUnit switch
                    //{
                    //    "AmountOfSubstanceUnit" => 1,
                    //    "CombinedUnit" => 2,
                    //    "DurationUnit" => 3,
                    //    "ElectricCurrentUnit" => 4,
                    //    "LengthUnit" => 5,
                    //    "LuminousIntensityUnit" => 6,
                    //    "MassUnit" => 7,
                    //    "TemperatureUnit" => 8,
                    //    _ => 0,
                    //};

                    //hash = (hash * 566936767) ^ unittype.GetHashCode();

                    HashCode = hash;
                }


            }

            return HashCode;
        }
    }
}
