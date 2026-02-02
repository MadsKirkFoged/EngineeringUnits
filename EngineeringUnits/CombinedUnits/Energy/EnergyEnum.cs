using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record EnergyUnit : UnitTypebase
{
       
    // --- Joule family ---
    [Synonyms("j", "joule", "joules")]
    public static readonly EnergyUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "J");

    [Synonyms("mj", "millijoule", "millijoules")]
    public static readonly EnergyUnit Millijoule = new(PreFix.milli, SI);

    [Synonyms("j", "joule", "joules")]
    public static readonly EnergyUnit Joule = new(PreFix.SI, SI);

    [Synonyms("kj", "kilojoule", "kilojoules")]
    public static readonly EnergyUnit Kilojoule = new(PreFix.kilo, SI);

    [Synonyms("mj", "megajoule", "megajoules")]
    public static readonly EnergyUnit Megajoule = new(PreFix.mega, SI);

    [Synonyms("gj", "gigajoule", "gigajoules")]
    public static readonly EnergyUnit Gigajoule = new(PreFix.giga, SI);

    [Synonyms("tj", "terajoule", "terajoules")]
    public static readonly EnergyUnit Terajoule = new(PreFix.tera, SI);

    // --- BTU family ---
    [Synonyms("btu", "btu(it)", "btu it", "btu_it",
              "british thermal unit", "british thermal units", "britishthermalunit",
              "british thermal unit (it)", "british thermal unit it")]
    public static readonly EnergyUnit BritishThermalUnit =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "BTU", 1055.06m);

    [Synonyms("kbtu", "k btu", "k-btu", "kbtus", "kilobtu",
              "kilobritish thermal unit", "kilo british thermal unit")]
    public static readonly EnergyUnit KilobritishThermalUnit = new(PreFix.kilo, BritishThermalUnit);

    [Synonyms("mbtu", "m btu", "m-btu", "mbtus", "megabtu",
              "megabritish thermal unit", "mega british thermal unit")]
    public static readonly EnergyUnit MegabritishThermalUnit = new(PreFix.mega, BritishThermalUnit);

    [Synonyms("gbtu", "g btu", "g-btu", "gbtus", "gigabtu",
              "gigabritish thermal unit", "giga british thermal unit")]
    public static readonly EnergyUnit GigabritishThermalUnit = new(PreFix.giga, BritishThermalUnit);

    // --- Electron volt family ---
    [Synonyms("ev", "e-v", "electronvolt", "electron-volt", "electron volts", "electron-volts")]
    public static readonly EnergyUnit ElectronVolt =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "eV", 0.0000000000000000001602176565m);

    [Synonyms("kev", "k ev", "k-eV", "kiloelectronvolt", "kilo-electronvolt", "kilo electronvolt")]
    public static readonly EnergyUnit KiloelectronVolt = new(PreFix.kilo, ElectronVolt);

    [Synonyms("mev", "m ev", "m-eV", "megaelectronvolt", "mega-electronvolt", "mega electronvolt")]
    public static readonly EnergyUnit MegaelectronVolt = new(PreFix.mega, ElectronVolt);

    [Synonyms("gev", "g ev", "g-eV", "gigaelectronvolt", "giga-electronvolt", "giga electronvolt")]
    public static readonly EnergyUnit GigaelectronVolt = new(PreFix.giga, ElectronVolt);

    [Synonyms("tev", "t ev", "t-eV", "teraelectronvolt", "tera-electronvolt", "tera electronvolt")]
    public static readonly EnergyUnit TeraelectronVolt = new(PreFix.tera, ElectronVolt);

    // --- Calories ---
    [Synonyms("cal", "calorie", "calories", "small calorie", "small calories")]
    public static readonly EnergyUnit Calorie =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "cal", 4.184m);

    [Synonyms("kcal", "kilocalorie", "kilocalories", "food calorie", "food calories")]
    public static readonly EnergyUnit Kilocalorie = new(PreFix.kilo, Calorie);

    [Synonyms("mcal", "megacalorie", "megacalories")]
    public static readonly EnergyUnit Megacalorie = new(PreFix.mega, Calorie);

    // --- Watt-day family ---
    [Synonyms("wd", "w d", "watt day", "watt days", "watt-day", "watt-days")]
    public static readonly EnergyUnit WattDay =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, DurationUnit.Day, "W");

    [Synonyms("kwd", "k wd", "k-wd", "kilowatt day", "kilowatt days", "kilowatt-day", "kilowatt-days")]
    public static readonly EnergyUnit KilowattDay = new(PreFix.kilo, WattDay);

    [Synonyms("mwd", "m wd", "m-wd", "megawatt day", "megawatt days", "megawatt-day", "megawatt-days")]
    public static readonly EnergyUnit MegawattDay = new(PreFix.mega, WattDay);

    [Synonyms("gwd", "g wd", "g-wd", "gigawatt day", "gigawatt days", "gigawatt-day", "gigawatt-days")]
    public static readonly EnergyUnit GigawattDay = new(PreFix.giga, WattDay);

    [Synonyms("twd", "t wd", "t-wd", "terawatt day", "terawatt days", "terawatt-day", "terawatt-days")]
    public static readonly EnergyUnit TerawattDay = new(PreFix.tera, WattDay);

    // --- Watt-hour family (most common in real life) ---
    [Synonyms("wh", "w h", "watt hour", "watt hours", "watt-hour", "watt-hours")]
    public static readonly EnergyUnit WattHour =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, DurationUnit.Hour, "W");

    [Synonyms("kwh", "kw h", "kilowatt hour", "kilowatt hours", "kilowatt-hour", "kilowatt-hours")]
    public static readonly EnergyUnit KilowattHour = new(PreFix.kilo, WattHour);

    [Synonyms("mwh", "mw h", "megawatt hour", "megawatt hours", "megawatt-hour", "megawatt-hours")]
    public static readonly EnergyUnit MegawattHour = new(PreFix.mega, WattHour);

    [Synonyms("gwh", "gw h", "gigawatt hour", "gigawatt hours", "gigawatt-hour", "gigawatt-hours")]
    public static readonly EnergyUnit GigawattHour = new(PreFix.giga, WattHour);

    [Synonyms("twh", "tw h", "terawatt hour", "terawatt hours", "terawatt-hour", "terawatt-hours")]
    public static readonly EnergyUnit TerawattHour = new(PreFix.tera, WattHour);

    // --- Foot-pound ---
    [Synonyms("ftlb", "ft-lb", "ft lb", "ft*lbf", "ft·lbf",
              "foot pound", "foot pounds", "foot-pound", "foot-pounds")]
    public static readonly EnergyUnit FootPound =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "ft·lb", 1.3558179483314004m);

    // --- Decatherms (E.C., imp., U.S.) ---
    [Synonyms("dth", "dth ec", "dth (ec)", "decatherm ec", "decatherm (ec)",
              "decatherm e.c.", "dth (e.c.)", "dth(e.c.)")]
    public static readonly EnergyUnit DecathermEc =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (E.C.)", 1055055852.62m);

    [Synonyms("dth imp", "dth (imp)", "decatherm imperial", "decatherm (imp)",
              "decatherm imp", "dth (imp.)", "dth(imp.)")]
    public static readonly EnergyUnit DecathermImperial =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (imp.)", 1055055852.57348m);

    [Synonyms("dth us", "dth (us)", "decatherm us", "decatherm (u.s.)",
              "dth (u.s.)", "dth(u.s.)", "decatherm u.s.")]
    public static readonly EnergyUnit DecathermUs =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "Dth (U.S.)", 1054804000.0m);

    // --- Therms (E.C., imp., U.S.) ---
    [Synonyms("therm", "therm ec", "therm (ec)", "therm e.c.", "th ec", "th (ec)",
              "th (e.c.)", "th(e.c.)", "therm (e.c.)")]
    public static readonly EnergyUnit ThermEc =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (E.C.)", 105506000m);

    [Synonyms("therm imp", "therm (imp)", "therm imperial", "th imp", "th (imp)",
              "th (imp.)", "th(imp.)", "therm (imp.)")]
    public static readonly EnergyUnit ThermImperial =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (imp.)", 105505585.257348m);

    [Synonyms("therm us", "therm (us)", "therm u.s.", "th us", "th (us)",
              "th (u.s.)", "th(u.s.)", "therm (u.s.)")]
    public static readonly EnergyUnit ThermUs =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "th (U.S.)", 105480400.00m);

    // --- Erg ---
    [Synonyms("erg", "ergs")]
    public static readonly EnergyUnit Erg =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "erg", 1e-7m);

    // --- Horsepower-hour ---
    [Synonyms("hp h", "hp*h", "hp·h", "horsepower hour", "horsepower hours", "horsepower-hour", "horsepower-hours")]
    public static readonly EnergyUnit HorsepowerHour =
        new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "hp·h", 2.6845195377e6m);


    public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol, decimal correction = 1)
    {
        Unit = new UnitSystem(mass * Length.Pow(2) / duration.Pow(2) * correction, NewSymbol);
    }

    public EnergyUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, DurationUnit duration2, string NewSymbol)
    {
        Unit = new UnitSystem(mass * Length.Pow(2) / duration.Pow(3)* duration2.Unit,
                                $"{NewSymbol}{duration2}");
    }

    public EnergyUnit(PreFix SI, EnergyUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}