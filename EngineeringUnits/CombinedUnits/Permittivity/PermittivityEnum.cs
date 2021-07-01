using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PermittivityUnit : Enumeration
    {

        public static readonly PermittivityUnit SI = new PermittivityUnit(LengthUnit.Meter);
        public static readonly PermittivityUnit CubicMeter = new PermittivityUnit(LengthUnit.Meter);
        public static readonly PermittivityUnit HectocubicMeter = new PermittivityUnit(PreFix.hecto, CubicMeter);
        public static readonly PermittivityUnit KilocubicMeter = new PermittivityUnit(PreFix.kilo, CubicMeter);



        public PermittivityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public PermittivityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public PermittivityUnit(PreFix SI, PermittivityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public PermittivityUnit(PermittivityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}