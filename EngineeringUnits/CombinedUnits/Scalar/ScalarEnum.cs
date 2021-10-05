using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ScalarUnit : Enumeration
    {

        public static readonly ScalarUnit SI = new(LengthUnit.SI);
        public static readonly ScalarUnit CubicMeter = new(LengthUnit.Meter);
        public static readonly ScalarUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);
        public static readonly ScalarUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);



        public ScalarUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ScalarUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ScalarUnit(PreFix SI, ScalarUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ScalarUnit(ScalarUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}