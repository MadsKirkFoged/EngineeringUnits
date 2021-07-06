using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Permittivity
    {
        /// <summary>
        ///     Get Permittivity from FaradsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Permittivity FromFaradsPerMeter(double faradspermeter)
        {
            double value = (double)faradspermeter;
            return new Permittivity(value, PermittivityUnit.FaradPerMeter);
        }

    }
}
