using EngineeringUnits.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class TemperatureDelta
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromSI(double si)
        {
            double value = (double)si;
            return new TemperatureDelta(value, TemperatureUnit.SI);
        }

        /// <summary>
        ///     Get Temperature from DegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromDegreesCelsius(double degreescelsius)
        {
            double value = (double)degreescelsius;
            return new TemperatureDelta(value, TemperatureUnit.DegreeCelsius);
        }
        /// <summary>
        ///     Get Temperature from DegreesDelisle.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromDegreesDelisle(double degreesdelisle)
        {
            double value = (double)degreesdelisle;
            return new TemperatureDelta(value, TemperatureUnit.SI);
        }
        /// <summary>
        ///     Get Temperature from DegreesFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>

        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromDegreesFahrenheit(double degreesfahrenheit)
        {
            double value = (double)degreesfahrenheit;
            return new TemperatureDelta(value, TemperatureUnit.DegreeFahrenheit);
        }

        /// <summary>
        ///     Get Temperature from DegreesNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        /// 
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromDegreesNewton(double degreesnewton)
        {
            double value = (double)degreesnewton;
            return new TemperatureDelta(value, TemperatureUnit.SI);
        }
        /// <summary>
        ///     Get Temperature from DegreesRankine.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromDegreesRankine(double degreesrankine)
        {
            double value = (double)degreesrankine;
            return new TemperatureDelta(value, TemperatureUnit.DegreeRankine);
        }
        /// <summary>
        ///     Get Temperature from DegreesReaumur.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>

        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromDegreesReaumur(double degreesreaumur)
        {
            double value = (double)degreesreaumur;
            return new TemperatureDelta(value, TemperatureUnit.SI);
        }
        /// <summary>
        ///     Get Temperature from DegreesRoemer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        /// 
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromDegreesRoemer(double degreesroemer)
        {
            double value = (double)degreesroemer;
            return new TemperatureDelta(value, TemperatureUnit.SI);
        }
        /// <summary>
        ///     Get Temperature from Kelvins.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromKelvins(double kelvins)
        {
            double value = (double)kelvins;
            return new TemperatureDelta(value, TemperatureUnit.Kelvin);
        }
        /// <summary>
        ///     Get Temperature from MillidegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromMillidegreesCelsius(double millidegreescelsius)
        {
            double value = (double)millidegreescelsius;
            return new TemperatureDelta(value, TemperatureUnit.SI);
        }
        /// <summary>
        ///     Get Temperature from SolarTemperatures.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
        public static TemperatureDelta FromSolarTemperatures(double solartemperatures)
        {
            double value = (double)solartemperatures;
            return new TemperatureDelta(value, TemperatureUnit.SI);
        }

    }
}
