using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class PermeabilityUnit : Enumeration
    {

        public static readonly PermeabilityUnit SI = new(ElectricInductanceUnit.SI, LengthUnit.SI);
        public static readonly PermeabilityUnit HenryPerMeter = new(ElectricInductanceUnit.Henry, LengthUnit.Meter);




        public PermeabilityUnit(ElectricInductanceUnit electricInductance,LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricInductance / Length;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricInductance}/{Length}");
        }

      

    }




}