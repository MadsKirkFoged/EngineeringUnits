using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricFieldUnit : Enumeration
    {

        public static readonly ElectricFieldUnit SI = new ElectricFieldUnit(LengthUnit.Meter);
        public static readonly ElectricFieldUnit CubicMeter = new ElectricFieldUnit(LengthUnit.Meter);
        public static readonly ElectricFieldUnit HectocubicMeter = new ElectricFieldUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricFieldUnit KilocubicMeter = new ElectricFieldUnit(PreFix.kilo, CubicMeter);



        public ElectricFieldUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricFieldUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricFieldUnit(PreFix SI, ElectricFieldUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricFieldUnit(ElectricFieldUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}