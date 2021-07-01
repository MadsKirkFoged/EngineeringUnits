using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ApparentPowerUnit : Enumeration
    {

        public static readonly ApparentPowerUnit SI = new ApparentPowerUnit(LengthUnit.Meter);
        public static readonly ApparentPowerUnit CubicMeter = new ApparentPowerUnit(LengthUnit.Meter);
        public static readonly ApparentPowerUnit HectocubicMeter = new ApparentPowerUnit(PreFix.hecto, CubicMeter);
        public static readonly ApparentPowerUnit KilocubicMeter = new ApparentPowerUnit(PreFix.kilo, CubicMeter);



        public ApparentPowerUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ApparentPowerUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ApparentPowerUnit(PreFix SI, ApparentPowerUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ApparentPowerUnit(ApparentPowerUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}