using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits
{


    public class MolarEntropyUnit : Enumeration
    {

        public static readonly MolarEntropyUnit SI = new MolarEntropyUnit(EnergyUnit.Joule, AmountOfSubstanceUnit.Mole, TemperatureUnit.Kelvin);
        public static readonly MolarEntropyUnit JoulePerMoleKelvin = new MolarEntropyUnit(EnergyUnit.Joule, AmountOfSubstanceUnit.Mole, TemperatureUnit.Kelvin);
        public static readonly MolarEntropyUnit KilojoulePerMoleKelvin = new MolarEntropyUnit(EnergyUnit.Kilojoule, AmountOfSubstanceUnit.Mole, TemperatureUnit.Kelvin);
        public static readonly MolarEntropyUnit MegajoulePerMoleKelvin = new MolarEntropyUnit(EnergyUnit.Megajoule, AmountOfSubstanceUnit.Mole, TemperatureUnit.Kelvin);


        public MolarEntropyUnit(EnergyUnit energy, AmountOfSubstanceUnit amountOfSubstance, TemperatureUnit temperature, string NewSymbol = "Empty", decimal correction = 1)
        {
            Unit = energy.Unit / (amountOfSubstance.Unit * temperature.Unit);
            SetCombined(correction);
            SetNewSymbol(NewSymbol, $"{energy}/({amountOfSubstance}*{temperature})");
        }

    

    }




}