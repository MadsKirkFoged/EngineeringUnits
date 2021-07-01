using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LinearDensityUnit : Enumeration
    {

        public static readonly LinearDensityUnit SI = new LinearDensityUnit(LengthUnit.Meter);
        public static readonly LinearDensityUnit CubicMeter = new LinearDensityUnit(LengthUnit.Meter);
        public static readonly LinearDensityUnit HectocubicMeter = new LinearDensityUnit(PreFix.hecto, CubicMeter);
        public static readonly LinearDensityUnit KilocubicMeter = new LinearDensityUnit(PreFix.kilo, CubicMeter);



        public LinearDensityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public LinearDensityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public LinearDensityUnit(PreFix SI, LinearDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public LinearDensityUnit(LinearDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}