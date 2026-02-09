using EngineeringUnits.Parsing;
using Fractions;

namespace EngineeringUnits.Units;

public partial record ElectricCurrentUnit : UnitTypebase
{

    public static readonly ElectricCurrentUnit SI = new(PreFix.SI);

    [Synonyms("ampere", "amperes", "amp", "amps", "A")]
    public static readonly ElectricCurrentUnit Ampere = new(PreFix.SI);

    [Synonyms("centiampere", "centiamperes", "cA")]
    public static readonly ElectricCurrentUnit Centiampere = new(PreFix.centi);

    [Synonyms("kiloampere", "kiloamperes", "kA")]
    public static readonly ElectricCurrentUnit Kiloampere = new(PreFix.kilo);

    [Synonyms("megaampere", "megaamperes", "MA")]
    public static readonly ElectricCurrentUnit Megaampere = new(PreFix.mega);

    [Synonyms("microampere", "microamperes", "µA", "uA")]
    public static readonly ElectricCurrentUnit Microampere = new(PreFix.micro);

    [Synonyms("milliampere", "milliamperes", "mA")]
    public static readonly ElectricCurrentUnit Milliampere = new(PreFix.milli);

    [Synonyms("nanoampere", "nanoamperes", "nA")]
    public static readonly ElectricCurrentUnit Nanoampere = new(PreFix.nano);

    [Synonyms("picoampere", "picoamperes", "pA")]
    public static readonly ElectricCurrentUnit Picoampere = new(PreFix.pico);

    public ElectricCurrentUnit() { }

    public ElectricCurrentUnit(PreFix SI)
    {
        var unit = new RawUnit()
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.electricCurrent),
            A = new Fraction(PrefixSISize(SI)),
            B = 0,
            Count = 1,
            UnitType = BaseunitType.electricCurrent,

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