using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PressureChangeRateUnit : Enumeration
    {

        public static readonly PressureChangeRateUnit SI = new PressureChangeRateUnit(LengthUnit.Meter);
        public static readonly PressureChangeRateUnit CubicMeter = new PressureChangeRateUnit(LengthUnit.Meter);
        public static readonly PressureChangeRateUnit HectocubicMeter = new PressureChangeRateUnit(PreFix.hecto, CubicMeter);
        public static readonly PressureChangeRateUnit KilocubicMeter = new PressureChangeRateUnit(PreFix.kilo, CubicMeter);



        public PressureChangeRateUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public PressureChangeRateUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public PressureChangeRateUnit(PreFix SI, PressureChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public PressureChangeRateUnit(PressureChangeRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}