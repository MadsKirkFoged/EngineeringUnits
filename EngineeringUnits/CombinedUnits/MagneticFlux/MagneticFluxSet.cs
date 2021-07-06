using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class MagneticFlux
    {
        /// <summary>
        ///     Get MagneticFlux from Webers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MagneticFlux FromWebers(double webers)
        {
            double value = (double)webers;
            return new MagneticFlux(value, MagneticFluxUnit.Weber);
        }

    }
}
