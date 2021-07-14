using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricPotentialChangeRateUnit : Enumeration
    {

        public static readonly ElectricPotentialChangeRateUnit SI = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Volt, DurationUnit.Second);
        public static readonly ElectricPotentialChangeRateUnit VoltPerSecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Volt, DurationUnit.Second);
        public static readonly ElectricPotentialChangeRateUnit VoltPerMinute = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Volt, DurationUnit.Minute);
        public static readonly ElectricPotentialChangeRateUnit VoltPerMicrosecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Volt, DurationUnit.Microsecond);
        public static readonly ElectricPotentialChangeRateUnit VoltPerHour = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Volt, DurationUnit.Hour);

        public static readonly ElectricPotentialChangeRateUnit MillivoltPerSecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Millivolt, DurationUnit.Second);
        public static readonly ElectricPotentialChangeRateUnit MillivoltPerMinute = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Millivolt, DurationUnit.Minute);
        public static readonly ElectricPotentialChangeRateUnit MillivoltPerMicrosecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Millivolt, DurationUnit.Microsecond);
        public static readonly ElectricPotentialChangeRateUnit MillivoltPerHour = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Millivolt, DurationUnit.Hour);

        public static readonly ElectricPotentialChangeRateUnit MicrovoltPerSecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Microvolt, DurationUnit.Second);
        public static readonly ElectricPotentialChangeRateUnit MicrovoltPerMinute = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Microvolt, DurationUnit.Minute);
        public static readonly ElectricPotentialChangeRateUnit MicrovoltPerMicrosecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Microvolt, DurationUnit.Microsecond);
        public static readonly ElectricPotentialChangeRateUnit MicrovoltPerHour = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Microvolt, DurationUnit.Hour);

        public static readonly ElectricPotentialChangeRateUnit MegavoltPerSecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Megavolt, DurationUnit.Second);
        public static readonly ElectricPotentialChangeRateUnit MegavoltPerMinute = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Megavolt, DurationUnit.Minute);
        public static readonly ElectricPotentialChangeRateUnit MegavoltPerMicrosecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Megavolt, DurationUnit.Microsecond);
        public static readonly ElectricPotentialChangeRateUnit MegavoltPerHour = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Megavolt, DurationUnit.Hour);

        public static readonly ElectricPotentialChangeRateUnit KilovoltPerSecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Kilovolt, DurationUnit.Second);
        public static readonly ElectricPotentialChangeRateUnit KilovoltPerMinute = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Kilovolt, DurationUnit.Minute);
        public static readonly ElectricPotentialChangeRateUnit KilovoltPerMicrosecond = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Kilovolt, DurationUnit.Microsecond);
        public static readonly ElectricPotentialChangeRateUnit KilovoltPerHour = new ElectricPotentialChangeRateUnit(ElectricPotentialUnit.Kilovolt, DurationUnit.Hour);




        public ElectricPotentialChangeRateUnit(ElectricPotentialUnit electricPotential, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential / duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricPotential}/{duration}");
        }

        public ElectricPotentialChangeRateUnit(PreFix SI, ElectricPotentialChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricPotentialChangeRateUnit(ElectricPotentialChangeRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}