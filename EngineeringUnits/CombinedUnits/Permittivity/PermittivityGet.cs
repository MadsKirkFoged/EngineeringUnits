using System;
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

    }
}
