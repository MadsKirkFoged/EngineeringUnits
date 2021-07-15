using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricResistance
    {
        /// <summary>
        ///     Get ElectricResistance from Gigaohms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromGigaohms(double gigaohms)
        {
            double value = (double)gigaohms;
            return new ElectricResistance(value, ElectricResistanceUnit.Gigaohm);
        }
        /// <summary>
        ///     Get ElectricResistance from Kiloohms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromKiloohms(double kiloohms)
        {
            double value = (double)kiloohms;
            return new ElectricResistance(value, ElectricResistanceUnit.Kiloohm);
        }
        /// <summary>
        ///     Get ElectricResistance from Megaohms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromMegaohms(double megaohms)
        {
            double value = (double)megaohms;
            return new ElectricResistance(value, ElectricResistanceUnit.Megaohm);
        }
        /// <summary>
        ///     Get ElectricResistance from Microohms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromMicroohms(double microohms)
        {
            double value = (double)microohms;
            return new ElectricResistance(value, ElectricResistanceUnit.Microohm);
        }
        /// <summary>
        ///     Get ElectricResistance from Milliohms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromMilliohms(double milliohms)
        {
            double value = (double)milliohms;
            return new ElectricResistance(value, ElectricResistanceUnit.Milliohm);
        }
        /// <summary>
        ///     Get ElectricResistance from Ohms.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricResistance FromOhms(double ohms)
        {
            double value = (double)ohms;
            return new ElectricResistance(value, ElectricResistanceUnit.Ohm);
        }

    }
}
