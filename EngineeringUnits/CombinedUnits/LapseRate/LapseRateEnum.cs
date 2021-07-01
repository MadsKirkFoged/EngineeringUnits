using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LapseRateUnit : Enumeration
    {

        public static readonly LapseRateUnit SI = new LapseRateUnit(LengthUnit.Meter);
        public static readonly LapseRateUnit CubicMeter = new LapseRateUnit(LengthUnit.Meter);
        public static readonly LapseRateUnit HectocubicMeter = new LapseRateUnit(PreFix.hecto, CubicMeter);
        public static readonly LapseRateUnit KilocubicMeter = new LapseRateUnit(PreFix.kilo, CubicMeter);



        public LapseRateUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public LapseRateUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public LapseRateUnit(PreFix SI, LapseRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public LapseRateUnit(LapseRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}