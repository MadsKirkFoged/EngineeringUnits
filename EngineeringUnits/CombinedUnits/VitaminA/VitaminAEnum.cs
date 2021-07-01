using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class VitaminAUnit : Enumeration
    {

        public static readonly VitaminAUnit SI = new VitaminAUnit(LengthUnit.Meter);
        public static readonly VitaminAUnit CubicMeter = new VitaminAUnit(LengthUnit.Meter);
        public static readonly VitaminAUnit HectocubicMeter = new VitaminAUnit(PreFix.hecto, CubicMeter);
        public static readonly VitaminAUnit KilocubicMeter = new VitaminAUnit(PreFix.kilo, CubicMeter);



        public VitaminAUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public VitaminAUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public VitaminAUnit(PreFix SI, VitaminAUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public VitaminAUnit(VitaminAUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}