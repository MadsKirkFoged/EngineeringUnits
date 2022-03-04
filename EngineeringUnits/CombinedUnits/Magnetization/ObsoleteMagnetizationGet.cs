using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class Magnetization
    {
        /// <summary>
        ///     Get Magnetization in AmperesPerMeter.
        /// </summary>
        [Obsolete("Use without the 's' - AmperesPerMeter->AmperePerMeter")]
        public double AmperesPerMeter => As(MagnetizationUnit.AmperePerMeter);

        /// <summary>
        ///     Get Magnetization in SI Unit (AmperesPerMeter).
        /// </summary>
        //public double SI => As(MagnetizationUnit.SI);

    }
}
