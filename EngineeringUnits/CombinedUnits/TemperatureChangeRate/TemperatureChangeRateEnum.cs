using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class TemperatureChangeRateUnit : Enumeration
    {

        public static readonly TemperatureChangeRateUnit SI = new(TemperatureUnit.SI, DurationUnit.SI);
        public static readonly TemperatureChangeRateUnit DegreeCelsiusPerSecond = new(TemperatureUnit.Kelvin, DurationUnit.Second);
        public static readonly TemperatureChangeRateUnit DegreeCelsiusPerMinute = new(TemperatureUnit.Kelvin, DurationUnit.Minute);

        public static readonly TemperatureChangeRateUnit CentidegreeCelsiusPerSecond = new(PreFix.centi, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit DecadegreeCelsiusPerSecond = new(PreFix.deka, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit DecidegreeCelsiusPerSecond = new(PreFix.deci, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit HectodegreeCelsiusPerSecond = new(PreFix.hecto, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit KilodegreeCelsiusPerSecond = new(PreFix.kilo, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit MicrodegreeCelsiusPerSecond = new(PreFix.micro, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit MillidegreeCelsiusPerSecond = new(PreFix.milli, DegreeCelsiusPerSecond);
        public static readonly TemperatureChangeRateUnit NanodegreeCelsiusPerSecond = new(PreFix.nano, DegreeCelsiusPerSecond);



        public TemperatureChangeRateUnit(TemperatureUnit temperature, DurationUnit duration,  string NewSymbol = "Empty")
        {
            Unit = temperature / duration;
            SetNewSymbol(NewSymbol, $"{TemperatureUnit.DegreeCelsius}/{duration}");
        }

       

        public TemperatureChangeRateUnit(PreFix SI, TemperatureChangeRateUnit unit) : base(SI, unit)
        {
        }


    }




}