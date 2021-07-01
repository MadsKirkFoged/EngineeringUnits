using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LuminosityUnit : Enumeration
    {

        public static readonly LuminosityUnit SI = new LuminosityUnit(LengthUnit.Meter);
        public static readonly LuminosityUnit CubicMeter = new LuminosityUnit(LengthUnit.Meter);
        public static readonly LuminosityUnit HectocubicMeter = new LuminosityUnit(PreFix.hecto, CubicMeter);
        public static readonly LuminosityUnit KilocubicMeter = new LuminosityUnit(PreFix.kilo, CubicMeter);



        public LuminosityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public LuminosityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public LuminosityUnit(PreFix SI, LuminosityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public LuminosityUnit(LuminosityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}