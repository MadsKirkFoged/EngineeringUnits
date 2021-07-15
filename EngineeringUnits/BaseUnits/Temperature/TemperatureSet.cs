using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Temperature
    {
        /// <summary>
        ///     Get Temperature from DegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesCelsius(double degreescelsius)
        {
            double value = (double)degreescelsius;
            return new Temperature(value, TemperatureUnit.DegreeCelsius);
        }
        /// <summary>
        ///     Get Temperature from DegreesDelisle.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Temperature FromDegreesDelisle(double degreesdelisle)
        //{
        //    double value = (double)degreesdelisle;
        //    return new Temperature(value, TemperatureUnit.DegreeDelisle);
        //}
        /// <summary>
        ///     Get Temperature from DegreesFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesFahrenheit(double degreesfahrenheit)
        {
            double value = (double)degreesfahrenheit;
            return new Temperature(value, TemperatureUnit.DegreeFahrenheit);
        }
        /// <summary>
        ///     Get Temperature from DegreesNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Temperature FromDegreesNewton(double degreesnewton)
        //{
        //    double value = (double)degreesnewton;
        //    return new Temperature(value, TemperatureUnit.DegreeNewton);
        //}
        /// <summary>
        ///     Get Temperature from DegreesRankine.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromDegreesRankine(double degreesrankine)
        {
            double value = (double)degreesrankine;
            return new Temperature(value, TemperatureUnit.DegreeRankine);
        }
        /// <summary>
        ///     Get Temperature from DegreesReaumur.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Temperature FromDegreesReaumur(double degreesreaumur)
        //{
        //    double value = (double)degreesreaumur;
        //    return new Temperature(value, TemperatureUnit.DegreeReaumur);
        //}
        /// <summary>
        ///     Get Temperature from DegreesRoemer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Temperature FromDegreesRoemer(double degreesroemer)
        //{
        //    double value = (double)degreesroemer;
        //    return new Temperature(value, TemperatureUnit.DegreeRoemer);
        //}
        /// <summary>
        ///     Get Temperature from Kelvins.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Temperature FromKelvins(double kelvins)
        {
            double value = (double)kelvins;
            return new Temperature(value, TemperatureUnit.Kelvin);
        }
        /// <summary>
        ///     Get Temperature from MillidegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Temperature FromMillidegreesCelsius(double millidegreescelsius)
        //{
        //    double value = (double)millidegreescelsius;
        //    return new Temperature(value, TemperatureUnit.MillidegreeCelsius);
        //}
        /// <summary>
        ///     Get Temperature from SolarTemperatures.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Temperature FromSolarTemperatures(double solartemperatures)
        //{
        //    double value = (double)solartemperatures;
        //    return new Temperature(value, TemperatureUnit.SolarTemperature);
        //}

    }
}
