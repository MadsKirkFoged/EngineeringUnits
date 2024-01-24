using Fractions;

namespace EngineeringUnits.Units;

public partial record DurationUnit : UnitTypebase
{


    public static readonly DurationUnit Nanosecond =    new(PreFix.nano);
    public static readonly DurationUnit Millisecond =   new(PreFix.milli);
    public static readonly DurationUnit Microsecond =   new(PreFix.micro);
    public static readonly DurationUnit Second =        new(PreFix.SI);

    public static readonly DurationUnit Minute =        new("min", 60m);
    public static readonly DurationUnit Hour =          new("h", 3600m);
    public static readonly DurationUnit Day =           new("day", 24*3600m);
    public static readonly DurationUnit Week =          new("wk", 7*24*3600m);
    public static readonly DurationUnit Month30 =       new("mo", 30 * 24 * 3600m);
    public static readonly DurationUnit Year365 =       new("yr", 365*24*3600m);
    public static readonly DurationUnit SI =            new(PreFix.SI);

    public DurationUnit() { }


    public DurationUnit(string symbol, decimal Constant)
    {
        var unit = new RawUnit()
        {
            Symbol=symbol,
            A = new Fraction(Constant),
            UnitType = BaseunitType.time,
            B = 0,
            Count = 1,

        };


        Unit = new UnitSystem(unit);
    }


    public DurationUnit(PreFix SI)
    {
        var unit = new RawUnit()
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.time),
            A = new Fraction(PrefixSISize(SI)),
            B = 0,
            Count = 1,
            UnitType = BaseunitType.time,

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