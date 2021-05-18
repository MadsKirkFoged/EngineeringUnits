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

        public double Factor { get; set; }
        public string Name { get; set; }


        public double ToSIFactor { get; set; }

        public double FixedFactor1 { get; set; }
        public double FixedFactor2 { get; set; }


        public Vector()
        {


        }

        public Vector(double factor, string name, double toSIFactor)
        {
            Factor = factor;
            Name = name;
            ToSIFactor = toSIFactor;
            FixedFactor1 = 0;
            FixedFactor2 = 0;
        }
        public Vector(double factor, string name, double toSIFactor, double fixedfactor)
        {
            Factor = factor;
            Name = name;
            ToSIFactor = toSIFactor;
            FixedFactor1 = fixedfactor;
            FixedFactor2 = 0;
        }

        public Vector(double factor, string name, double toSIFactor, double fixedfactor, double fixedfactor2)
        {
            Factor = factor;
            Name = name;
            ToSIFactor = toSIFactor;
            FixedFactor1 = fixedfactor;
            FixedFactor2 = fixedfactor2;
        }

        public Vector(PreFix SI, BaseUnits baseunit)
        {


            Factor = PrefixSISize(SI);
            Name = PrefixSISymbol(SI) + BaseUnitSISymbol(baseunit);
            ToSIFactor = 1;
            FixedFactor1 = 0;


        }

        public Vector Copy(Vector a)
        {
            return new Vector()
            {
                Factor = a.Factor,
                Name = a.Name,
                ToSIFactor = a.ToSIFactor,

            };


        }



        public double PrefixSISize(PreFix preFix) =>
            preFix switch
            {
                PreFix.yotta => 10e24,
                PreFix.zetta => 1021,
                PreFix.exa => 10e18,
                PreFix.peta => 10e15,
                PreFix.tera => 10e12,
                PreFix.giga => 10e9,
                PreFix.mega => 10e6,
                PreFix.kilo => 10e3,
                PreFix.hecto => 10e2,
                PreFix.deka => 10e1,
                PreFix.SI => 10e1,
                PreFix.deci => 10e-1,
                PreFix.centi => 10e-2,
                PreFix.milli => 10e-3,
                PreFix.micro => 10e-6,
                PreFix.nano => 10e-9,
                PreFix.pico => 10e-12,
                PreFix.femto => 10e-15,
                PreFix.atto => 10e-18,
                PreFix.zepto => 10e-21,
                PreFix.yocto => 10e-24,

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
