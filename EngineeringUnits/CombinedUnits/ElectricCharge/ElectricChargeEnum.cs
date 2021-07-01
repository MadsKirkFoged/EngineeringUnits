using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricChargeUnit : Enumeration
    {

        public static readonly ElectricChargeUnit SI = new ElectricChargeUnit(LengthUnit.Meter);
        public static readonly ElectricChargeUnit CubicMeter = new ElectricChargeUnit(LengthUnit.Meter);
        public static readonly ElectricChargeUnit HectocubicMeter = new ElectricChargeUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricChargeUnit KilocubicMeter = new ElectricChargeUnit(PreFix.kilo, CubicMeter);



        public ElectricChargeUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricChargeUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricChargeUnit(PreFix SI, ElectricChargeUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricChargeUnit(ElectricChargeUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}