using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MolarEnergy
    {
        /// <summary>
        ///     Get MolarEnergy in JoulesPerMole.
        /// </summary>
        public double JoulesPerMole => As(MolarEnergyUnit.JoulePerMole);

        /// <summary>
        ///     Get MolarEnergy in KilojoulesPerMole.
        /// </summary>
        public double KilojoulesPerMole => As(MolarEnergyUnit.KilojoulePerMole);

        /// <summary>
        ///     Get MolarEnergy in MegajoulesPerMole.
        /// </summary>
        public double MegajoulesPerMole => As(MolarEnergyUnit.MegajoulePerMole);

    }
}
