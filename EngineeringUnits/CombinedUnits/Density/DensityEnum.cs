using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class DensityUnit : Enumeration
    {

        public static readonly DensityUnit SI =                          new(MassUnit.SI,        VolumeUnit.SI);
        public static readonly DensityUnit CentigramPerDeciliter =       new(MassUnit.Centigram, VolumeUnit.Deciliter);
        public static readonly DensityUnit CentigramPerLiter =           new(MassUnit.Centigram, VolumeUnit.Liter);
        public static readonly DensityUnit CentigramPerMilliliter =      new(MassUnit.Centigram, VolumeUnit.Milliliter);
        public static readonly DensityUnit DecigramPerDeciliter =        new(MassUnit.Decigram,  VolumeUnit.Deciliter);
        public static readonly DensityUnit DecigramPerLiter =            new(MassUnit.Decigram,  VolumeUnit.Liter);
        public static readonly DensityUnit DecigramPerMilliliter =       new(MassUnit.Decigram,  VolumeUnit.Milliliter);
        public static readonly DensityUnit DecigramPerMicroliter =       new(MassUnit.Decigram,  VolumeUnit.Microliter);
        public static readonly DensityUnit GramPerCubicCentimeter =      new(MassUnit.Gram,      VolumeUnit.CubicCentimeter);
        public static readonly DensityUnit GramPerCubicMeter =           new(MassUnit.Gram,      VolumeUnit.CubicMeter);
        public static readonly DensityUnit GramPerCubicMillimeter =      new(MassUnit.Gram,      VolumeUnit.CubicMillimeter);
        public static readonly DensityUnit GramPerDeciliter =            new(MassUnit.Gram,      VolumeUnit.Deciliter);
        public static readonly DensityUnit GramPerLiter =                new(MassUnit.Gram,      VolumeUnit.Liter);
        public static readonly DensityUnit GramPerMilliliter =           new(MassUnit.Gram,      VolumeUnit.Milliliter);
        public static readonly DensityUnit GramPerMicroliter =           new(MassUnit.Gram,      VolumeUnit.Microliter);
        public static readonly DensityUnit KilogramPerCubicCentimeter =  new(MassUnit.Kilogram,  VolumeUnit.CubicCentimeter);
        public static readonly DensityUnit KilogramPerCubicMeter =       new(MassUnit.Kilogram,  VolumeUnit.CubicMeter);
        public static readonly DensityUnit KilogramPerCubicMillimeter =  new(MassUnit.Kilogram,  VolumeUnit.CubicMillimeter);
        public static readonly DensityUnit KilogramPerLiter =            new(MassUnit.Kilogram,  VolumeUnit.Liter);
        public static readonly DensityUnit KilopoundPerCubicFoot =       new(MassUnit.Kilopound, VolumeUnit.CubicFoot);
        public static readonly DensityUnit KilopoundPerCubicInch =       new(MassUnit.Kilopound, VolumeUnit.CubicInch);
        public static readonly DensityUnit MicrogramPerCubicMeter =      new(MassUnit.Microgram, VolumeUnit.CubicMeter);
        public static readonly DensityUnit MicrogramPerDeciliter =       new(MassUnit.Microgram, VolumeUnit.Deciliter);
        public static readonly DensityUnit MicrogramPerLiter =           new(MassUnit.Microgram, VolumeUnit.Liter);
        public static readonly DensityUnit MicrogramPerMilliliter =      new(MassUnit.Microgram, VolumeUnit.Milliliter);
        public static readonly DensityUnit MicrogramPerMicroliter =      new(MassUnit.Microgram, VolumeUnit.Microliter);
        public static readonly DensityUnit MilligramPerCubicMeter =      new(MassUnit.Milligram, VolumeUnit.CubicMeter);
        public static readonly DensityUnit MilligramPerDeciliter =       new(MassUnit.Milligram, VolumeUnit.Deciliter);
        public static readonly DensityUnit MilligramPerLiter =           new(MassUnit.Milligram, VolumeUnit.Liter);
        public static readonly DensityUnit MilligramPerMilliliter =      new(MassUnit.Milligram, VolumeUnit.Milliliter);
        public static readonly DensityUnit MilligramPerMicroliter =      new(MassUnit.Milligram, VolumeUnit.Microliter);
        public static readonly DensityUnit NanogramPerDeciliter =        new(MassUnit.Nanogram,  VolumeUnit.Deciliter);
        public static readonly DensityUnit NanogramPerLiter =            new(MassUnit.Nanogram,  VolumeUnit.Liter);
        public static readonly DensityUnit NanogramPerMilliliter =       new(MassUnit.Nanogram,  VolumeUnit.Milliliter);
        public static readonly DensityUnit NanogramPerMicroliter =       new(MassUnit.Nanogram,  VolumeUnit.Microliter);
        public static readonly DensityUnit PicogramPerDeciliter =        new(MassUnit.Picogram,  VolumeUnit.Deciliter);
        public static readonly DensityUnit PicogramPerLiter =            new(MassUnit.Picogram,  VolumeUnit.Liter);
        public static readonly DensityUnit PicogramPerMilliliter =       new(MassUnit.Picogram,  VolumeUnit.Milliliter);
        public static readonly DensityUnit PicogramPerMicroliter =       new(MassUnit.Picogram,  VolumeUnit.Microliter);
        public static readonly DensityUnit PoundPerCubicFoot =           new(MassUnit.Pound,     VolumeUnit.CubicFoot);
        public static readonly DensityUnit PoundPerCubicInch =           new(MassUnit.Pound,     VolumeUnit.CubicInch);
        public static readonly DensityUnit PoundPerImperialGallon =      new(MassUnit.Pound,     VolumeUnit.ImperialGallon,  "ppg (imp.)");
        public static readonly DensityUnit PoundPerUSGallon =            new(MassUnit.Pound,     VolumeUnit.UsGallon,        "ppg (U.S.)");
        public static readonly DensityUnit SlugPerCubicFoot =            new(MassUnit.Slug,      VolumeUnit.CubicFoot);
        public static readonly DensityUnit TonnePerCubicCentimeter =     new(MassUnit.Tonne,     VolumeUnit.CubicCentimeter);
        public static readonly DensityUnit TonnePerCubicMeter =          new(MassUnit.Tonne,     VolumeUnit.CubicMeter);
        public static readonly DensityUnit TonnePerCubicMillimeter =     new(MassUnit.Tonne,     VolumeUnit.CubicMillimeter);





        public DensityUnit(MassUnit mass, VolumeUnit volume)
        {
            Unit = new UnitSystem(mass / volume, 
                               $"{mass}/{volume}");
        }


        public DensityUnit(MassUnit mass, VolumeUnit volume, string NewSymbol)
        {
            Unit = new UnitSystem(mass / volume, NewSymbol);
        }


      

    }




}