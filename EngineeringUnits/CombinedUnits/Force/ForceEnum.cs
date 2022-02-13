using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ForceUnit : Enumeration
    {
        public static readonly ForceUnit SI =            new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "N");
        public static readonly ForceUnit Newton =        new(MassUnit.SI, LengthUnit.SI , DurationUnit.SI , "N");
        public static readonly ForceUnit Micronewton =   new(PreFix.micro, Newton);
        public static readonly ForceUnit Millinewton =   new(PreFix.milli, Newton);
        public static readonly ForceUnit Decanewton =    new(PreFix.deka, Newton);
        public static readonly ForceUnit Kilonewton =    new(PreFix.kilo, Newton);
        public static readonly ForceUnit Meganewton =    new(PreFix.mega, Newton);
        public static readonly ForceUnit Dyn =               new(MassUnit.Gram, LengthUnit.Centimeter, DurationUnit.SI, "dyn");
        public static readonly ForceUnit TonneForce =        new(MassUnit.Tonne, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit ShortTonForce =     new(MassUnit.ShortTon, AccelerationUnit.StandardGravity , "tf (short)");
        public static readonly ForceUnit PoundForce =        new(MassUnit.Pound, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit KilogramForce =     new(MassUnit.Kilogram, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit OunceForce =        new(MassUnit.Ounce, AccelerationUnit.StandardGravity);
        public static readonly ForceUnit KiloPond =          new(MassUnit.Kilogram, AccelerationUnit.StandardGravity, "kp");
        public static readonly ForceUnit KilopoundForce =    new(MassUnit.Kilopound, AccelerationUnit.StandardGravity, "kipf");
        public static readonly ForceUnit MegapoundForce =    new(MassUnit.Megapound, AccelerationUnit.StandardGravity, "Mlbf");
        public static readonly ForceUnit Poundal =           new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "pdl", 0.138254954376m);

        public ForceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol, decimal correction = 1)
        {
            Unit = new UnitSystem((mass * Length) / (duration.Pow(2)) * correction, NewSymbol);
        }

        public ForceUnit(MassUnit mass, AccelerationUnit acceleration, string NewSymbol)
        {
            Unit = new UnitSystem(mass * acceleration, NewSymbol);     
        }

        public ForceUnit(MassUnit mass, AccelerationUnit acceleration)
        {
            Unit = new UnitSystem(mass * acceleration, 
                               $"{mass}f");
        }

        public ForceUnit(PreFix SI, ForceUnit unit) : base(SI, unit) {}


    }




}