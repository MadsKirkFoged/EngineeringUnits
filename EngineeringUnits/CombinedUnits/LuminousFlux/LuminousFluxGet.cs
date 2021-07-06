using System;
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

    }
}
