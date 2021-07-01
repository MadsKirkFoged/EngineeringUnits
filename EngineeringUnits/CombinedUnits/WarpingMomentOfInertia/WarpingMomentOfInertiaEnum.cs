using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class WarpingMomentOfInertiaUnit : Enumeration
    {

        public static readonly WarpingMomentOfInertiaUnit SI = new WarpingMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly WarpingMomentOfInertiaUnit CubicMeter = new WarpingMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly WarpingMomentOfInertiaUnit HectocubicMeter = new WarpingMomentOfInertiaUnit(PreFix.hecto, CubicMeter);
        public static readonly WarpingMomentOfInertiaUnit KilocubicMeter = new WarpingMomentOfInertiaUnit(PreFix.kilo, CubicMeter);



        public WarpingMomentOfInertiaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public WarpingMomentOfInertiaUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public WarpingMomentOfInertiaUnit(PreFix SI, WarpingMomentOfInertiaUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public WarpingMomentOfInertiaUnit(WarpingMomentOfInertiaUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}