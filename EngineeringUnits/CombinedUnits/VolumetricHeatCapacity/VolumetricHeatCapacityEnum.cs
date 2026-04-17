using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record VolumetricHeatCapacityUnit : UnitTypebase
{

    public static readonly VolumetricHeatCapacityUnit SI = new(EnergyUnit.SI, VolumeUnit.SI, TemperatureUnit.SI);

    public static readonly VolumetricHeatCapacityUnit JoulePerCubicMeterKelvin = new(EnergyUnit.Joule, VolumeUnit.CubicMeter, TemperatureUnit.Kelvin);
    public static readonly VolumetricHeatCapacityUnit KilojoulePerCubicMeterKelvin = new(EnergyUnit.Kilojoule, VolumeUnit.CubicMeter, TemperatureUnit.Kelvin);
    public static readonly VolumetricHeatCapacityUnit MegajoulePerCubicMeterKelvin = new(EnergyUnit.Megajoule, VolumeUnit.CubicMeter, TemperatureUnit.Kelvin);
    public static readonly VolumetricHeatCapacityUnit JoulePerCubicMeterCelsius = new(EnergyUnit.Joule, VolumeUnit.CubicMeter, TemperatureUnit.DegreeCelsius);
    public static readonly VolumetricHeatCapacityUnit KilojoulePerCubicMeterCelsius = new(EnergyUnit.Kilojoule, VolumeUnit.CubicMeter, TemperatureUnit.DegreeCelsius);
    public static readonly VolumetricHeatCapacityUnit MegajoulePerCubicMeterCelsius = new(EnergyUnit.Megajoule, VolumeUnit.CubicMeter, TemperatureUnit.DegreeCelsius);
    public static readonly VolumetricHeatCapacityUnit WattHourPerCubicMeterKelvin = new(EnergyUnit.WattHour, VolumeUnit.CubicMeter, TemperatureUnit.Kelvin);
    public static readonly VolumetricHeatCapacityUnit KilowattHourPerCubicMeterKelvin = new(EnergyUnit.KilowattHour, VolumeUnit.CubicMeter, TemperatureUnit.Kelvin);
    public static readonly VolumetricHeatCapacityUnit BtuPerCubicFootFahrenheit = new(EnergyUnit.BritishThermalUnit, VolumeUnit.CubicFoot, TemperatureUnit.DegreeFahrenheit);

    public VolumetricHeatCapacityUnit(EnergyUnit energy, VolumeUnit volume, TemperatureUnit temperature)
    {
        Unit = new UnitSystem(energy / (volume * temperature),
                           $"{energy}/({volume}·{temperature})");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }

}
