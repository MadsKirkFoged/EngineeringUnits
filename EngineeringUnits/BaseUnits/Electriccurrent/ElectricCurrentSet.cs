using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCurrent
    {
        /// <summary>
        ///     Get ElectricCurrent from Amperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromAmperes(double amperes)
        {
            double value = (double)amperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Ampere);
        }
        /// <summary>
        ///     Get ElectricCurrent from Centiamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromCentiamperes(double centiamperes)
        {
            double value = (double)centiamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Centiampere);
        }
        /// <summary>
        ///     Get ElectricCurrent from Kiloamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromKiloamperes(double kiloamperes)
        {
            double value = (double)kiloamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Kiloampere);
        }
        /// <summary>
        ///     Get ElectricCurrent from Megaamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromMegaamperes(double megaamperes)
        {
            double value = (double)megaamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Megaampere);
        }
        /// <summary>
        ///     Get ElectricCurrent from Microamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromMicroamperes(double microamperes)
        {
            double value = (double)microamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Microampere);
        }
        /// <summary>
        ///     Get ElectricCurrent from Milliamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromMilliamperes(double milliamperes)
        {
            double value = (double)milliamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Milliampere);
        }
        /// <summary>
        ///     Get ElectricCurrent from Nanoamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromNanoamperes(double nanoamperes)
        {
            double value = (double)nanoamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Nanoampere);
        }
        /// <summary>
        ///     Get ElectricCurrent from Picoamperes.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCurrent FromPicoamperes(double picoamperes)
        {
            double value = (double)picoamperes;
            return new ElectricCurrent(value, ElectricCurrentUnit.Picoampere);
        }



    }
}
