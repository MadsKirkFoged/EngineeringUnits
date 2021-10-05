using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ForceChangeRateUnit : Enumeration
    {

        public static readonly ForceChangeRateUnit SI = new(ForceUnit.SI, DurationUnit.SI);
        public static readonly ForceChangeRateUnit NewtonPerSecond = new(ForceUnit.Newton, DurationUnit.Second);
        public static readonly ForceChangeRateUnit NewtonPerMinute = new(ForceUnit.Newton, DurationUnit.Minute);

        public static readonly ForceChangeRateUnit PoundForcePerSecond = new(ForceUnit.PoundForce, DurationUnit.Second);
        public static readonly ForceChangeRateUnit PoundForcePerMinute = new(ForceUnit.PoundForce, DurationUnit.Minute);

        public static readonly ForceChangeRateUnit KilopoundForcePerSecond = new(PreFix.kilo, PoundForcePerSecond);

        public static readonly ForceChangeRateUnit KilopoundForcePerMinute = new(PreFix.kilo, PoundForcePerMinute);

        public static readonly ForceChangeRateUnit NanonewtonPerSecond = new(PreFix.nano, NewtonPerSecond);
        public static readonly ForceChangeRateUnit MillinewtonPerSecond = new(PreFix.milli, NewtonPerSecond);
        public static readonly ForceChangeRateUnit MicronewtonPerSecond = new(PreFix.micro, NewtonPerSecond);
        public static readonly ForceChangeRateUnit CentinewtonPerSecond = new(PreFix.centi, NewtonPerSecond);
        public static readonly ForceChangeRateUnit DecanewtonPerSecond = new(PreFix.deka, NewtonPerSecond);
        public static readonly ForceChangeRateUnit DecinewtonPerSecond = new(PreFix.deci, NewtonPerSecond);
        public static readonly ForceChangeRateUnit KilonewtonPerSecond = new(PreFix.kilo, NewtonPerSecond);


        public static readonly ForceChangeRateUnit DecanewtonPerMinute = new(PreFix.deka, NewtonPerMinute);
        public static readonly ForceChangeRateUnit KilonewtonPerMinute = new(PreFix.kilo, NewtonPerMinute);



        public ForceChangeRateUnit(ForceUnit force, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = force / duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{force}/{duration}");
        }

       
        public ForceChangeRateUnit(PreFix SI, ForceChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

       

    }




}