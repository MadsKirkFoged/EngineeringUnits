using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class PermeabilityUnit : UnitEnumbase
    {

        public static readonly PermeabilityUnit SI = new(ElectricInductanceUnit.SI, LengthUnit.SI);
        public static readonly PermeabilityUnit HenryPerMeter = new(ElectricInductanceUnit.Henry, LengthUnit.Meter);




        public PermeabilityUnit(ElectricInductanceUnit electricInductance, LengthUnit Length)
        {
            Unit = new UnitSystem(electricInductance / Length, 
                               $"{electricInductance}/{Length}");
        }

      

    }




}