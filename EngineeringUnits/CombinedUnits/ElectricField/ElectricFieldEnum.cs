﻿using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record ElectricFieldUnit : UnitTypebase
    {

        public static readonly ElectricFieldUnit SI = new(ElectricPotentialUnit.SI, LengthUnit.SI);
        public static readonly ElectricFieldUnit VoltPerMeter = new(ElectricPotentialUnit.Volt, LengthUnit.Meter);




        public ElectricFieldUnit(ElectricPotentialUnit electricPotential, LengthUnit Length)
        {
            Unit = new UnitSystem(electricPotential / Length, 
                               $"{electricPotential}/{Length}");
        }


        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}