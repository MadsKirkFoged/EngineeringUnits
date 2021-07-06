using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class TemperatureChangeRateUnit : Enumeration
    {

        public static readonly TemperatureChangeRateUnit SI = new TemperatureChangeRateUnit(TemperatureUnit.Kelvin, DurationUnit.Second);
        public static readonly TemperatureChangeRateUnit DegreeCelsiusPerSecond = new TemperatureChangeRateUnit(TemperatureUnit.Kelvin, DurationUnit.Second);
        public static readonly TemperatureChangeRateUnit DegreeCelsiusPerMinute = new TemperatureChangeRateUnit(TemperatureUnit.Kelvin, DurationUnit.Minute);

        public static readonly TemperatureChangeRateUnit CentidegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.centi, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit DecadegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.deka, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit DecidegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.deci, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit HectodegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.hecto, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit KilodegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.kilo, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit MicrodegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.micro, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit MillidegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.milli, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit NanodegreeCelsiusPerSecond = new TemperatureChangeRateUnit(PreFix.nano, DegreeCelsiusPerSecond);



        public TemperatureChangeRateUnit(TemperatureUnit temperature, DurationUnit duration,  string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = temperature.Unit / duration.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{TemperatureUnit.DegreeCelsius}/{duration}");
        }

       

        public TemperatureChangeRateUnit(PreFix SI, TemperatureChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }


    }




}