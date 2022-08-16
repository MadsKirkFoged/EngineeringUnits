using EngineeringUnits.Units;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EngineeringUnits.Units
{


    public record VolumetricHeatTransferCoefficientUnit : UnitTypebase
    {

        public static readonly VolumetricHeatTransferCoefficientUnit SI = new VolumetricHeatTransferCoefficientUnit(PowerUnit.SI, VolumeUnit.SI, TemperatureUnit.SI);

        public static readonly VolumetricHeatTransferCoefficientUnit WattPerCubicMeterKelvin = new VolumetricHeatTransferCoefficientUnit(PowerUnit.Watt, VolumeUnit.CubicMeter, TemperatureUnit.Kelvin);




        public VolumetricHeatTransferCoefficientUnit(PowerUnit power, VolumeUnit volume, TemperatureUnit temperature)
        {
            base.Unit = new UnitSystem(power / (volume * temperature), $"{power}/{volume}{temperature}");
        }

        public VolumetricHeatTransferCoefficientUnit(PowerUnit power, VolumeUnit volume, TemperatureUnit temperature, string NewSymbol)
        {
            base.Unit = new UnitSystem(power / (volume * temperature), NewSymbol);
        }

        public override string ToString()
        {
            if (base.Unit.Symbol != null)
            {
                return base.Unit.Symbol ?? "";
            }

            return $"{base.Unit}";
        }

    }




}