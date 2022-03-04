using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ThermalConductivity
    {
        /// <summary>
        ///     Get ThermalConductivity in BtusPerHourFootFahrenheit.
        /// </summary>
        [Obsolete("Use without the 's' - BtusPerHourFootFahrenheit->BtuPerHourFootFahrenheit")]
        public double BtusPerHourFootFahrenheit => As(ThermalConductivityUnit.BtuPerHourFootFahrenheit);

        /// <summary>
        ///     Get ThermalConductivity in WattsPerMeterKelvin.
        /// </summary>
        [Obsolete("Use without the 's' - WattsPerMeterKelvin->WattPerMeterKelvin")]
        public double WattsPerMeterKelvin => As(ThermalConductivityUnit.WattPerMeterKelvin);

        /// <summary>
        ///     Get ThermalConductivity in SI unit (WattsPerMeterKelvin).
        /// </summary>
        //public double SI => As(ThermalConductivityUnit.SI);

    }
}
