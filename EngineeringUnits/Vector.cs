using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{

    public enum BaseUnits
    {
        time,
        length,
        mass,
        electricCurrent,
        temperature,
        amountOfSubstance,
        luminousIntensity


    }


    public enum PreFix
    {

        yotta,
        zetta,
        exa,
        peta,
        tera,
        giga,
        mega,
        kilo,
        hecto,
        deka,
        SI,
        deci,
        centi,
        milli,
        micro,
        nano,
        pico,
        femto,
        atto,
        zepto,
        yocto,




    }



    public class Vector : Attribute
    {

        public string Symbol { get; set; }


        public double AFactor { get; set; }

        public double BFactor { get; set; }



        public Vector()
        {


        }
        public Vector(string symbol)
        {
            Symbol = symbol;
            AFactor = 1;
            BFactor = 0;

        }

        public Vector(string symbol, double aFactor)
        {
            Symbol = symbol;
            AFactor = aFactor;
            BFactor = 0;

        }
        public Vector(string symbol, double aFactor, double bFactor)
        {
            Symbol = symbol;
            AFactor = aFactor;
            BFactor = bFactor;

        }


        public Vector(PreFix SI, BaseUnits baseunit)
        {
            AFactor = PrefixSISize(SI);
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(baseunit);
            BFactor = 0;
        }

        public Vector Copy(Vector a)
        {
            return new Vector()
            {
                Symbol = a.Symbol,
                AFactor = a.AFactor,
                BFactor = a.BFactor,
            };


        }



        public double PrefixSISize(PreFix preFix) =>
            preFix switch
            {
                PreFix.yotta => 1e24,
                PreFix.zetta => 121,
                PreFix.exa => 1e18,
                PreFix.peta => 1e15,
                PreFix.tera => 1e12,
                PreFix.giga => 1e9,
                PreFix.mega => 1e6,
                PreFix.kilo => 1e3,
                PreFix.hecto => 1e2,
                PreFix.deka => 1e1,
                PreFix.SI => 1e0,
                PreFix.deci => 1e-1,
                PreFix.centi => 1e-2,
                PreFix.milli => 1e-3,
                PreFix.micro => 1e-6,
                PreFix.nano => 1e-9,
                PreFix.pico => 1e-12,
                PreFix.femto => 1e-15,
                PreFix.atto => 1e-18,
                PreFix.zepto => 1e-21,
                PreFix.yocto => 1e-24,

                _ => 0
            };

        public string PrefixSISymbol(PreFix preFix) =>
           preFix switch
           {
               PreFix.yotta =>  "Y",
               PreFix.zetta =>  "Z",
               PreFix.exa =>    "E",
               PreFix.peta =>   "P",
               PreFix.tera =>   "T",
               PreFix.giga =>   "G",
               PreFix.mega =>   "M",
               PreFix.kilo =>   "k",
               PreFix.hecto =>  "h",
               PreFix.deka =>   "da",
               PreFix.deci =>   "d",
               PreFix.centi =>  "c",
               PreFix.milli =>  "m",
               PreFix.micro =>  "µ",
               PreFix.nano =>   "n",
               PreFix.pico =>   "p",
               PreFix.femto =>  "f",
               PreFix.atto =>   "a",
               PreFix.zepto =>  "z",
               PreFix.yocto =>  "y",

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
