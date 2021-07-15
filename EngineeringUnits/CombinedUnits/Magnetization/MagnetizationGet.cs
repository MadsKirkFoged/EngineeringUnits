using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class Magnetization
    {
        /// <summary>
        ///     Get Magnetization in AmperesPerMeter.
        /// </summary>
        public double AmperesPerMeter => As(MagnetizationUnit.AmperePerMeter);

    }
}
