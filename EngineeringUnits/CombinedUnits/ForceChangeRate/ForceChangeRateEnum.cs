using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ForceChangeRateUnit : Enumeration
    {

        public static readonly ForceChangeRateUnit SI = new ForceChangeRateUnit(ForceUnit.Newton, DurationUnit.Second);
        public static readonly ForceChangeRateUnit NewtonPerSecond = new ForceChangeRateUnit(ForceUnit.Newton, DurationUnit.Second);
        public static readonly ForceChangeRateUnit NewtonPerMinute = new ForceChangeRateUnit(ForceUnit.Newton, DurationUnit.Minute);

        public static readonly ForceChangeRateUnit PoundForcePerSecond = new ForceChangeRateUnit(ForceUnit.PoundForce, DurationUnit.Second);
        public static readonly ForceChangeRateUnit PoundForcePerMinute = new ForceChangeRateUnit(ForceUnit.PoundForce, DurationUnit.Minute);

        public static readonly ForceChangeRateUnit KilopoundForcePerSecond = new ForceChangeRateUnit(PreFix.kilo, PoundForcePerSecond);

        public static readonly ForceChangeRateUnit KilopoundForcePerMinute = new ForceChangeRateUnit(PreFix.kilo, PoundForcePerMinute);

        public static readonly ForceChangeRateUnit NanonewtonPerSecond = new ForceChangeRateUnit(PreFix.nano, NewtonPerSecond);
        public static readonly ForceChangeRateUnit MillinewtonPerSecond = new ForceChangeRateUnit(PreFix.milli, NewtonPerSecond);
        public static readonly ForceChangeRateUnit MicronewtonPerSecond = new ForceChangeRateUnit(PreFix.micro, NewtonPerSecond);
        public static readonly ForceChangeRateUnit CentinewtonPerSecond = new ForceChangeRateUnit(PreFix.centi, NewtonPerSecond);
        public static readonly ForceChangeRateUnit DecanewtonPerSecond = new ForceChangeRateUnit(PreFix.deka, NewtonPerSecond);
        public static readonly ForceChangeRateUnit DecinewtonPerSecond = new ForceChangeRateUnit(PreFix.deci, NewtonPerSecond);
        public static readonly ForceChangeRateUnit KilonewtonPerSecond = new ForceChangeRateUnit(PreFix.kilo, NewtonPerSecond);


        public static readonly ForceChangeRateUnit DecanewtonPerMinute = new ForceChangeRateUnit(PreFix.deka, NewtonPerMinute);
        public static readonly ForceChangeRateUnit KilonewtonPerMinute = new ForceChangeRateUnit(PreFix.kilo, NewtonPerMinute);



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