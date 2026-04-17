using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record EnergyDensityUnit : UnitTypebase
{

    public static readonly EnergyDensityUnit SI = new(EnergyUnit.SI, VolumeUnit.SI);

    public static readonly EnergyDensityUnit JoulePerCubicMeter = new(EnergyUnit.Joule, VolumeUnit.CubicMeter);
    public static readonly EnergyDensityUnit KilojoulePerCubicMeter = new(EnergyUnit.Kilojoule, VolumeUnit.CubicMeter);
    public static readonly EnergyDensityUnit MegajoulePerCubicMeter = new(EnergyUnit.Megajoule, VolumeUnit.CubicMeter);
    public static readonly EnergyDensityUnit WattHourPerCubicMeter = new(EnergyUnit.WattHour, VolumeUnit.CubicMeter);
    public static readonly EnergyDensityUnit KilowattHourPerCubicMeter = new(EnergyUnit.KilowattHour, VolumeUnit.CubicMeter);
    public static readonly EnergyDensityUnit MegawattHourPerCubicMeter = new(EnergyUnit.MegawattHour, VolumeUnit.CubicMeter);
    public static readonly EnergyDensityUnit GigawattHourPerCubicMeter = new(EnergyUnit.GigawattHour, VolumeUnit.CubicMeter);

    public EnergyDensityUnit(EnergyUnit energy, VolumeUnit volume)
    {
        Unit = new UnitSystem(energy / volume,
                           $"{energy}/{volume}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
