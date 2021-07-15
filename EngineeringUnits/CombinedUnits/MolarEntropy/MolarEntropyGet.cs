using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MolarEntropy
    {
        /// <summary>
        ///     Get MolarEntropy in JoulesPerMoleKelvin.
        /// </summary>
        public double JoulesPerMoleKelvin => As(MolarEntropyUnit.JoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy in SI Unit (JoulesPerMoleKelvin).
        /// </summary>
        public double SI => As(MolarEntropyUnit.SI);

        /// <summary>
        ///     Get MolarEntropy in KilojoulesPerMoleKelvin.
        /// </summary>
        public double KilojoulesPerMoleKelvin => As(MolarEntropyUnit.KilojoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy in MegajoulesPerMoleKelvin.
        /// </summary>
        public double MegajoulesPerMoleKelvin => As(MolarEntropyUnit.MegajoulePerMoleKelvin);

    }
}
