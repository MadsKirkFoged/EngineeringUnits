using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PowerRatioUnit : Enumeration
    {

        public static readonly PowerRatioUnit SI = new PowerRatioUnit(LengthUnit.Meter);
        public static readonly PowerRatioUnit CubicMeter = new PowerRatioUnit(LengthUnit.Meter);
        public static readonly PowerRatioUnit HectocubicMeter = new PowerRatioUnit(PreFix.hecto, CubicMeter);
        public static readonly PowerRatioUnit KilocubicMeter = new PowerRatioUnit(PreFix.kilo, CubicMeter);



        public PowerRatioUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public PowerRatioUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public PowerRatioUnit(PreFix SI, PowerRatioUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public PowerRatioUnit(PowerRatioUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}