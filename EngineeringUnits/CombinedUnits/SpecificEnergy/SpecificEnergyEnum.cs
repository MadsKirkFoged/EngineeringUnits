using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record SpecificEnergyUnit : UnitTypebase
{

    // SpecificEnergyUnit synonyms (case-insensitive-safe; avoids case-dependent prefix symbols)

    // Base / SI
    [Synonyms(
        "j/kg",
        "joule per kilogram", "joules per kilogram",
        "jouleperkilogram", "joulesperkilogram",
        "specific energy", "specificenergy"
    )]
    public static readonly SpecificEnergyUnit SI = new(EnergyUnit.SI, MassUnit.SI);

    [Synonyms(
        "j/kg",
        "joule per kilogram", "joules per kilogram",
        "jouleperkilogram", "joulesperkilogram"
    )]
    public static readonly SpecificEnergyUnit JoulePerKilogram = new(EnergyUnit.Joule, MassUnit.Kilogram);

    [Synonyms(
        "kj/kg",
        "kilojoule per kilogram", "kilojoules per kilogram",
        "kilojouleperkilogram", "kilojoulesperkilogram",
        "kj per kg", "kj per kilogram"
    )]
    public static readonly SpecificEnergyUnit KilojoulePerKilogram = new(EnergyUnit.Kilojoule, MassUnit.Kilogram);

    [Synonyms(
        // Avoid "mj/kg" here (could mean milliJ/kg if case-sensitive elsewhere)
        "megajoule per kilogram", "megajoules per kilogram",
        "megajouleperkilogram", "megajoulesperkilogram"
    )]
    public static readonly SpecificEnergyUnit MegajoulePerKilogram = new(EnergyUnit.Megajoule, MassUnit.Kilogram);

    [Synonyms(
        "btu/lb",
        "btu per pound", "btus per pound",
        "btuperpound", "btusperpound",
        "btu per lb", "btus per lb",
        "btu/lbm", "btu per lbm"
    )]
    public static readonly SpecificEnergyUnit BtuPerPound = new(EnergyUnit.BritishThermalUnit, MassUnit.Pound);

    [Synonyms(
        "cal/g",
        "calorie per gram", "calories per gram",
        "caloriepergram", "caloriespergram",
        "cal per g"
    )]
    public static readonly SpecificEnergyUnit CaloriePerGram = new(EnergyUnit.Calorie, MassUnit.Gram);

    [Synonyms(
        "kcal/g",
        "kilocalorie per gram", "kilocalories per gram",
        "kilocaloriepergram", "kilocaloriespergram",
        "kcal per g"
    )]
    public static readonly SpecificEnergyUnit KilocaloriePerGram = new(EnergyUnit.Kilocalorie, MassUnit.Gram);

    // --- Watt-day per mass ---

    [Synonyms(
        "wd/kg", "wattday/kg",
        "watt day per kilogram", "watt days per kilogram",
        "wattdayperkilogram", "wattdaysperkilogram",
        "watt-day per kilogram", "watt-days per kilogram"
    )]
    public static readonly SpecificEnergyUnit WattDayPerKilogram = new(EnergyUnit.WattDay, MassUnit.Kilogram);

    [Synonyms(
        // Avoid "kwd/kg" symbol if you want to be ultra-strict; "k" is safe though.
        "kilowatt day per kilogram", "kilowatt days per kilogram",
        "kilowattdayperkilogram", "kilowattdaysperkilogram",
        "kilowatt-day per kilogram", "kilowatt-days per kilogram",
        "kwd per kg", "kilowattday/kg"
    )]
    public static readonly SpecificEnergyUnit KilowattDayPerKilogram = new(EnergyUnit.KilowattDay, MassUnit.Kilogram);

    [Synonyms(
        // Avoid "mwd/kg" (could be milli vs mega depending on case)
        "megawatt day per kilogram", "megawatt days per kilogram",
        "megawattdayperkilogram", "megawattdaysperkilogram",
        "megawatt-day per kilogram", "megawatt-days per kilogram"
    )]
    public static readonly SpecificEnergyUnit MegawattDayPerKilogram = new(EnergyUnit.MegawattDay, MassUnit.Kilogram);

    [Synonyms(
        // Avoid "gwd/kg" (case-sensitive G vs g)
        "gigawatt day per kilogram", "gigawatt days per kilogram",
        "gigawattdayperkilogram", "gigawattdaysperkilogram",
        "gigawatt-day per kilogram", "gigawatt-days per kilogram"
    )]
    public static readonly SpecificEnergyUnit GigawattDayPerKilogram = new(EnergyUnit.GigawattDay, MassUnit.Kilogram);

    [Synonyms(
        // Avoid "twd/kg" (case-sensitive T vs t)
        "terawatt day per kilogram", "terawatt days per kilogram",
        "terawattdayperkilogram", "terawattdaysperkilogram",
        "terawatt-day per kilogram", "terawatt-days per kilogram"
    )]
    public static readonly SpecificEnergyUnit TerawattDayPerKilogram = new(EnergyUnit.TerawattDay, MassUnit.Kilogram);

    // --- Watt-hour per mass ---

    [Synonyms(
        "wh/kg",
        "watt hour per kilogram", "watt hours per kilogram",
        "watthourperkilogram", "watthoursperkilogram",
        "watt-hour per kilogram", "watt-hours per kilogram"
    )]
    public static readonly SpecificEnergyUnit WattHourPerKilogram = new(EnergyUnit.WattHour, MassUnit.Kilogram);

    [Synonyms(
        "kwh/kg",
        "kilowatt hour per kilogram", "kilowatt hours per kilogram",
        "kilowatthourperkilogram", "kilowatthoursperkilogram",
        "kilowatt-hour per kilogram", "kilowatt-hours per kilogram"
    )]
    public static readonly SpecificEnergyUnit KilowattHourPerKilogram = new(EnergyUnit.KilowattHour, MassUnit.Kilogram);

    [Synonyms(
        // Avoid "mwh/kg" (case-sensitive m vs M)
        "megawatt hour per kilogram", "megawatt hours per kilogram",
        "megawatthourperkilogram", "megawatthoursperkilogram",
        "megawatt-hour per kilogram", "megawatt-hours per kilogram"
    )]
    public static readonly SpecificEnergyUnit MegawattHourPerKilogram = new(EnergyUnit.MegawattHour, MassUnit.Kilogram);

    [Synonyms(
        // Avoid "gwh/kg" (case-sensitive g vs G)
        "gigawatt hour per kilogram", "gigawatt hours per kilogram",
        "gigawatthourperkilogram", "gigawatthoursperkilogram",
        "gigawatt-hour per kilogram", "gigawatt-hours per kilogram"
    )]
    public static readonly SpecificEnergyUnit GigawattHourPerKilogram = new(EnergyUnit.GigawattHour, MassUnit.Kilogram);

    // --- per tonne (metric) ---

    [Synonyms(
        "wd/tonne", "wd per tonne",
        "watt day per tonne", "watt days per tonne",
        "wattdaypertonne", "wattdayspertonne",
        "watt-day per tonne", "watt-days per tonne",
        "watt day per metric ton", "watt days per metric ton"
    )]
    public static readonly SpecificEnergyUnit WattDayPerTonne = new(EnergyUnit.WattDay, MassUnit.Tonne);

    [Synonyms(
        "kilowatt day per tonne", "kilowatt days per tonne",
        "kilowattdaypertonne", "kilowattdayspertonne",
        "kilowatt-day per tonne", "kilowatt-days per tonne",
        "kilowatt day per metric ton", "kilowatt days per metric ton"
    )]
    public static readonly SpecificEnergyUnit KilowattDayPerTonne = new(EnergyUnit.KilowattDay, MassUnit.Tonne);

    [Synonyms(
        "megawatt day per tonne", "megawatt days per tonne",
        "megawattdaypertonne", "megawattdayspertonne",
        "megawatt-day per tonne", "megawatt-days per tonne",
        "megawatt day per metric ton", "megawatt days per metric ton"
    )]
    public static readonly SpecificEnergyUnit MegawattDayPerTonne = new(EnergyUnit.MegawattDay, MassUnit.Tonne);

    [Synonyms(
        "gigawatt day per tonne", "gigawatt days per tonne",
        "gigawattdaypertonne", "gigawattdayspertonne",
        "gigawatt-day per tonne", "gigawatt-days per tonne",
        "gigawatt day per metric ton", "gigawatt days per metric ton"
    )]
    public static readonly SpecificEnergyUnit GigawattDayPerTonne = new(EnergyUnit.GigawattDay, MassUnit.Tonne);

    [Synonyms(
        "terawatt day per tonne", "terawatt days per tonne",
        "terawattdaypertonne", "terawattdayspertonne",
        "terawatt-day per tonne", "terawatt-days per tonne",
        "terawatt day per metric ton", "terawatt days per metric ton"
    )]
    public static readonly SpecificEnergyUnit TerawattDayPerTonne = new(EnergyUnit.TerawattDay, MassUnit.Tonne);

    // --- per short ton (US) ---

    [Synonyms(
        "wd/short ton", "wd per short ton",
        "watt day per short ton", "watt days per short ton",
        "wattdaypershortton", "wattdayspershortton",
        "watt-day per short ton", "watt-days per short ton",
        "watt day per us ton", "watt days per us ton",
        "short ton watt day", "shortton watt day"
    )]
    public static readonly SpecificEnergyUnit WattDayPerShortTon = new(EnergyUnit.WattDay, MassUnit.ShortTon);

    [Synonyms(
        "kilowatt day per short ton", "kilowatt days per short ton",
        "kilowattdaypershortton", "kilowattdayspershortton",
        "kilowatt-day per short ton", "kilowatt-days per short ton",
        "kilowatt day per us ton", "kilowatt days per us ton"
    )]
    public static readonly SpecificEnergyUnit KilowattDayPerShortTon = new(EnergyUnit.KilowattDay, MassUnit.ShortTon);

    [Synonyms(
        "megawatt day per short ton", "megawatt days per short ton",
        "megawattdaypershortton", "megawattdayspershortton",
        "megawatt-day per short ton", "megawatt-days per short ton",
        "megawatt day per us ton", "megawatt days per us ton"
    )]
    public static readonly SpecificEnergyUnit MegawattDayPerShortTon = new(EnergyUnit.MegawattDay, MassUnit.ShortTon);

    [Synonyms(
        "gigawatt day per short ton", "gigawatt days per short ton",
        "gigawattdaypershortton", "gigawattdayspershortton",
        "gigawatt-day per short ton", "gigawatt-days per short ton",
        "gigawatt day per us ton", "gigawatt days per us ton"
    )]
    public static readonly SpecificEnergyUnit GigawattDayPerShortTon = new(EnergyUnit.GigawattDay, MassUnit.ShortTon);

    [Synonyms(
        "terawatt day per short ton", "terawatt days per short ton",
        "terawattdaypershortton", "terawattdayspershortton",
        "terawatt-day per short ton", "terawatt-days per short ton",
        "terawatt day per us ton", "terawatt days per us ton"
    )]
    public static readonly SpecificEnergyUnit TerawattDayPerShortTon = new(EnergyUnit.TerawattDay, MassUnit.ShortTon);

    public SpecificEnergyUnit(EnergyUnit energy, MassUnit mass)
    {
        Unit = new UnitSystem(energy / mass,
                            $"{energy}/{mass}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}