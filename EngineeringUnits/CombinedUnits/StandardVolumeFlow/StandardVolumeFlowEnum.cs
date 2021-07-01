using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class StandardVolumeFlowUnit : Enumeration
    {

        public static readonly StandardVolumeFlowUnit SI = new StandardVolumeFlowUnit(LengthUnit.Meter);
        public static readonly StandardVolumeFlowUnit CubicMeter = new StandardVolumeFlowUnit(LengthUnit.Meter);
        public static readonly StandardVolumeFlowUnit HectocubicMeter = new StandardVolumeFlowUnit(PreFix.hecto, CubicMeter);
        public static readonly StandardVolumeFlowUnit KilocubicMeter = new StandardVolumeFlowUnit(PreFix.kilo, CubicMeter);



        public StandardVolumeFlowUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public StandardVolumeFlowUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public StandardVolumeFlowUnit(PreFix SI, StandardVolumeFlowUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public StandardVolumeFlowUnit(StandardVolumeFlowUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}