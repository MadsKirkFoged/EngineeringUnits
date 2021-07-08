using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class RatioUnit : Enumeration
    {

        public static readonly RatioUnit SI = new RatioUnit();
        public static readonly RatioUnit DecimalFraction = new RatioUnit();
        public static readonly RatioUnit PartPerBillion = new RatioUnit("ppb", 1/1e9m);
        public static readonly RatioUnit PartPerMillion = new RatioUnit("ppm", 1 / 1e6m);
        public static readonly RatioUnit PartPerThousand = new RatioUnit("‰", 1 / 1e3m);
        public static readonly RatioUnit PartPerTrillion = new RatioUnit("ppt", 1 / 1e12m);
        public static readonly RatioUnit Percent = new RatioUnit("%", 1 / 1e2m);

        public static readonly RatioUnit CentigramPerGram =     new RatioUnit(MassUnit.Centigram, MassUnit.Gram);
        public static readonly RatioUnit CentigramPerKilogram = new RatioUnit(MassUnit.Centigram, MassUnit.Kilogram);
        public static readonly RatioUnit DecagramPerGram =      new RatioUnit(MassUnit.Decagram, MassUnit.Gram);
        public static readonly RatioUnit DecagramPerKilogram =  new RatioUnit(MassUnit.Decagram, MassUnit.Kilogram);
        public static readonly RatioUnit DecigramPerGram =      new RatioUnit(MassUnit.Decigram, MassUnit.Gram);
        public static readonly RatioUnit DecigramPerKilogram =  new RatioUnit(MassUnit.Decigram, MassUnit.Kilogram);

        public static readonly RatioUnit GramPerGram =          new RatioUnit(MassUnit.Gram, MassUnit.Gram);
        public static readonly RatioUnit GramPerKilogram =      new RatioUnit(MassUnit.Gram, MassUnit.Kilogram);
        public static readonly RatioUnit HectogramPerGram =     new RatioUnit(MassUnit.Hectogram, MassUnit.Gram);
        public static readonly RatioUnit HectogramPerKilogram = new RatioUnit(MassUnit.Hectogram, MassUnit.Kilogram);
        public static readonly RatioUnit KilogramPerGram =      new RatioUnit(MassUnit.Kilogram, MassUnit.Gram);
        public static readonly RatioUnit KilogramPerKilogram =  new RatioUnit(MassUnit.Kilogram, MassUnit.Kilogram);
        public static readonly RatioUnit MicrogramPerGram =     new RatioUnit(MassUnit.Microgram, MassUnit.Gram);
        public static readonly RatioUnit MicrogramPerKilogram = new RatioUnit(MassUnit.Microgram, MassUnit.Kilogram);
        public static readonly RatioUnit MilligramPerGram =     new RatioUnit(MassUnit.Milligram, MassUnit.Gram);
        public static readonly RatioUnit MilligramPerKilogram = new RatioUnit(MassUnit.Milligram, MassUnit.Kilogram);
        public static readonly RatioUnit NanogramPerGram =      new RatioUnit(MassUnit.Nanogram, MassUnit.Gram);
        public static readonly RatioUnit NanogramPerKilogram =  new RatioUnit(MassUnit.Nanogram, MassUnit.Kilogram);


        public static readonly RatioUnit CentilitersPerLiter =      new RatioUnit(VolumeUnit.Centiliter, VolumeUnit.Liter);
        public static readonly RatioUnit CentilitersPerMililiter =  new RatioUnit(VolumeUnit.Centiliter, VolumeUnit.Milliliter);
        public static readonly RatioUnit DecilitersPerLiter =       new RatioUnit(VolumeUnit.Deciliter, VolumeUnit.Liter);
        public static readonly RatioUnit DecilitersPerMililiter =   new RatioUnit(VolumeUnit.Deciliter, VolumeUnit.Milliliter);
        public static readonly RatioUnit LitersPerLiter =           new RatioUnit(VolumeUnit.Liter, VolumeUnit.Liter);
        public static readonly RatioUnit LitersPerMililiter =       new RatioUnit(VolumeUnit.Liter, VolumeUnit.Milliliter);
        public static readonly RatioUnit MicrolitersPerLiter =      new RatioUnit(VolumeUnit.Microliter, VolumeUnit.Liter);
        public static readonly RatioUnit MicrolitersPerMililiter =  new RatioUnit(VolumeUnit.Microliter, VolumeUnit.Milliliter);
        public static readonly RatioUnit MillilitersPerLiter =      new RatioUnit(VolumeUnit.Milliliter, VolumeUnit.Liter);
        public static readonly RatioUnit MillilitersPerMililiter =  new RatioUnit(VolumeUnit.Milliliter, VolumeUnit.Milliliter);
        public static readonly RatioUnit NanolitersPerLiter =       new RatioUnit(VolumeUnit.Nanoliter, VolumeUnit.Liter);
        public static readonly RatioUnit NanolitersPerMililiter =   new RatioUnit(VolumeUnit.Nanoliter, VolumeUnit.Milliliter);
        public static readonly RatioUnit PicolitersPerLiter =       new RatioUnit(VolumeUnit.Picoliter, VolumeUnit.Liter);
        public static readonly RatioUnit PicolitersPerMililiter =   new RatioUnit(VolumeUnit.Picoliter, VolumeUnit.Milliliter);




        public RatioUnit(string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = new UnitSystem();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RatioUnit(MassUnit mass1, MassUnit mass2, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass1.Unit / mass2.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass1}/{mass2}");
        }

        public RatioUnit(VolumeUnit vol1, VolumeUnit vol2, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = vol1.Unit / vol2.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{vol1}/{vol2}");
        }

       

    }




}