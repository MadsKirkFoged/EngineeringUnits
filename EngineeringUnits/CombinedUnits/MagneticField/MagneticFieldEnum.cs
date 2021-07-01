using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MagneticFieldUnit : Enumeration
    {

        public static readonly MagneticFieldUnit SI = new MagneticFieldUnit(LengthUnit.Meter);
        public static readonly MagneticFieldUnit CubicMeter = new MagneticFieldUnit(LengthUnit.Meter);
        public static readonly MagneticFieldUnit HectocubicMeter = new MagneticFieldUnit(PreFix.hecto, CubicMeter);
        public static readonly MagneticFieldUnit KilocubicMeter = new MagneticFieldUnit(PreFix.kilo, CubicMeter);



        public MagneticFieldUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MagneticFieldUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MagneticFieldUnit(PreFix SI, MagneticFieldUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MagneticFieldUnit(MagneticFieldUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}