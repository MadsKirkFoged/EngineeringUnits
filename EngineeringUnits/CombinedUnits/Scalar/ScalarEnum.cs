using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ScalarUnit : Enumeration
    {

        public static readonly ScalarUnit SI = new ScalarUnit(LengthUnit.Meter);
        public static readonly ScalarUnit CubicMeter = new ScalarUnit(LengthUnit.Meter);
        public static readonly ScalarUnit HectocubicMeter = new ScalarUnit(PreFix.hecto, CubicMeter);
        public static readonly ScalarUnit KilocubicMeter = new ScalarUnit(PreFix.kilo, CubicMeter);



        public ScalarUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ScalarUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ScalarUnit(PreFix SI, ScalarUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ScalarUnit(ScalarUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}