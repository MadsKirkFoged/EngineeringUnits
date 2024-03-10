namespace EngineeringUnits.Units;

public partial record SpecificEntropyUnit : UnitTypebase
{

    public static readonly SpecificEntropyUnit SI = new(EnergyUnit.SI, MassUnit.SI, TemperatureUnit.SI);
    public static readonly SpecificEntropyUnit JoulePerKilogramKelvin = new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
    public static readonly SpecificEntropyUnit JoulePerKilogramDegreeCelsius = new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);
    public static readonly SpecificEntropyUnit KilojoulePerKilogramDegreeCelsius = new(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
    public static readonly SpecificEntropyUnit KilojoulePerKilogramKelvin = new(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);
    public static readonly SpecificEntropyUnit MegajoulePerKilogramDegreeCelsius = new(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
    public static readonly SpecificEntropyUnit MegajoulePerKilogramKelvin = new(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);
    public static readonly SpecificEntropyUnit JoulePerKilogramRankine = new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.DegreeRankine);
    public static readonly SpecificEntropyUnit CaloriePerGramKelvin = new(EnergyUnit.Calorie, MassUnit.Gram, TemperatureUnit.Kelvin);
    public static readonly SpecificEntropyUnit KilocaloriePerGramKelvin = new(EnergyUnit.Kilocalorie, MassUnit.Gram, TemperatureUnit.Kelvin);
    public static readonly SpecificEntropyUnit BtuPerPoundKelvin = new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.Kelvin);
    public static readonly SpecificEntropyUnit BtuPerPoundRankine = new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);
    public static readonly SpecificEntropyUnit BtuPerPoundFahrenheit = new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);

    public SpecificEntropyUnit(EnergyUnit energy, MassUnit mass, TemperatureUnit temperature)
    {
        Unit = new UnitSystem(energy /(mass * temperature),
                           $"{energy}/{mass}·{temperature}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}