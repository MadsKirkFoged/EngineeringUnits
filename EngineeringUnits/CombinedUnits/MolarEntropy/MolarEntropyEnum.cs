using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MolarEntropyUnit : Enumeration
    {

        public static readonly MolarEntropyUnit SI = new MolarEntropyUnit(LengthUnit.Meter);
        public static readonly MolarEntropyUnit CubicMeter = new MolarEntropyUnit(LengthUnit.Meter);
        public static readonly MolarEntropyUnit HectocubicMeter = new MolarEntropyUnit(PreFix.hecto, CubicMeter);
        public static readonly MolarEntropyUnit KilocubicMeter = new MolarEntropyUnit(PreFix.kilo, CubicMeter);



        public MolarEntropyUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MolarEntropyUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MolarEntropyUnit(PreFix SI, MolarEntropyUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MolarEntropyUnit(MolarEntropyUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}