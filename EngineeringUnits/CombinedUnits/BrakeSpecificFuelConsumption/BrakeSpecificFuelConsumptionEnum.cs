using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record BrakeSpecificFuelConsumptionUnit : UnitTypebase
    {

        public static readonly BrakeSpecificFuelConsumptionUnit SI = new(MassUnit.SI, EnergyUnit.SI);
        public static readonly BrakeSpecificFuelConsumptionUnit KilogramPerJoule = new(MassUnit.Kilogram, EnergyUnit.Joule);
        public static readonly BrakeSpecificFuelConsumptionUnit GramPerKiloWattHour = new(MassUnit.Gram, EnergyUnit.KilowattHour);       
        public static readonly BrakeSpecificFuelConsumptionUnit PoundPerMechanicalHorsepowerHour = new(MassUnit.Pound, PowerUnit.MechanicalHorsepower, DurationUnit.Hour, "lb/hph");


        public BrakeSpecificFuelConsumptionUnit(MassUnit mass, EnergyUnit energy)
        {
            Unit = new UnitSystem(mass / energy, 
                               $"{mass}/{energy}");
        }

        public BrakeSpecificFuelConsumptionUnit(MassUnit mass, PowerUnit power, DurationUnit duration, string NewSymbol)
        {
            Unit = new UnitSystem(mass / (power * duration), NewSymbol);
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}