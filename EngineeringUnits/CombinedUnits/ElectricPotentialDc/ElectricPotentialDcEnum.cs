using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricPotentialDcUnit : Enumeration
    {

        public static readonly ElectricPotentialDcUnit SI = new ElectricPotentialDcUnit(LengthUnit.Meter);
        public static readonly ElectricPotentialDcUnit CubicMeter = new ElectricPotentialDcUnit(LengthUnit.Meter);
        public static readonly ElectricPotentialDcUnit HectocubicMeter = new ElectricPotentialDcUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricPotentialDcUnit KilocubicMeter = new ElectricPotentialDcUnit(PreFix.kilo, CubicMeter);



        public ElectricPotentialDcUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricPotentialDcUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricPotentialDcUnit(PreFix SI, ElectricPotentialDcUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricPotentialDcUnit(ElectricPotentialDcUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}