using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricConductivityUnit : Enumeration
    {

        public static readonly ElectricConductivityUnit SI = new ElectricConductivityUnit(LengthUnit.Meter);
        public static readonly ElectricConductivityUnit CubicMeter = new ElectricConductivityUnit(LengthUnit.Meter);
        public static readonly ElectricConductivityUnit HectocubicMeter = new ElectricConductivityUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricConductivityUnit KilocubicMeter = new ElectricConductivityUnit(PreFix.kilo, CubicMeter);



        public ElectricConductivityUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricConductivityUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricConductivityUnit(PreFix SI, ElectricConductivityUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricConductivityUnit(ElectricConductivityUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}