using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ReactivePowerUnit : Enumeration
    {

        public static readonly ReactivePowerUnit SI = new ReactivePowerUnit(LengthUnit.Meter);
        public static readonly ReactivePowerUnit CubicMeter = new ReactivePowerUnit(LengthUnit.Meter);
        public static readonly ReactivePowerUnit HectocubicMeter = new ReactivePowerUnit(PreFix.hecto, CubicMeter);
        public static readonly ReactivePowerUnit KilocubicMeter = new ReactivePowerUnit(PreFix.kilo, CubicMeter);



        public ReactivePowerUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ReactivePowerUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ReactivePowerUnit(PreFix SI, ReactivePowerUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ReactivePowerUnit(ReactivePowerUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}