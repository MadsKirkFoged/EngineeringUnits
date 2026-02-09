using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record MassFlowUnit : UnitTypebase
{

    // MassFlowUnit synonyms (ready to paste)

    [Synonyms("cg/day", "cg/d", "centigram per day", "centigrams per day", "centigramperday", "centigramsperday")]
    public static readonly MassFlowUnit CentigramPerDay = new(MassUnit.Centigram, DurationUnit.Day);

    [Synonyms("cg/s", "cg/sec", "centigram per second", "centigrams per second", "centigrampersecond", "centigramspersecond")]
    public static readonly MassFlowUnit CentigramPerSecond = new(MassUnit.Centigram, DurationUnit.Second);

    [Synonyms("dag/day", "dag/d", "decagram per day", "decagrams per day", "decagramperday", "decagramsperday", "dkg/day", "dkg/d")]
    public static readonly MassFlowUnit DecagramPerDay = new(MassUnit.Decagram, DurationUnit.Day);

    [Synonyms("dag/s", "dag/sec", "decagram per second", "decagrams per second", "decagrampersecond", "decagramspersecond", "dkg/s", "dkg/sec")]
    public static readonly MassFlowUnit DecagramPerSecond = new(MassUnit.Decagram, DurationUnit.Second);

    [Synonyms("dg/day", "dg/d", "decigram per day", "decigrams per day", "decigramperday", "decigramsperday")]
    public static readonly MassFlowUnit DecigramPerDay = new(MassUnit.Decigram, DurationUnit.Day);

    [Synonyms("dg/s", "dg/sec", "decigram per second", "decigrams per second", "decigrampersecond", "decigramspersecond")]
    public static readonly MassFlowUnit DecigramPerSecond = new(MassUnit.Decigram, DurationUnit.Second);

    [Synonyms("g/day", "g/d", "gram per day", "grams per day", "gramperday", "gramsperday")]
    public static readonly MassFlowUnit GramPerDay = new(MassUnit.Gram, DurationUnit.Day);

    [Synonyms("g/hour", "g/hr", "g/h", "gram per hour", "grams per hour", "gramperhour", "gramsperhour")]
    public static readonly MassFlowUnit GramPerHour = new(MassUnit.Gram, DurationUnit.Hour);

    [Synonyms("g/s", "g/sec", "gram per second", "grams per second", "grampersecond", "gramspersecond")]
    public static readonly MassFlowUnit GramPerSecond = new(MassUnit.Gram, DurationUnit.Second);

    [Synonyms(
        // If your parsing is CASE-SENSITIVE, you can safely add: "Mg/day", "Mg/d"
        "megagram per day", "megagrams per day", "megagramperday", "megagramsperday",
        // Safe equivalences (1 Mg == 1 tonne):
        "t/day", "t/d", "tonne/day", "tonne per day", "tonnes per day",
        "metric ton/day", "metric ton per day", "metric tons per day"
    )]
    public static readonly MassFlowUnit MegagramPerDay = new(PreFix.mega, GramPerDay);

    [Synonyms("µg/s", "ug/s", "mcg/s", "microgram per second", "micrograms per second", "microgrampersecond", "microgramspersecond")]
    public static readonly MassFlowUnit MicrogramPerSecond = new(PreFix.micro, GramPerSecond);

    [Synonyms("µg/day", "ug/day", "mcg/day", "µg/d", "ug/d", "mcg/d", "microgram per day", "micrograms per day", "microgramperday", "microgramsperday")]
    public static readonly MassFlowUnit MicrogramPerDay = new(PreFix.micro, GramPerDay);

    [Synonyms("mg/s", "mg/sec", "milligram per second", "milligrams per second", "milligrampersecond", "milligramspersecond")]
    public static readonly MassFlowUnit MilligramPerSecond = new(PreFix.milli, GramPerSecond);

    [Synonyms("mg/day", "mg/d", "milligram per day", "milligrams per day", "milligramperday", "milligramsperday")]
    public static readonly MassFlowUnit MilligramPerDay = new(PreFix.milli, GramPerDay);

    [Synonyms("ng/s", "ng/sec", "nanogram per second", "nanograms per second", "nanogrampersecond", "nanogramspersecond")]
    public static readonly MassFlowUnit NanogramPerSecond = new(PreFix.nano, GramPerSecond);

    [Synonyms("ng/day", "ng/d", "nanogram per day", "nanograms per day", "nanogramperday", "nanogramsperday")]
    public static readonly MassFlowUnit NanogramPerDay = new(PreFix.nano, GramPerDay);

    [Synonyms("hg/day", "hg/d", "hectogram per day", "hectograms per day", "hectogramperday", "hectogramsperday")]
    public static readonly MassFlowUnit HectogramPerDay = new(MassUnit.Hectogram, DurationUnit.Day);

    [Synonyms("hg/s", "hg/sec", "hectogram per second", "hectograms per second", "hectogrampersecond", "hectogramspersecond")]
    public static readonly MassFlowUnit HectogramPerSecond = new(MassUnit.Hectogram, DurationUnit.Second);

    [Synonyms(
        // Optional: Only include these if you want "SI" to be parseable from strings:
        // "si", "si unit", "si mass flow",
        "kg/s", "kg/sec", "kilogram per second", "kilograms per second", "kilogrampersecond", "kilogramspersecond"
    )]
    public static readonly MassFlowUnit SI = new(MassUnit.SI, DurationUnit.SI);

    [Synonyms("kg/s", "kg/sec", "kilogram per second", "kilograms per second", "kilogrampersecond", "kilogramspersecond")]
    public static readonly MassFlowUnit KilogramPerSecond = new(MassUnit.Kilogram, DurationUnit.Second);

    [Synonyms("kg/min", "kg/m", "kilogram per minute", "kilograms per minute", "kilogramperminute", "kilogramsperminute")]
    public static readonly MassFlowUnit KilogramPerMinute = new(MassUnit.Kilogram, DurationUnit.Minute);

    [Synonyms("kg/hour", "kg/hr", "kg/h", "kilogram per hour", "kilograms per hour", "kilogramperhour", "kilogramsperhour")]
    public static readonly MassFlowUnit KilogramPerHour = new(MassUnit.Kilogram, DurationUnit.Hour);

    [Synonyms("kg/day", "kg/d", "kilogram per day", "kilograms per day", "kilogramperday", "kilogramsperday")]
    public static readonly MassFlowUnit KilogramPerDay = new(MassUnit.Kilogram, DurationUnit.Day);

    [Synonyms("lb/s", "lb/sec", "lbs/s", "lbs/sec", "pound per second", "pounds per second", "poundpersecond", "poundspersecond")]
    public static readonly MassFlowUnit PoundPerSecond = new(MassUnit.Pound, DurationUnit.SI);

    [Synonyms("lb/min", "lb/m", "lbs/min", "lbs/m", "pound per minute", "pounds per minute", "poundperminute", "poundsperminute")]
    public static readonly MassFlowUnit PoundPerMinute = new(MassUnit.Pound, DurationUnit.Minute);

    [Synonyms("lb/hour", "lb/hr", "lb/h", "lbs/hour", "lbs/hr", "lbs/h", "pound per hour", "pounds per hour", "poundperhour", "poundsperhour")]
    public static readonly MassFlowUnit PoundPerHour = new(MassUnit.Pound, DurationUnit.Hour);

    [Synonyms("lb/day", "lb/d", "lbs/day", "lbs/d", "pound per day", "pounds per day", "poundperday", "poundsperday")]
    public static readonly MassFlowUnit PoundPerDay = new(MassUnit.Pound, DurationUnit.Day);

    [Synonyms(
        "Mlb/day", "Mlb/d",
        "million lb/day", "million lbs/day", "million pounds/day",
        "megapound per day", "megapounds per day", "megapoundperday", "megapoundsperday"
    )]
    public static readonly MassFlowUnit MegapoundPerDay = new(PreFix.mega, PoundPerDay);

    [Synonyms(
        "Mlb/hour", "Mlb/hr", "Mlb/h",
        "million lb/hour", "million lbs/hour", "million pounds/hour",
        "megapound per hour", "megapounds per hour", "megapoundperhour", "megapoundsperhour"
    )]
    public static readonly MassFlowUnit MegapoundPerHour = new(PreFix.mega, PoundPerHour);

    [Synonyms(
        "Mlb/min", "Mlb/m",
        "million lb/min", "million lbs/min", "million pounds/min",
        "megapound per minute", "megapounds per minute", "megapoundperminute", "megapoundsperminute"
    )]
    public static readonly MassFlowUnit MegapoundPerMinute = new(PreFix.mega, PoundPerMinute);

    [Synonyms(
        "Mlb/s", "Mlb/sec",
        "million lb/s", "million lbs/s", "million pounds/s",
        "megapound per second", "megapounds per second", "megapoundpersecond", "megapoundspersecond"
    )]
    public static readonly MassFlowUnit MegapoundPerSecond = new(PreFix.mega, PoundPerSecond);

    [Synonyms(
        "short tn/h", "short tn/hr",
        "short ton/h", "short ton/hr",
        "short ton per hour", "short tons per hour",
        "st/h", "st/hr"
    // Avoid "ton/h" alone (ambiguous: short ton vs tonne)
    )]
    public static readonly MassFlowUnit ShortTonPerHour = new(MassUnit.ShortTon, DurationUnit.Hour, "short tn/h");

    [Synonyms("t/day", "t/d", "tonne/day", "tonne per day", "tonnes per day", "metric ton/day", "metric ton per day", "metric tons per day")]
    public static readonly MassFlowUnit TonnePerDay = new(MassUnit.Tonne, DurationUnit.Day);

    [Synonyms("t/hour", "t/hr", "t/h", "tonne/hour", "tonne per hour", "tonnes per hour", "metric ton/hr", "metric ton per hour", "metric tons per hour")]
    public static readonly MassFlowUnit TonnePerHour = new(MassUnit.Tonne, DurationUnit.Hour);

    public MassFlowUnit(MassUnit mass, DurationUnit duration, string NewSymbol)
    {
        Unit = new UnitSystem(mass / duration, NewSymbol);
    }

    public MassFlowUnit(MassUnit mass, DurationUnit duration)
    {
        Unit = new UnitSystem(mass / duration,
                           $"{mass}/{duration}");
    }

    public MassFlowUnit(PreFix SI, MassFlowUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}