
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    //This class is auto-generated, changes to the file will be overwritten!
    public partial class Entropy
    {

 

        /// <summary>
        ///     Get Entropy from SI.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromSI(double? SI)
        {
            if (SI is null)
                return null;

            return new Entropy((double)SI, EntropyUnit.SI);
        }
        /// <summary>
        ///     Get Entropy from JoulePerKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromJoulePerKelvin(double? JoulePerKelvin)
        {
            if (JoulePerKelvin is null)
                return null;

            return new Entropy((double)JoulePerKelvin, EntropyUnit.JoulePerKelvin);
        }
        /// <summary>
        ///     Get Entropy from CaloriePerKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromCaloriePerKelvin(double? CaloriePerKelvin)
        {
            if (CaloriePerKelvin is null)
                return null;

            return new Entropy((double)CaloriePerKelvin, EntropyUnit.CaloriePerKelvin);
        }
        /// <summary>
        ///     Get Entropy from JoulePerDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromJoulePerDegreeCelsius(double? JoulePerDegreeCelsius)
        {
            if (JoulePerDegreeCelsius is null)
                return null;

            return new Entropy((double)JoulePerDegreeCelsius, EntropyUnit.JoulePerDegreeCelsius);
        }
        /// <summary>
        ///     Get Entropy from KilocaloriePerKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromKilocaloriePerKelvin(double? KilocaloriePerKelvin)
        {
            if (KilocaloriePerKelvin is null)
                return null;

            return new Entropy((double)KilocaloriePerKelvin, EntropyUnit.KilocaloriePerKelvin);
        }
        /// <summary>
        ///     Get Entropy from KilojoulePerDegreeCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromKilojoulePerDegreeCelsius(double? KilojoulePerDegreeCelsius)
        {
            if (KilojoulePerDegreeCelsius is null)
                return null;

            return new Entropy((double)KilojoulePerDegreeCelsius, EntropyUnit.KilojoulePerDegreeCelsius);
        }
        /// <summary>
        ///     Get Entropy from KilojoulePerKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromKilojoulePerKelvin(double? KilojoulePerKelvin)
        {
            if (KilojoulePerKelvin is null)
                return null;

            return new Entropy((double)KilojoulePerKelvin, EntropyUnit.KilojoulePerKelvin);
        }
        /// <summary>
        ///     Get Entropy from MegajoulePerKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Entropy FromMegajoulePerKelvin(double? MegajoulePerKelvin)
        {
            if (MegajoulePerKelvin is null)
                return null;

            return new Entropy((double)MegajoulePerKelvin, EntropyUnit.MegajoulePerKelvin);
        }
    }
}


