using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ElectricChargeDensity
    {
        /// <summary>
        ///     Get ElectricChargeDensity in CoulombsPerCubicMeter.
        /// </summary>
        public double CoulombsPerCubicMeter => As(ElectricChargeDensityUnit.CoulombPerCubicMeter);

    }
}
