using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class FrequencyUnit : Enumeration
    {

        public static FrequencyUnit SI = new FrequencyUnit(DurationUnit.SI);
        public static FrequencyUnit Hertz = new FrequencyUnit(DurationUnit.Second, "Hz");
        public static FrequencyUnit Kilohertz = new FrequencyUnit(PreFix.kilo, Hertz);
        public static FrequencyUnit Megahertz = new FrequencyUnit(PreFix.mega, Hertz);
        public static FrequencyUnit Gigahertz = new FrequencyUnit(PreFix.giga, Hertz);
        public static FrequencyUnit Terahertz = new FrequencyUnit(PreFix.tera, Hertz);


        public static FrequencyUnit PerSecond = new FrequencyUnit(DurationUnit.Second, "s⁻¹");
        public static FrequencyUnit BeatPerMinute = new FrequencyUnit(DurationUnit.Minute, "bpm");
        public static FrequencyUnit CyclePerHour = new FrequencyUnit(DurationUnit.Hour, "cph");
        public static FrequencyUnit CyclePerMinute = new FrequencyUnit(DurationUnit.Minute, "cpm");

        public static FrequencyUnit RadianPerSecond = new FrequencyUnit(DurationUnit.Second, "rad/s", 1/(2*(decimal)Math.PI));




        public FrequencyUnit(DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {

            //Name = "Frequency";
            Unit = duration.Unit / (duration.Unit * duration.Unit);

            SetCombined(correction);
            SetNewSymbol(NewSymbol);

        }


        public FrequencyUnit(PreFix SI, FrequencyUnit unit)
        {
            //Name = "Frequencyh";
            Unit = unit.Unit.Copy();

            SetCombined(SI);
            SetNewSymbol(SI);
        }



        public static IEnumerable<FrequencyUnit> List()
        {
            return new[] { BeatPerMinute, CyclePerHour, CyclePerMinute, Gigahertz, Hertz, Kilohertz, Megahertz, PerSecond, RadianPerSecond, Terahertz, };
        }





    }




}