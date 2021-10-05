using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class RotationalStiffnessUnit : Enumeration
    {

        public static readonly RotationalStiffnessUnit SI = new(LengthUnit.SI);
        public static readonly RotationalStiffnessUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly RotationalStiffnessUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly RotationalStiffnessUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



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