using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class IlluminanceUnit : Enumeration
    {

        public static readonly IlluminanceUnit SI = new IlluminanceUnit(LengthUnit.Meter);
        public static readonly IlluminanceUnit CubicMeter = new IlluminanceUnit(LengthUnit.Meter);
        public static readonly IlluminanceUnit HectocubicMeter = new IlluminanceUnit(PreFix.hecto, CubicMeter);
        public static readonly IlluminanceUnit KilocubicMeter = new IlluminanceUnit(PreFix.kilo, CubicMeter);



        public IlluminanceUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public IlluminanceUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public IlluminanceUnit(PreFix SI, IlluminanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public IlluminanceUnit(IlluminanceUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}