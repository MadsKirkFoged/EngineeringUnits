using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class BrakeSpecificFuelConsumptionUnit : Enumeration
    {

        public static readonly BrakeSpecificFuelConsumptionUnit SI = new BrakeSpecificFuelConsumptionUnit(MassUnit.Kilogram, EnergyUnit.Joule);
        public static readonly BrakeSpecificFuelConsumptionUnit KilogramPerJoule = new BrakeSpecificFuelConsumptionUnit(MassUnit.Kilogram, EnergyUnit.Joule);
        public static readonly BrakeSpecificFuelConsumptionUnit GramPerKiloWattHour = new BrakeSpecificFuelConsumptionUnit(MassUnit.Gram, EnergyUnit.KilowattHour);       
        public static readonly BrakeSpecificFuelConsumptionUnit PoundPerMechanicalHorsepowerHour = new BrakeSpecificFuelConsumptionUnit(MassUnit.Pound, PowerUnit.MechanicalHorsepower, DurationUnit.Hour, "lb/hph");




        public BrakeSpecificFuelConsumptionUnit(MassUnit mass, EnergyUnit energy, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass.Unit / energy.Unit;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{energy}");
        }

        public BrakeSpecificFuelConsumptionUnit(MassUnit mass, PowerUnit power, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass.Unit / (power.Unit * duration.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{power}*{duration}");
        }

      

    }




}