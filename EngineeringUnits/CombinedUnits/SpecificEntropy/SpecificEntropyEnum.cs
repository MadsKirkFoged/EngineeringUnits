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

        //used to remember the inputs
        private EnergyUnit localenergy;
        private MassUnit localmass;

        public static SpecificEntropyUnit SI = new SpecificEntropyUnit(EnergyUnit.SI, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit JoulePerKilogramKelvin = new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit JoulePerKilogramDegreeCelsius = new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);

        public static SpecificEntropyUnit KilojoulePerKilogramDegreeCelsius = new SpecificEntropyUnit(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit KilojoulePerKilogramKelvin = new SpecificEntropyUnit(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);

        public static SpecificEntropyUnit MegajoulePerKilogramDegreeCelsius = new SpecificEntropyUnit(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
        public static SpecificEntropyUnit MegajoulePerKilogramKelvin = new SpecificEntropyUnit(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);

        public static SpecificEntropyUnit JoulePerKilogramRankine = new SpecificEntropyUnit(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.DegreeRankine);

        public static SpecificEntropyUnit CaloriePerGramKelvin = new SpecificEntropyUnit(EnergyUnit.Calorie, MassUnit.Gram, TemperatureUnit.Kelvin);
        public static SpecificEntropyUnit KilocaloriePerGramKelvin = new SpecificEntropyUnit(EnergyUnit.Kilocalorie, MassUnit.Gram, TemperatureUnit.Kelvin);

        public static SpecificEntropyUnit BtuPerPoundKelvin = new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.Kelvin);
        public static SpecificEntropyUnit BtuPerPoundRankine = new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);
        public static SpecificEntropyUnit BtuPerPoundFahrenheit = new SpecificEntropyUnit(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);


        public SpecificEntropyUnit(EnergyUnit energy, MassUnit mass, TemperatureUnit temperature)
        {
            Name = "Specific Heat Capacity";

            //    J/(kg*k)
            Unit = energy.Unit / (mass.Unit * temperature.Unit);
            Unit.Symbol = $"{energy}/{mass}*{temperature}";

            localenergy = energy;
            localmass = mass;

            //EkstraCorrection *= 

        }

        public SpecificEntropyUnit()
        {

        }


        public static IEnumerable<SpecificEntropyUnit> List()
        {
            return new[] { BtuPerPoundFahrenheit, CaloriePerGramKelvin, JoulePerKilogramDegreeCelsius, JoulePerKilogramKelvin, KilocaloriePerGramKelvin, KilojoulePerKilogramDegreeCelsius, KilojoulePerKilogramKelvin, MegajoulePerKilogramDegreeCelsius, MegajoulePerKilogramKelvin, };
        }

        //public override string ToString()
        //{
        //    return $"{localenergy}/{localmass}*{temperature.Unit}";
        //}

    }



}