using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class testUnit : Enumeration
    {

        public static readonly testUnit SI = new testUnit(LengthUnit.Meter);
        public static readonly testUnit CubicMeter = new testUnit(LengthUnit.Meter);
        public static readonly testUnit HectocubicMeter = new testUnit(PreFix.hecto, CubicMeter);
        public static readonly testUnit KilocubicMeter = new testUnit(PreFix.kilo, CubicMeter);



        public testUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length * Length * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public testUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public testUnit(PreFix SI, testUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public testUnit(testUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}