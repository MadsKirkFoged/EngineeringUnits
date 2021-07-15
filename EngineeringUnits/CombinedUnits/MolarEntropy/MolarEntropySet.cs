using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MolarEntropy
    {
        /// <summary>
        ///     Get MolarEntropy from JoulesPerMoleKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEntropy FromJoulesPerMoleKelvin(double joulespermolekelvin)
        {
            double value = (double)joulespermolekelvin;
            return new MolarEntropy(value, MolarEntropyUnit.JoulePerMoleKelvin);
        }
        /// <summary>
        ///     Get MolarEntropy from KilojoulesPerMoleKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEntropy FromKilojoulesPerMoleKelvin(double kilojoulespermolekelvin)
        {
            double value = (double)kilojoulespermolekelvin;
            return new MolarEntropy(value, MolarEntropyUnit.KilojoulePerMoleKelvin);
        }
        /// <summary>
        ///     Get MolarEntropy from MegajoulesPerMoleKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MolarEntropy FromMegajoulesPerMoleKelvin(double megajoulespermolekelvin)
        {
            double value = (double)megajoulespermolekelvin;
            return new MolarEntropy(value, MolarEntropyUnit.MegajoulePerMoleKelvin);
        }

    }
}
