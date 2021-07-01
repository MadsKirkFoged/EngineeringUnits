using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MassFluxUnit : Enumeration
    {

        public static readonly MassFluxUnit SI = new MassFluxUnit(LengthUnit.Meter);
        public static readonly MassFluxUnit CubicMeter = new MassFluxUnit(LengthUnit.Meter);
        public static readonly MassFluxUnit HectocubicMeter = new MassFluxUnit(PreFix.hecto, CubicMeter);
        public static readonly MassFluxUnit KilocubicMeter = new MassFluxUnit(PreFix.kilo, CubicMeter);



        public MassFluxUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MassFluxUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MassFluxUnit(PreFix SI, MassFluxUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MassFluxUnit(MassFluxUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}