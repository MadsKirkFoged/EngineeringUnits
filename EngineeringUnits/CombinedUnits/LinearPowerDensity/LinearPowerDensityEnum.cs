using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LinearPowerDensityUnit : Enumeration
    {

        public static readonly LinearPowerDensityUnit SI = new LinearPowerDensityUnit(LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit CubicMeter = new LinearPowerDensityUnit(LengthUnit.Meter);
        public static readonly LinearPowerDensityUnit HectocubicMeter = new LinearPowerDensityUnit(PreFix.hecto, CubicMeter);
        public static readonly LinearPowerDensityUnit KilocubicMeter = new LinearPowerDensityUnit(PreFix.kilo, CubicMeter);



        public LinearPowerDensityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public LinearPowerDensityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public LinearPowerDensityUnit(PreFix SI, LinearPowerDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public LinearPowerDensityUnit(LinearPowerDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}