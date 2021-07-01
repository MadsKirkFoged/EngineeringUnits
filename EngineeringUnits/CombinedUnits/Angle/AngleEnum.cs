using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AngleUnit : Enumeration
    {

        public static readonly AngleUnit SI = new AngleUnit(LengthUnit.Meter);
        public static readonly AngleUnit CubicMeter = new AngleUnit(LengthUnit.Meter);
        public static readonly AngleUnit HectocubicMeter = new AngleUnit(PreFix.hecto, CubicMeter);
        public static readonly AngleUnit KilocubicMeter = new AngleUnit(PreFix.kilo, CubicMeter);



        public AngleUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public AngleUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public AngleUnit(PreFix SI, AngleUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public AngleUnit(AngleUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}