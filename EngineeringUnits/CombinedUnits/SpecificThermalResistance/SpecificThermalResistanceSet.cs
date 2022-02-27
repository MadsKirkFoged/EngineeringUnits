using EngineeringUnits.Units;

namespace EngineeringUnits
{
    public partial class SpecificThermalResistance
    {
        /// <summary>
        ///     Get from SI Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificThermalResistance FromSI(double si)
        {
            double value = (double)si;
            return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.SI);
        }

        /// <summary>
        ///     Get from MeterDegreeCelsiusPerWatt Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificThermalResistance FromMeterDegreeCelsiusPerWatt(double meterDegreeCelsiusPerWatt)
        {
            double value = (double)meterDegreeCelsiusPerWatt;
            return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.MeterDegreeCelsiusPerWatt);
        }

        /// <summary>
        ///     Get from MeterKelvinPerKilowatt Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificThermalResistance FromMeterKelvinPerKilowatt(double meterKelvinPerKilowatt)
        {
            double value = (double)meterKelvinPerKilowatt;
            return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.MeterKelvinPerKilowatt);
        }

        /// <summary>
        ///     Get from CentimeterKelvinPerWatt Unit.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static SpecificThermalResistance FromCentimeterKelvinPerWatt(double centimeterKelvinPerWatt)
        {
            double value = (double)centimeterKelvinPerWatt;
            return new SpecificThermalResistance(value, SpecificThermalResistanceUnit.CentimeterKelvinPerWatt);
        }
    }
}
