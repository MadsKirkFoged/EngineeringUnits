using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AreaDensityUnit : Enumeration
    {

        public static readonly AreaDensityUnit SI = new AreaDensityUnit(LengthUnit.Meter);
        public static readonly AreaDensityUnit CubicMeter = new AreaDensityUnit(LengthUnit.Meter);
        public static readonly AreaDensityUnit HectocubicMeter = new AreaDensityUnit(PreFix.hecto, CubicMeter);
        public static readonly AreaDensityUnit KilocubicMeter = new AreaDensityUnit(PreFix.kilo, CubicMeter);



        public AreaDensityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public AreaDensityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public AreaDensityUnit(PreFix SI, AreaDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public AreaDensityUnit(AreaDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}