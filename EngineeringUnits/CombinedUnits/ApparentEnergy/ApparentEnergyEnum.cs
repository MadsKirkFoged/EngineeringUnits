using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ApparentEnergyUnit : Enumeration
    {

        public static readonly ApparentEnergyUnit SI = new ApparentEnergyUnit(LengthUnit.Meter);
        public static readonly ApparentEnergyUnit CubicMeter = new ApparentEnergyUnit(LengthUnit.Meter);
        public static readonly ApparentEnergyUnit HectocubicMeter = new ApparentEnergyUnit(PreFix.hecto, CubicMeter);
        public static readonly ApparentEnergyUnit KilocubicMeter = new ApparentEnergyUnit(PreFix.kilo, CubicMeter);



        public ApparentEnergyUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ApparentEnergyUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ApparentEnergyUnit(PreFix SI, ApparentEnergyUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ApparentEnergyUnit(ApparentEnergyUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}