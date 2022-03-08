using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Permeability
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static Permeability FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new Permeability(value, PermeabilityUnit.SI);
        //}

        /// <summary>
        ///     Get Permeability from HenriesPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromHenriesPerMeter->FromHenryPerMeter")]
        public static Permeability FromHenriesPerMeter(double henriespermeter)
        {
            double value = (double)henriespermeter;
            return new Permeability(value, PermeabilityUnit.HenryPerMeter);
        }

    }
}
