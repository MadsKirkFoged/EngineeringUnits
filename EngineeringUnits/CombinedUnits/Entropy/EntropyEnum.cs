using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record EntropyUnit : UnitTypebase
    {

        public static readonly EntropyUnit SI =                          new(EnergyUnit.SI, TemperatureUnit.SI);
        public static readonly EntropyUnit JoulePerKelvin =              new(EnergyUnit.Joule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit CaloriePerKelvin =            new(EnergyUnit.Calorie, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit JoulePerDegreeCelsius =       new(EnergyUnit.Joule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit KilocaloriePerKelvin =        new(EnergyUnit.Kilocalorie, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit KilojoulePerDegreeCelsius =   new(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit KilojoulePerKelvin =          new(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);
        public static readonly EntropyUnit MegajoulePerKelvin =          new(EnergyUnit.Megajoule, TemperatureUnit.Kelvin);


        public EntropyUnit(EnergyUnit energy, TemperatureUnit temperature)
        {
            Unit = new UnitSystem(energy / temperature, 
                               $"{energy}/{temperature}");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }
    }




}