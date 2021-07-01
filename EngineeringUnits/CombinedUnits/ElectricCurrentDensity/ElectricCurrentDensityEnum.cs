using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricCurrentDensityUnit : Enumeration
    {

        public static readonly ElectricCurrentDensityUnit SI = new ElectricCurrentDensityUnit(LengthUnit.Meter);
        public static readonly ElectricCurrentDensityUnit CubicMeter = new ElectricCurrentDensityUnit(LengthUnit.Meter);
        public static readonly ElectricCurrentDensityUnit HectocubicMeter = new ElectricCurrentDensityUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricCurrentDensityUnit KilocubicMeter = new ElectricCurrentDensityUnit(PreFix.kilo, CubicMeter);



        public ElectricCurrentDensityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricCurrentDensityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricCurrentDensityUnit(PreFix SI, ElectricCurrentDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricCurrentDensityUnit(ElectricCurrentDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}