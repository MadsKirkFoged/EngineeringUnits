using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class Entropy
{

    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static Entropy FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new Entropy(value, EntropyUnit.SI);
    //}

    /// <summary>
    ///     Get Entropy from CaloriesPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCaloriesPerKelvin->FromCaloriePerKelvin")]
    public static Entropy FromCaloriesPerKelvin(double caloriesperkelvin)
    {
        var value = (double)caloriesperkelvin;
        return new Entropy(value, EntropyUnit.CaloriePerKelvin);
    }
    /// <summary>
    ///     Get Entropy from JoulesPerDegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerDegreeCelsius->FromJoulePerDegreeCelsius")]
    public static Entropy FromJoulesPerDegreeCelsius(double joulesperdegreecelsius)
    {
        var value = (double)joulesperdegreecelsius;
        return new Entropy(value, EntropyUnit.JoulePerDegreeCelsius);
    }
    /// <summary>
    ///     Get Entropy from JoulesPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerKelvin->FromJoulePerKelvin")]
    public static Entropy FromJoulesPerKelvin(double joulesperkelvin)
    {
        var value = (double)joulesperkelvin;
        return new Entropy(value, EntropyUnit.JoulePerKelvin);
    }
    /// <summary>
    ///     Get Entropy from KilocaloriesPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilocaloriesPerKelvin->FromKilocaloriePerKelvin")]
    public static Entropy FromKilocaloriesPerKelvin(double kilocaloriesperkelvin)
    {
        var value = (double)kilocaloriesperkelvin;
        return new Entropy(value, EntropyUnit.KilocaloriePerKelvin);
    }
    /// <summary>
    ///     Get Entropy from KilojoulesPerDegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerDegreeCelsius->FromKilojoulePerDegreeCelsius")]
    public static Entropy FromKilojoulesPerDegreeCelsius(double kilojoulesperdegreecelsius)
    {
        var value = (double)kilojoulesperdegreecelsius;
        return new Entropy(value, EntropyUnit.KilojoulePerDegreeCelsius);
    }
    /// <summary>
    ///     Get Entropy from KilojoulesPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerKelvin->FromKilojoulePerKelvin")]
    public static Entropy FromKilojoulesPerKelvin(double kilojoulesperkelvin)
    {
        var value = (double)kilojoulesperkelvin;
        return new Entropy(value, EntropyUnit.KilojoulePerKelvin);
    }
    /// <summary>
    ///     Get Entropy from MegajoulesPerKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegajoulesPerKelvin->FromMegajoulePerKelvin")]
    public static Entropy FromMegajoulesPerKelvin(double megajoulesperkelvin)
    {
        var value = (double)megajoulesperkelvin;
        return new Entropy(value, EntropyUnit.MegajoulePerKelvin);
    }
}
