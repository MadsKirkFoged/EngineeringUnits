using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MagnetizationUnit : Enumeration
    {

        public static readonly MagnetizationUnit SI = new MagnetizationUnit(LengthUnit.Meter);
        public static readonly MagnetizationUnit CubicMeter = new MagnetizationUnit(LengthUnit.Meter);
        public static readonly MagnetizationUnit HectocubicMeter = new MagnetizationUnit(PreFix.hecto, CubicMeter);
        public static readonly MagnetizationUnit KilocubicMeter = new MagnetizationUnit(PreFix.kilo, CubicMeter);



        public MagnetizationUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MagnetizationUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MagnetizationUnit(PreFix SI, MagnetizationUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MagnetizationUnit(MagnetizationUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}