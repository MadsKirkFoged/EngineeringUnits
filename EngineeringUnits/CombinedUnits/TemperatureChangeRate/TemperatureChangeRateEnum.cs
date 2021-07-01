using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class TemperatureChangeRateUnit : Enumeration
    {

        public static readonly TemperatureChangeRateUnit SI = new TemperatureChangeRateUnit(LengthUnit.Meter);
        public static readonly TemperatureChangeRateUnit CubicMeter = new TemperatureChangeRateUnit(LengthUnit.Meter);
        public static readonly TemperatureChangeRateUnit HectocubicMeter = new TemperatureChangeRateUnit(PreFix.hecto, CubicMeter);
        public static readonly TemperatureChangeRateUnit KilocubicMeter = new TemperatureChangeRateUnit(PreFix.kilo, CubicMeter);



        public TemperatureChangeRateUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public TemperatureChangeRateUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public TemperatureChangeRateUnit(PreFix SI, TemperatureChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public TemperatureChangeRateUnit(TemperatureChangeRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}