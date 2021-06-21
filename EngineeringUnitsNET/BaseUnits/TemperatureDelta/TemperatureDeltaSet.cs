using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class TemperatureDelta
    {
        /// <summary>
        ///     Get TemperatureDelta from DegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesCelsius(double degreescelsius)
        {
            double value = (double)degreescelsius;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeCelsius);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesDelisle.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static TemperatureDelta FromDegreesDelisle(double degreesdelisle)
        //{
        //    double value = (double)degreesdelisle;
        //    return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeDelisle);
        //}
        /// <summary>
        ///     Get TemperatureDelta from DegreesFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesFahrenheit(double degreesfahrenheit)
        {
            double value = (double)degreesfahrenheit;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeFahrenheit);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesNewton.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static TemperatureDelta FromDegreesNewton(double degreesnewton)
        //{
        //    double value = (double)degreesnewton;
        //    return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeNewton);
        //}
        /// <summary>
        ///     Get TemperatureDelta from DegreesRankine.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromDegreesRankine(double degreesrankine)
        {
            double value = (double)degreesrankine;
            return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeRankine);
        }
        /// <summary>
        ///     Get TemperatureDelta from DegreesReaumur.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static TemperatureDelta FromDegreesReaumur(double degreesreaumur)
        //{
        //    double value = (double)degreesreaumur;
        //    return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeReaumur);
        //}
        /// <summary>
        ///     Get TemperatureDelta from DegreesRoemer.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static TemperatureDelta FromDegreesRoemer(double degreesroemer)
        //{
        //    double value = (double)degreesroemer;
        //    return new TemperatureDelta(value, TemperatureDeltaUnit.DegreeRoemer);
        //}
        /// <summary>
        ///     Get TemperatureDelta from Kelvins.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static TemperatureDelta FromKelvins(double kelvins)
        {
            double value = (double)kelvins;
            return new TemperatureDelta(value, TemperatureDeltaUnit.Kelvin);
        }
        /// <summary>
        ///     Get TemperatureDelta from MillidegreesCelsius.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static TemperatureDelta FromMillidegreesCelsius(double millidegreescelsius)
        //{
        //    double value = (double)millidegreescelsius;
        //    return new TemperatureDelta(value, TemperatureDeltaUnit.MillidegreeCelsius);
        //}
        /// <summary>
        ///     Get TemperatureDelta from SolarTemperatureDeltas.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static TemperatureDelta FromSolarTemperatureDeltas(double solarTemperatureDeltas)
        //{
        //    double value = (double)solarTemperatureDeltas;
        //    return new TemperatureDelta(value, TemperatureDeltaUnit.SolarTemperatureDelta);
        //}

    }
}
