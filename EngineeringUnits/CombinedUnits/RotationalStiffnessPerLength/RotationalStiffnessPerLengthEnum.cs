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



        public RotationalStiffnessPerLengthUnit(LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Length.Pow(3);
            SetNewSymbol(NewSymbol);
        }



        public RotationalStiffnessPerLengthUnit(PreFix SI, RotationalStiffnessPerLengthUnit unit) : base(SI, unit)
        {
        }



    }




}