using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricField
    {
        /// <summary>
        ///     Get ElectricField in VoltsPerMeter.
        /// </summary>
        public double VoltsPerMeter => As(ElectricFieldUnit.VoltPerMeter);

    }
}
