using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{



    public class RotationalSpeedUnit : Enumeration
    {

        public static readonly RotationalSpeedUnit SI = new RotationalSpeedUnit(DurationUnit.Second, "rad/s");
        public static readonly RotationalSpeedUnit RadianPerSecond = new RotationalSpeedUnit(DurationUnit.Second, "rad/s");


        public static readonly RotationalSpeedUnit Hertz = new RotationalSpeedUnit(DurationUnit.Second, "Hz", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit Kilohertz = new RotationalSpeedUnit(PreFix.kilo, Hertz);
        public static readonly RotationalSpeedUnit Megahertz = new RotationalSpeedUnit(PreFix.mega, Hertz);
        public static readonly RotationalSpeedUnit Gigahertz = new RotationalSpeedUnit(PreFix.giga, Hertz);
        public static readonly RotationalSpeedUnit Terahertz = new RotationalSpeedUnit(PreFix.tera, Hertz);

        public static readonly RotationalSpeedUnit PerSecond = new RotationalSpeedUnit(DurationUnit.Second, "s⁻¹", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit BeatPerMinute = new RotationalSpeedUnit(DurationUnit.Minute, "bpm", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit CyclePerHour = new RotationalSpeedUnit(DurationUnit.Hour, "cph", (2 * (decimal)Math.PI));
        public static readonly RotationalSpeedUnit CyclePerMinute = new RotationalSpeedUnit(DurationUnit.Minute, "cpm", (2 * (decimal)Math.PI));




        public RotationalSpeedUnit(DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = duration.Pow(-1);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public RotationalSpeedUnit(PreFix SI, RotationalSpeedUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }


    }




}