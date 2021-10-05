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



        public SolidAngleUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public SolidAngleUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public SolidAngleUnit(PreFix SI, SolidAngleUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public SolidAngleUnit(SolidAngleUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}