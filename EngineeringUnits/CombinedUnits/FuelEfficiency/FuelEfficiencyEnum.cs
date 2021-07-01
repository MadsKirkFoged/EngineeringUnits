using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class FuelEfficiencyUnit : Enumeration
    {

        public static readonly FuelEfficiencyUnit SI = new FuelEfficiencyUnit(LengthUnit.Meter);
        public static readonly FuelEfficiencyUnit CubicMeter = new FuelEfficiencyUnit(LengthUnit.Meter);
        public static readonly FuelEfficiencyUnit HectocubicMeter = new FuelEfficiencyUnit(PreFix.hecto, CubicMeter);
        public static readonly FuelEfficiencyUnit KilocubicMeter = new FuelEfficiencyUnit(PreFix.kilo, CubicMeter);



        public FuelEfficiencyUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public FuelEfficiencyUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public FuelEfficiencyUnit(PreFix SI, FuelEfficiencyUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public FuelEfficiencyUnit(FuelEfficiencyUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}