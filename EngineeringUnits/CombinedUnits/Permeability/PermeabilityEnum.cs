using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class PermeabilityUnit : Enumeration
    {

        public static readonly PermeabilityUnit SI = new PermeabilityUnit(ElectricInductanceUnit.Henry, LengthUnit.Meter);
        public static readonly PermeabilityUnit HenryPerMeter = new PermeabilityUnit(ElectricInductanceUnit.Henry, LengthUnit.Meter);




        public PermeabilityUnit(ElectricInductanceUnit electricInductance,LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricInductance.Unit / Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricInductance}/{Length}");
        }

      

    }




}