using EngineeringUnits.Parsing;
using Fractions;

namespace EngineeringUnits.Units;

public partial record LengthUnit : UnitTypebase
{

    // --- Metric SI base ---
    [Synonyms("meter", "metre", "meters", "metres")]
    public static readonly LengthUnit Meter = new(PreFix.SI);

    // NOTE: "SI" is a separate instance. Keep it discoverable but avoid mapping it to "m".
    // Field name "SI" will already be mapped by registry.
    [Synonyms("si")]
    public static readonly LengthUnit SI = new(PreFix.SI);

    // --- Metric prefixes ---
    [Synonyms("kilometer", "kilometre", "kilometers", "kilometres", "km")]
    public static readonly LengthUnit Kilometer = new(PreFix.kilo);

    [Synonyms("hectometer", "hectometre", "hectometers", "hectometres", "hm")]
    public static readonly LengthUnit Hectometer = new(PreFix.hecto);

    [Synonyms("decimeter", "decimetre", "decimeters", "decimetres", "dm")]
    public static readonly LengthUnit Decimeter = new(PreFix.deci);

    [Synonyms("centimeter", "centimetre", "centimeters", "centimetres", "cm")]
    public static readonly LengthUnit Centimeter = new(PreFix.centi);

    [Synonyms("millimeter", "millimetre", "millimeters", "millimetres", "mm")]
    public static readonly LengthUnit Millimeter = new(PreFix.milli);

    [Synonyms("micrometer", "micrometre", "micrometers", "micrometres", "micron", "microns", "um", "µm")]
    public static readonly LengthUnit Micrometer = new(PreFix.micro);

    [Synonyms("nanometer", "nanometre", "nanometers", "nanometres", "nm")]
    public static readonly LengthUnit Nanometer = new(PreFix.nano);

    // --- Typography / small units ---
    [Synonyms("microinch", "microinches", "uin", "µin", "micro-inch", "micro inch")]
    public static readonly LengthUnit Microinch = new("µin", new Fraction(1e-6m) * new Fraction(0.0254m));

    [Synonyms("twip", "twips")]
    public static readonly LengthUnit Twip = new("twip", new Fraction(1, 1440) * new Fraction(0.0254m));

    [Synonyms("mil", "mils", "thou", "thousandth", "thousandth of an inch")]
    public static readonly LengthUnit Mil = new("mil", new Fraction(1, 1000) * new Fraction(0.0254m));

    [Synonyms("point", "points", "pt", "dtp point", "dtppoint")]
    public static readonly LengthUnit DtpPoint = new("pt", new Fraction(1, 72) * new Fraction(0.0254m));

    // IMPORTANT: Do NOT add "pc" here (conflicts with Parsec).
    [Synonyms("pica", "picas", "dtp pica", "dtppica")]
    public static readonly LengthUnit DtpPica = new("pica", new Fraction(1, 6) * new Fraction(0.0254m));

    // --- Imperial / customary ---
    [Synonyms("inch", "inches", "in", "\"")]
    public static readonly LengthUnit Inch = new("in", new Fraction(1) * new Fraction(0.0254m));

    [Synonyms("hand", "hands", "hh")]
    public static readonly LengthUnit Hand = new("h", new Fraction(4) * new Fraction(0.0254m));

    [Synonyms("foot", "feet", "ft", "'")]
    public static readonly LengthUnit Foot = new("ft", new Fraction(12) * new Fraction(0.0254m));

    [Synonyms("yard", "yards", "yd")]
    public static readonly LengthUnit Yard = new("yd", new Fraction(36) * new Fraction(0.0254m));

    [Synonyms("fathom", "fathoms", "ftm")]
    public static readonly LengthUnit Fathom = new("fathom", new Fraction(72) * new Fraction(0.0254m));

    [Synonyms("chain", "chains", "ch")]
    public static readonly LengthUnit Chain = new("ch", new Fraction(792) * new Fraction(0.0254m));

    [Synonyms("shackle", "shackles")]
    public static readonly LengthUnit Shackle = new("shackle", new Fraction(1080) * new Fraction(0.0254m));

    [Synonyms("mile", "miles", "mi")]
    public static readonly LengthUnit Mile = new("mi", new Fraction(63360) * new Fraction(0.0254m));

    [Synonyms("nautical mile", "nautical miles", "nauticalmile", "nauticalmiles", "nmi", "nm")]
    public static readonly LengthUnit NauticalMile = new("NM", new Fraction(72913.3858m) * new Fraction(0.0254m));

    [Synonyms("us survey foot", "u.s. survey foot", "survey foot", "usft", "ftus", "ftUS")]
    public static readonly LengthUnit UsSurveyFoot = new("ftUS", new Fraction(1200, 3937));

    // --- Astronomy ---
    [Synonyms("lightyear", "lightyears", "light year", "light years", "ly")]
    public static readonly LengthUnit LightYear = new("ly", 9460730472580800m);

    [Synonyms("kilolightyear", "kilolightyears", "kilo lightyear", "kilo light year", "kly")]
    public static readonly LengthUnit KilolightYear = new("kly", 9460730472580800m * 1e+3m);

    [Synonyms("megalightyear", "megalightyears", "mega lightyear", "mega light year", "mly", "Mly")]
    public static readonly LengthUnit MegalightYear = new("Mly", 9460730472580800m * 1e+6m);

    [Synonyms("solar radius", "solarradius", "rsun", "r_sun", "r☉", "R☉", "Rsun")]
    public static readonly LengthUnit SolarRadius = new("R⊙", 6.95510000E+08m);

    [Synonyms("astronomical unit", "astronomicalunit", "au", "AU")]
    public static readonly LengthUnit AstronomicalUnit = new("au", 149597870700m);

    [Synonyms("parsec", "parsecs", "pc")]
    public static readonly LengthUnit Parsec = new("pc", 30856775814913673m);

    [Synonyms("kiloparsec", "kiloparsecs", "kpc")]
    public static readonly LengthUnit Kiloparsec = new("kpc", 30856775814913673m * 1e+3m);

    [Synonyms("megaparsec", "megaparsecs", "mpc", "Mpc")]
    public static readonly LengthUnit Megaparsec = new("Mpc", 30856775814913673m * 1e+6m);


    public LengthUnit() { }

    public LengthUnit(string symbol, Fraction a1)
    {
        var unit = new RawUnit()
        {
            Symbol=symbol,
            A = a1,
            UnitType = BaseunitType.length,
            B = 0,
            Count = 1,

        };

        Unit = new UnitSystem(unit);

    }

    public LengthUnit(string NewSymbol, decimal Constant)
    {
        var unit = new RawUnit()
        {
            Symbol=NewSymbol,
            A = new Fraction(Constant),
            UnitType = BaseunitType.length,
            B = 0,
            Count = 1,

        };

        Unit = new UnitSystem(unit);
    }

    public LengthUnit(PreFix SI)
    {

        var unit = new RawUnit()
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.length),
            A = new Fraction(PrefixSISize(SI)),
            UnitType = BaseunitType.length,
            B = 0,
            Count = 1,

        };

        Unit = new UnitSystem(unit);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}