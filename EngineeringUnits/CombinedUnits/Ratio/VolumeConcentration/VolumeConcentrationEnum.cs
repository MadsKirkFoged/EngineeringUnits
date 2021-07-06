using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class VolumeConcentrationUnit : Enumeration
    {

        public static readonly VolumeConcentrationUnit SI = new VolumeConcentrationUnit(LengthUnit.Meter);
        public static readonly VolumeConcentrationUnit CubicMeter = new VolumeConcentrationUnit(LengthUnit.Meter);
        public static readonly VolumeConcentrationUnit HectocubicMeter = new VolumeConcentrationUnit(PreFix.hecto, CubicMeter);
        public static readonly VolumeConcentrationUnit KilocubicMeter = new VolumeConcentrationUnit(PreFix.kilo, CubicMeter);



        public VolumeConcentrationUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public VolumeConcentrationUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public VolumeConcentrationUnit(PreFix SI, VolumeConcentrationUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public VolumeConcentrationUnit(VolumeConcentrationUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}