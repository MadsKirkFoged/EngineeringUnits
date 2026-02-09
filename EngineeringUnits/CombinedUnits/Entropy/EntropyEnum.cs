using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record EntropyUnit : UnitTypebase
{

    public static readonly EntropyUnit SI = new(EnergyUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        "j/k",
        "jouleperkelvin", "joulesperkelvin",
        "joule per kelvin", "joules per kelvin",
        "j per k", "j per kelvin",
        "j·k-1", "j k-1"
    )]
    public static readonly EntropyUnit JoulePerKelvin = new(EnergyUnit.Joule, TemperatureUnit.Kelvin);

    [Synonyms(
        "cal/k",
        "calorieperkelvin", "caloriesperkelvin",
        "calorie per kelvin", "calories per kelvin",
        "cal per k", "cal per kelvin",
        "cal·k-1", "cal k-1"
    )]
    public static readonly EntropyUnit CaloriePerKelvin = new(EnergyUnit.Calorie, TemperatureUnit.Kelvin);

    /// NOTE: Entropy uses temperature difference, so J/°C == J/K in scaling.
    /// If you keep this as Kelvin internally, synonyms make the °C form parseable.
    [Synonyms(
        "j/°c", "j/degc", "j/degreecelsius",
        "jouleperdegreecelsius", "joulesperdegreecelsius",
        "joule per degree celsius", "joules per degree celsius",
        "j per °c", "j per degc", "j per degree celsius",
        "j·°c-1", "j °c-1"
    )]
    public static readonly EntropyUnit JoulePerDegreeCelsius = new(EnergyUnit.Joule, TemperatureUnit.Kelvin);

    [Synonyms(
        "kcal/k",
        "kilocalorieperkelvin", "kilocaloriesperkelvin",
        "kilocalorie per kelvin", "kilocalories per kelvin",
        "kcal per k", "kcal per kelvin",
        "kcal·k-1", "kcal k-1"
    )]
    public static readonly EntropyUnit KilocaloriePerKelvin = new(EnergyUnit.Kilocalorie, TemperatureUnit.Kelvin);

    [Synonyms(
        "kj/°c", "kj/degc", "kj/degreecelsius",
        "kilojouleperdegreecelsius", "kilojoulesperdegreecelsius",
        "kilojoule per degree celsius", "kilojoules per degree celsius",
        "kj per °c", "kj per degc", "kj per degree celsius",
        "kj·°c-1", "kj °c-1"
    )]
    public static readonly EntropyUnit KilojoulePerDegreeCelsius = new(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);

    [Synonyms(
        "kj/k",
        "kilojouleperkelvin", "kilojoulesperkelvin",
        "kilojoule per kelvin", "kilojoules per kelvin",
        "kj per k", "kj per kelvin",
        "kj·k-1", "kj k-1"
    )]
    public static readonly EntropyUnit KilojoulePerKelvin = new(EnergyUnit.Kilojoule, TemperatureUnit.Kelvin);

    [Synonyms(
        "mj/k",
        "megajouleperkelvin", "megajoulesperkelvin",
        "megajoule per kelvin", "megajoules per kelvin",
        "mj per k", "mj per kelvin",
        "mj·k-1", "mj k-1"
    )]
    public static readonly EntropyUnit MegajoulePerKelvin = new(EnergyUnit.Megajoule, TemperatureUnit.Kelvin);

    public EntropyUnit(EnergyUnit energy, TemperatureUnit temperature)
    {
        Unit = new UnitSystem(energy / temperature,
                           $"{energy}/{temperature}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}