using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public record SpecificHeatCapacityUnit : UnitTypebase
    {

        public static readonly SpecificHeatCapacityUnit SI =                                  new(EnergyUnit.SI, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificHeatCapacityUnit JoulePerKilogramKelvin =              new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificHeatCapacityUnit JoulePerKilogramDegreeCelsius =       new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificHeatCapacityUnit KilojoulePerKilogramDegreeCelsius =   new(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificHeatCapacityUnit KilojoulePerKilogramKelvin =          new(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificHeatCapacityUnit MegajoulePerKilogramDegreeCelsius =   new(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificHeatCapacityUnit MegajoulePerKilogramKelvin =          new(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificHeatCapacityUnit JoulePerKilogramRankine =             new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.DegreeRankine);
        public static readonly SpecificHeatCapacityUnit CaloriePerGramKelvin =                new(EnergyUnit.Calorie, MassUnit.Gram, TemperatureUnit.Kelvin);
        public static readonly SpecificHeatCapacityUnit KilocaloriePerGramKelvin =            new(EnergyUnit.Kilocalorie, MassUnit.Gram, TemperatureUnit.Kelvin);
        public static readonly SpecificHeatCapacityUnit BtuPerPoundKelvin =                   new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.Kelvin);
        public static readonly SpecificHeatCapacityUnit BtuPerPoundRankine =                  new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);
        public static readonly SpecificHeatCapacityUnit BtuPerPoundFahrenheit =               new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);


        public SpecificHeatCapacityUnit(EnergyUnit energy, MassUnit mass, TemperatureUnit temperature)
        {
            Unit = new UnitSystem(energy /(mass * temperature), 
                               $"{energy}/{mass}·{temperature}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }
    }



}