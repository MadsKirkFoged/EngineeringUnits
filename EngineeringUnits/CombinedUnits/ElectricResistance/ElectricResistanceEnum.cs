using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricResistanceUnit : Enumeration
    {

        public static readonly ElectricResistanceUnit SI = new ElectricResistanceUnit(LengthUnit.Meter);
        public static readonly ElectricResistanceUnit CubicMeter = new ElectricResistanceUnit(LengthUnit.Meter);
        public static readonly ElectricResistanceUnit HectocubicMeter = new ElectricResistanceUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricResistanceUnit KilocubicMeter = new ElectricResistanceUnit(PreFix.kilo, CubicMeter);



        public ElectricResistanceUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricResistanceUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricResistanceUnit(PreFix SI, ElectricResistanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricResistanceUnit(ElectricResistanceUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}