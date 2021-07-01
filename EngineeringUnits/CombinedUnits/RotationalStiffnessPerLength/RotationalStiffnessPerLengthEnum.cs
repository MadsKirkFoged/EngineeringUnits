using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class RotationalStiffnessPerLengthUnit : Enumeration
    {

        public static readonly RotationalStiffnessPerLengthUnit SI = new RotationalStiffnessPerLengthUnit(LengthUnit.Meter);
        public static readonly RotationalStiffnessPerLengthUnit CubicMeter = new RotationalStiffnessPerLengthUnit(LengthUnit.Meter);
        public static readonly RotationalStiffnessPerLengthUnit HectocubicMeter = new RotationalStiffnessPerLengthUnit(PreFix.hecto, CubicMeter);
        public static readonly RotationalStiffnessPerLengthUnit KilocubicMeter = new RotationalStiffnessPerLengthUnit(PreFix.kilo, CubicMeter);



        public RotationalStiffnessPerLengthUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RotationalStiffnessPerLengthUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RotationalStiffnessPerLengthUnit(PreFix SI, RotationalStiffnessPerLengthUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RotationalStiffnessPerLengthUnit(RotationalStiffnessPerLengthUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}