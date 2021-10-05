using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class PermittivityUnit : Enumeration
    {

        public static readonly PermittivityUnit SI = new(CapacitanceUnit.SI, LengthUnit.SI);
        public static readonly PermittivityUnit FaradPerMeter = new(CapacitanceUnit.Farad, LengthUnit.Meter);




        public PermittivityUnit(CapacitanceUnit capacitance,LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = capacitance / Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{capacitance}/{Length}");
        }


    }




}