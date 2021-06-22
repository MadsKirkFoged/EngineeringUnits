using System;
using System.Collections.Generic;
using System.Text;

namespace EngineeringUnits
{
    public partial class ThermalConductivity
    {
        /// <summary>
        ///     Get ThermalConductivity from BtusPerHourFootFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalConductivity FromBtusPerHourFootFahrenheit(double btusperhourfootfahrenheit)
        {
            double value = (double)btusperhourfootfahrenheit;
            return new ThermalConductivity(value, ThermalConductivityUnit.BtuPerHourFootFahrenheit);
        }
        /// <summary>
        ///     Get ThermalConductivity from WattsPerMeterKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ThermalConductivity FromWattsPerMeterKelvin(double wattspermeterkelvin)
        {
            double value = (double)wattspermeterkelvin;
            return new ThermalConductivity(value, ThermalConductivityUnit.WattPerMeterKelvin);
        }

    }
}
