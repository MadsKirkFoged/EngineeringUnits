using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricCharge
    {
        /// <summary>
        ///     Get ElectricCharge from AmpereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromAmpereHours(double amperehours)
        {
            double value = (double)amperehours;
            return new ElectricCharge(value, ElectricChargeUnit.AmpereHour);
        }
        /// <summary>
        ///     Get ElectricCharge from Coulombs.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromCoulombs(double coulombs)
        {
            double value = (double)coulombs;
            return new ElectricCharge(value, ElectricChargeUnit.Coulomb);
        }
        /// <summary>
        ///     Get ElectricCharge from KiloampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromKiloampereHours(double kiloamperehours)
        {
            double value = (double)kiloamperehours;
            return new ElectricCharge(value, ElectricChargeUnit.KiloampereHour);
        }
        /// <summary>
        ///     Get ElectricCharge from MegaampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromMegaampereHours(double megaamperehours)
        {
            double value = (double)megaamperehours;
            return new ElectricCharge(value, ElectricChargeUnit.MegaampereHour);
        }
        /// <summary>
        ///     Get ElectricCharge from MilliampereHours.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricCharge FromMilliampereHours(double milliamperehours)
        {
            double value = (double)milliamperehours;
            return new ElectricCharge(value, ElectricChargeUnit.MilliampereHour);
        }

    }
}
