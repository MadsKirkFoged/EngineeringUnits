using EngineeringUnits.Units;
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

        /// <summary>
        ///     Get ElectricField in SI Unit (VoltsPerMeter).
        /// </summary>
        public double SI => As(ElectricFieldUnit.SI);
    }
}
