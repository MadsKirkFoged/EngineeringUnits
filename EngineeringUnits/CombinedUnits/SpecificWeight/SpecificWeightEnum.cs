using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record SpecificWeightUnit : UnitTypebase
    {

        public static readonly SpecificWeightUnit SI = new(ForceUnit.SI, VolumeUnit.SI);
        public static readonly SpecificWeightUnit NewtonPerCubicMeter =             new(ForceUnit.Newton,            VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit KilogramForcePerCubicCentimeter = new(ForceUnit.KilogramForce,     VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit KilogramForcePerCubicMeter =      new(ForceUnit.KilogramForce,     VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit KilogramForcePerCubicMillimeter = new(ForceUnit.KilogramForce,     VolumeUnit.CubicMillimeter);
        public static readonly SpecificWeightUnit KilonewtonPerCubicCentimeter =    new(ForceUnit.Kilonewton,        VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit KilonewtonPerCubicMeter =         new(ForceUnit.Kilonewton,        VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit KilonewtonPerCubicMillimeter =    new(ForceUnit.Kilonewton,        VolumeUnit.CubicMillimeter);
        public static readonly SpecificWeightUnit KilopoundForcePerCubicFoot =      new(ForceUnit.KilopoundForce,    VolumeUnit.CubicFoot);
        public static readonly SpecificWeightUnit KilopoundForcePerCubicInch =      new(ForceUnit.KilopoundForce,    VolumeUnit.CubicInch);
        public static readonly SpecificWeightUnit MeganewtonPerCubicMeter =         new(ForceUnit.Meganewton,        VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit NewtonPerCubicCentimeter =        new(ForceUnit.Newton,            VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit NewtonPerCubicMillimeter =        new(ForceUnit.Newton,            VolumeUnit.CubicMillimeter);
        public static readonly SpecificWeightUnit PoundForcePerCubicFoot =          new(ForceUnit.PoundForce,        VolumeUnit.CubicFoot);
        public static readonly SpecificWeightUnit PoundForcePerCubicInch =          new(ForceUnit.PoundForce,        VolumeUnit.CubicInch);
        public static readonly SpecificWeightUnit TonneForcePerCubicCentimeter =    new(ForceUnit.TonneForce,        VolumeUnit.CubicCentimeter);
        public static readonly SpecificWeightUnit TonneForcePerCubicMeter =         new(ForceUnit.TonneForce,        VolumeUnit.CubicMeter);
        public static readonly SpecificWeightUnit TonneForcePerCubicMillimeter =    new(ForceUnit.TonneForce,        VolumeUnit.CubicMillimeter);




        public SpecificWeightUnit(ForceUnit force, VolumeUnit volume)
        {
            Unit = new UnitSystem(force / volume, 
                               $"{force}/{volume}");

        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}