using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class SpecificWeightUnit : Enumeration
    {

        public static readonly SpecificWeightUnit SI = new SpecificWeightUnit(LengthUnit.Meter);
        public static readonly SpecificWeightUnit CubicMeter = new SpecificWeightUnit(LengthUnit.Meter);
        public static readonly SpecificWeightUnit HectocubicMeter = new SpecificWeightUnit(PreFix.hecto, CubicMeter);
        public static readonly SpecificWeightUnit KilocubicMeter = new SpecificWeightUnit(PreFix.kilo, CubicMeter);



        public SpecificWeightUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public SpecificWeightUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public SpecificWeightUnit(PreFix SI, SpecificWeightUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public SpecificWeightUnit(SpecificWeightUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}