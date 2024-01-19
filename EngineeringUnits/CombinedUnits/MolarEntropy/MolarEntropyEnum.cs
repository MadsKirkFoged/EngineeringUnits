using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public partial record MolarEntropyUnit : UnitTypebase
    {

        public static readonly MolarEntropyUnit SI = new(EnergyUnit.SI, AmountOfSubstanceUnit.SI, TemperatureUnit.SI);
        public static readonly MolarEntropyUnit JoulePerMoleKelvin = new(EnergyUnit.Joule, AmountOfSubstanceUnit.Mole, TemperatureUnit.Kelvin);
        public static readonly MolarEntropyUnit KilojoulePerMoleKelvin = new(EnergyUnit.Kilojoule, AmountOfSubstanceUnit.Mole, TemperatureUnit.Kelvin);
        public static readonly MolarEntropyUnit MegajoulePerMoleKelvin = new(EnergyUnit.Megajoule, AmountOfSubstanceUnit.Mole, TemperatureUnit.Kelvin);


        public MolarEntropyUnit(EnergyUnit energy, AmountOfSubstanceUnit amountOfSubstance, TemperatureUnit temperature)
        {
            Unit = new UnitSystem( energy / (amountOfSubstance * temperature), 
                                $"{energy}/({amountOfSubstance}·{temperature})");
        }

        public override string ToString()
        {
            if (Unit.Symbol is not null)
                return $"{Unit.Symbol}";

            return $"{Unit}";
        }

    }




}