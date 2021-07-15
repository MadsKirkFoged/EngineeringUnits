using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class FrequencyUnit : Enumeration
    {

        public static readonly FrequencyUnit SI =        new FrequencyUnit(DurationUnit.SI);
        public static readonly FrequencyUnit Hertz =     new FrequencyUnit(DurationUnit.Second, "Hz");
        public static readonly FrequencyUnit Kilohertz = new FrequencyUnit(PreFix.kilo, Hertz);
        public static readonly FrequencyUnit Megahertz = new FrequencyUnit(PreFix.mega, Hertz);
        public static readonly FrequencyUnit Gigahertz = new FrequencyUnit(PreFix.giga, Hertz);
        public static readonly FrequencyUnit Terahertz = new FrequencyUnit(PreFix.tera, Hertz);
        public static readonly FrequencyUnit PerSecond =         new FrequencyUnit(DurationUnit.Second, "s⁻¹");
        public static readonly FrequencyUnit BeatPerMinute =     new FrequencyUnit(DurationUnit.Minute, "bpm");
        public static readonly FrequencyUnit CyclePerHour =      new FrequencyUnit(DurationUnit.Hour, "cph");
        public static readonly FrequencyUnit CyclePerMinute =    new FrequencyUnit(DurationUnit.Minute, "cpm");
        public static readonly FrequencyUnit RadianPerSecond = new FrequencyUnit(DurationUnit.Second, "rad/s", 1/(2*(decimal)Math.PI));




        public FrequencyUnit(DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = duration.Pow(-1);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }


        public FrequencyUnit(PreFix SI, FrequencyUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }


    }




}