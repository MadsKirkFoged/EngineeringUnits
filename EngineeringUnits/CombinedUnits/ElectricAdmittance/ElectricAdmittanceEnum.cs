using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricAdmittanceUnit : Enumeration
    {

        public static readonly ElectricAdmittanceUnit SI = new ElectricAdmittanceUnit(LengthUnit.Meter);
        public static readonly ElectricAdmittanceUnit CubicMeter = new ElectricAdmittanceUnit(LengthUnit.Meter);
        public static readonly ElectricAdmittanceUnit HectocubicMeter = new ElectricAdmittanceUnit(PreFix.hecto, CubicMeter);
        public static readonly ElectricAdmittanceUnit KilocubicMeter = new ElectricAdmittanceUnit(PreFix.kilo, CubicMeter);



        public ElectricAdmittanceUnit(LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Length.Unit * Length.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

        public ElectricAdmittanceUnit(AreaUnit Area, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = Area.Unit * Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{Area}-{Length}");
        }

        public ElectricAdmittanceUnit(PreFix SI, ElectricAdmittanceUnit unit)
        {
            Unit = unit.Unit.Copy();
            SetCombined(SI);
            SetNewSymbol(SI);
        }

        public ElectricAdmittanceUnit(ElectricAdmittanceUnit unit, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = unit.Unit.Copy();
            SetCombined(correction);
            SetNewSymbol(NewSymbol);
        }

    }




}