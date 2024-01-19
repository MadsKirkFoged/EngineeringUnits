using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record FrequencyUnit : UnitTypebase
    {

        public static readonly FrequencyUnit SI =        new(DurationUnit.Second, "Hz");
        public static readonly FrequencyUnit Hertz =     new(DurationUnit.Second, "Hz");
        public static readonly FrequencyUnit Kilohertz = new(PreFix.kilo, Hertz);
        public static readonly FrequencyUnit Megahertz = new(PreFix.mega, Hertz);
        public static readonly FrequencyUnit Gigahertz = new(PreFix.giga, Hertz);
        public static readonly FrequencyUnit Terahertz = new(PreFix.tera, Hertz);
        public static readonly FrequencyUnit PerSecond =         new(DurationUnit.Second, "s⁻¹");
        public static readonly FrequencyUnit BeatPerMinute =     new(DurationUnit.Minute, "bpm");
        public static readonly FrequencyUnit RevolutionsPerMinute = new(DurationUnit.Minute, "RPM");
        public static readonly FrequencyUnit RPM = new(DurationUnit.Minute, "RPM");
        public static readonly FrequencyUnit CyclePerHour =      new(DurationUnit.Hour, "cph");
        public static readonly FrequencyUnit CyclePerMinute =    new(DurationUnit.Minute, "cpm");
        public static readonly FrequencyUnit RadianPerSecond = new(DurationUnit.Second, "rad/s", 1/(2*(decimal)Math.PI));




        public FrequencyUnit(DurationUnit duration, string NewSymbol, decimal correction = 1)
        {
            Unit = new UnitSystem(duration.Pow(-1) * correction, NewSymbol);
        }


        public FrequencyUnit(PreFix SI, FrequencyUnit unit) : base(SI, unit) {}

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }
    }




}