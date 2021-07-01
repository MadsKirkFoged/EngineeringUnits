using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ForceChangeRateUnit : Enumeration
    {

        public static readonly ForceChangeRateUnit SI = new ForceChangeRateUnit(LengthUnit.Meter);
        public static readonly ForceChangeRateUnit CubicMeter = new ForceChangeRateUnit(LengthUnit.Meter);
        public static readonly ForceChangeRateUnit HectocubicMeter = new ForceChangeRateUnit(PreFix.hecto, CubicMeter);
        public static readonly ForceChangeRateUnit KilocubicMeter = new ForceChangeRateUnit(PreFix.kilo, CubicMeter);



        public ForceChangeRateUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ForceChangeRateUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ForceChangeRateUnit(PreFix SI, ForceChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ForceChangeRateUnit(ForceChangeRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}