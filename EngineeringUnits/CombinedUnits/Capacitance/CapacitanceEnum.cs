using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class CapacitanceUnit : Enumeration
    {

        public static readonly CapacitanceUnit SI = new CapacitanceUnit(LengthUnit.Meter);
        public static readonly CapacitanceUnit CubicMeter = new CapacitanceUnit(LengthUnit.Meter);
        public static readonly CapacitanceUnit HectocubicMeter = new CapacitanceUnit(PreFix.hecto, CubicMeter);
        public static readonly CapacitanceUnit KilocubicMeter = new CapacitanceUnit(PreFix.kilo, CubicMeter);



        public CapacitanceUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public CapacitanceUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public CapacitanceUnit(PreFix SI, CapacitanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public CapacitanceUnit(CapacitanceUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}