using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class RotationalStiffnessPerLengthUnit : Enumeration
    {

        public static readonly RotationalStiffnessPerLengthUnit SI = new(LengthUnit.SI);
        public static readonly RotationalStiffnessPerLengthUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly RotationalStiffnessPerLengthUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly RotationalStiffnessPerLengthUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public RotationalStiffnessPerLengthUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public RotationalStiffnessPerLengthUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
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