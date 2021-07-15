using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricCurrentGradientUnit : Enumeration
    {

        public static readonly ElectricCurrentGradientUnit SI = new ElectricCurrentGradientUnit(ElectricCurrentUnit.Ampere, DurationUnit.Second);
        public static readonly ElectricCurrentGradientUnit AmperePerSecond = new ElectricCurrentGradientUnit(ElectricCurrentUnit.Ampere, DurationUnit.Second);
        public static readonly ElectricCurrentGradientUnit AmperePerMicrosecond = new ElectricCurrentGradientUnit(ElectricCurrentUnit.Ampere, DurationUnit.Microsecond);
        public static readonly ElectricCurrentGradientUnit AmperePerMillisecond = new ElectricCurrentGradientUnit(ElectricCurrentUnit.Ampere, DurationUnit.Millisecond);
        public static readonly ElectricCurrentGradientUnit AmperePerNanosecond = new ElectricCurrentGradientUnit(ElectricCurrentUnit.Ampere, DurationUnit.Nanosecond);

        public ElectricCurrentGradientUnit(ElectricCurrentUnit electricCurrent, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricCurrent / duration;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricCurrent}/{duration}");
        }

      

    }




}