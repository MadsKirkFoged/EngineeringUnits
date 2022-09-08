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

    // This is inherited by all UnitTypes
    // It is just a UnitSystem with a few extra methods
    // --> ex LengthUnit inherits this
    // --> LengthUnit is used to store: Kilometer, Meter, Inch, Yard...


    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
    public record UnitTypebase : IUnitSystem
    {

        [JsonIgnore]
        public string QuantityName { get; set; }

        //[JsonIgnore]
        public UnitSystem Unit { get; init; }


        public UnitTypebase() {}
       
        protected UnitTypebase(PreFix SI, UnitTypebase baseunit)
        {
            if (baseunit.Unit.Symbol is null)
                Unit = new UnitSystem(baseunit.Unit * PrefixSISize(SI), PrefixSISymbol(SI) + $"{baseunit.Unit}");
            else
                Unit = new UnitSystem(baseunit.Unit * PrefixSISize(SI), PrefixSISymbol(SI) + baseunit.Unit.Symbol);
            
        }

        protected UnitTypebase(UnitTypebase unit, string NewSymbol, decimal correction)
        {
            Unit = new UnitSystem(unit * correction, NewSymbol);
        }       

        public override string ToString()
        {
            if (Unit.Symbol is not null)            
                return $"{Unit.Symbol}";          

            return $"{Unit}";            
        }      
     
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
       
        public static T GetUnitByString<T>(string name)
            where T:UnitTypebase
        {
            foreach (var field in typeof(T).GetFields(BindingFlags.Static | BindingFlags.Public))
            {
                if (field.Name.ToLower() == name.ToLower())
                    return (T)field.GetValue(field);
            }

            throw new ArgumentException($"Could not find a unit with a name of '{name}'");
        }

        public static List<T> ListOf<T>() where T: UnitTypebase
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


        public static UnitSystem operator *(UnitTypebase left, UnitTypebase right) => left.Unit* right.Unit;
        public static UnitSystem operator *(UnitSystem left, UnitTypebase right) => left * right.Unit;
        public static UnitSystem operator *(UnitTypebase left, UnitSystem right) => left.Unit * right;

        public static UnitSystem operator *(decimal left, UnitTypebase right) => left * right.Unit;
        public static UnitSystem operator *(UnitTypebase left, decimal right) => left.Unit * right;

        public static UnitSystem operator /(UnitTypebase left, UnitTypebase right) => left.Unit / right.Unit;
        public static UnitSystem operator /(UnitTypebase left, UnitSystem right) => left.Unit / right;
        public static UnitSystem operator /(UnitSystem left, UnitTypebase right) => left / right.Unit;


        
    }
}
