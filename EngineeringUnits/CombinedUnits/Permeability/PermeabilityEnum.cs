using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PermeabilityUnit : Enumeration
    {

        public static readonly PermeabilityUnit SI = new PermeabilityUnit(LengthUnit.Meter);
        public static readonly PermeabilityUnit CubicMeter = new PermeabilityUnit(LengthUnit.Meter);
        public static readonly PermeabilityUnit HectocubicMeter = new PermeabilityUnit(PreFix.hecto, CubicMeter);
        public static readonly PermeabilityUnit KilocubicMeter = new PermeabilityUnit(PreFix.kilo, CubicMeter);



        public PermeabilityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public PermeabilityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public PermeabilityUnit(PreFix SI, PermeabilityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public PermeabilityUnit(PermeabilityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}