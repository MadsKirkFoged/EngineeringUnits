using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class ElectricFieldUnit : UnitEnumbase
    {

        public static readonly ElectricFieldUnit SI = new(ElectricPotentialUnit.SI, LengthUnit.SI);
        public static readonly ElectricFieldUnit VoltPerMeter = new(ElectricPotentialUnit.Volt, LengthUnit.Meter);




        public ElectricFieldUnit(ElectricPotentialUnit electricPotential, LengthUnit Length)
        {
            Unit = new UnitSystem(electricPotential / Length, 
                               $"{electricPotential}/{Length}");
        }


       

    }




}