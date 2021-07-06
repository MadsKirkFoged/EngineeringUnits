using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MolarEnergy
    {
        /// <summary>
        ///     Get MolarEnergy from JoulesPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEnergy FromJoulesPerMole(double joulespermole)
        {
            double value = (double)joulespermole;
            return new MolarEnergy(value, MolarEnergyUnit.JoulePerMole);
        }
        /// <summary>
        ///     Get MolarEnergy from KilojoulesPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEnergy FromKilojoulesPerMole(double kilojoulespermole)
        {
            double value = (double)kilojoulespermole;
            return new MolarEnergy(value, MolarEnergyUnit.KilojoulePerMole);
        }
        /// <summary>
        ///     Get MolarEnergy from MegajoulesPerMole.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEnergy FromMegajoulesPerMole(double megajoulespermole)
        {
            double value = (double)megajoulespermole;
            return new MolarEnergy(value, MolarEnergyUnit.MegajoulePerMole);
        }

    }
}
