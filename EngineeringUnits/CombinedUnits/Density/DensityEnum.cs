using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class DensityUnit : Enumeration
    {

        public static readonly DensityUnit SI = new DensityUnit(MassUnit.Kilogram, VolumeUnit.CubicMeter);
        public static readonly DensityUnit CentigramPerDeciliter =       new DensityUnit(MassUnit.Centigram, VolumeUnit.Deciliter);
        public static readonly DensityUnit CentigramPerLiter =           new DensityUnit(MassUnit.Centigram, VolumeUnit.Liter);
        public static readonly DensityUnit CentigramPerMilliliter =      new DensityUnit(MassUnit.Centigram, VolumeUnit.Milliliter);
        public static readonly DensityUnit DecigramPerDeciliter =        new DensityUnit(MassUnit.Decigram,  VolumeUnit.Deciliter);
        public static readonly DensityUnit DecigramPerLiter =            new DensityUnit(MassUnit.Decigram,  VolumeUnit.Liter);
        public static readonly DensityUnit DecigramPerMilliliter =       new DensityUnit(MassUnit.Decigram,  VolumeUnit.Milliliter);
        public static readonly DensityUnit DecigramPerMicroliter =       new DensityUnit(MassUnit.Decigram,  VolumeUnit.Microliter);
        public static readonly DensityUnit GramPerCubicCentimeter =      new DensityUnit(MassUnit.Gram,      VolumeUnit.CubicCentimeter);
        public static readonly DensityUnit GramPerCubicMeter =           new DensityUnit(MassUnit.Gram,      VolumeUnit.CubicMeter);
        public static readonly DensityUnit GramPerCubicMillimeter =      new DensityUnit(MassUnit.Gram,      VolumeUnit.CubicMillimeter);
        public static readonly DensityUnit GramPerDeciliter =            new DensityUnit(MassUnit.Gram,      VolumeUnit.Deciliter);
        public static readonly DensityUnit GramPerLiter =                new DensityUnit(MassUnit.Gram,      VolumeUnit.Liter);
        public static readonly DensityUnit GramPerMilliliter =           new DensityUnit(MassUnit.Gram,      VolumeUnit.Milliliter);
        public static readonly DensityUnit GramPerMicroliter =           new DensityUnit(MassUnit.Gram,      VolumeUnit.Microliter);
        public static readonly DensityUnit KilogramPerCubicCentimeter =  new DensityUnit(MassUnit.Kilogram,  VolumeUnit.CubicCentimeter);
        public static readonly DensityUnit KilogramPerCubicMeter =       new DensityUnit(MassUnit.Kilogram,  VolumeUnit.CubicMeter);
        public static readonly DensityUnit KilogramPerCubicMillimeter =  new DensityUnit(MassUnit.Kilogram,  VolumeUnit.CubicMillimeter);
        public static readonly DensityUnit KilogramPerLiter =            new DensityUnit(MassUnit.Kilogram,  VolumeUnit.Liter);
        public static readonly DensityUnit KilopoundPerCubicFoot =       new DensityUnit(MassUnit.Kilopound, VolumeUnit.CubicFoot);
        public static readonly DensityUnit KilopoundPerCubicInch =       new DensityUnit(MassUnit.Kilopound, VolumeUnit.CubicInch);
        public static readonly DensityUnit MicrogramPerCubicMeter =      new DensityUnit(MassUnit.Microgram, VolumeUnit.CubicMeter);
        public static readonly DensityUnit MicrogramPerDeciliter =       new DensityUnit(MassUnit.Microgram, VolumeUnit.Deciliter);
        public static readonly DensityUnit MicrogramPerLiter =           new DensityUnit(MassUnit.Microgram, VolumeUnit.Liter);
        public static readonly DensityUnit MicrogramPerMilliliter =      new DensityUnit(MassUnit.Microgram, VolumeUnit.Milliliter);
        public static readonly DensityUnit MicrogramPerMicroliter =      new DensityUnit(MassUnit.Microgram, VolumeUnit.Microliter);
        public static readonly DensityUnit MilligramPerCubicMeter =      new DensityUnit(MassUnit.Milligram, VolumeUnit.CubicMeter);
        public static readonly DensityUnit MilligramPerDeciliter =       new DensityUnit(MassUnit.Milligram, VolumeUnit.Deciliter);
        public static readonly DensityUnit MilligramPerLiter =           new DensityUnit(MassUnit.Milligram, VolumeUnit.Liter);
        public static readonly DensityUnit MilligramPerMilliliter =      new DensityUnit(MassUnit.Milligram, VolumeUnit.Milliliter);
        public static readonly DensityUnit MilligramPerMicroliter =      new DensityUnit(MassUnit.Milligram, VolumeUnit.Microliter);
        public static readonly DensityUnit NanogramPerDeciliter =        new DensityUnit(MassUnit.Nanogram,  VolumeUnit.Deciliter);
        public static readonly DensityUnit NanogramPerLiter =            new DensityUnit(MassUnit.Nanogram,  VolumeUnit.Liter);
        public static readonly DensityUnit NanogramPerMilliliter =       new DensityUnit(MassUnit.Nanogram,  VolumeUnit.Milliliter);
        public static readonly DensityUnit NanogramPerMicroliter =       new DensityUnit(MassUnit.Nanogram,  VolumeUnit.Microliter);
        public static readonly DensityUnit PicogramPerDeciliter =        new DensityUnit(MassUnit.Picogram,  VolumeUnit.Deciliter);
        public static readonly DensityUnit PicogramPerLiter =            new DensityUnit(MassUnit.Picogram,  VolumeUnit.Liter);
        public static readonly DensityUnit PicogramPerMilliliter =       new DensityUnit(MassUnit.Picogram,  VolumeUnit.Milliliter);
        public static readonly DensityUnit PicogramPerMicroliter =       new DensityUnit(MassUnit.Picogram,  VolumeUnit.Microliter);
        public static readonly DensityUnit PoundPerCubicFoot =           new DensityUnit(MassUnit.Pound,     VolumeUnit.CubicFoot);
        public static readonly DensityUnit PoundPerCubicInch =           new DensityUnit(MassUnit.Pound,     VolumeUnit.CubicInch);
        public static readonly DensityUnit PoundPerImperialGallon =      new DensityUnit(MassUnit.Pound,     VolumeUnit.ImperialGallon,  "ppg (imp.)");
        public static readonly DensityUnit PoundPerUSGallon =            new DensityUnit(MassUnit.Pound,     VolumeUnit.UsGallon,        "ppg (U.S.)");
        public static readonly DensityUnit SlugPerCubicFoot =            new DensityUnit(MassUnit.Slug,      VolumeUnit.CubicFoot);
        public static readonly DensityUnit TonnePerCubicCentimeter =     new DensityUnit(MassUnit.Tonne,     VolumeUnit.CubicCentimeter);
        public static readonly DensityUnit TonnePerCubicMeter =          new DensityUnit(MassUnit.Tonne,     VolumeUnit.CubicMeter);
        public static readonly DensityUnit TonnePerCubicMillimeter =     new DensityUnit(MassUnit.Tonne,     VolumeUnit.CubicMillimeter);








        public DensityUnit(MassUnit mass, VolumeUnit volume, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / volume;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{volume}");
        }


      

    }




}