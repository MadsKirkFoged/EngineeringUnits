using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class AreaMomentOfInertiaUnit : Enumeration
    {

        public static readonly AreaMomentOfInertiaUnit SI = new AreaMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly AreaMomentOfInertiaUnit CubicMeter = new AreaMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly AreaMomentOfInertiaUnit HectocubicMeter = new AreaMomentOfInertiaUnit(PreFix.hecto, CubicMeter);
        public static readonly AreaMomentOfInertiaUnit KilocubicMeter = new AreaMomentOfInertiaUnit(PreFix.kilo, CubicMeter);



        public AreaMomentOfInertiaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public AreaMomentOfInertiaUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public AreaMomentOfInertiaUnit(PreFix SI, AreaMomentOfInertiaUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public AreaMomentOfInertiaUnit(AreaMomentOfInertiaUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}