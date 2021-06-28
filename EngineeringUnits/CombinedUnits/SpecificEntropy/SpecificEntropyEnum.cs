using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EngineeringUnits
{



    public class SpecificEntropyUnit : Enumeration
    {

        public static SpecificEntropyUnit SI =                                  new SpecificEntropyUnit(EnergyUnit.SI, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit JoulePerKilogramKelvin =              new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit JoulePerKilogramDegreeCelsius =       new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);

        public static SpecificEntropyUnit KilojoulePerKilogramDegreeCelsius =   new SpecificEntropyUnit(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit KilojoulePerKilogramKelvin =          new SpecificEntropyUnit(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);

        public static SpecificEntropyUnit MegajoulePerKilogramDegreeCelsius =   new SpecificEntropyUnit(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit MegajoulePerKilogramKelvin =          new SpecificEntropyUnit(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);

        public static SpecificEntropyUnit JoulePerKilogramRankine =             new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.DegreeRankine);

        public static SpecificEntropyUnit CaloriePerGramKelvin =                new SpecificEntropyUnit(EnergyUnit.Calorie, MassUnit.Gram, TemperatureUnit.Kelvin);
        public static SpecificEntropyUnit KilocaloriePerGramKelvin =            new SpecificEntropyUnit(EnergyUnit.Kilocalorie, MassUnit.Gram, TemperatureUnit.Kelvin);

        public static SpecificEntropyUnit BtuPerPoundKelvin =                   new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.Kelvin);
        public static SpecificEntropyUnit BtuPerPoundRankine =                  new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);
        public static SpecificEntropyUnit BtuPerPoundFahrenheit =               new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);


        public SpecificEntropyUnit(EnergyUnit energy, MassUnit mass, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy.Unit / (mass.Unit * temperature.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{mass}*{temperature}");
        }
    }



}