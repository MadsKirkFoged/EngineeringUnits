using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class MolarEntropy
    {
        /// <summary>
        ///     Get MolarEntropy in JoulesPerMoleKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - JoulesPerMoleKelvin->JoulePerMoleKelvin")]
        public double JoulesPerMoleKelvin => As(MolarEntropyUnit.JoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy in SI Unit (JoulesPerMoleKelvin).
        /// </summary>
        //public double SI => As(MolarEntropyUnit.SI);

        /// <summary>
        ///     Get MolarEntropy in KilojoulesPerMoleKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - KilojoulesPerMoleKelvin->KilojoulePerMoleKelvin")]
        public double KilojoulesPerMoleKelvin => As(MolarEntropyUnit.KilojoulePerMoleKelvin);

        /// <summary>
        ///     Get MolarEntropy in MegajoulesPerMoleKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - MegajoulesPerMoleKelvin->MegajoulePerMoleKelvin")]
        public double MegajoulesPerMoleKelvin => As(MolarEntropyUnit.MegajoulePerMoleKelvin);

    }
}
