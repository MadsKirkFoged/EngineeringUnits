using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ReactiveEnergyUnit : Enumeration
    {

        public static readonly ReactiveEnergyUnit SI = new ReactiveEnergyUnit(LengthUnit.Meter);
        public static readonly ReactiveEnergyUnit CubicMeter = new ReactiveEnergyUnit(LengthUnit.Meter);
        public static readonly ReactiveEnergyUnit HectocubicMeter = new ReactiveEnergyUnit(PreFix.hecto, CubicMeter);
        public static readonly ReactiveEnergyUnit KilocubicMeter = new ReactiveEnergyUnit(PreFix.kilo, CubicMeter);



        public ReactiveEnergyUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ReactiveEnergyUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ReactiveEnergyUnit(PreFix SI, ReactiveEnergyUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ReactiveEnergyUnit(ReactiveEnergyUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}