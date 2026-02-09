using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record VolumeFlowUnit : UnitTypebase
{

    // VolumeFlowUnit synonyms (case-insensitive-safe)

    // --- Acre-foot per time ---
    [Synonyms(
        "af/d", "af per day",
        "ac-ft/d", "acft/d", "acre-ft/day",
        "acre foot per day", "acre-foot per day",
        "acre feet per day", "acre-feet per day"
    )]
    public static readonly VolumeFlowUnit AcreFootPerDay = new(VolumeUnit.AcreFoot, DurationUnit.Day, "af/d");

    [Synonyms(
        "af/h", "af/hr", "af per hour",
        "ac-ft/h", "ac-ft/hr", "acft/h", "acft/hr",
        "acre foot per hour", "acre-foot per hour",
        "acre feet per hour", "acre-feet per hour"
    )]
    public static readonly VolumeFlowUnit AcreFootPerHour = new(VolumeUnit.AcreFoot, DurationUnit.Hour, "af/h");

    [Synonyms(
        "af/m", "af/min", "af per minute",
        "ac-ft/min", "acft/min",
        "acre foot per minute", "acre-foot per minute",
        "acre feet per minute", "acre-feet per minute"
    )]
    public static readonly VolumeFlowUnit AcreFootPerMinute = new(VolumeUnit.AcreFoot, DurationUnit.Minute, "af/m");

    [Synonyms(
        "af/s", "af/sec", "af per second",
        "ac-ft/s", "ac-ft/sec", "acft/s", "acft/sec",
        "acre foot per second", "acre-foot per second",
        "acre feet per second", "acre-feet per second"
    )]
    public static readonly VolumeFlowUnit AcreFootPerSecond = new(VolumeUnit.AcreFoot, DurationUnit.Second, "af/s");

    // --- Centiliter per time ---
    [Synonyms(
        "cl/day", "cl/d",
        "centiliter per day", "centiliters per day",
        "centilitre per day", "centilitres per day",
        "centiliterperday", "centilitersperday"
    )]
    public static readonly VolumeFlowUnit CentiliterPerDay = new(VolumeUnit.Centiliter, DurationUnit.Day);

    [Synonyms(
        "cl/min",
        "centiliter per minute", "centiliters per minute",
        "centilitre per minute", "centilitres per minute",
        "centiliterperminute", "centilitersperminute"
    )]
    public static readonly VolumeFlowUnit CentiliterPerMinute = new(VolumeUnit.Centiliter, DurationUnit.Minute);

    [Synonyms(
        "cl/s", "cl/sec",
        "centiliter per second", "centiliters per second",
        "centilitre per second", "centilitres per second",
        "centiliterpersecond", "centiliterspersecond"
    )]
    public static readonly VolumeFlowUnit CentiliterPerSecond = new(VolumeUnit.Centiliter, DurationUnit.Second);

    // --- Cubic centimeter / decimeter per minute ---
    [Synonyms(
        "cm3/min", "cm^3/min", "cm³/min",
        "cc/min",
        "cubic centimeter per minute", "cubic centimeters per minute",
        "cubic centimetre per minute", "cubic centimetres per minute",
        "cubiccentimeterperminute", "cubiccentimetersperminute"
    )]
    public static readonly VolumeFlowUnit CubicCentimeterPerMinute = new(VolumeUnit.CubicCentimeter, DurationUnit.Minute);

    [Synonyms(
        "dm3/min", "dm^3/min", "dm³/min",
        "cubic decimeter per minute", "cubic decimeters per minute",
        "cubic decimetre per minute", "cubic decimetres per minute",
        "cubicdecimeterperminute", "cubicdecimetersperminute"
    )]
    public static readonly VolumeFlowUnit CubicDecimeterPerMinute = new(VolumeUnit.CubicDecimeter, DurationUnit.Minute);

    // --- Cubic foot per time ---
    [Synonyms(
        "ft3/h", "ft^3/h", "ft³/h",
        "cfh",
        "cubic foot per hour", "cubic feet per hour",
        "cubicfootperhour", "cubicfeetperhour"
    )]
    public static readonly VolumeFlowUnit CubicFootPerHour = new(VolumeUnit.CubicFoot, DurationUnit.Hour);

    [Synonyms(
        "ft3/min", "ft^3/min", "ft³/min",
        "cfm",
        "cubic foot per minute", "cubic feet per minute",
        "cubicfootperminute", "cubicfeetperminute"
    )]
    public static readonly VolumeFlowUnit CubicFootPerMinute = new(VolumeUnit.CubicFoot, DurationUnit.Minute);

    [Synonyms(
        "ft3/s", "ft^3/s", "ft³/s",
        "cfs",
        "cubic foot per second", "cubic feet per second",
        "cubicfootpersecond", "cubicfeetpersecond"
    )]
    public static readonly VolumeFlowUnit CubicFootPerSecond = new(VolumeUnit.CubicFoot, DurationUnit.Second);

    // --- Cubic meter per time ---
    [Synonyms(
        "m3/day", "m^3/day", "m³/day", "m3/d",
        "cubic meter per day", "cubic meters per day",
        "cubic metre per day", "cubic metres per day",
        "cubicmeterperday", "cubicmetersperday"
    )]
    public static readonly VolumeFlowUnit CubicMeterPerDay = new(VolumeUnit.CubicMeter, DurationUnit.Day);

    [Synonyms(
        "m3/h", "m^3/h", "m³/h", "m3/hr",
        "cubic meter per hour", "cubic meters per hour",
        "cubic metre per hour", "cubic metres per hour",
        "cubicmeterperhour", "cubicmetersperhour"
    )]
    public static readonly VolumeFlowUnit CubicMeterPerHour = new(VolumeUnit.CubicMeter, DurationUnit.Hour);

    [Synonyms(
        "m3/min", "m^3/min", "m³/min",
        "cubic meter per minute", "cubic meters per minute",
        "cubic metre per minute", "cubic metres per minute",
        "cubicmeterperminute", "cubicmetersperminute"
    )]
    public static readonly VolumeFlowUnit CubicMeterPerMinute = new(VolumeUnit.CubicMeter, DurationUnit.Minute);

    [Synonyms(
        "m3/s", "m^3/s", "m³/s", "cms",
        "cubic meter per second", "cubic meters per second",
        "cubic metre per second", "cubic metres per second",
        "cubicmeterpersecond", "cubicmeterspersecond"
    )]
    public static readonly VolumeFlowUnit CubicMeterPerSecond = new(VolumeUnit.CubicMeter, DurationUnit.Second);

    // SI (same as m³/s)
    [Synonyms(
        "m3/s", "m^3/s", "m³/s",
        "si", "si unit", "si volume flow", "sivolumeflow"
    )]
    public static readonly VolumeFlowUnit SI = new(VolumeUnit.SI, DurationUnit.SI);

    // --- Cubic millimeter per second ---
    [Synonyms(
        "mm3/s", "mm^3/s", "mm³/s",
        "cubic millimeter per second", "cubic millimeters per second",
        "cubic millimetre per second", "cubic millimetres per second",
        "cubicmillimeterpersecond", "cubicmillimeterspersecond"
    )]
    public static readonly VolumeFlowUnit CubicMillimeterPerSecond = new(VolumeUnit.CubicMillimeter, DurationUnit.Second);

    // --- Cubic yard per time ---
    [Synonyms(
        "yd3/day", "yd^3/day", "yd³/day", "yd3/d",
        "cubic yard per day", "cubic yards per day",
        "cubicyardperday", "cubicyardsperday"
    )]
    public static readonly VolumeFlowUnit CubicYardPerDay = new(VolumeUnit.CubicYard, DurationUnit.Day);

    [Synonyms(
        "yd3/h", "yd^3/h", "yd³/h", "yd3/hr",
        "cubic yard per hour", "cubic yards per hour",
        "cubicyardperhour", "cubicyardsperhour"
    )]
    public static readonly VolumeFlowUnit CubicYardPerHour = new(VolumeUnit.CubicYard, DurationUnit.Hour);

    [Synonyms(
        "yd3/min", "yd^3/min", "yd³/min",
        "cubic yard per minute", "cubic yards per minute",
        "cubicyardperminute", "cubicyardsperminute"
    )]
    public static readonly VolumeFlowUnit CubicYardPerMinute = new(VolumeUnit.CubicYard, DurationUnit.Minute);

    [Synonyms(
        "yd3/s", "yd^3/s", "yd³/s", "yd3/sec",
        "cubic yard per second", "cubic yards per second",
        "cubicyardpersecond", "cubicyardspersecond"
    )]
    public static readonly VolumeFlowUnit CubicYardPerSecond = new(VolumeUnit.CubicYard, DurationUnit.Second);

    // --- Deciliter per time ---
    [Synonyms(
        "dl/day", "dl/d",
        "deciliter per day", "deciliters per day",
        "decilitre per day", "decilitres per day",
        "deciliterperday", "decilitersperday"
    )]
    public static readonly VolumeFlowUnit DeciliterPerDay = new(VolumeUnit.Deciliter, DurationUnit.Day);

    [Synonyms(
        "dl/min",
        "deciliter per minute", "deciliters per minute",
        "decilitre per minute", "decilitres per minute",
        "deciliterperminute", "decilitersperminute"
    )]
    public static readonly VolumeFlowUnit DeciliterPerMinute = new(VolumeUnit.Deciliter, DurationUnit.Minute);

    [Synonyms(
        "dl/s", "dl/sec",
        "deciliter per second", "deciliters per second",
        "decilitre per second", "decilitres per second",
        "deciliterpersecond", "deciliterspersecond"
    )]
    public static readonly VolumeFlowUnit DeciliterPerSecond = new(VolumeUnit.Deciliter, DurationUnit.Second);

    // --- Kiloliter per time ---
    [Synonyms(
        "kl/day", "kl/d",
        "kiloliter per day", "kiloliters per day",
        "kilolitre per day", "kilolitres per day",
        "kiloliterperday", "kilolitersperday"
    )]
    public static readonly VolumeFlowUnit KiloliterPerDay = new(VolumeUnit.Kiloliter, DurationUnit.Day);

    [Synonyms(
        "kl/min",
        "kiloliter per minute", "kiloliters per minute",
        "kilolitre per minute", "kilolitres per minute",
        "kiloliterperminute", "kilolitersperminute"
    )]
    public static readonly VolumeFlowUnit KiloliterPerMinute = new(VolumeUnit.Kiloliter, DurationUnit.Minute);

    [Synonyms(
        "kl/s", "kl/sec",
        "kiloliter per second", "kiloliters per second",
        "kilolitre per second", "kilolitres per second",
        "kiloliterpersecond", "kiloliterspersecond"
    )]
    public static readonly VolumeFlowUnit KiloliterPerSecond = new(VolumeUnit.Kiloliter, DurationUnit.Second);

    // --- kUS gallon per minute ---
    [Synonyms(
        "kgal/min", "kgal per minute", "kgalpm",
        "thousand us gallons per minute", "1000 us gallons per minute",
        "kilo us gallon per minute", "kilo us gallons per minute",
        "kilousgallonperminute", "kilousgallonsperminute"
    )]
    public static readonly VolumeFlowUnit KilousGallonPerMinute = new(VolumeUnit.KilousGallon, DurationUnit.Minute);

    // --- Liter per time ---
    [Synonyms(
        "l/day", "l/d",
        "liter per day", "liters per day",
        "litre per day", "litres per day",
        "literperday", "litersperday"
    )]
    public static readonly VolumeFlowUnit LiterPerDay = new(VolumeUnit.Liter, DurationUnit.Day);

    [Synonyms(
        "l/h", "l/hr",
        "liter per hour", "liters per hour",
        "litre per hour", "litres per hour",
        "literperhour", "litersperhour"
    )]
    public static readonly VolumeFlowUnit LiterPerHour = new(VolumeUnit.Liter, DurationUnit.Hour);

    [Synonyms(
        "l/min",
        "liter per minute", "liters per minute",
        "litre per minute", "litres per minute",
        "literperminute", "litersperminute"
    )]
    public static readonly VolumeFlowUnit LiterPerMinute = new(VolumeUnit.Liter, DurationUnit.Minute);

    [Synonyms(
        "l/s", "l/sec",
        "liter per second", "liters per second",
        "litre per second", "litres per second",
        "literpersecond", "literspersecond"
    )]
    public static readonly VolumeFlowUnit LiterPerSecond = new(VolumeUnit.Liter, DurationUnit.Second);

    // NOTE: avoid "mld" / "MLD" to prevent collisions with "ml/d" when case-insensitive
    [Synonyms(
        "megaliter per day", "megaliters per day",
        "megalitre per day", "megalitres per day",
        "mega liter per day", "mega litre per day",
        "million liters per day", "million litres per day",
        "1000000 liters per day", "1000000 litres per day"
    )]
    public static readonly VolumeFlowUnit MegaliterPerDay = new(VolumeUnit.Megaliter, DurationUnit.Day);

    // --- Microliter per time ---
    [Synonyms(
        "ul/day", "µl/day", "ul/d", "µl/d",
        "microliter per day", "microliters per day",
        "microlitre per day", "microlitres per day",
        "microliterperday", "microlitersperday"
    )]
    public static readonly VolumeFlowUnit MicroliterPerDay = new(VolumeUnit.Microliter, DurationUnit.Day);

    [Synonyms(
        "ul/min", "µl/min",
        "microliter per minute", "microliters per minute",
        "microlitre per minute", "microlitres per minute",
        "microliterperminute", "microlitersperminute"
    )]
    public static readonly VolumeFlowUnit MicroliterPerMinute = new(VolumeUnit.Microliter, DurationUnit.Minute);

    [Synonyms(
        "ul/s", "ul/sec", "µl/s", "µl/sec",
        "microliter per second", "microliters per second",
        "microlitre per second", "microlitres per second",
        "microliterpersecond", "microliterspersecond"
    )]
    public static readonly VolumeFlowUnit MicroliterPerSecond = new(VolumeUnit.Microliter, DurationUnit.Second);

    // --- Milliliter per time ---
    [Synonyms(
        "ml/day", "ml/d",
        "milliliter per day", "milliliters per day",
        "millilitre per day", "millilitres per day",
        "milliliterperday", "millilitersperday"
    )]
    public static readonly VolumeFlowUnit MilliliterPerDay = new(VolumeUnit.Milliliter, DurationUnit.Day);

    [Synonyms(
        "ml/min",
        "milliliter per minute", "milliliters per minute",
        "millilitre per minute", "millilitres per minute",
        "milliliterperminute", "millilitersperminute"
    )]
    public static readonly VolumeFlowUnit MilliliterPerMinute = new(VolumeUnit.Milliliter, DurationUnit.Minute);

    [Synonyms(
        "ml/s", "ml/sec",
        "milliliter per second", "milliliters per second",
        "millilitre per second", "millilitres per second",
        "milliliterpersecond", "milliliterspersecond"
    )]
    public static readonly VolumeFlowUnit MilliliterPerSecond = new(VolumeUnit.Milliliter, DurationUnit.Second);

    // Million US gallons per day (MGD)
    [Synonyms(
        "mgd",
        "million gallons per day", "million us gallons per day",
        "milliongallonsperday", "millionusgallonsperday",
        "1000000 gallons per day", "1000000 us gallons per day"
    )]
    public static readonly VolumeFlowUnit MillionUsGallonsPerDay = new(VolumeUnit.UsGallon, DurationUnit.Day, "MGD", 1000000);

    // --- Nanoliter per time ---
    [Synonyms(
        "nl/day", "nl/d",
        "nanoliter per day", "nanoliters per day",
        "nanolitre per day", "nanolitres per day",
        "nanoliterperday", "nanolitersperday"
    )]
    public static readonly VolumeFlowUnit NanoliterPerDay = new(VolumeUnit.Nanoliter, DurationUnit.Day);

    [Synonyms(
        "nl/min",
        "nanoliter per minute", "nanoliters per minute",
        "nanolitre per minute", "nanolitres per minute",
        "nanoliterperminute", "nanolitersperminute"
    )]
    public static readonly VolumeFlowUnit NanoliterPerMinute = new(VolumeUnit.Nanoliter, DurationUnit.Minute);

    [Synonyms(
        "nl/s", "nl/sec",
        "nanoliter per second", "nanoliters per second",
        "nanolitre per second", "nanolitres per second",
        "nanoliterpersecond", "nanoliterspersecond"
    )]
    public static readonly VolumeFlowUnit NanoliterPerSecond = new(VolumeUnit.Nanoliter, DurationUnit.Second);

    // --- Oil barrel per time ---
    [Synonyms(
        "bbl/day", "bbl/d", "bpd",
        "barrel per day", "barrels per day",
        "oil barrel per day", "oil barrels per day",
        "barrelperday", "barrelsperday"
    )]
    public static readonly VolumeFlowUnit OilBarrelPerDay = new(VolumeUnit.OilBarrel, DurationUnit.Day);

    [Synonyms(
        "bbl/h", "bbl/hr",
        "barrel per hour", "barrels per hour",
        "oil barrel per hour", "oil barrels per hour",
        "barrelperhour", "barrelsperhour"
    )]
    public static readonly VolumeFlowUnit OilBarrelPerHour = new(VolumeUnit.OilBarrel, DurationUnit.Hour);

    [Synonyms(
        "bbl/min",
        "barrel per minute", "barrels per minute",
        "oil barrel per minute", "oil barrels per minute",
        "barrelperminute", "barrelsperminute"
    )]
    public static readonly VolumeFlowUnit OilBarrelPerMinute = new(VolumeUnit.OilBarrel, DurationUnit.Minute);

    [Synonyms(
        "bbl/s", "bbl/sec",
        "barrel per second", "barrels per second",
        "oil barrel per second", "oil barrels per second",
        "barrelpersecond", "barrelspersecond"
    )]
    public static readonly VolumeFlowUnit OilBarrelPerSecond = new(VolumeUnit.OilBarrel, DurationUnit.Second);

    // --- UK/Imperial gallons per time ---
    // Note: avoid plain "gpd" etc here (reserved for US below). Use explicit uk/imp.
    [Synonyms(
        "uk gpd", "imp gpd", "igpd",
        "imperial gallon per day", "imperial gallons per day",
        "uk gallon per day", "uk gallons per day",
        "gal (u. k.)/d", "gal (uk)/d", "gal imp/d"
    )]
    public static readonly VolumeFlowUnit UkGallonPerDay = new(VolumeUnit.ImperialGallon, DurationUnit.Day, "gal (U. K.)/d");

    [Synonyms(
        "uk gph", "imp gph", "igph",
        "imperial gallon per hour", "imperial gallons per hour",
        "uk gallon per hour", "uk gallons per hour",
        "gal (uk)/h", "gal imp/h"
    )]
    public static readonly VolumeFlowUnit UkGallonPerHour = new(VolumeUnit.ImperialGallon, DurationUnit.Hour);

    [Synonyms(
        "uk gpm", "imp gpm", "igpm",
        "imperial gallon per minute", "imperial gallons per minute",
        "uk gallon per minute", "uk gallons per minute",
        "gal (uk)/min", "gal imp/min"
    )]
    public static readonly VolumeFlowUnit UkGallonPerMinute = new(VolumeUnit.ImperialGallon, DurationUnit.Minute);

    [Synonyms(
        "uk gps", "imp gps", "igps",
        "imperial gallon per second", "imperial gallons per second",
        "uk gallon per second", "uk gallons per second",
        "gal (uk)/s", "gal imp/s"
    )]
    public static readonly VolumeFlowUnit UkGallonPerSecond = new(VolumeUnit.ImperialGallon, DurationUnit.Second);

    // --- US gallons per time ---
    [Synonyms(
        "gpd",
        "us gpd", "gallon per day", "gallons per day",
        "us gallon per day", "us gallons per day",
        "gal (us)/d", "gal us/d"
    )]
    public static readonly VolumeFlowUnit UsGallonPerDay = new(VolumeUnit.UsGallon, DurationUnit.Day, "gpd");

    [Synonyms(
        "gph",
        "us gph", "gallon per hour", "gallons per hour",
        "us gallon per hour", "us gallons per hour",
        "gal (us)/h", "gal us/h"
    )]
    public static readonly VolumeFlowUnit UsGallonPerHour = new(VolumeUnit.UsGallon, DurationUnit.Hour);

    [Synonyms(
        "gpm",
        "us gpm", "gallon per minute", "gallons per minute",
        "us gallon per minute", "us gallons per minute",
        "gal (us)/min", "gal us/min"
    )]
    public static readonly VolumeFlowUnit UsGallonPerMinute = new(VolumeUnit.UsGallon, DurationUnit.Minute);

    [Synonyms(
        "gps",
        "us gps", "gallon per second", "gallons per second",
        "us gallon per second", "us gallons per second",
        "gal (us)/s", "gal us/s"
    )]
    public static readonly VolumeFlowUnit UsGallonPerSecond = new(VolumeUnit.UsGallon, DurationUnit.Second);

    // --- Mega UK gallon per second ---
    // Avoid case-dependent "MIGD/MIGS" style abbreviations; use words/safe forms.
    [Synonyms(
        "mega uk gallons per second", "mega uk gallon per second",
        "million uk gallons per second", "million imperial gallons per second",
        "mega imperial gallons per second", "mega imperial gallon per second",
        "megaukgallonpersecond", "megaukgallonspersecond"
    )]
    public static readonly VolumeFlowUnit MegaukGallonPerSecond = new(PreFix.mega, UkGallonPerSecond);

    public VolumeFlowUnit(VolumeUnit volume, DurationUnit duration, decimal correction = 1)
    {
        Unit = new UnitSystem(volume / duration  * correction,
                            $"{volume}/{duration}");
    }

    public VolumeFlowUnit(VolumeUnit volume, DurationUnit duration, string NewSymbol, decimal correction = 1)
    {
        Unit = new UnitSystem(volume / duration * correction,
                              NewSymbol);
    }

    public VolumeFlowUnit(PreFix SI, VolumeFlowUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}