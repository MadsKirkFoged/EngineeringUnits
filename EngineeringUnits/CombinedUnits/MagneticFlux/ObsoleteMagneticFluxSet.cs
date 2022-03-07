using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class MagneticFlux
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static MagneticFlux FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new MagneticFlux(value, MagneticFluxUnit.SI);
        //}

        /// <summary>
        ///     Get MagneticFlux from Webers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWebers->FromWeber")]
        public static MagneticFlux FromWebers(double webers)
        {
            double value = (double)webers;
            return new MagneticFlux(value, MagneticFluxUnit.Weber);
        }

    }
}
