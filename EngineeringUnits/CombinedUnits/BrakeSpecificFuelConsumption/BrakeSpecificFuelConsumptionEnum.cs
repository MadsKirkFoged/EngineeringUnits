using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class BrakeSpecificFuelConsumptionUnit : Enumeration
    {

        public static readonly BrakeSpecificFuelConsumptionUnit SI = new BrakeSpecificFuelConsumptionUnit(LengthUnit.Meter);
        public static readonly BrakeSpecificFuelConsumptionUnit CubicMeter = new BrakeSpecificFuelConsumptionUnit(LengthUnit.Meter);
        public static readonly BrakeSpecificFuelConsumptionUnit HectocubicMeter = new BrakeSpecificFuelConsumptionUnit(PreFix.hecto, CubicMeter);
        public static readonly BrakeSpecificFuelConsumptionUnit KilocubicMeter = new BrakeSpecificFuelConsumptionUnit(PreFix.kilo, CubicMeter);



        public BrakeSpecificFuelConsumptionUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public BrakeSpecificFuelConsumptionUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public BrakeSpecificFuelConsumptionUnit(PreFix SI, BrakeSpecificFuelConsumptionUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public BrakeSpecificFuelConsumptionUnit(BrakeSpecificFuelConsumptionUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}