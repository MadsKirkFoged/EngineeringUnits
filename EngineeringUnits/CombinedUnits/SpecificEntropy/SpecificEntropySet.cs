using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class SpecificEntropy
    {
        /// <summary>
        ///     Get SpecificEntropy from BtusPerPoundFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromBtusPerPoundFahrenheit(double btusperpoundfahrenheit)
        {
            double value = (double)btusperpoundfahrenheit;
            return new SpecificEntropy(value, SpecificEntropyUnit.BtuPerPoundFahrenheit);
        }
        /// <summary>
        ///     Get SpecificEntropy from CaloriesPerGramKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromCaloriesPerGramKelvin(double caloriespergramkelvin)
        {
            double value = (double)caloriespergramkelvin;
            return new SpecificEntropy(value, SpecificEntropyUnit.CaloriePerGramKelvin);
        }
        /// <summary>
        ///     Get SpecificEntropy from JoulesPerKilogramDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromJoulesPerKilogramDegreeCelsius(double joulesperkilogramdegreecelsius)
        {
            double value = (double)joulesperkilogramdegreecelsius;
            return new SpecificEntropy(value, SpecificEntropyUnit.JoulePerKilogramDegreeCelsius);
        }
        /// <summary>
        ///     Get SpecificEntropy from JoulesPerKilogramKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromJoulesPerKilogramKelvin(double joulesperkilogramkelvin)
        {
            double value = (double)joulesperkilogramkelvin;
            return new SpecificEntropy(value, SpecificEntropyUnit.JoulePerKilogramKelvin);
        }
        /// <summary>
        ///     Get SpecificEntropy from KilocaloriesPerGramKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromKilocaloriesPerGramKelvin(double kilocaloriespergramkelvin)
        {
            double value = (double)kilocaloriespergramkelvin;
            return new SpecificEntropy(value, SpecificEntropyUnit.KilocaloriePerGramKelvin);
        }
        /// <summary>
        ///     Get SpecificEntropy from KilojoulesPerKilogramDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromKilojoulesPerKilogramDegreeCelsius(double kilojoulesperkilogramdegreecelsius)
        {
            double value = (double)kilojoulesperkilogramdegreecelsius;
            return new SpecificEntropy(value, SpecificEntropyUnit.KilojoulePerKilogramDegreeCelsius);
        }
        /// <summary>
        ///     Get SpecificEntropy from KilojoulesPerKilogramKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromKilojoulesPerKilogramKelvin(double kilojoulesperkilogramkelvin)
        {
            double value = (double)kilojoulesperkilogramkelvin;
            return new SpecificEntropy(value, SpecificEntropyUnit.KilojoulePerKilogramKelvin);
        }
        /// <summary>
        ///     Get SpecificEntropy from MegajoulesPerKilogramDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromMegajoulesPerKilogramDegreeCelsius(double megajoulesperkilogramdegreecelsius)
        {
            double value = (double)megajoulesperkilogramdegreecelsius;
            return new SpecificEntropy(value, SpecificEntropyUnit.MegajoulePerKilogramDegreeCelsius);
        }
        /// <summary>
        ///     Get SpecificEntropy from MegajoulesPerKilogramKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificEntropy FromMegajoulesPerKilogramKelvin(double megajoulesperkilogramkelvin)
        {
            double value = (double)megajoulesperkilogramkelvin;
            return new SpecificEntropy(value, SpecificEntropyUnit.MegajoulePerKilogramKelvin);
        }

    }
}
