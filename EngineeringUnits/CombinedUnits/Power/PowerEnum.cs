using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record PowerUnit : UnitTypebase
{

    // PowerUnit synonyms (ready to paste)

    // Base / SI
    [Synonyms("w", "watt", "watts", "W")]
    public static readonly PowerUnit SI = new(EnergyUnit.SI, DurationUnit.SI, "W");

    [Synonyms("fW", "fw", "femtowatt", "femtowatts", "femto-watt", "femto-watts")]
    public static readonly PowerUnit Femtowatt = new(PreFix.femto, SI);

    //[Synonyms("pW", "pw", "picowatt", "picowatts", "pico-watt", "pico-watts")]
    public static readonly PowerUnit Picowatt = new(PreFix.pico, SI);

    [Synonyms("nW", "nw", "nanowatt", "nanowatts", "nano-watt", "nano-watts")]
    public static readonly PowerUnit Nanowatt = new(PreFix.nano, SI);

    [Synonyms("µW", "uW", "uw", "microwatt", "microwatts", "micro-watt", "micro-watts")]
    public static readonly PowerUnit Microwatt = new(PreFix.micro, SI);

    //[Synonyms("mW", "mw", "milliwatt", "milliwatts", "milli-watt", "milli-watts")]
    public static readonly PowerUnit Milliwatt = new(PreFix.milli, SI);

    [Synonyms("dW", "dw", "deciwatt", "deciwatts", "deci-watt", "deci-watts")]
    public static readonly PowerUnit Deciwatt = new(PreFix.deci, SI);

    [Synonyms("W", "w", "watt", "watts")]
    public static readonly PowerUnit Watt = new(PreFix.SI, SI);

    [Synonyms("daW", "daw", "decawatt", "decawatts", "deka-watt", "deka-watts")]
    public static readonly PowerUnit Decawatt = new(PreFix.deka, SI);

    [Synonyms("kW", "kw", "kilowatt", "kilowatts", "kilo-watt", "kilo-watts")]
    public static readonly PowerUnit Kilowatt = new(PreFix.kilo, SI);

    //[Synonyms("MW", "mw", "megawatt", "megawatts", "mega-watt", "mega-watts")]
    public static readonly PowerUnit Megawatt = new(PreFix.mega, SI);

    [Synonyms("GW", "gw", "gigawatt", "gigawatts", "giga-watt", "giga-watts")]
    public static readonly PowerUnit Gigawatt = new(PreFix.giga, SI);

    [Synonyms("TW", "tw", "terawatt", "terawatts", "tera-watt", "tera-watts")]
    public static readonly PowerUnit Terawatt = new(PreFix.tera, SI);

    //[Synonyms("PW", "pw", "petawatt", "petawatts", "peta-watt", "peta-watts")]
    public static readonly PowerUnit Petawatt = new(PreFix.peta, SI);

    // Joule per hour family
    [Synonyms(
        "mJ/h", "mJ/hr", "mj/h", "mj/hr",
        "millijoule per hour", "millijoules per hour", "millijouleperhour", "millijoulesperhour"
    )]
    public static readonly PowerUnit MillijoulePerHour = new(EnergyUnit.Millijoule, DurationUnit.Hour);

    [Synonyms(
        "J/h", "J/hr", "j/h", "j/hr",
        "joule per hour", "joules per hour", "jouleperhour", "joulesperhour"
    )]
    public static readonly PowerUnit JoulePerHour = new(EnergyUnit.Joule, DurationUnit.Hour);

    [Synonyms(
        "kJ/h", "kJ/hr", "kj/h", "kj/hr",
        "kilojoule per hour", "kilojoules per hour", "kilojouleperhour", "kilojoulesperhour"
    )]
    public static readonly PowerUnit KilojoulePerHour = new(EnergyUnit.Kilojoule, DurationUnit.Hour);

    [Synonyms(
        "MJ/h", "MJ/hr", "mj/h", "mj/hr",
        "megajoule per hour", "megajoules per hour", "megajouleperhour", "megajoulesperhour"
    )]
    public static readonly PowerUnit MegajoulePerHour = new(EnergyUnit.Megajoule, DurationUnit.Hour);

    [Synonyms(
        "GJ/h", "GJ/hr", "gj/h", "gj/hr",
        "gigajoule per hour", "gigajoules per hour", "gigajouleperhour", "gigajoulesperhour"
    )]
    public static readonly PowerUnit GigajoulePerHour = new(EnergyUnit.Gigajoule, DurationUnit.Hour);

    // BTU / time
    [Synonyms(
        "Btu/h", "Btu/hr", "btu/h", "btu/hr",
        "BTU/h", "BTU/hr",
        "btuh", "Btuh",
        "british thermal unit per hour", "british thermal units per hour",
        "btu per hour", "btus per hour"
    )]
    public static readonly PowerUnit BritishThermalUnitPerHour = new(EnergyUnit.BritishThermalUnit, DurationUnit.Hour);

    [Synonyms(
        "Btu/min", "btu/min", "BTU/min",
        "british thermal unit per minute", "british thermal units per minute",
        "btu per minute", "btus per minute"
    )]
    public static readonly PowerUnit BritishThermalUnitPerMinute = new(EnergyUnit.BritishThermalUnit, DurationUnit.Minute);

    [Synonyms(
        "Btu/s", "Btu/sec", "btu/s", "btu/sec", "BTU/s", "BTU/sec",
        "british thermal unit per second", "british thermal units per second",
        "btu per second", "btus per second"
    )]
    public static readonly PowerUnit BritishThermalUnitPerSecond = new(EnergyUnit.BritishThermalUnit, DurationUnit.Second);

    [Synonyms(
        "kBtu/h", "kBtu/hr", "kbtu/h", "kbtu/hr",
        "kbtuh", "kBtuh", "kbtuhr",
        "kilobtu/h", "kilobtu/hr",
        "kilo british thermal unit per hour", "kilo british thermal units per hour",
        "kilobritishthermalunitperhour", "kilobritishthermalunitsperhour"
    // common industry shorthand (optional):
    // "MBH", "mbh" // 1 MBH = 1000 Btu/h
    )]
    public static readonly PowerUnit KilobritishThermalUnitPerHour = new(EnergyUnit.KilobritishThermalUnit, DurationUnit.Hour);

    // Horsepower variants
    [Synonyms(
        "hp(s)", "hp (s)", "hp-s", "hps",
        "boiler horsepower", "boiler hp", "steam horsepower"
    )]
    public static readonly PowerUnit BoilerHorsepower = new(EnergyUnit.SI, DurationUnit.SI, "hp(S)", 9812.5m);

    [Synonyms(
        "hp(e)", "hp (e)", "hp-e", "hpe",
        "electrical horsepower", "electric horsepower"
    )]
    public static readonly PowerUnit ElectricalHorsepower = new(EnergyUnit.SI, DurationUnit.SI, "hp(E)", 746m);

    [Synonyms(
        "hp(h)", "hp (h)", "hp-h", "hph",
        "hydraulic horsepower", "hydraulic hp"
    )]
    public static readonly PowerUnit HydraulicHorsepower = new(EnergyUnit.SI, DurationUnit.SI, "hp(H)", 745.69988145m);

    [Synonyms(
        "hp(i)", "hp (i)", "hp-i",
        "hp", "horsepower",
        "mechanical horsepower", "imperial horsepower", "hp (imperial)"
    )]
    public static readonly PowerUnit MechanicalHorsepower = new(EnergyUnit.SI, DurationUnit.SI, "hp(I)", 745.69m);

    [Synonyms(
        "hp(m)", "hp (m)", "hp-m", "hpm",
        "metric horsepower",
        "ps", "pferdestarke",         // common for metric hp
        "cv", "cheval vapeur",        // common for metric hp
        "ch"                          // sometimes used for metric hp in EU contexts
    )]
    public static readonly PowerUnit MetricHorsepower = new(EnergyUnit.SI, DurationUnit.SI, "hp(M)", 735.49875m);

    // Refrigeration ton
    [Synonyms(
        "TR", "tr",
        "ton of refrigeration", "tons of refrigeration",
        "refrigeration ton", "refrigeration tons",
        "rt" // common shorthand; remove if it conflicts in your domain
    )]
    public static readonly PowerUnit TonOfRefrigeration = new(EnergyUnit.BritishThermalUnit, DurationUnit.Hour, "TR", 12000m);

    // Calorie-based
    [Synonyms(
        "cal/s", "cal/sec",
        "calorie per second", "calories per second",
        "caloriepersecond", "caloriespersecond"
    )]
    public static readonly PowerUnit CaloriePerSecond = new(EnergyUnit.Calorie, DurationUnit.Second);

    [Synonyms(
        "kcal/h", "kcal/hr",
        "kilocalorie per hour", "kilocalories per hour",
        "kilocalorieperhour", "kilocaloriesperhour"
    )]
    public static readonly PowerUnit KilocaloriePerHour = new(EnergyUnit.Kilocalorie, DurationUnit.Hour);

    [Synonyms(
        "kcal/s", "kcal/sec",
        "kilocalorie per second", "kilocalories per second",
        "kilocaloriepersecond", "kilocaloriespersecond"
    )]
    public static readonly PowerUnit KilocaloriePerSecond = new(EnergyUnit.Kilocalorie, DurationUnit.Second);

    // Solar luminosity
    [Synonyms(
        "L⊙", "l⊙", "L☉", "l☉",
        "lsun", "l_sun", "l-sun",
        "solar luminosity", "luminosity of the sun"
    )]
    public static readonly PowerUnit SolarLuminosity = new(EnergyUnit.SI, DurationUnit.SI, "L⊙", 3.846e26m);

    public PowerUnit(EnergyUnit Energy, DurationUnit duration, string NewSymbol, decimal correction = 1)
    {
        Unit = new UnitSystem(Energy / duration * correction, NewSymbol);
    }

    public PowerUnit(EnergyUnit Energy, DurationUnit duration)
    {
        Unit = new UnitSystem(Energy / duration,
                            $"{Energy}/{duration}");
    }

    public PowerUnit(PreFix SI, PowerUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}