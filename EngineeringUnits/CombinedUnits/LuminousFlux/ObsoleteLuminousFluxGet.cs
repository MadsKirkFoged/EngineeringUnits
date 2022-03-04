using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class LuminousFlux
    {
        /// <summary>
        ///     Get LuminousFlux in Lumens.
        /// </summary>
        [Obsolete("Use without the 's' - Lumens->Lumen")]
        public double Lumens => As(LuminousFluxUnit.Lumen);

        /// <summary>
        ///     Get LuminousFlux in SI Unit (Lumens).
        /// </summary>
        //public double SI => As(LuminousFluxUnit.SI);

    }
}
