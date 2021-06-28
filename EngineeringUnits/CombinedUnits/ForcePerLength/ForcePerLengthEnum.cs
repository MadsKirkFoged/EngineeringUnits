using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ForcePerLengthUnit : Enumeration
    {
        public static ForcePerLengthUnit SI = new ForcePerLengthUnit(ForceUnit.Newton, LengthUnit.Meter);

        public static ForcePerLengthUnit NewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Newton, LengthUnit.Meter);
        public static ForcePerLengthUnit NewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Newton, LengthUnit.Centimeter);
        public static ForcePerLengthUnit NewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Newton, LengthUnit.Millimeter);

        public static ForcePerLengthUnit KilogramForcePerCentimeter = new ForcePerLengthUnit(ForceUnit.KilogramForce, LengthUnit.Centimeter);
        public static ForcePerLengthUnit KilogramForcePerMeter = new ForcePerLengthUnit(ForceUnit.KilogramForce, LengthUnit.Meter);
        public static ForcePerLengthUnit KilogramForcePerMillimeter = new ForcePerLengthUnit(ForceUnit.KilogramForce, LengthUnit.Millimeter);

        public static ForcePerLengthUnit KilonewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Kilonewton, LengthUnit.Centimeter);
        public static ForcePerLengthUnit KilonewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Kilonewton, LengthUnit.Meter);
        public static ForcePerLengthUnit KilonewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Kilonewton, LengthUnit.Millimeter);

        public static ForcePerLengthUnit KilopoundForcePerFoot = new ForcePerLengthUnit(ForceUnit.KilopoundForce, LengthUnit.Foot);
        public static ForcePerLengthUnit KilopoundForcePerInch = new ForcePerLengthUnit(ForceUnit.KilopoundForce, LengthUnit.Inch);

        public static ForcePerLengthUnit MeganewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Meganewton, LengthUnit.Centimeter);
        public static ForcePerLengthUnit MeganewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Meganewton, LengthUnit.Meter);
        public static ForcePerLengthUnit MeganewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Meganewton, LengthUnit.Millimeter);

        public static ForcePerLengthUnit MicronewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Micronewton, LengthUnit.Centimeter);
        public static ForcePerLengthUnit MicronewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Micronewton, LengthUnit.Meter);
        public static ForcePerLengthUnit MicronewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Micronewton, LengthUnit.Millimeter);

        public static ForcePerLengthUnit MillinewtonPerCentimeter = new ForcePerLengthUnit(ForceUnit.Millinewton, LengthUnit.Centimeter);
        public static ForcePerLengthUnit MillinewtonPerMeter = new ForcePerLengthUnit(ForceUnit.Millinewton, LengthUnit.Meter);
        public static ForcePerLengthUnit MillinewtonPerMillimeter = new ForcePerLengthUnit(ForceUnit.Millinewton, LengthUnit.Millimeter);


        public static ForcePerLengthUnit PoundForcePerFoot = new ForcePerLengthUnit(ForceUnit.PoundForce, LengthUnit.Foot);
        public static ForcePerLengthUnit PoundForcePerInch = new ForcePerLengthUnit(ForceUnit.PoundForce, LengthUnit.Inch);
        public static ForcePerLengthUnit PoundForcePerYard = new ForcePerLengthUnit(ForceUnit.PoundForce, LengthUnit.Yard);
        public static ForcePerLengthUnit TonneForcePerCentimeter = new ForcePerLengthUnit(ForceUnit.TonneForce, LengthUnit.Centimeter);
        public static ForcePerLengthUnit TonneForcePerMeter = new ForcePerLengthUnit(ForceUnit.TonneForce, LengthUnit.Meter);
        public static ForcePerLengthUnit TonneForcePerMillimeter = new ForcePerLengthUnit(ForceUnit.TonneForce, LengthUnit.Millimeter);



        public static ForcePerLengthUnit NanonewtonPerCentimeter = new ForcePerLengthUnit(PreFix.nano, NewtonPerCentimeter);
        public static ForcePerLengthUnit NanonewtonPerMeter = new ForcePerLengthUnit(PreFix.nano, NewtonPerMeter);
        public static ForcePerLengthUnit NanonewtonPerMillimeter = new ForcePerLengthUnit(PreFix.nano, NewtonPerMillimeter);



        public static ForcePerLengthUnit CentinewtonPerCentimeter = new ForcePerLengthUnit(PreFix.centi, NewtonPerCentimeter);
        public static ForcePerLengthUnit CentinewtonPerMeter = new ForcePerLengthUnit(PreFix.centi, NewtonPerMeter);
        public static ForcePerLengthUnit CentinewtonPerMillimeter = new ForcePerLengthUnit(PreFix.centi, NewtonPerMillimeter);

        public static ForcePerLengthUnit DecanewtonPerCentimeter = new ForcePerLengthUnit(PreFix.deka, NewtonPerCentimeter);
        public static ForcePerLengthUnit DecanewtonPerMeter = new ForcePerLengthUnit(PreFix.deka, NewtonPerMeter);
        public static ForcePerLengthUnit DecanewtonPerMillimeter = new ForcePerLengthUnit(PreFix.deka, NewtonPerMillimeter);

        public static ForcePerLengthUnit DecinewtonPerCentimeter = new ForcePerLengthUnit(PreFix.deci, NewtonPerCentimeter);
        public static ForcePerLengthUnit DecinewtonPerMeter = new ForcePerLengthUnit(PreFix.deci, NewtonPerMeter);
        public static ForcePerLengthUnit DecinewtonPerMillimeter = new ForcePerLengthUnit(PreFix.deci, NewtonPerMillimeter);




        public ForcePerLengthUnit(ForceUnit force, LengthUnit length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ForcePerLength";
            Unit = force.Unit / length.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}/{length}");

        }

        public ForcePerLengthUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "ForcePerLength";
            Unit = Area.Unit * Length.Unit;
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