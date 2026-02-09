using EngineeringUnits.Parsing;
using Fractions;
using Newtonsoft.Json;

namespace EngineeringUnits.Units;

[JsonObject(ItemNullValueHandling = NullValueHandling.Ignore, ItemTypeNameHandling = TypeNameHandling.All)]
public partial record MassUnit : UnitTypebase
{
    public static readonly MassUnit SI = new($"{PrefixSISymbol(PreFix.kilo)}g", PrefixSISize(PreFix.kilo) / 1000m);

    [Synonyms("kilogram", "kilograms", "kilogramme", "kilogrammes", "kg")]
    public static readonly MassUnit Kilogram = new($"{PrefixSISymbol(PreFix.kilo)}g", PrefixSISize(PreFix.kilo) / 1000m);

    [Synonyms("picogram", "picograms")]
    public static readonly MassUnit Picogram = new($"{PrefixSISymbol(PreFix.pico)}g", PrefixSISize(PreFix.pico) / 1000m);

    [Synonyms("centigram", "centigrams")]
    public static readonly MassUnit Centigram = new($"{PrefixSISymbol(PreFix.centi)}g", PrefixSISize(PreFix.centi) / 1000m);

    [Synonyms("decagram", "decagrams")]
    public static readonly MassUnit Decagram = new($"{PrefixSISymbol(PreFix.deka)}g", PrefixSISize(PreFix.deka) / 1000m);

    [Synonyms("decigram", "decigrams")]
    public static readonly MassUnit Decigram = new($"{PrefixSISymbol(PreFix.deci)}g", PrefixSISize(PreFix.deci) / 1000m);

    [Synonyms("gram", "grams", "gramme", "grammes")]
    public static readonly MassUnit Gram = new($"g", PrefixSISize(PreFix.SI) / 1000m);

    [Synonyms("hectogram", "hectograms")]
    public static readonly MassUnit Hectogram = new($"{PrefixSISymbol(PreFix.hecto)}g", PrefixSISize(PreFix.hecto) / 1000m);

    [Synonyms("microgram", "micrograms", "mcg")]
    public static readonly MassUnit Microgram = new($"{PrefixSISymbol(PreFix.micro)}g", PrefixSISize(PreFix.micro) / 1000m);

    [Synonyms("milligram", "milligrams")]
    public static readonly MassUnit Milligram = new($"{PrefixSISymbol(PreFix.milli)}g", PrefixSISize(PreFix.milli) / 1000m);

    [Synonyms("nanogram", "nanograms")]
    public static readonly MassUnit Nanogram = new($"{PrefixSISymbol(PreFix.nano)}g", PrefixSISize(PreFix.nano) / 1000m);

    [Synonyms("tonne", "tonnes", "metrictonne", "metrictonnes")]
    public static readonly MassUnit Tonne = new("t", 1e+3m);

    [Synonyms("kilotonne", "kilotonnes")]
    public static readonly MassUnit Kilotonne = new("kt", 1e+6m);

    [Synonyms("megatonne", "megatonnes")]
    public static readonly MassUnit Megatonne = new("Mt", 1e+9m);

    [Synonyms("earthmass", "earthmasses")]
    public static readonly MassUnit EarthMass = new("em", 5.9722m * 1e24m);


    [Synonyms("ounce", "ounces")]
    public static readonly MassUnit Ounce = new("oz", 1 / 16m * 0.45359237m);

    [Synonyms("pound", "pounds")]
    public static readonly MassUnit Pound = new("lb", 1 * 0.45359237m);

    [Synonyms("stone", "stones")]
    public static readonly MassUnit Stone = new("st", 14 * 0.45359237m);

    [Synonyms("slug", "slugs")]
    public static readonly MassUnit Slug = new("slug", 32.174m * 0.45359237m);

    // Skipping synonyms here: “hundredweight” is ambiguous (short vs long) and “cwt” collides
    public static readonly MassUnit ShortHundredweight = new("cwt", 100 * 0.45359237m);

    // Skipping synonyms here: “hundredweight” is ambiguous (short vs long) and “cwt” collides
    public static readonly MassUnit LongHundredweight = new("cwt", 112 * 0.45359237m);

    [Synonyms("kilopound", "kilopounds")]
    public static readonly MassUnit Kilopound = new("kip", 1000 * 0.45359237m);

    [Synonyms("shortton", "shorttons", "short-ton", "short-tons")]
    public static readonly MassUnit ShortTon = new("t (short)", 2000 * 0.45359237m);

    [Synonyms("longton", "longtons", "imperialton", "imperialtons", "long-ton", "long-tons")]
    public static readonly MassUnit LongTon = new("long tn", 2240 * 0.45359237m);

    [Synonyms("megapound", "megapounds")]
    public static readonly MassUnit Megapound = new("Mlb", 1e6m * 0.45359237m);

    [Synonyms("grain", "grains")]
    public static readonly MassUnit Grain = new("gr", 0.00006479891m);

    public MassUnit() { }

    public MassUnit(string symbol, decimal Constant)
    {
        var unit = new RawUnit()
        {
            Symbol=symbol,
            A = new Fraction(Constant),
            UnitType = BaseunitType.mass,
            B = 0,
            Count = 1,

        };

        Unit = new UnitSystem(unit);
    }

    public MassUnit(PreFix SI)
    {
        var unit = new RawUnit()
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.mass),
            A = new Fraction(PrefixSISize(SI)/1000m),
            B = 0,
            Count = 1,
            UnitType = BaseunitType.mass,

        };

        Unit = new UnitSystem(unit);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
        {
            return $"{Unit.Symbol}";
        }

        return $"{Unit}";
    }
}