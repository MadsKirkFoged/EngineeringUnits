using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MagneticFlux
    {
        /// <summary>
        ///     Get MagneticFlux in Webers.
        /// </summary>
        public double Webers => As(MagneticFluxUnit.Weber);

        /// <summary>
        ///     Get MagneticFlux in SI Unit (Webers).
        /// </summary>
        public double SI => As(MagneticFluxUnit.SI);
    }
}
