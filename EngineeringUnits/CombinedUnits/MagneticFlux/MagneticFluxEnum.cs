using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MagneticFluxUnit : Enumeration
    {

        public static readonly MagneticFluxUnit SI = new MagneticFluxUnit(LengthUnit.Meter);
        public static readonly MagneticFluxUnit CubicMeter = new MagneticFluxUnit(LengthUnit.Meter);
        public static readonly MagneticFluxUnit HectocubicMeter = new MagneticFluxUnit(PreFix.hecto, CubicMeter);
        public static readonly MagneticFluxUnit KilocubicMeter = new MagneticFluxUnit(PreFix.kilo, CubicMeter);



        public MagneticFluxUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MagneticFluxUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MagneticFluxUnit(PreFix SI, MagneticFluxUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MagneticFluxUnit(MagneticFluxUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}