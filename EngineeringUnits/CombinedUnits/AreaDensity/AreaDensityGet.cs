using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class AreaDensity
    {
        /// <summary>
        ///     Get AreaDensity in KilogramsPerSquareMeter.
        /// </summary>
        public double KilogramsPerSquareMeter => As(AreaDensityUnit.KilogramPerSquareMeter);

        /// <summary>
        ///     Get AreaDensity in SI Unit (KilogramsPerSquareMeter).
        /// </summary>
        public double SI => As(AreaDensityUnit.SI);
    }
}
