using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ForcePerLengthUnit : Enumeration
    {
        public static readonly ForcePerLengthUnit SI = new ForcePerLengthUnit(ForceUnit.SI, LengthUnit.SI);
        public static readonly ForcePerLengthUnit NewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Newton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit NewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Newton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit NewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Newton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit KilogramForcePerCentimeter = new ForcePerLengthUnit(ForceUnit.KilogramForce, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit KilogramForcePerMeter = new ForcePerLengthUnit(ForceUnit.KilogramForce, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit KilogramForcePerMillimeter = new ForcePerLengthUnit(ForceUnit.KilogramForce, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit KilonewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Kilonewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit KilonewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Kilonewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit KilonewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Kilonewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit KilopoundForcePerFoot = new ForcePerLengthUnit(ForceUnit.KilopoundForce, LengthUnit.Foot);
        public static readonly ForcePerLengthUnit KilopoundForcePerInch = new ForcePerLengthUnit(ForceUnit.KilopoundForce, LengthUnit.Inch);
        public static readonly ForcePerLengthUnit MeganewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Meganewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit MeganewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Meganewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit MeganewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Meganewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit MicronewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Micronewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit MicronewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Micronewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit MicronewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Micronewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit MillinewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Millinewton, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit MillinewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Millinewton, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit MillinewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Millinewton, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit PoundForcePerFoot = new ForcePerLengthUnit(ForceUnit.PoundForce, LengthUnit.Foot);
        public static readonly ForcePerLengthUnit PoundForcePerInch = new ForcePerLengthUnit(ForceUnit.PoundForce, LengthUnit.Inch);
        public static readonly ForcePerLengthUnit PoundForcePerYard = new ForcePerLengthUnit(ForceUnit.PoundForce, LengthUnit.Yard);
        public static readonly ForcePerLengthUnit TonneForcePerCentimeter = new ForcePerLengthUnit(ForceUnit.TonneForce, LengthUnit.Centimeter);
        public static readonly ForcePerLengthUnit TonneForcePerMeter = new ForcePerLengthUnit(ForceUnit.TonneForce, LengthUnit.Meter);
        public static readonly ForcePerLengthUnit TonneForcePerMillimeter = new ForcePerLengthUnit(ForceUnit.TonneForce, LengthUnit.Millimeter);
        public static readonly ForcePerLengthUnit NanonewtonPerCentimeter = new ForcePerLengthUnit(PreFix.nano, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit NanonewtonPerMeter = new ForcePerLengthUnit(PreFix.nano, NewtonPerMeter);
        public static readonly ForcePerLengthUnit NanonewtonPerMillimeter = new ForcePerLengthUnit(PreFix.nano, NewtonPerMillimeter);
        public static readonly ForcePerLengthUnit CentinewtonPerCentimeter = new ForcePerLengthUnit(PreFix.centi, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit CentinewtonPerMeter = new ForcePerLengthUnit(PreFix.centi, NewtonPerMeter);
        public static readonly ForcePerLengthUnit CentinewtonPerMillimeter = new ForcePerLengthUnit(PreFix.centi, NewtonPerMillimeter);
        public static readonly ForcePerLengthUnit DecanewtonPerCentimeter = new ForcePerLengthUnit(PreFix.deka, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit DecanewtonPerMeter = new ForcePerLengthUnit(PreFix.deka, NewtonPerMeter);
        public static readonly ForcePerLengthUnit DecanewtonPerMillimeter = new ForcePerLengthUnit(PreFix.deka, NewtonPerMillimeter);
        public static readonly ForcePerLengthUnit DecinewtonPerCentimeter = new ForcePerLengthUnit(PreFix.deci, NewtonPerCentimeter);
        public static readonly ForcePerLengthUnit DecinewtonPerMeter = new ForcePerLengthUnit(PreFix.deci, NewtonPerMeter);
        public static readonly ForcePerLengthUnit DecinewtonPerMillimeter = new ForcePerLengthUnit(PreFix.deci, NewtonPerMillimeter);




        public ForcePerLengthUnit(ForceUnit force, LengthUnit length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ForcePerLength";
            Unit = force / length;

            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}/{length}");

        }

        public ForcePerLengthUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ForcePerLength";
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ForcePerLengthUnit(PreFix SI, ForcePerLengthUnit unit)
        {
            //Name = "ForcePerLength";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ForcePerLengthUnit(ForcePerLengthUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ForcePerLength";
            Unit = unit.Unit.Copy();

            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}