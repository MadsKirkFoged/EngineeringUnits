using EngineeringUnits.Units;
using System.Collections.Generic;
using System;

namespace EngineeringUnits
{
    public partial class ThermalConductivity
    {

        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        //public static ThermalConductivity FromSI(double si)
        //{
        //    double value = (double)si;
        //    return new ThermalConductivity(value, ThermalConductivityUnit.SI);
        //}

        /// <summary>
        ///     Get ThermalConductivity from BtusPerHourFootFahrenheit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromBtusPerHourFootFahrenheit->FromBtuPerHourFootFahrenheit")]
        public static ThermalConductivity FromBtusPerHourFootFahrenheit(double btusperhourfootfahrenheit)
        {
            double value = (double)btusperhourfootfahrenheit;
            return new ThermalConductivity(value, ThermalConductivityUnit.BtuPerHourFootFahrenheit);
        }
        /// <summary>
        ///     Get ThermalConductivity from WattsPerMeterKelvin.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        [Obsolete("Use without the 's' - FromWattsPerMeterKelvin->FromWattPerMeterKelvin")]
        public static ThermalConductivity FromWattsPerMeterKelvin(double wattspermeterkelvin)
        {
            double value = (double)wattspermeterkelvin;
            return new ThermalConductivity(value, ThermalConductivityUnit.WattPerMeterKelvin);
        }

    }
}
