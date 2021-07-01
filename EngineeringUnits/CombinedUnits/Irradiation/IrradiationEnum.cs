using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class IrradiationUnit : Enumeration
    {

        public static readonly IrradiationUnit SI = new IrradiationUnit(LengthUnit.Meter);
        public static readonly IrradiationUnit CubicMeter = new IrradiationUnit(LengthUnit.Meter);
        public static readonly IrradiationUnit HectocubicMeter = new IrradiationUnit(PreFix.hecto, CubicMeter);
        public static readonly IrradiationUnit KilocubicMeter = new IrradiationUnit(PreFix.kilo, CubicMeter);



        public IrradiationUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public IrradiationUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public IrradiationUnit(PreFix SI, IrradiationUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public IrradiationUnit(IrradiationUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}