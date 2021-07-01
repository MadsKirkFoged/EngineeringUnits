using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class VolumePerLengthUnit : Enumeration
    {

        public static readonly VolumePerLengthUnit SI = new VolumePerLengthUnit(LengthUnit.Meter);
        public static readonly VolumePerLengthUnit CubicMeter = new VolumePerLengthUnit(LengthUnit.Meter);
        public static readonly VolumePerLengthUnit HectocubicMeter = new VolumePerLengthUnit(PreFix.hecto, CubicMeter);
        public static readonly VolumePerLengthUnit KilocubicMeter = new VolumePerLengthUnit(PreFix.kilo, CubicMeter);



        public VolumePerLengthUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public VolumePerLengthUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public VolumePerLengthUnit(PreFix SI, VolumePerLengthUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public VolumePerLengthUnit(VolumePerLengthUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}