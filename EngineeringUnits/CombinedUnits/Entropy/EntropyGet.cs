
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class Entropy
    {

 

            /// <summary>
            ///     Get Entropy in SI.
            /// </summary>
            public double SI => As(EntropyUnit.SI);
            /// <summary>
            ///     Get Entropy in JoulePerKelvin.
            /// </summary>
            public double JoulePerKelvin => As(EntropyUnit.JoulePerKelvin);
            /// <summary>
            ///     Get Entropy in CaloriePerKelvin.
            /// </summary>
            public double CaloriePerKelvin => As(EntropyUnit.CaloriePerKelvin);
            /// <summary>
            ///     Get Entropy in JoulePerDegreeCelsius.
            /// </summary>
            public double JoulePerDegreeCelsius => As(EntropyUnit.JoulePerDegreeCelsius);
            /// <summary>
            ///     Get Entropy in KilocaloriePerKelvin.
            /// </summary>
            public double KilocaloriePerKelvin => As(EntropyUnit.KilocaloriePerKelvin);
            /// <summary>
            ///     Get Entropy in KilojoulePerDegreeCelsius.
            /// </summary>
            public double KilojoulePerDegreeCelsius => As(EntropyUnit.KilojoulePerDegreeCelsius);
            /// <summary>
            ///     Get Entropy in KilojoulePerKelvin.
            /// </summary>
            public double KilojoulePerKelvin => As(EntropyUnit.KilojoulePerKelvin);
            /// <summary>
            ///     Get Entropy in MegajoulePerKelvin.
            /// </summary>
            public double MegajoulePerKelvin => As(EntropyUnit.MegajoulePerKelvin);
    }
}


