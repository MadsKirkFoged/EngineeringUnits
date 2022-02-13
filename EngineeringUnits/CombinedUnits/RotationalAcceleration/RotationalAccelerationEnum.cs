using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class RotationalAccelerationUnit : Enumeration
    {

        public static readonly RotationalAccelerationUnit SI = new(LengthUnit.SI);
        public static readonly RotationalAccelerationUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly RotationalAccelerationUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly RotationalAccelerationUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public RotationalAccelerationUnit(LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Length.Pow(3);
            SetNewSymbol(NewSymbol);
        }

        public RotationalAccelerationUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Area * Length;
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public RotationalAccelerationUnit(PreFix SI, RotationalAccelerationUnit unit) : base(SI, unit)
        {
        }

        public RotationalAccelerationUnit(RotationalAccelerationUnit unit, string NewSymbol = "Empty") : base(unit, NewSymbol, 1)
        {
        }

    }




}