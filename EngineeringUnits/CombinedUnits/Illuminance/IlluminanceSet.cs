using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Illuminance
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Illuminance FromSI(double si)
        {
            double value = (double)si;
            return new Illuminance(value, IlluminanceUnit.SI);
        }

        /// <summary>
        ///     Get Illuminance from Kilolux.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Illuminance FromKilolux(double kilolux)
        {
            double value = (double)kilolux;
            return new Illuminance(value, IlluminanceUnit.Kilolux);
        }
        /// <summary>
        ///     Get Illuminance from Lux.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Illuminance FromLux(double lux)
        {
            double value = (double)lux;
            return new Illuminance(value, IlluminanceUnit.Lux);
        }
        /// <summary>
        ///     Get Illuminance from Megalux.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Illuminance FromMegalux(double megalux)
        {
            double value = (double)megalux;
            return new Illuminance(value, IlluminanceUnit.Megalux);
        }
        /// <summary>
        ///     Get Illuminance from Millilux.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Illuminance FromMillilux(double millilux)
        {
            double value = (double)millilux;
            return new Illuminance(value, IlluminanceUnit.Millilux);
        }

    }
}
