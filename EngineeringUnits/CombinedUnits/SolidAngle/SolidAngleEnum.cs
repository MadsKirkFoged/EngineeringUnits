using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class SolidAngleUnit : Enumeration
    {

        public static readonly SolidAngleUnit SI = new SolidAngleUnit(LengthUnit.Meter);
        public static readonly SolidAngleUnit CubicMeter = new SolidAngleUnit(LengthUnit.Meter);
        public static readonly SolidAngleUnit HectocubicMeter = new SolidAngleUnit(PreFix.hecto, CubicMeter);
        public static readonly SolidAngleUnit KilocubicMeter = new SolidAngleUnit(PreFix.kilo, CubicMeter);



        public SolidAngleUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public SolidAngleUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public SolidAngleUnit(PreFix SI, SolidAngleUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public SolidAngleUnit(SolidAngleUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}