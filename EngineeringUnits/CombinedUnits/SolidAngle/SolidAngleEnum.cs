using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class SolidAngleUnit : Enumeration
    {

        public static readonly SolidAngleUnit SI = new(LengthUnit.SI);
        public static readonly SolidAngleUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly SolidAngleUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly SolidAngleUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public SolidAngleUnit(LengthUnit Length, string NewSymbol = "Empty")
        {
            Unit = Length.Pow(3);
            SetNewSymbol(NewSymbol);
        }


        public SolidAngleUnit(PreFix SI, SolidAngleUnit unit)
        {
            Unit = unit.Unit.Copy() * PrefixSISize(SI);
            SetNewSymbol(SI);
        }



    }




}