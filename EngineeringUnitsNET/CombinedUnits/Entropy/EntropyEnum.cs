using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class EntropyUnit : Enumeration
    {

        public static EntropyUnit SI = new EntropyUnit(EnergyUnit.Joule, TemperatureUnit.Kelvin);
        public static EntropyUnit JoulePerKelvin = new EntropyUnit(EnergyUnit.Joule, TemperatureUnit.Kelvin);

        public static EntropyUnit CaloriePerKelvin = new EntropyUnit(EnergyUnit.Calorie, TemperatureUnit.Kelvin);
        public static EntropyUnit JoulePerDegreeCelsius = new EntropyUnit(EnergyUnit.Joule, TemperatureUnit.Kelvin);
        public static EntropyUnit KilocaloriePerKelvin = new EntropyUnit(EnergyUnit.Kilocalorie, TemperatureUnit.Kelvin);
        public static EntropyUnit KilojoulePerDegreeCelsius = new EntropyUnit(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);
        public static EntropyUnit KilojoulePerKelvin = new EntropyUnit(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);
        public static EntropyUnit MegajoulePerKelvin = new EntropyUnit(EnergyUnit.Megajoule, TemperatureUnit.Kelvin);


        public EntropyUnit(EnergyUnit energy, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {

            Name = "Entropyh";
            Unit = energy.Unit / temperature.Unit;

            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{temperature}");

        }



        public static IEnumerable<EntropyUnit> List()
        {
            return new[] { CaloriePerKelvin, JoulePerDegreeCelsius, JoulePerKelvin, KilocaloriePerKelvin, KilojoulePerDegreeCelsius, KilojoulePerKelvin, MegajoulePerKelvin, };
        }





    }




}