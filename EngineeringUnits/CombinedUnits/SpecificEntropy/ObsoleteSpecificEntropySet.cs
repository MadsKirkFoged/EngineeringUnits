using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

public partial class SpecificEntropy
{
    /// <summary>
    ///     Get from SI Unit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    //public static SpecificEntropy FromSI(double si)
    //{
    //    double value = (double)si;
    //    return new SpecificEntropy(value, SpecificEntropyUnit.SI);
    //}

    /// <summary>
    ///     Get SpecificEntropy from BtusPerPoundFahrenheit.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromBtusPerPoundFahrenheit->FromBtuPerPoundFahrenheit")]
    public static SpecificEntropy FromBtusPerPoundFahrenheit(double btusperpoundfahrenheit)
    {
        var value = (double)btusperpoundfahrenheit;
        return new SpecificEntropy(value, SpecificEntropyUnit.BtuPerPoundFahrenheit);
    }
    /// <summary>
    ///     Get SpecificEntropy from CaloriesPerGramKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromCaloriesPerGramKelvin->FromCaloriePerGramKelvin")]
    public static SpecificEntropy FromCaloriesPerGramKelvin(double caloriespergramkelvin)
    {
        var value = (double)caloriespergramkelvin;
        return new SpecificEntropy(value, SpecificEntropyUnit.CaloriePerGramKelvin);
    }
    /// <summary>
    ///     Get SpecificEntropy from JoulesPerKilogramDegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerKilogramDegreeCelsius->FromJoulePerKilogramDegreeCelsius")]
    public static SpecificEntropy FromJoulesPerKilogramDegreeCelsius(double joulesperkilogramdegreecelsius)
    {
        var value = (double)joulesperkilogramdegreecelsius;
        return new SpecificEntropy(value, SpecificEntropyUnit.JoulePerKilogramDegreeCelsius);
    }
    /// <summary>
    ///     Get SpecificEntropy from JoulesPerKilogramKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromJoulesPerKilogramKelvin->FromJoulePerKilogramKelvin")]
    public static SpecificEntropy FromJoulesPerKilogramKelvin(double joulesperkilogramkelvin)
    {
        var value = (double)joulesperkilogramkelvin;
        return new SpecificEntropy(value, SpecificEntropyUnit.JoulePerKilogramKelvin);
    }
    /// <summary>
    ///     Get SpecificEntropy from KilocaloriesPerGramKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilocaloriesPerGramKelvin->FromKilocaloriePerGramKelvin")]
    public static SpecificEntropy FromKilocaloriesPerGramKelvin(double kilocaloriespergramkelvin)
    {
        var value = (double)kilocaloriespergramkelvin;
        return new SpecificEntropy(value, SpecificEntropyUnit.KilocaloriePerGramKelvin);
    }
    /// <summary>
    ///     Get SpecificEntropy from KilojoulesPerKilogramDegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerKilogramDegreeCelsius->FromKilojoulePerKilogramDegreeCelsius")]
    public static SpecificEntropy FromKilojoulesPerKilogramDegreeCelsius(double kilojoulesperkilogramdegreecelsius)
    {
        var value = (double)kilojoulesperkilogramdegreecelsius;
        return new SpecificEntropy(value, SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius);
    }
    /// <summary>
    ///     Get SpecificEntropy from KilojoulesPerKilogramKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromKilojoulesPerKilogramKelvin->FromKilojoulePerKilogramKelvin")]
    public static SpecificEntropy FromKilojoulesPerKilogramKelvin(double kilojoulesperkilogramkelvin)
    {
        var value = (double)kilojoulesperkilogramkelvin;
        return new SpecificEntropy(value, SpecificEntropyUnit.KilojoulePerKilogramKelvin);
    }
    /// <summary>
    ///     Get SpecificEntropy from MegajoulesPerKilogramDegreeCelsius.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegajoulesPerKilogramDegreeCelsius->FromMegajoulePerKilogramDegreeCelsius")]
    public static SpecificEntropy FromMegajoulesPerKilogramDegreeCelsius(double megajoulesperkilogramdegreecelsius)
    {
        var value = (double)megajoulesperkilogramdegreecelsius;
        return new SpecificEntropy(value, SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius);
    }
    /// <summary>
    ///     Get SpecificEntropy from MegajoulesPerKilogramKelvin.
    /// </summary>
    /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
    [Obsolete("Use without the 's' - FromMegajoulesPerKilogramKelvin->FromMegajoulePerKilogramKelvin")]
    public static SpecificEntropy FromMegajoulesPerKilogramKelvin(double megajoulesperkilogramkelvin)
    {
        var value = (double)megajoulesperkilogramkelvin;
        return new SpecificEntropy(value, SpecificEntropyUnit.MegajoulePerKilogramKelvin);
    }
}
