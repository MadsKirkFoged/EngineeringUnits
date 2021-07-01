using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricPotentialChangeRateUnit : Enumeration
    {

        public static readonly ElectricPotentialChangeRateUnit SI = new ElectricPotentialChangeRateUnit(LengthUnit.Meter);
        public static readonly ElectricPotentialChangeRateUnit CubicMeter = new ElectricPotentialChangeRateUnit(LengthUnit.Meter);
        public static readonly ElectricPotentialChangeRateUnit HectocubicMeter = new ElectricPotentialChangeRateUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricPotentialChangeRateUnit KilocubicMeter = new ElectricPotentialChangeRateUnit(PreFix.kilo, CubicMeter);



        public ElectricPotentialChangeRateUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricPotentialChangeRateUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricPotentialChangeRateUnit(PreFix SI, ElectricPotentialChangeRateUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricPotentialChangeRateUnit(ElectricPotentialChangeRateUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}