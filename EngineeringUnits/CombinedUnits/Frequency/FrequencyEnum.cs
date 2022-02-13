using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class FrequencyUnit : Enumeration
    {

        public static readonly FrequencyUnit SI =        new(DurationUnit.Second, "Hz");
        public static readonly FrequencyUnit Hertz =     new(DurationUnit.Second, "Hz");
        public static readonly FrequencyUnit Kilohertz = new(PreFix.kilo, Hertz);
        public static readonly FrequencyUnit Megahertz = new(PreFix.mega, Hertz);
        public static readonly FrequencyUnit Gigahertz = new(PreFix.giga, Hertz);
        public static readonly FrequencyUnit Terahertz = new(PreFix.tera, Hertz);
        public static readonly FrequencyUnit PerSecond =         new(DurationUnit.Second, "s⁻¹");
        public static readonly FrequencyUnit BeatPerMinute =     new(DurationUnit.Minute, "bpm");
        public static readonly FrequencyUnit CyclePerHour =      new(DurationUnit.Hour, "cph");
        public static readonly FrequencyUnit CyclePerMinute =    new(DurationUnit.Minute, "cpm");
        public static readonly FrequencyUnit RadianPerSecond = new(DurationUnit.Second, "rad/s", 1/(2*(decimal)Math.PI));




        public FrequencyUnit(DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = duration.Pow(-1) * correction;
            SetNewSymbol(NewSymbol);
        }


        public FrequencyUnit(PreFix SI, FrequencyUnit unit) : base(SI, unit)
        {
        }


    }




}