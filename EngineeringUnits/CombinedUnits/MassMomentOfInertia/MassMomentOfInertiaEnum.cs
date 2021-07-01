using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MassMomentOfInertiaUnit : Enumeration
    {

        public static readonly MassMomentOfInertiaUnit SI = new MassMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly MassMomentOfInertiaUnit CubicMeter = new MassMomentOfInertiaUnit(LengthUnit.Meter);
        public static readonly MassMomentOfInertiaUnit HectocubicMeter = new MassMomentOfInertiaUnit(PreFix.hecto, CubicMeter);
        public static readonly MassMomentOfInertiaUnit KilocubicMeter = new MassMomentOfInertiaUnit(PreFix.kilo, CubicMeter);



        public MassMomentOfInertiaUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MassMomentOfInertiaUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MassMomentOfInertiaUnit(PreFix SI, MassMomentOfInertiaUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MassMomentOfInertiaUnit(MassMomentOfInertiaUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}