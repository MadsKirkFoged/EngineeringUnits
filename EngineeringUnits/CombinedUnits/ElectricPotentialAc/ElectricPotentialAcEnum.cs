using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricPotentialAcUnit : Enumeration
    {

        public static readonly ElectricPotentialAcUnit SI = new ElectricPotentialAcUnit(LengthUnit.Meter);
        public static readonly ElectricPotentialAcUnit CubicMeter = new ElectricPotentialAcUnit(LengthUnit.Meter);
        public static readonly ElectricPotentialAcUnit HectocubicMeter = new ElectricPotentialAcUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricPotentialAcUnit KilocubicMeter = new ElectricPotentialAcUnit(PreFix.kilo, CubicMeter);



        public ElectricPotentialAcUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricPotentialAcUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricPotentialAcUnit(PreFix SI, ElectricPotentialAcUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricPotentialAcUnit(ElectricPotentialAcUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}