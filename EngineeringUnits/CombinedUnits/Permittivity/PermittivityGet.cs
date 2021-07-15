using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Permittivity
    {
        /// <summary>
        ///     Get Permittivity in FaradsPerMeter.
        /// </summary>
        public double FaradsPerMeter => As(PermittivityUnit.FaradPerMeter);

        /// <summary>
        ///     Get Permittivity in SI unit (FaradsPerMeter).
        /// </summary>
        public double SI => As(PermittivityUnit.SI);

    }
}
