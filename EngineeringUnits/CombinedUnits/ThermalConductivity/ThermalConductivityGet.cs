using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ThermalConductivity
    {
        /// <summary>
        ///     Get ThermalConductivity in BtusPerHourFootFahrenheit.
        /// </summary>
        public double BtusPerHourFootFahrenheit => As(ThermalConductivityUnit.BtuPerHourFootFahrenheit);

        /// <summary>
        ///     Get ThermalConductivity in WattsPerMeterKelvin.
        /// </summary>
        public double WattsPerMeterKelvin => As(ThermalConductivityUnit.WattPerMeterKelvin);

    }
}
