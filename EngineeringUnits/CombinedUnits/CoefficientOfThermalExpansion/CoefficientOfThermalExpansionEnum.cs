using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class CoefficientOfThermalExpansionUnit : Enumeration
    {

        public static readonly CoefficientOfThermalExpansionUnit SI = new CoefficientOfThermalExpansionUnit(LengthUnit.Meter);
        public static readonly CoefficientOfThermalExpansionUnit CubicMeter = new CoefficientOfThermalExpansionUnit(LengthUnit.Meter);
        public static readonly CoefficientOfThermalExpansionUnit HectocubicMeter = new CoefficientOfThermalExpansionUnit(PreFix.hecto, CubicMeter);
        public static readonly CoefficientOfThermalExpansionUnit KilocubicMeter = new CoefficientOfThermalExpansionUnit(PreFix.kilo, CubicMeter);



        public CoefficientOfThermalExpansionUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public CoefficientOfThermalExpansionUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public CoefficientOfThermalExpansionUnit(PreFix SI, CoefficientOfThermalExpansionUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public CoefficientOfThermalExpansionUnit(CoefficientOfThermalExpansionUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}