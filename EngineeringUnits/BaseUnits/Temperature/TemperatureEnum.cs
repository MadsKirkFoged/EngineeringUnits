using EngineeringUnits.Parsing;
using Fractions;

namespace EngineeringUnits.Units;

public partial record TemperatureUnit : UnitTypebase
{
    [Synonyms("kelvin", "kelvins")]
    public static readonly TemperatureUnit Kelvin = new("K", 1m, Fraction.Zero);

    public static readonly TemperatureUnit SI = new("K", 1m, Fraction.Zero);

    [Synonyms("celsius", "degreecelsius", "degrees celsius", "degree celsius", "degc", "deg c")]
    public static readonly TemperatureUnit DegreeCelsius = new("\u00b0C", 1m, Fraction.FromDecimal(273.15m));

    [Synonyms("fahrenheit", "degreefahrenheit", "degrees fahrenheit", "degree fahrenheit", "degf", "deg f")]
    public static readonly TemperatureUnit DegreeFahrenheit = new("\u00b0F", new Fraction(5, 9), Fraction.FromDecimal(273.15m) - (Fraction.FromDecimal(32) * new Fraction(5, 9)));

    [Synonyms("rankine", "degreerankine", "degrees rankine", "degree rankine")]
    public static readonly TemperatureUnit DegreeRankine = new("\u00b0R", new Fraction(5, 9), Fraction.Zero);

    public TemperatureUnit() { }

    public TemperatureUnit(string symbol, decimal a1, Fraction b)
    {
        var unit = new RawUnit()
        {
            Symbol=symbol,
            A = new Fraction(a1),
            UnitType = BaseunitType.temperature,
            B = b,
            Count = 1,

        };

        Unit = new UnitSystem(unit);

    }

    public TemperatureUnit(string symbol, Fraction a1, Fraction b)
    {
        var unit = new RawUnit()
        {
            Symbol=symbol,
            A = a1,
            UnitType = BaseunitType.temperature,
            B = b,
            Count = 1,

        };

        Unit = new UnitSystem(unit);

    }

    public TemperatureUnit(PreFix SI)
    {
        var unit = new RawUnit()
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.temperature),
            A = new Fraction(PrefixSISize(SI)),
            B = 0,
            Count = 1,
            UnitType = BaseunitType.temperature,

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