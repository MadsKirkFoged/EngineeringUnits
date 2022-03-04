using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class SpecificEntropy
    {
        /// <summary>
        ///     Get SpecificEntropy in BtusPerPoundFahrenheit.
        /// </summary>
        [Obsolete("Use without the 's' - BtusPerPoundFahrenheit->BtuPerPoundFahrenheit")]
        public double BtusPerPoundFahrenheit => As(SpecificEntropyUnit.BtuPerPoundFahrenheit);

        /// <summary>
        ///     Get SpecificEntropy in CaloriesPerGramKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - CaloriesPerGramKelvin->CaloriePerGramKelvin")]
        public double CaloriesPerGramKelvin => As(SpecificEntropyUnit.CaloriePerGramKelvin);

        /// <summary>
        ///     Get SpecificEntropy in JoulesPerKilogramDegreeCelsius.
        /// </summary>
        [Obsolete("Use without the 's' - JoulesPerKilogramDegreeCelsius->JoulePerKilogramDegreeCelsius")]
        public double JoulesPerKilogramDegreeCelsius => As(SpecificEntropyUnit.JoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Get SpecificEntropy in JoulesPerKilogramKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - JoulesPerKilogramKelvin->JoulePerKilogramKelvin")]
        public double JoulesPerKilogramKelvin => As(SpecificEntropyUnit.JoulePerKilogramKelvin);

        /// <summary>
        ///     Get SpecificEntropy in SI unit (JoulesPerKilogramKelvin).
        /// </summary>
        //public double SI => As(SpecificEntropyUnit.SI);

        /// <summary>
        ///     Get SpecificEntropy in KilocaloriesPerGramKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - KilocaloriesPerGramKelvin->KilocaloriePerGramKelvin")]
        public double KilocaloriesPerGramKelvin => As(SpecificEntropyUnit.KilocaloriePerGramKelvin);

        /// <summary>
        ///     Get SpecificEntropy in KilojoulesPerKilogramDegreeCelsius.
        /// </summary>
        [Obsolete("Use without the 's' - KilojoulesPerKilogramDegreeCelsius->KilojoulePerKilogramDegreeCelsius")]
        public double KilojoulesPerKilogramDegreeCelsius => As(SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Get SpecificEntropy in KilojoulesPerKilogramKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - KilojoulesPerKilogramKelvin->KilojoulePerKilogramKelvin")]
        public double KilojoulesPerKilogramKelvin => As(SpecificEntropyUnit.KilojoulePerKilogramKelvin);

        /// <summary>
        ///     Get SpecificEntropy in MegajoulesPerKilogramDegreeCelsius.
        /// </summary>
        [Obsolete("Use without the 's' - MegajoulesPerKilogramDegreeCelsius->MegajoulePerKilogramDegreeCelsius")]
        public double MegajoulesPerKilogramDegreeCelsius => As(SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius);

        /// <summary>
        ///     Get SpecificEntropy in MegajoulesPerKilogramKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - MegajoulesPerKilogramKelvin->MegajoulePerKilogramKelvin")]
        public double MegajoulesPerKilogramKelvin => As(SpecificEntropyUnit.MegajoulePerKilogramKelvin);

    }
}
