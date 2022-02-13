using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ForcePerLengthUnit : Enumeration
    {
        public static readonly ForcePerLengthUnit SI = new(ForceUnit.SI, LengthUnit.SI);
        public static readonly ForcePerLengthUnit NewtonPerMeter = new(ForceUnit.Newton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit NewtonPerCentimeter = new(ForceUnit.Newton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit NewtonPerMillimeter = new(ForceUnit.Newton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit KilogramForcePerCentimeter = new(ForceUnit.KilogramForce, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit KilogramForcePerMeter = new(ForceUnit.KilogramForce, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit KilogramForcePerMillimeter = new(ForceUnit.KilogramForce, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit KilonewtonPerCentimeter = new(ForceUnit.Kilonewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit KilonewtonPerMeter = new(ForceUnit.Kilonewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit KilonewtonPerMillimeter = new(ForceUnit.Kilonewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit KilopoundForcePerFoot = new(ForceUnit.KilopoundForce, LengthUnit.Foot);
        public static readonly ForcePerLengthUnit KilopoundForcePerInch = new(ForceUnit.KilopoundForce, LengthUnit.Inch);
        public static readonly ForcePerLengthUnit MeganewtonPerCentimeter = new(ForceUnit.Meganewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit MeganewtonPerMeter = new(ForceUnit.Meganewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit MeganewtonPerMillimeter = new(ForceUnit.Meganewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit MicronewtonPerCentimeter = new(ForceUnit.Micronewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit MicronewtonPerMeter = new(ForceUnit.Micronewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit MicronewtonPerMillimeter = new(ForceUnit.Micronewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit MillinewtonPerCentimeter = new(ForceUnit.Millinewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit MillinewtonPerMeter = new(ForceUnit.Millinewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit MillinewtonPerMillimeter = new(ForceUnit.Millinewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit PoundForcePerFoot = new(ForceUnit.PoundForce, LengthUnit.Foot);
        public static readonly ForcePerLengthUnit PoundForcePerInch = new(ForceUnit.PoundForce, LengthUnit.Inch);
        public static readonly ForcePerLengthUnit PoundForcePerYard = new(ForceUnit.PoundForce, LengthUnit.Yard);
        public static readonly ForcePerLengthUnit TonneForcePerCentimeter = new(ForceUnit.TonneForce, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit TonneForcePerMeter = new(ForceUnit.TonneForce, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit TonneForcePerMillimeter = new(ForceUnit.TonneForce, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit NanonewtonPerCentimeter = new(PreFix.nano, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit NanonewtonPerMeter = new(PreFix.nano, NewtonPerMeter);
        public static readonly ForcePerLengthUnit NanonewtonPerMillimeter = new(PreFix.nano, NewtonPerMillimeter);
        public static readonly ForcePerLengthUnit CentinewtonPerCentimeter = new(PreFix.centi, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit CentinewtonPerMeter = new(PreFix.centi, NewtonPerMeter);
        public static readonly ForcePerLengthUnit CentinewtonPerMillimeter = new(PreFix.centi, NewtonPerMillimeter);
        public static readonly ForcePerLengthUnit DecanewtonPerCentimeter = new(PreFix.deka, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit DecanewtonPerMeter = new(PreFix.deka, NewtonPerMeter);
        public static readonly ForcePerLengthUnit DecanewtonPerMillimeter = new(PreFix.deka, NewtonPerMillimeter);
        public static readonly ForcePerLengthUnit DecinewtonPerCentimeter = new(PreFix.deci, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit DecinewtonPerMeter = new(PreFix.deci, NewtonPerMeter);
        public static readonly ForcePerLengthUnit DecinewtonPerMillimeter = new(PreFix.deci, NewtonPerMillimeter);




        public ForcePerLengthUnit(ForceUnit force, LengthUnit length)
        {
            Unit = new UnitSystem(force / length, 
                               $"{force}/{length}");
        }
        public ForcePerLengthUnit(PreFix SI, ForcePerLengthUnit unit) : base(SI, unit) {}

      

    }




}