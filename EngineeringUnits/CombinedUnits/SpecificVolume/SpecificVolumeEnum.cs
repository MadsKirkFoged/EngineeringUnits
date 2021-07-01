using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class SpecificVolumeUnit : Enumeration
    {

        public static readonly SpecificVolumeUnit SI = new SpecificVolumeUnit(LengthUnit.Meter);
        public static readonly SpecificVolumeUnit CubicMeter = new SpecificVolumeUnit(LengthUnit.Meter);
        public static readonly SpecificVolumeUnit HectocubicMeter = new SpecificVolumeUnit(PreFix.hecto, CubicMeter);
        public static readonly SpecificVolumeUnit KilocubicMeter = new SpecificVolumeUnit(PreFix.kilo, CubicMeter);



        public SpecificVolumeUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public SpecificVolumeUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public SpecificVolumeUnit(PreFix SI, SpecificVolumeUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public SpecificVolumeUnit(SpecificVolumeUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}