using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Entropy
{

    /// <summary>
    ///     Get Entropy in CaloriesPerKelvin.
    /// </summary>
    [Obsolete("Use without the 's' - CaloriesPerKelvin->CaloriePerKelvin")]
    public double CaloriesPerKelvin => As(EntropyUnit.CaloriePerKelvin);

    /// <summary>
    ///     Get Entropy in JoulesPerDegreeCelsius.
    /// </summary>
    [Obsolete("Use without the 's' - JoulesPerDegreeCelsius->JoulePerDegreeCelsius")]
    public double JoulesPerDegreeCelsius => As(EntropyUnit.JoulePerDegreeCelsius);

    /// <summary>
    ///     Get Entropy in JoulesPerKelvin.
    /// </summary>
    [Obsolete("Use without the 's' - JoulesPerKelvin->JoulePerKelvin")]
    public double JoulesPerKelvin => As(EntropyUnit.JoulePerKelvin);

    /// <summary>
    ///     Get Entropy in SI Unit (JoulesPerKelvin).
    /// </summary>
   // public double SI => As(EntropyUnit.SI);

    /// <summary>
    ///     Get Entropy in KilocaloriesPerKelvin.
    /// </summary>
    [Obsolete("Use without the 's' - KilocaloriesPerKelvin->KilocaloriePerKelvin")]
    public double KilocaloriesPerKelvin => As(EntropyUnit.KilocaloriePerKelvin);

    /// <summary>
    ///     Get Entropy in KilojoulesPerDegreeCelsius.
    /// </summary>
    [Obsolete("Use without the 's' - KilojoulesPerDegreeCelsius->KilojoulePerDegreeCelsius")]
    public double KilojoulesPerDegreeCelsius => As(EntropyUnit.KilojoulePerDegreeCelsius);

    /// <summary>
    ///     Get Entropy in KilojoulesPerKelvin.
    /// </summary>
    [Obsolete("Use without the 's' - KilojoulesPerKelvin->KilojoulePerKelvin")]
    public double KilojoulesPerKelvin => As(EntropyUnit.KilojoulePerKelvin);

    /// <summary>
    ///     Get Entropy in MegajoulesPerKelvin.
    /// </summary>
    [Obsolete("Use without the 's' - MegajoulesPerKelvin->MegajoulePerKelvin")]
    public double MegajoulesPerKelvin => As(EntropyUnit.MegajoulePerKelvin);
}
