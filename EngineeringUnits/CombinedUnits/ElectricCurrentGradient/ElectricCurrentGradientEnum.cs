using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricCurrentGradientUnit : Enumeration
    {

        public static readonly ElectricCurrentGradientUnit SI = new ElectricCurrentGradientUnit(LengthUnit.Meter);
        public static readonly ElectricCurrentGradientUnit CubicMeter = new ElectricCurrentGradientUnit(LengthUnit.Meter);
        public static readonly ElectricCurrentGradientUnit HectocubicMeter = new ElectricCurrentGradientUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricCurrentGradientUnit KilocubicMeter = new ElectricCurrentGradientUnit(PreFix.kilo, CubicMeter);



        public ElectricCurrentGradientUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricCurrentGradientUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricCurrentGradientUnit(PreFix SI, ElectricCurrentGradientUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricCurrentGradientUnit(ElectricCurrentGradientUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}