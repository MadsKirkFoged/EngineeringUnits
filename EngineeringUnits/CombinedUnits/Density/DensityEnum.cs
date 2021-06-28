using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class DensityUnit : Enumeration
    {

        public static DensityUnit SI = new DensityUnit(MassUnit.Kilogram, VolumeUnit.CubicMeter);

        public static DensityUnit CentigramPerDeciliter =       new DensityUnit(MassUnit.Centigram, VolumeUnit.Deciliter);
        public static DensityUnit CentigramPerLiter =           new DensityUnit(MassUnit.Centigram, VolumeUnit.Liter);
        public static DensityUnit CentigramPerMilliliter =      new DensityUnit(MassUnit.Centigram, VolumeUnit.Milliliter);
        public static DensityUnit DecigramPerDeciliter =        new DensityUnit(MassUnit.Decigram,  VolumeUnit.Deciliter);
        public static DensityUnit DecigramPerLiter =            new DensityUnit(MassUnit.Decigram,  VolumeUnit.Liter);
        public static DensityUnit DecigramPerMilliliter =       new DensityUnit(MassUnit.Decigram,  VolumeUnit.Milliliter);
        public static DensityUnit GramPerCubicCentimeter =      new DensityUnit(MassUnit.Gram,      VolumeUnit.CubicCentimeter);
        public static DensityUnit GramPerCubicMeter =           new DensityUnit(MassUnit.Gram,      VolumeUnit.CubicMeter);
        public static DensityUnit GramPerCubicMillimeter =      new DensityUnit(MassUnit.Gram,      VolumeUnit.CubicMillimeter);
        public static DensityUnit GramPerDeciliter =            new DensityUnit(MassUnit.Gram,      VolumeUnit.Deciliter);
        public static DensityUnit GramPerLiter =                new DensityUnit(MassUnit.Gram,      VolumeUnit.Liter);
        public static DensityUnit GramPerMilliliter =           new DensityUnit(MassUnit.Gram,      VolumeUnit.Milliliter);
        public static DensityUnit KilogramPerCubicCentimeter =  new DensityUnit(MassUnit.Kilogram,  VolumeUnit.CubicCentimeter);
        public static DensityUnit KilogramPerCubicMeter =       new DensityUnit(MassUnit.Kilogram,  VolumeUnit.CubicMeter);
        public static DensityUnit KilogramPerCubicMillimeter =  new DensityUnit(MassUnit.Kilogram,  VolumeUnit.CubicMillimeter);
        public static DensityUnit KilogramPerLiter =            new DensityUnit(MassUnit.Kilogram,  VolumeUnit.Liter);
        public static DensityUnit KilopoundPerCubicFoot =       new DensityUnit(MassUnit.Kilopound, VolumeUnit.CubicFoot);
        public static DensityUnit KilopoundPerCubicInch =       new DensityUnit(MassUnit.Kilopound, VolumeUnit.CubicInch);
        public static DensityUnit MicrogramPerCubicMeter =      new DensityUnit(MassUnit.Microgram, VolumeUnit.CubicMeter);
        public static DensityUnit MicrogramPerDeciliter =       new DensityUnit(MassUnit.Microgram, VolumeUnit.Deciliter);
        public static DensityUnit MicrogramPerLiter =           new DensityUnit(MassUnit.Microgram, VolumeUnit.Liter);
        public static DensityUnit MicrogramPerMilliliter =      new DensityUnit(MassUnit.Microgram, VolumeUnit.Milliliter);
        public static DensityUnit MilligramPerCubicMeter =      new DensityUnit(MassUnit.Milligram, VolumeUnit.CubicMeter);
        public static DensityUnit MilligramPerDeciliter =       new DensityUnit(MassUnit.Milligram, VolumeUnit.Deciliter);
        public static DensityUnit MilligramPerLiter =           new DensityUnit(MassUnit.Milligram, VolumeUnit.Liter);
        public static DensityUnit MilligramPerMilliliter =      new DensityUnit(MassUnit.Milligram, VolumeUnit.Milliliter);
        public static DensityUnit NanogramPerDeciliter =        new DensityUnit(MassUnit.Nanogram,  VolumeUnit.Deciliter);
        public static DensityUnit NanogramPerLiter =            new DensityUnit(MassUnit.Nanogram,  VolumeUnit.Liter);
        public static DensityUnit NanogramPerMilliliter =       new DensityUnit(MassUnit.Nanogram,  VolumeUnit.Milliliter);

        public static DensityUnit PicogramPerDeciliter =        new DensityUnit(MassUnit.Picogram,  VolumeUnit.Deciliter);
        public static DensityUnit PicogramPerLiter =            new DensityUnit(MassUnit.Picogram,  VolumeUnit.Liter);
        public static DensityUnit PicogramPerMilliliter =       new DensityUnit(MassUnit.Picogram,  VolumeUnit.Milliliter);

        public static DensityUnit PoundPerCubicFoot =           new DensityUnit(MassUnit.Pound,     VolumeUnit.CubicFoot);
        public static DensityUnit PoundPerCubicInch =           new DensityUnit(MassUnit.Pound,     VolumeUnit.CubicInch);
        public static DensityUnit PoundPerImperialGallon =      new DensityUnit(MassUnit.Pound,     VolumeUnit.ImperialGallon,  "ppg (imp.)");
        public static DensityUnit PoundPerUSGallon =            new DensityUnit(MassUnit.Pound,     VolumeUnit.UsGallon,        "ppg (U.S.)");
        public static DensityUnit SlugPerCubicFoot =            new DensityUnit(MassUnit.Slug,      VolumeUnit.CubicFoot);
        public static DensityUnit TonnePerCubicCentimeter =     new DensityUnit(MassUnit.Tonne,     VolumeUnit.CubicCentimeter);
        public static DensityUnit TonnePerCubicMeter =          new DensityUnit(MassUnit.Tonne,     VolumeUnit.CubicMeter);
        public static DensityUnit TonnePerCubicMillimeter =     new DensityUnit(MassUnit.Tonne,     VolumeUnit.CubicMillimeter);



        public DensityUnit(MassUnit mass, VolumeUnit volume, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass.Unit / volume.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{volume}");
        }


      

    }




}