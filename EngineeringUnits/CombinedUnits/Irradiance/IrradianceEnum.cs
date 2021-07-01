using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class IrradianceUnit : Enumeration
    {

        public static readonly IrradianceUnit SI = new IrradianceUnit(LengthUnit.Meter);
        public static readonly IrradianceUnit CubicMeter = new IrradianceUnit(LengthUnit.Meter);
        public static readonly IrradianceUnit HectocubicMeter = new IrradianceUnit(PreFix.hecto, CubicMeter);
        public static readonly IrradianceUnit KilocubicMeter = new IrradianceUnit(PreFix.kilo, CubicMeter);



        public IrradianceUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public IrradianceUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public IrradianceUnit(PreFix SI, IrradianceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public IrradianceUnit(IrradianceUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}