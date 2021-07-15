using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricPotential
    {
        /// <summary>
        ///     Get ElectricPotential from Kilovolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromKilovolts(double kilovolts)
        {
            double value = (double)kilovolts;
            return new ElectricPotential(value, ElectricPotentialUnit.Kilovolt);
        }
        /// <summary>
        ///     Get ElectricPotential from Megavolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromMegavolts(double megavolts)
        {
            double value = (double)megavolts;
            return new ElectricPotential(value, ElectricPotentialUnit.Megavolt);
        }
        /// <summary>
        ///     Get ElectricPotential from Microvolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromMicrovolts(double microvolts)
        {
            double value = (double)microvolts;
            return new ElectricPotential(value, ElectricPotentialUnit.Microvolt);
        }
        /// <summary>
        ///     Get ElectricPotential from Millivolts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromMillivolts(double millivolts)
        {
            double value = (double)millivolts;
            return new ElectricPotential(value, ElectricPotentialUnit.Millivolt);
        }
        /// <summary>
        ///     Get ElectricPotential from Volts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ElectricPotential FromVolts(double volts)
        {
            double value = (double)volts;
            return new ElectricPotential(value, ElectricPotentialUnit.Volt);
        }


    }
}
