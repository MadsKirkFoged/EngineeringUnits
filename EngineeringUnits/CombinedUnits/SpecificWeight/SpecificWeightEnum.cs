using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class SpecificWeightUnit : Enumeration
    {

        public static readonly SpecificWeightUnit SI = new SpecificWeightUnit(ForceUnit.Newton, VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit NewtonPerCubicMeter =             new SpecificWeightUnit(ForceUnit.Newton,            VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit KilogramForcePerCubicCentimeter = new SpecificWeightUnit(ForceUnit.KilogramForce,     VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit KilogramForcePerCubicMeter =      new SpecificWeightUnit(ForceUnit.KilogramForce,     VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit KilogramForcePerCubicMillimeter = new SpecificWeightUnit(ForceUnit.KilogramForce,     VolumeUnit.CubicMillimeter);
        public static readonly SpecificWeightUnit KilonewtonPerCubicCentimeter =    new SpecificWeightUnit(ForceUnit.Kilonewton,        VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit KilonewtonPerCubicMeter =         new SpecificWeightUnit(ForceUnit.Kilonewton,        VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit KilonewtonPerCubicMillimeter =    new SpecificWeightUnit(ForceUnit.Kilonewton,        VolumeUnit.CubicMillimeter);
        public static readonly SpecificWeightUnit KilopoundForcePerCubicFoot =      new SpecificWeightUnit(ForceUnit.KilopoundForce,    VolumeUnit.CubicFoot);
        public static readonly SpecificWeightUnit KilopoundForcePerCubicInch =      new SpecificWeightUnit(ForceUnit.KilopoundForce,    VolumeUnit.CubicInch);
        public static readonly SpecificWeightUnit MeganewtonPerCubicMeter =         new SpecificWeightUnit(ForceUnit.Meganewton,        VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit NewtonPerCubicCentimeter =        new SpecificWeightUnit(ForceUnit.Newton,            VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit NewtonPerCubicMillimeter =        new SpecificWeightUnit(ForceUnit.Newton,            VolumeUnit.CubicMillimeter);
        public static readonly SpecificWeightUnit PoundForcePerCubicFoot =          new SpecificWeightUnit(ForceUnit.PoundForce,        VolumeUnit.CubicFoot);
        public static readonly SpecificWeightUnit PoundForcePerCubicInch =          new SpecificWeightUnit(ForceUnit.PoundForce,        VolumeUnit.CubicInch);
        public static readonly SpecificWeightUnit TonneForcePerCubicCentimeter =    new SpecificWeightUnit(ForceUnit.TonneForce,        VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit TonneForcePerCubicMeter =         new SpecificWeightUnit(ForceUnit.TonneForce,        VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit TonneForcePerCubicMillimeter =    new SpecificWeightUnit(ForceUnit.TonneForce,        VolumeUnit.CubicMillimeter);




        public SpecificWeightUnit(ForceUnit force, VolumeUnit volume, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = force / volume;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}/{volume}");
        }       

    }




}