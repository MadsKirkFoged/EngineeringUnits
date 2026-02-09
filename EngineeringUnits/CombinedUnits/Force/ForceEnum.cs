using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record ForceUnit : UnitTypebase
{
    
    public static readonly ForceUnit SI = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "N");

    [Synonyms( "n", "newton", "newtons", "si force unit" )]
    public static readonly ForceUnit Newton = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "N");

    [Synonyms(
        "µn", "μn", "un",
        "micronewton", "micronewtons",
        "micro-newton", "micro-newtons"
    )]
    public static readonly ForceUnit Micronewton = new(PreFix.micro, Newton);

    [Synonyms(
        "mn",
        "millinewton", "millinewtons",
        "milli-newton", "milli-newtons"
    )]
    public static readonly ForceUnit Millinewton = new(PreFix.milli, Newton);

    [Synonyms(
        "dan",
        "decanewton", "decanewtons",
        "deka-newton", "deka-newtons"
    )]
    public static readonly ForceUnit Decanewton = new(PreFix.deka, Newton);

    [Synonyms(
        "kn",
        "kilonewton", "kilonewtons",
        "kilo-newton", "kilo-newtons"
    )]
    public static readonly ForceUnit Kilonewton = new(PreFix.kilo, Newton);

    [Synonyms(
        "mn",  // NOTE: conflicts with millinewton if case-insensitive
        "mnw", // optional alternative if you need a disambiguator
        "mn (mega)", // probably remove if your parser is strict
        "mn (meganewton)"
    )]
    public static readonly ForceUnit Meganewton = new(PreFix.mega, Newton);

    [Synonyms(
    "dyn",
    "dyne", "dynes"
)]
    public static readonly ForceUnit Dyn = new(MassUnit.Gram, LengthUnit.Centimeter, DurationUnit.SI, "dyn");

    [Synonyms(
        "tf",            // OK if you reserve tf for tonne-force only
        "tonne-force", "tonne force",
        "metric ton-force", "metric ton force",
        "metric tonne-force", "metric tonne force",
        "tonnef", "tonnef", "tonf (metric)"
    )]
    public static readonly ForceUnit TonneForce = new(MassUnit.Tonne, AccelerationUnit.StandardGravity);

    [Synonyms(
        "short ton-force", "short ton force",
        "us ton-force", "us ton force",
        "ustf", "tonf (short)", "ton-force (short)"
    // avoid "tf" and "ton-force" alone to prevent ambiguity
    )]
    public static readonly ForceUnit ShortTonForce = new(MassUnit.ShortTon, AccelerationUnit.StandardGravity, "tf (short)");

    [Synonyms(
        "lbf", "lb_f", "lb-force", "lb force",
        "pound-force", "pound force",
        "pounds-force", "pounds force"
    )]
    public static readonly ForceUnit PoundForce = new(MassUnit.Pound, AccelerationUnit.StandardGravity);

    [Synonyms(
        "kgf",
        "kilogram-force", "kilogram force",
        "kilograms-force", "kilograms force"
    )]
    public static readonly ForceUnit KilogramForce = new(MassUnit.Kilogram, AccelerationUnit.StandardGravity);

    [Synonyms(
        "ozf", "oz_f", "oz-force", "oz force",
        "ounce-force", "ounce force",
        "ounces-force", "ounces force"
    )]
    public static readonly ForceUnit OunceForce = new(MassUnit.Ounce, AccelerationUnit.StandardGravity);

    [Synonyms(
        "kp",
        "kilopond", "kiloponds"
    )]
    public static readonly ForceUnit KiloPond = new(MassUnit.Kilogram, AccelerationUnit.StandardGravity, "kp");

    [Synonyms(
        "kip", "kipf", "klbf",
        "kilopound-force", "kilopound force",
        "kips" // often plural usage in structural engineering
    )]
    public static readonly ForceUnit KilopoundForce = new(MassUnit.Kilopound, AccelerationUnit.StandardGravity, "kipf");

    [Synonyms(
        "mlbf",
        "megapound-force", "megapound force",
        "million pound-force", "million pound force"
    )]
    public static readonly ForceUnit MegapoundForce = new(MassUnit.Megapound, AccelerationUnit.StandardGravity, "Mlbf");

    [Synonyms(
        "pdl",
        "poundal", "poundals"
    )]
    public static readonly ForceUnit Poundal = new(MassUnit.SI, LengthUnit.SI, DurationUnit.SI, "pdl", 0.138254954376m);



    public ForceUnit(MassUnit mass, LengthUnit Length, DurationUnit duration, string NewSymbol, decimal correction = 1)
    {
        Unit = new UnitSystem(mass * Length / duration.Pow(2) * correction, NewSymbol);
    }

    public ForceUnit(MassUnit mass, AccelerationUnit acceleration, string NewSymbol)
    {
        Unit = new UnitSystem(mass * acceleration, NewSymbol);
    }

    public ForceUnit(MassUnit mass, AccelerationUnit acceleration)
    {
        Unit = new UnitSystem(mass * acceleration,
                           $"{mass}f");
    }

    public ForceUnit(PreFix SI, ForceUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}