using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Permeability
    {
        /// <summary>
        ///     Get Permeability from HenriesPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Permeability FromHenriesPerMeter(double henriespermeter)
        {
            double value = (double)henriespermeter;
            return new Permeability(value, PermeabilityUnit.HenryPerMeter);
        }

    }
}
