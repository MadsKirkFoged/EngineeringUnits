using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LevelUnit : Enumeration
    {

        public static readonly LevelUnit SI = new LevelUnit(LengthUnit.Meter);
        public static readonly LevelUnit CubicMeter = new LevelUnit(LengthUnit.Meter);
        public static readonly LevelUnit HectocubicMeter = new LevelUnit(PreFix.hecto, CubicMeter);
        public static readonly LevelUnit KilocubicMeter = new LevelUnit(PreFix.kilo, CubicMeter);



        public LevelUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public LevelUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public LevelUnit(PreFix SI, LevelUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public LevelUnit(LevelUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}