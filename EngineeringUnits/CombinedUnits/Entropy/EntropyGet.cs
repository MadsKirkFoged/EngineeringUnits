using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Entropy
    {

        /// <summary>
        ///     Get Entropy in CaloriesPerKelvin.
        /// </summary>
        public double CaloriesPerKelvin => As(EntropyUnit.CaloriePerKelvin);

        /// <summary>
        ///     Get Entropy in JoulesPerDegreeCelsius.
        /// </summary>
        public double JoulesPerDegreeCelsius => As(EntropyUnit.JoulePerDegreeCelsius);

        /// <summary>
        ///     Get Entropy in JoulesPerKelvin.
        /// </summary>
        public double JoulesPerKelvin => As(EntropyUnit.JoulePerKelvin);

        /// <summary>
        ///     Get Entropy in KilocaloriesPerKelvin.
        /// </summary>
        public double KilocaloriesPerKelvin => As(EntropyUnit.KilocaloriePerKelvin);

        /// <summary>
        ///     Get Entropy in KilojoulesPerDegreeCelsius.
        /// </summary>
        public double KilojoulesPerDegreeCelsius => As(EntropyUnit.KilojoulePerDegreeCelsius);

        /// <summary>
        ///     Get Entropy in KilojoulesPerKelvin.
        /// </summary>
        public double KilojoulesPerKelvin => As(EntropyUnit.KilojoulePerKelvin);

        /// <summary>
        ///     Get Entropy in MegajoulesPerKelvin.
        /// </summary>
        public double MegajoulesPerKelvin => As(EntropyUnit.MegajoulePerKelvin);
    }
}
