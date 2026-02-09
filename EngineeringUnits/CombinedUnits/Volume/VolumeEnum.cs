using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record VolumeUnit : UnitTypebase
{

    // VolumeUnit synonyms (case-insensitive-safe; avoids case-dependent abbreviations)

    // --- SI / cubic meter family ---
    [Synonyms(
        "m3", "m^3", "m³",
        "cubic meter", "cubic meters",
        "cubic metre", "cubic metres",
        "meter cubed", "meters cubed",
        "metre cubed", "metres cubed"
    )]
    public static readonly VolumeUnit SI = new(LengthUnit.SI);

    [Synonyms(
        "m3", "m^3", "m³",
        "cubic meter", "cubic meters",
        "cubic metre", "cubic metres",
        "meter cubed", "meters cubed",
        "metre cubed", "metres cubed"
    )]
    public static readonly VolumeUnit CubicMeter = new(LengthUnit.Meter);

    // NOTE: Avoid "hm3" here (often means cubic hectometer). Use words instead.
    [Synonyms(
        "hectocubic meter", "hectocubic meters",
        "hecto cubic meter", "hecto cubic meters",
        "hectocubic metre", "hectocubic metres",
        "hundred cubic meters", "hundred cubic metres",
        "100 cubic meters", "100 cubic metres"
    )]
    public static readonly VolumeUnit HectocubicMeter = new(PreFix.hecto, CubicMeter);

    // NOTE: Avoid "km3" here (that’s cubic kilometer). Use words instead.
    [Synonyms(
        "kilocubic meter", "kilocubic meters",
        "kilo cubic meter", "kilo cubic meters",
        "kilocubic metre", "kilocubic metres",
        "thousand cubic meters", "thousand cubic metres",
        "1000 cubic meters", "1000 cubic metres"
    )]
    public static readonly VolumeUnit KilocubicMeter = new(PreFix.kilo, CubicMeter);

    [Synonyms(
        "km3", "km^3", "km³",
        "cubic kilometer", "cubic kilometers",
        "cubic kilometre", "cubic kilometres",
        "kilometer cubed", "kilometers cubed",
        "kilometre cubed", "kilometres cubed"
    )]
    public static readonly VolumeUnit CubicKilometer = new(LengthUnit.Kilometer);

    [Synonyms(
        "um3", "um^3", "um³",
        "µm3", "µm^3", "µm³",
        "cubic micrometer", "cubic micrometers",
        "cubic micrometre", "cubic micrometres",
        "micrometer cubed", "micrometers cubed",
        "micrometre cubed", "micrometres cubed"
    )]
    public static readonly VolumeUnit CubicMicrometer = new(LengthUnit.Micrometer);

    [Synonyms(
        "mi3", "mi^3", "mi³",
        "cubic mile", "cubic miles",
        "mile cubed", "miles cubed"
    )]
    public static readonly VolumeUnit CubicMile = new(LengthUnit.Mile);

    [Synonyms(
        "mm3", "mm^3", "mm³",
        "cubic millimeter", "cubic millimeters",
        "cubic millimetre", "cubic millimetres",
        "millimeter cubed", "millimeters cubed",
        "millimetre cubed", "millimetres cubed"
    )]
    public static readonly VolumeUnit CubicMillimeter = new(LengthUnit.Millimeter);

    [Synonyms(
        "yd3", "yd^3", "yd³",
        "cu yd", "cuyd",
        "cubic yard", "cubic yards",
        "yard cubed", "yards cubed"
    )]
    public static readonly VolumeUnit CubicYard = new(LengthUnit.Yard);

    [Synonyms(
        "in3", "in^3", "in³",
        "cu in", "cuin",
        "cubic inch", "cubic inches",
        "inch cubed", "inches cubed"
    )]
    public static readonly VolumeUnit CubicInch = new(LengthUnit.Inch);

    [Synonyms(
        "hm3", "hm^3", "hm³",
        "cubic hectometer", "cubic hectometers",
        "cubic hectometre", "cubic hectometres",
        "hectometer cubed", "hectometers cubed",
        "hectometre cubed", "hectometres cubed"
    )]
    public static readonly VolumeUnit CubicHectometer = new(LengthUnit.Hectometer);

    [Synonyms(
        "ft3", "ft^3", "ft³",
        "cu ft", "cuft",
        "cubic foot", "cubic feet",
        "foot cubed", "feet cubed"
    )]
    public static readonly VolumeUnit CubicFoot = new(LengthUnit.Foot);

    // NOTE: Avoid abbreviated forms like "hcf" (not standard). Use words instead.
    [Synonyms(
        "hectocubic foot", "hectocubic feet",
        "hecto cubic foot", "hecto cubic feet",
        "hundred cubic feet", "100 cubic feet"
    )]
    public static readonly VolumeUnit HectocubicFoot = new(PreFix.hecto, CubicFoot);

    // NOTE: Avoid "kcf" if you worry about conventions; keep words.
    [Synonyms(
        "kilocubic foot", "kilocubic feet",
        "kilo cubic foot", "kilo cubic feet",
        "thousand cubic feet", "1000 cubic feet"
    )]
    public static readonly VolumeUnit KilocubicFoot = new(PreFix.kilo, CubicFoot);

    // NOTE: Avoid "mcf" (often means thousand cubic feet in industry). Use words.
    [Synonyms(
        "megacubic foot", "megacubic feet",
        "mega cubic foot", "mega cubic feet",
        "million cubic feet"
    )]
    public static readonly VolumeUnit MegacubicFoot = new(PreFix.mega, CubicFoot);

    [Synonyms(
        "dm3", "dm^3", "dm³",
        "cubic decimeter", "cubic decimeters",
        "cubic decimetre", "cubic decimetres",
        "decimeter cubed", "decimeters cubed",
        "decimetre cubed", "decimetres cubed"
    )]
    public static readonly VolumeUnit CubicDecimeter = new(LengthUnit.Decimeter);

    [Synonyms(
        "cm3", "cm^3", "cm³",
        "cc",
        "cubic centimeter", "cubic centimeters",
        "cubic centimetre", "cubic centimetres",
        "centimeter cubed", "centimeters cubed",
        "centimetre cubed", "centimetres cubed"
    )]
    public static readonly VolumeUnit CubicCentimeter = new(LengthUnit.Centimeter);

    // --- Liter family ---
    // NOTE: keep both "l" and "liter/litre" spellings; avoid "L" reliance (case-insensitive anyway).
    [Synonyms(
        "l",
        "liter", "liters",
        "litre", "litres"
    )]
    public static readonly VolumeUnit Liter = new(LengthUnit.Decimeter, "l");

    [Synonyms(
        "nl",
        "nanoliter", "nanoliters",
        "nanolitre", "nanolitres"
    )]
    public static readonly VolumeUnit Nanoliter = new(PreFix.nano, Liter);

    [Synonyms(
        "ul", "µl",
        "microliter", "microliters",
        "microlitre", "microlitres"
    )]
    public static readonly VolumeUnit Microliter = new(PreFix.micro, Liter);

    [Synonyms(
        "ml",
        "milliliter", "milliliters",
        "millilitre", "millilitres"
    )]
    public static readonly VolumeUnit Milliliter = new(PreFix.milli, Liter);

    [Synonyms(
        "dl",
        "deciliter", "deciliters",
        "decilitre", "decilitres"
    )]
    public static readonly VolumeUnit Deciliter = new(PreFix.deci, Liter);

    [Synonyms(
        "cl",
        "centiliter", "centiliters",
        "centilitre", "centilitres"
    )]
    public static readonly VolumeUnit Centiliter = new(PreFix.centi, Liter);

    [Synonyms(
        "hl",
        "hectoliter", "hectoliters",
        "hectolitre", "hectolitres"
    )]
    public static readonly VolumeUnit Hectoliter = new(PreFix.hecto, Liter);

    [Synonyms(
        "kl",
        "kiloliter", "kiloliters",
        "kilolitre", "kilolitres"
    )]
    public static readonly VolumeUnit Kiloliter = new(PreFix.kilo, Liter);

    // NOTE: Do NOT use "ml" / "ML" here (collides with milliliter if case-insensitive). Words only.
    [Synonyms(
        "megaliter", "megaliters",
        "megalitre", "megalitres",
        "mega liter", "mega litre"
    )]
    public static readonly VolumeUnit Megaliter = new(PreFix.mega, Liter);

    [Synonyms(
        "pl",
        "picoliter", "picoliters",
        "picolitre", "picolitres"
    )]
    public static readonly VolumeUnit Picoliter = new(PreFix.pico, Liter);

    // --- Land / lumber volumes ---
    [Synonyms(
        "acre-foot", "acre foot", "acre feet",
        "ac-ft", "ac ft",
        "af" // optional; remove if it conflicts in your domain
    )]
    public static readonly VolumeUnit AcreFoot = new(AreaUnit.Acre, LengthUnit.Foot);

    [Synonyms(
        "bf",
        "board foot", "board feet",
        "board-foot", "board-feet",
        "bdft", "bd ft"
    )]
    public static readonly VolumeUnit BoardFoot = new(AreaUnit.SquareFoot, LengthUnit.Inch, "bf");

    // --- Spoons / cups (be explicit to avoid ambiguity across regions) ---
    [Synonyms(
        "australian tablespoon", "au tablespoon",
        "tablespoon (au)", "tablespoon (australia)",
        "tbsp (au)", "au tbsp"
    )]
    public static readonly VolumeUnit AuTablespoon = new(LengthUnit.Meter, "", 2e-5m);

    [Synonyms(
        "imperial beer barrel", "beer barrel (imperial)",
        "imperial barrel (beer)", "bl (imp.)", "bl imp", "imp bl"
    )]
    public static readonly VolumeUnit ImperialBeerBarrel = new(LengthUnit.Meter, "bl (imp.)", 0.16365924m);

    [Synonyms(
        "tsp",
        "metric teaspoon", "teaspoon (metric)",
        "metric tsp"
    )]
    public static readonly VolumeUnit MetricTeaspoon = new(LengthUnit.Meter, "tsp", 0.5e-5m);

    [Synonyms(
        "metric cup", "cup (metric)"
    )]
    public static readonly VolumeUnit MetricCup = new(LengthUnit.Meter, "", 0.00025m);

    // --- Imperial/UK liquid measures ---
    [Synonyms(
        "imperial gallon", "uk gallon", "british gallon",
        "gal (imp.)", "gal imp", "imp gal"
    )]
    public static readonly VolumeUnit ImperialGallon = new(LengthUnit.Meter, "gal (imp.)", 0.00454609000000181429905810072407m);

    [Synonyms(
        "kilo imperial gallon", "kil oimperial gallon",
        "thousand imperial gallons", "1000 imperial gallons",
        "kimp gal", "kilo imp gal"
    )]
    public static readonly VolumeUnit KiloimperialGallon = new(PreFix.kilo, ImperialGallon);

    [Synonyms(
        "mega imperial gallon",
        "million imperial gallons", "1000000 imperial gallons"
    )]
    public static readonly VolumeUnit MegaimperialGallon = new(PreFix.mega, ImperialGallon);

    [Synonyms(
        "imperial fluid ounce", "imp fluid ounce",
        "fl oz (imp)", "imp fl oz",
        "oz (imp.)", "oz imp"
    )]
    public static readonly VolumeUnit ImperialOunce = new(LengthUnit.Meter, "oz (imp.)", 2.8413062499962901241875439064617e-5m);

    [Synonyms(
        "imperial pint", "uk pint", "british pint",
        "pt (imp.)", "pt imp", "imp pt"
    )]
    public static readonly VolumeUnit ImperialPint = new(LengthUnit.Meter, "pt (imp.)", 5.6826125e-4m);

    // --- US measures ---
    [Synonyms(
        "us cup", "cup (us)", "us customary cup", "cup (us customary)"
    )]
    public static readonly VolumeUnit UsCustomaryCup = new(LengthUnit.Meter, "", 0.0002365882365m);

    [Synonyms(
        "us beer barrel", "beer barrel (us)",
        "bl (u.s.)", "bl us", "us bl"
    )]
    public static readonly VolumeUnit UsBeerBarrel = new(LengthUnit.Meter, "bl (U.S.)", 0.1173477658m);

    [Synonyms(
        "uk tablespoon", "british tablespoon",
        "tablespoon (uk)", "tablespoon (britain)",
        "tbsp (uk)", "uk tbsp"
    )]
    public static readonly VolumeUnit UkTablespoon = new(LengthUnit.Meter, "", 1.5e-5m);

    [Synonyms(
        "us fluid ounce", "fluid ounce (us)",
        "fl oz", "us fl oz",
        "oz (u.s.)", "oz us"
    )]
    public static readonly VolumeUnit UsOunce = new(LengthUnit.Meter, "oz (U.S.)", 2.957352956253760505068307980135e-5m);

    [Synonyms(
        "us gallon", "gallon (us)", "us liquid gallon",
        "gal (u.s.)", "gal us", "us gal"
    )]
    public static readonly VolumeUnit UsGallon = new(UsOunce, "gal (U.S.)", 128m);

    [Synonyms(
        "kilo us gallon", "kilo us gallons",
        "thousand us gallons", "1000 us gallons"
    )]
    public static readonly VolumeUnit KilousGallon = new(PreFix.kilo, UsGallon);

    [Synonyms(
        "mega us gallon", "mega us gallons",
        "million us gallons", "1000000 us gallons"
    )]
    public static readonly VolumeUnit MegausGallon = new(PreFix.mega, UsGallon);

    [Synonyms(
        "deka us gallon", "deca us gallon",
        "ten us gallons", "10 us gallons"
    )]
    public static readonly VolumeUnit DecausGallon = new(PreFix.deka, UsGallon);

    [Synonyms(
        "deci us gallon",
        "tenth us gallon", "0.1 us gallon"
    )]
    public static readonly VolumeUnit DeciusGallon = new(PreFix.deci, UsGallon);

    [Synonyms(
        "hecto us gallon",
        "hundred us gallons", "100 us gallons"
    )]
    public static readonly VolumeUnit HectousGallon = new(PreFix.hecto, UsGallon);

    [Synonyms(
        "bbl",
        "oil barrel", "barrel of oil", "petroleum barrel", "petroleum bbl"
    )]
    public static readonly VolumeUnit OilBarrel = new(UsGallon, "bbl", 42);

    [Synonyms(
        "us legal cup", "legal cup (us)", "uslegalcup"
    )]
    public static readonly VolumeUnit UsLegalCup = new(LengthUnit.Meter, "", 0.00024m);

    [Synonyms(
        "us pint", "pint (us)",
        "pt (u.s.)", "pt us", "us pt"
    )]
    public static readonly VolumeUnit UsPint = new(UsOunce, "pt (U.S.)", 16);

    [Synonyms(
        "us quart", "quart (us)",
        "qt (u.s.)", "qt us", "us qt"
    )]
    public static readonly VolumeUnit UsQuart = new(UsOunce, "qt (U.S.)", 32);

    // NOTE: I map plain "tbsp" to US tablespoon (most common). UK/AU require qualifier above.
    [Synonyms(
        "tbsp", "tablespoon",
        "us tablespoon", "tablespoon (us)", "us tbsp"
    )]
    public static readonly VolumeUnit UsTablespoon = new(UsOunce, "", 1 / 2m);

    // NOTE: Do NOT include plain "tsp" here (it’s already used by MetricTeaspoon). Use US-specific forms.
    [Synonyms(
        "us tsp", "us teaspoon",
        "teaspoon (us)", "ustsp"
    )]
    public static readonly VolumeUnit UsTeaspoon = new(UsOunce, "", 1 / 6m);
    //public static VolumeUnit UsLegalCup =         new VolumeUnit(UsOunce, "", 8m);

    public VolumeUnit(LengthUnit Length, string? NewSymbol = null, decimal correction = 1)
    {
        Unit = new UnitSystem(Length.Pow(3) * correction, NewSymbol);
    }

    public VolumeUnit(AreaUnit Area, LengthUnit Length)
    {
        Unit = new UnitSystem(Area * Length,
                           $"{Area}-{Length}");
    }

    public VolumeUnit(AreaUnit Area, LengthUnit Length, string NewSymbol)
    {
        Unit = new UnitSystem(Area * Length,
                              NewSymbol);
    }

    public VolumeUnit(PreFix SI, VolumeUnit unit) : base(SI, unit) { }

    public VolumeUnit(VolumeUnit unit, string NewSymbol = "Empty", decimal correction = 1) : base(unit, NewSymbol, correction) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
        {
            return $"{Unit.Symbol}";
        }

        return $"{Unit}";
    }
}