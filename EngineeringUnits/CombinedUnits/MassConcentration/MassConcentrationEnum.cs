using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MassConcentrationUnit : Enumeration
    {

        public static readonly MassConcentrationUnit SI = new MassConcentrationUnit(LengthUnit.Meter);
        public static readonly MassConcentrationUnit CubicMeter = new MassConcentrationUnit(LengthUnit.Meter);
        public static readonly MassConcentrationUnit HectocubicMeter = new MassConcentrationUnit(PreFix.hecto, CubicMeter);
        public static readonly MassConcentrationUnit KilocubicMeter = new MassConcentrationUnit(PreFix.kilo, CubicMeter);



        public MassConcentrationUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public MassConcentrationUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public MassConcentrationUnit(PreFix SI, MassConcentrationUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public MassConcentrationUnit(MassConcentrationUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}