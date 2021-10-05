using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public class BrakeSpecificFuelConsumptionUnit : Enumeration
    {

        public static readonly BrakeSpecificFuelConsumptionUnit SI = new(MassUnit.SI, EnergyUnit.SI);
        public static readonly BrakeSpecificFuelConsumptionUnit KilogramPerJoule = new(MassUnit.Kilogram, EnergyUnit.Joule);
        public static readonly BrakeSpecificFuelConsumptionUnit GramPerKiloWattHour = new(MassUnit.Gram, EnergyUnit.KilowattHour);       
        public static readonly BrakeSpecificFuelConsumptionUnit PoundPerMechanicalHorsepowerHour = new(MassUnit.Pound, PowerUnit.MechanicalHorsepower, DurationUnit.Hour, "lb/hph");




        public BrakeSpecificFuelConsumptionUnit(MassUnit mass, EnergyUnit energy, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / energy;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{energy}");
        }

        public BrakeSpecificFuelConsumptionUnit(MassUnit mass, PowerUnit power, DurationUnit duration, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = mass / (power * duration);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{mass}/{power}*{duration}");
        }

      

    }




}