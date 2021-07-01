using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricInductanceUnit : Enumeration
    {

        public static readonly ElectricInductanceUnit SI = new ElectricInductanceUnit(LengthUnit.Meter);
        public static readonly ElectricInductanceUnit CubicMeter = new ElectricInductanceUnit(LengthUnit.Meter);
        public static readonly ElectricInductanceUnit HectocubicMeter = new ElectricInductanceUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricInductanceUnit KilocubicMeter = new ElectricInductanceUnit(PreFix.kilo, CubicMeter);



        public ElectricInductanceUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricInductanceUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricInductanceUnit(PreFix SI, ElectricInductanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricInductanceUnit(ElectricInductanceUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}