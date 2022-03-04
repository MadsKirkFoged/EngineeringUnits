
using EngineeringUnits.Units;


namespace EngineeringUnits
{
    public partial class ThermalConductivity
    {

 

            /// <summary>
            ///     Get ThermalConductivity in SI.
            /// </summary>
            public double SI => As(ThermalConductivityUnit.SI);
            /// <summary>
            ///     Get ThermalConductivity in WattPerMeterKelvin.
            /// </summary>
            public double WattPerMeterKelvin => As(ThermalConductivityUnit.WattPerMeterKelvin);
            /// <summary>
            ///     Get ThermalConductivity in BtuPerHourFootFahrenheit.
            /// </summary>
            public double BtuPerHourFootFahrenheit => As(ThermalConductivityUnit.BtuPerHourFootFahrenheit);
    }
}


