using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class EntropyUnit : Enumeration
    {

        public static readonly EntropyUnit SI = new EntropyUnit(EnergyUnit.Joule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit JoulePerKelvin = new EntropyUnit(EnergyUnit.Joule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit CaloriePerKelvin =            new EntropyUnit(EnergyUnit.Calorie, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit JoulePerDegreeCelsius =       new EntropyUnit(EnergyUnit.Joule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit KilocaloriePerKelvin =        new EntropyUnit(EnergyUnit.Kilocalorie, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit KilojoulePerDegreeCelsius =   new EntropyUnit(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit KilojoulePerKelvin =          new EntropyUnit(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit MegajoulePerKelvin =          new EntropyUnit(EnergyUnit.Megajoule, TemperatureUnit.Kelvin);


        public EntropyUnit(EnergyUnit energy, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy / temperature;
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/{temperature}");
        }

    }




}