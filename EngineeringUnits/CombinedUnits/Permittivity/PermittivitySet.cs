using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Permittivity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Permittivity FromSI(double si)
        {
            double value = (double)si;
            return new Permittivity(value, PermittivityUnit.SI);
        }

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
