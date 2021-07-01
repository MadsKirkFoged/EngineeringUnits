using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class InformationUnit : Enumeration
    {

        public static readonly InformationUnit SI = new InformationUnit(LengthUnit.Meter);
        public static readonly InformationUnit CubicMeter = new InformationUnit(LengthUnit.Meter);
        public static readonly InformationUnit HectocubicMeter = new InformationUnit(PreFix.hecto, CubicMeter);
        public static readonly InformationUnit KilocubicMeter = new InformationUnit(PreFix.kilo, CubicMeter);



        public InformationUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public InformationUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public InformationUnit(PreFix SI, InformationUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public InformationUnit(InformationUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}