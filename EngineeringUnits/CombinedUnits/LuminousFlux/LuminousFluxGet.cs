using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LuminousFlux
    {
        /// <summary>
        ///     Get LuminousFlux in Lumens.
        /// </summary>
        public double Lumens => As(LuminousFluxUnit.Lumen);

        /// <summary>
        ///     Get LuminousFlux in SI Unit (Lumens).
        /// </summary>
        public double SI => As(LuminousFluxUnit.SI);

    }
}
