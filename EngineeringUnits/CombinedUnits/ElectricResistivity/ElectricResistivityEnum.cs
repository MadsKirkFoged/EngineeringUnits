using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricResistivityUnit : Enumeration
    {

        public static readonly ElectricResistivityUnit SI = new ElectricResistivityUnit(LengthUnit.Meter);
        public static readonly ElectricResistivityUnit CubicMeter = new ElectricResistivityUnit(LengthUnit.Meter);
        public static readonly ElectricResistivityUnit HectocubicMeter = new ElectricResistivityUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricResistivityUnit KilocubicMeter = new ElectricResistivityUnit(PreFix.kilo, CubicMeter);



        public ElectricResistivityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricResistivityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricResistivityUnit(PreFix SI, ElectricResistivityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricResistivityUnit(ElectricResistivityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}