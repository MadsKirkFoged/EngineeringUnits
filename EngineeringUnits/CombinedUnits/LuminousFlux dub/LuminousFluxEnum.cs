using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class LuminousFluxUnit : Enumeration
    {

        public static readonly LuminousFluxUnit SI = new LuminousFluxUnit(LengthUnit.Meter);
        public static readonly LuminousFluxUnit CubicMeter = new LuminousFluxUnit(LengthUnit.Meter);
        public static readonly LuminousFluxUnit HectocubicMeter = new LuminousFluxUnit(PreFix.hecto, CubicMeter);
        public static readonly LuminousFluxUnit KilocubicMeter = new LuminousFluxUnit(PreFix.kilo, CubicMeter);



        public LuminousFluxUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public LuminousFluxUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public LuminousFluxUnit(PreFix SI, LuminousFluxUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public LuminousFluxUnit(LuminousFluxUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}