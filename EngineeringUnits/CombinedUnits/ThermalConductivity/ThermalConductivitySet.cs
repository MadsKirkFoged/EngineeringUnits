
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ThermalConductivity
    {

 

            /// <summary>
            ///     Get ThermalConductivity from SI.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalConductivity FromSI(double SI)
            {
                double value= (double)SI;
                return new ThermalConductivity(value, ThermalConductivityUnit.SI);
            }
            /// <summary>
            ///     Get ThermalConductivity from WattPerMeterKelvin.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalConductivity FromWattPerMeterKelvin(double WattPerMeterKelvin)
            {
                double value= (double)WattPerMeterKelvin;
                return new ThermalConductivity(value, ThermalConductivityUnit.WattPerMeterKelvin);
            }
            /// <summary>
            ///     Get ThermalConductivity from BtuPerHourFootFahrenheit.
            /// </summary>
            /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
            public static ThermalConductivity FromBtuPerHourFootFahrenheit(double BtuPerHourFootFahrenheit)
            {
                double value= (double)BtuPerHourFootFahrenheit;
                return new ThermalConductivity(value, ThermalConductivityUnit.BtuPerHourFootFahrenheit);
            }
    }
}


