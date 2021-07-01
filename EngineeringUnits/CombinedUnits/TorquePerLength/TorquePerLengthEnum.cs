using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class TorquePerLengthUnit : Enumeration
    {

        public static readonly TorquePerLengthUnit SI = new TorquePerLengthUnit(LengthUnit.Meter);
        public static readonly TorquePerLengthUnit CubicMeter = new TorquePerLengthUnit(LengthUnit.Meter);
        public static readonly TorquePerLengthUnit HectocubicMeter = new TorquePerLengthUnit(PreFix.hecto, CubicMeter);
        public static readonly TorquePerLengthUnit KilocubicMeter = new TorquePerLengthUnit(PreFix.kilo, CubicMeter);



        public TorquePerLengthUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public TorquePerLengthUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public TorquePerLengthUnit(PreFix SI, TorquePerLengthUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public TorquePerLengthUnit(TorquePerLengthUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}