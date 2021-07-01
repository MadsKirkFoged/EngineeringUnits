using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class HeatFluxUnit : Enumeration
    {

        public static readonly HeatFluxUnit SI = new HeatFluxUnit(LengthUnit.Meter);
        public static readonly HeatFluxUnit CubicMeter = new HeatFluxUnit(LengthUnit.Meter);
        public static readonly HeatFluxUnit HectocubicMeter = new HeatFluxUnit(PreFix.hecto, CubicMeter);
        public static readonly HeatFluxUnit KilocubicMeter = new HeatFluxUnit(PreFix.kilo, CubicMeter);



        public HeatFluxUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public HeatFluxUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public HeatFluxUnit(PreFix SI, HeatFluxUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public HeatFluxUnit(HeatFluxUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}