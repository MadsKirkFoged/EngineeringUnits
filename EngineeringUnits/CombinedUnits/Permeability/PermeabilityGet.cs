using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Permeability
    {
        /// <summary>
        ///     Get Permeability in HenriesPerMeter.
        /// </summary>
        public double HenriesPerMeter => As(PermeabilityUnit.HenryPerMeter);

    }
}
