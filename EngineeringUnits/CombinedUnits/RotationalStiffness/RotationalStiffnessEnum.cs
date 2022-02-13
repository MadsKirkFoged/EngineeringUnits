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



        public RotationalStiffnessUnit(LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Length.Pow(3);
            SetNewSymbol(NewSymbol);
        }

        public RotationalStiffnessUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Area * Length;
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RotationalStiffnessUnit(PreFix SI, RotationalStiffnessUnit unit) : base(SI, unit)
        {
        }

        public RotationalStiffnessUnit(RotationalStiffnessUnit unit, string NewSymbol = "Empty") : base(unit, NewSymbol, 1)
        {
        }

    }




}