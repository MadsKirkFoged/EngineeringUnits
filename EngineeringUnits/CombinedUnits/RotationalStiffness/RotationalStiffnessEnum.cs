using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class RotationalStiffnessUnit : Enumeration
    {

        public static readonly RotationalStiffnessUnit SI = new RotationalStiffnessUnit(LengthUnit.Meter);
        public static readonly RotationalStiffnessUnit CubicMeter = new RotationalStiffnessUnit(LengthUnit.Meter);
        public static readonly RotationalStiffnessUnit HectocubicMeter = new RotationalStiffnessUnit(PreFix.hecto, CubicMeter);
        public static readonly RotationalStiffnessUnit KilocubicMeter = new RotationalStiffnessUnit(PreFix.kilo, CubicMeter);



        public RotationalStiffnessUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RotationalStiffnessUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RotationalStiffnessUnit(PreFix SI, RotationalStiffnessUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public RotationalStiffnessUnit(RotationalStiffnessUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}