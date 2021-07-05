using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class ElectricFieldUnit : Enumeration
    {

        public static readonly ElectricFieldUnit SI = new ElectricFieldUnit(ElectricPotentialUnit.Volt, LengthUnit.Meter);
        public static readonly ElectricFieldUnit VoltPerMeter = new ElectricFieldUnit(ElectricPotentialUnit.Volt, LengthUnit.Meter);




        public ElectricFieldUnit(ElectricPotentialUnit electricPotential, LengthUnit Length, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = electricPotential.Unit / Length.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{electricPotential}/{Length}");
        }


       

    }




}