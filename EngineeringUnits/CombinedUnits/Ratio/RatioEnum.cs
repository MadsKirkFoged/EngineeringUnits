using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class RatioUnit : Enumeration
    {

        public static readonly RatioUnit SI = new RatioUnit(LengthUnit.Meter);
        public static readonly RatioUnit CubicMeter = new RatioUnit(LengthUnit.Meter);
        public static readonly RatioUnit HectocubicMeter = new RatioUnit(PreFix.hecto, CubicMeter);
        public static readonly RatioUnit KilocubicMeter = new RatioUnit(PreFix.kilo, CubicMeter);



        public RatioUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RatioUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RatioUnit(PreFix SI, RatioUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RatioUnit(RatioUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}