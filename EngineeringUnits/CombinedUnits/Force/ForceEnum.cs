using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ForceUnit : Enumeration
    {
        public static readonly ForceUnit SI =            new ForceUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "N");
        public static readonly ForceUnit Newton =        new ForceUnit(MassUnit.SI, LengthUnit.SI , DurationUnit.SI , "N");
        public static readonly ForceUnit Micronewton =   new ForceUnit(PreFix.micro, Newton);
        public static readonly ForceUnit Millinewton =   new ForceUnit(PreFix.milli, Newton);
        public static readonly ForceUnit Decanewton =    new ForceUnit(PreFix.deka, Newton);
        public static readonly ForceUnit Kilonewton =    new ForceUnit(PreFix.kilo, Newton);
        public static readonly ForceUnit Meganewton =    new ForceUnit(PreFix.mega, Newton);
        public static readonly ForceUnit Dyn =               new ForceUnit(MassUnit.Gram, LengthUnit.Centimeter, DurationUnit.SI, "dyn");
        public static readonly ForceUnit TonneForce =        new ForceUnit(MassUnit.Tonne, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit ShortTonForce =     new ForceUnit(MassUnit.ShortTon, AccelerationUnit.StandardGravity , "tf (short)");
        public static readonly ForceUnit PoundForce =        new ForceUnit(MassUnit.Pound, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit KilogramForce =     new ForceUnit(MassUnit.Kilogram, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit OunceForce =        new ForceUnit(MassUnit.Ounce, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit KiloPond =          new ForceUnit(MassUnit.Kilogram, AccelerationUnit.StandardGravity, "kp");
        public static readonly ForceUnit KilopoundForce =    new ForceUnit(MassUnit.Kilopound, AccelerationUnit.StandardGravity, "kipf");
        public static readonly ForceUnit MegapoundForce =    new ForceUnit(MassUnit.Megapound, AccelerationUnit.StandardGravity, "Mlbf");
        public static readonly ForceUnit Poundal =           new ForceUnit(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "pdl", 0.138254954376m);

        public ForceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = (mass * Length) / (duration.Pow(2));
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ForceUnit(MassUnit mass, AccelerationUnit acceleration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass * acceleration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}f");         
        }

        public ForceUnit(PreFix SI, ForceUnit energyunit)
        {
            Unit = energyunit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }


    }




}