using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record SpecificEntropyUnit : UnitTypebase
{

    // SpecificEntropyUnit synonyms (case-insensitive-safe; avoids case-dependent prefix symbols)

    // SI / base
    [Synonyms(
        "j/kgk", "j/(kg*k)", "j/(kg k)", "j per kg k", "j per kilogram kelvin",
        "joule per kilogram kelvin", "joules per kilogram kelvin",
        "joule per kilogram per kelvin", "joules per kilogram per kelvin",
        "jouleperkilogramkelvin", "joulesperkilogramkelvin",
        "specific entropy", "specificentropy"
    )]
    public static readonly SpecificEntropyUnit SI = new(EnergyUnit.SI, MassUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        "j/kgk", "j/(kg*k)", "j/(kg k)",
        "j per kg k", "j per kilogram kelvin",
        "joule per kilogram kelvin", "joules per kilogram kelvin",
        "joule per kilogram per kelvin", "joules per kilogram per kelvin",
        "jouleperkilogramkelvin", "joulesperkilogramkelvin"
    )]
    public static readonly SpecificEntropyUnit JoulePerKilogramKelvin = new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        "j/kgc", "j/kg°c", "j/(kg*°c)", "j/(kg degc)", "j/(kg c)",
        "j per kilogram degree celsius", "j per kilogram degc",
        "joule per kilogram degree celsius", "joules per kilogram degree celsius",
        "joule per kilogram per degree celsius", "joules per kilogram per degree celsius",
        "jouleperkilogramdegreecelsius", "joulesperkilogramdegreecelsius"
    )]
    public static readonly SpecificEntropyUnit JoulePerKilogramDegreeCelsius = new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        "kj/kgc", "kj/kg°c", "kj/(kg*°c)", "kj/(kg degc)", "kj/(kg c)",
        "kilojoule per kilogram degree celsius", "kilojoules per kilogram degree celsius",
        "kilojoule per kilogram per degree celsius", "kilojoules per kilogram per degree celsius",
        "kilojouleperkilogramdegreecelsius", "kilojoulesperkilogramdegreecelsius"
    )]
    public static readonly SpecificEntropyUnit KilojoulePerKilogramDegreeCelsius = new(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        "kj/kgk", "kj/(kg*k)", "kj/(kg k)",
        "kj per kg k", "kj per kilogram kelvin",
        "kilojoule per kilogram kelvin", "kilojoules per kilogram kelvin",
        "kilojoule per kilogram per kelvin", "kilojoules per kilogram per kelvin",
        "kilojouleperkilogramkelvin", "kilojoulesperkilogramkelvin"
    )]
    public static readonly SpecificEntropyUnit KilojoulePerKilogramKelvin = new(EnergyUnit.Kilojoule, MassUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        // Avoid "mj/..." (could collide if case-insensitive); use word forms instead
        "megajoule per kilogram degree celsius", "megajoules per kilogram degree celsius",
        "megajoule per kilogram per degree celsius", "megajoules per kilogram per degree celsius",
        "megajouleperkilogramdegreecelsius", "megajoulesperkilogramdegreecelsius"
    )]
    public static readonly SpecificEntropyUnit MegajoulePerKilogramDegreeCelsius = new(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        // Avoid "mj/..." (could collide if case-insensitive); use word forms instead
        "megajoule per kilogram kelvin", "megajoules per kilogram kelvin",
        "megajoule per kilogram per kelvin", "megajoules per kilogram per kelvin",
        "megajouleperkilogramkelvin", "megajoulesperkilogramkelvin"
    )]
    public static readonly SpecificEntropyUnit MegajoulePerKilogramKelvin = new(EnergyUnit.Megajoule, MassUnit.SI, TemperatureUnit.SI);

    [Synonyms(
        "j/kgr", "j/(kg*r)", "j/(kg r)", "j per kilogram rankine",
        "joule per kilogram rankine", "joules per kilogram rankine",
        "joule per kilogram per rankine", "joules per kilogram per rankine",
        "jouleperkilogramrankine", "joulesperkilogramrankine",
        "j/kgdeg r", "j/(kg degr)", "j per kg deg r"
    )]
    public static readonly SpecificEntropyUnit JoulePerKilogramRankine = new(EnergyUnit.Joule, MassUnit.SI, TemperatureUnit.DegreeRankine);

    [Synonyms(
        "cal/gk", "cal/(g*k)", "cal/(g k)", "cal per gram kelvin",
        "calorie per gram kelvin", "calories per gram kelvin",
        "calorie per gram per kelvin", "calories per gram per kelvin",
        "caloriepergramkelvin", "caloriespergramkelvin"
    )]
    public static readonly SpecificEntropyUnit CaloriePerGramKelvin = new(EnergyUnit.Calorie, MassUnit.Gram, TemperatureUnit.Kelvin);

    [Synonyms(
        "kcal/gk", "kcal/(g*k)", "kcal/(g k)", "kcal per gram kelvin",
        "kilocalorie per gram kelvin", "kilocalories per gram kelvin",
        "kilocalorie per gram per kelvin", "kilocalories per gram per kelvin",
        "kilocaloriepergramkelvin", "kilocaloriespergramkelvin"
    )]
    public static readonly SpecificEntropyUnit KilocaloriePerGramKelvin = new(EnergyUnit.Kilocalorie, MassUnit.Gram, TemperatureUnit.Kelvin);

    [Synonyms(
        "btu/lbk", "btu/(lb*k)", "btu/(lb k)", "btu per pound kelvin",
        "btu per lb k", "btu per lb kelvin",
        "british thermal unit per pound kelvin", "british thermal units per pound kelvin",
        "btuperpoundkelvin", "btusperpoundkelvin"
    )]
    public static readonly SpecificEntropyUnit BtuPerPoundKelvin = new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.Kelvin);

    [Synonyms(
        "btu/lbr", "btu/(lb*r)", "btu/(lb r)", "btu per pound rankine",
        "btu per lb r", "btu per lb rankine",
        "british thermal unit per pound rankine", "british thermal units per pound rankine",
        "btuperpoundrankine", "btusperpoundrankine",
        "btu/lbdeg r", "btu/(lb degr)", "btu per lb deg r"
    )]
    public static readonly SpecificEntropyUnit BtuPerPoundRankine = new(EnergyUnit.BritishThermalUnit, MassUnit.Pound, TemperatureUnit.DegreeRankine);

    [Synonyms(
        // Even though you store DegreeRankine internally, Δ°F == Δ°R for specific entropy.
        "btu/lbf", "btu/(lb*f)", "btu/(lb f)", "btu per pound fahrenheit",
        "btu per lb f", "btu per lb deg f", "btu/(lb degf)",
        "british thermal unit per pound fahrenheit", "british thermal units per pound fahrenheit",
        "btuperpoundfahrenheit", "btusperpoundfahrenheit"
    )]
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