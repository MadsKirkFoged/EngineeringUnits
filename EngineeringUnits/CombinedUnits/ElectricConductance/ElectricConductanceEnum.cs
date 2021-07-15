using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricConductanceUnit : Enumeration
    {

        public static readonly ElectricConductanceUnit SI = new ElectricConductanceUnit(LengthUnit.Meter);
        public static readonly ElectricConductanceUnit CubicMeter = new ElectricConductanceUnit(LengthUnit.Meter);
        public static readonly ElectricConductanceUnit HectocubicMeter = new ElectricConductanceUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricConductanceUnit KilocubicMeter = new ElectricConductanceUnit(PreFix.kilo, CubicMeter);



        public ElectricConductanceUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Pow(3);
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricConductanceUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area * Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricConductanceUnit(PreFix SI, ElectricConductanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricConductanceUnit(ElectricConductanceUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}