using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class BitRateUnit : Enumeration
    {

        public static readonly BitRateUnit SI = new BitRateUnit(LengthUnit.Meter);
        public static readonly BitRateUnit CubicMeter = new BitRateUnit(LengthUnit.Meter);
        public static readonly BitRateUnit HectocubicMeter = new BitRateUnit(PreFix.hecto, CubicMeter);
        public static readonly BitRateUnit KilocubicMeter = new BitRateUnit(PreFix.kilo, CubicMeter);



        public BitRateUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public BitRateUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public BitRateUnit(PreFix SI, BitRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public BitRateUnit(BitRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}