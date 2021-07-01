using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MolarityUnit : Enumeration
    {

        public static readonly MolarityUnit SI = new MolarityUnit(LengthUnit.Meter);
        public static readonly MolarityUnit CubicMeter = new MolarityUnit(LengthUnit.Meter);
        public static readonly MolarityUnit HectocubicMeter = new MolarityUnit(PreFix.hecto, CubicMeter);
        public static readonly MolarityUnit KilocubicMeter = new MolarityUnit(PreFix.kilo, CubicMeter);



        public MolarityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MolarityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MolarityUnit(PreFix SI, MolarityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MolarityUnit(MolarityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}