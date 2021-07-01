using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class TurbidityUnit : Enumeration
    {

        public static readonly TurbidityUnit SI = new TurbidityUnit(LengthUnit.Meter);
        public static readonly TurbidityUnit CubicMeter = new TurbidityUnit(LengthUnit.Meter);
        public static readonly TurbidityUnit HectocubicMeter = new TurbidityUnit(PreFix.hecto, CubicMeter);
        public static readonly TurbidityUnit KilocubicMeter = new TurbidityUnit(PreFix.kilo, CubicMeter);



        public TurbidityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public TurbidityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public TurbidityUnit(PreFix SI, TurbidityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public TurbidityUnit(TurbidityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}