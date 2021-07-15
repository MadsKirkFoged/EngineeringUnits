using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class SpecificVolumeUnit : Enumeration
    {

        public static readonly SpecificVolumeUnit SI = new SpecificVolumeUnit(LengthUnit.Meter);
        public static readonly SpecificVolumeUnit CubicMeter = new SpecificVolumeUnit(LengthUnit.Meter);
        public static readonly SpecificVolumeUnit HectocubicMeter = new SpecificVolumeUnit(PreFix.hecto, CubicMeter);
        public static readonly SpecificVolumeUnit KilocubicMeter = new SpecificVolumeUnit(PreFix.kilo, CubicMeter);



        public SpecificVolumeUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public SpecificVolumeUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
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