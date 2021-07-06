using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MassFractionUnit : Enumeration
    {

        public static readonly MassFractionUnit SI = new MassFractionUnit(LengthUnit.Meter);
        public static readonly MassFractionUnit CubicMeter = new MassFractionUnit(LengthUnit.Meter);
        public static readonly MassFractionUnit HectocubicMeter = new MassFractionUnit(PreFix.hecto, CubicMeter);
        public static readonly MassFractionUnit KilocubicMeter = new MassFractionUnit(PreFix.kilo, CubicMeter);



        public MassFractionUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MassFractionUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MassFractionUnit(PreFix SI, MassFractionUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MassFractionUnit(MassFractionUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}