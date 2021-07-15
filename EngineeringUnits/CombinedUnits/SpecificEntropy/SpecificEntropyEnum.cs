using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits.Units
{



    public class SpecificEntropyUnit : Enumeration
    {

        public static readonly SpecificEntropyUnit SI =                                  new SpecificEntropyUnit(EnergyUnit.SI, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificEntropyUnit JoulePerKilogramKelvin =              new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificEntropyUnit JoulePerKilogramDegreeCelsius =       new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificEntropyUnit KilojoulePerKilogramDegreeCelsius =   new SpecificEntropyUnit(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificEntropyUnit KilojoulePerKilogramKelvin =          new SpecificEntropyUnit(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificEntropyUnit MegajoulePerKilogramDegreeCelsius =   new SpecificEntropyUnit(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificEntropyUnit MegajoulePerKilogramKelvin =          new SpecificEntropyUnit(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
        public static readonly SpecificEntropyUnit JoulePerKilogramRankine =             new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.DegreeRankine);
        public static readonly SpecificEntropyUnit CaloriePerGramKelvin =                new SpecificEntropyUnit(EnergyUnit.Calorie, MassUnit.Gram, TemperatureUnit.Kelvin);
        public static readonly SpecificEntropyUnit KilocaloriePerGramKelvin =            new SpecificEntropyUnit(EnergyUnit.Kilocalorie, MassUnit.Gram, TemperatureUnit.Kelvin);
        public static readonly SpecificEntropyUnit BtuPerPoundKelvin =                   new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.Kelvin);
        public static readonly SpecificEntropyUnit BtuPerPoundRankine =                  new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);
        public static readonly SpecificEntropyUnit BtuPerPoundFahrenheit =               new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);


        public SpecificEntropyUnit(EnergyUnit energy, MassUnit mass, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy / (mass * temperature);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{mass}*{temperature}");
        }
    }



}