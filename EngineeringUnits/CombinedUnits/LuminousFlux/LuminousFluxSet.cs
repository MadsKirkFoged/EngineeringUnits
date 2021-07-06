using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class LuminousFlux
    {
        /// <summary>
        ///     Get LuminousFlux from Lumens.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static LuminousFlux FromLumens(double lumens)
        {
            double value = (double)lumens;
            return new LuminousFlux(value, LuminousFluxUnit.Lumen);
        }

    }
}
