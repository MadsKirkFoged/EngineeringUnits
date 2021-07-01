using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PowerDensityUnit : Enumeration
    {

        public static readonly PowerDensityUnit SI = new PowerDensityUnit(LengthUnit.Meter);
        public static readonly PowerDensityUnit CubicMeter = new PowerDensityUnit(LengthUnit.Meter);
        public static readonly PowerDensityUnit HectocubicMeter = new PowerDensityUnit(PreFix.hecto, CubicMeter);
        public static readonly PowerDensityUnit KilocubicMeter = new PowerDensityUnit(PreFix.kilo, CubicMeter);



        public PowerDensityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public PowerDensityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public PowerDensityUnit(PreFix SI, PowerDensityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public PowerDensityUnit(PowerDensityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}