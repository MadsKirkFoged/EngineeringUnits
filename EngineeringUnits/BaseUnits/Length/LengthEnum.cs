using Fractions;

namespace EngineeringUnits.Units;

public partial record LengthUnit : UnitTypebase
{
    public static readonly LengthUnit Kilometer =           new(PreFix.kilo);
    public static readonly LengthUnit Hectometer =          new(PreFix.hecto);
    public static readonly LengthUnit Meter =               new(PreFix.SI);
    public static readonly LengthUnit SI =                  new(PreFix.SI);
    public static readonly LengthUnit Decimeter =           new(PreFix.deci);
    public static readonly LengthUnit Centimeter =          new(PreFix.centi);
    public static readonly LengthUnit Millimeter =          new(PreFix.milli);
    public static readonly LengthUnit Micrometer =          new(PreFix.micro);
    public static readonly LengthUnit Nanometer =           new(PreFix.nano);
    public static readonly LengthUnit Microinch =           new("µin", new Fraction(1e-6m)      * new Fraction(0.0254m));
    public static readonly LengthUnit Twip =                new("twip", new Fraction(1, 1440)   * new Fraction(0.0254m));
    public static readonly LengthUnit Mil =                 new("mil", new Fraction(1,1000)     * new Fraction(0.0254m));
    public static readonly LengthUnit DtpPoint =            new("pt", new Fraction(1,72)        * new Fraction(0.0254m));
    public static readonly LengthUnit DtpPica =             new("pica", new Fraction(1,6)       * new Fraction(0.0254m));
    public static readonly LengthUnit Inch =                new("in", new Fraction(1)           * new Fraction(0.0254m));
    public static readonly LengthUnit Hand =                new("h", new Fraction(4)            * new Fraction(0.0254m));
    public static readonly LengthUnit Foot =                new("ft", new Fraction(12)          * new Fraction(0.0254m));
    public static readonly LengthUnit Yard =                new("yd", new Fraction(36)          * new Fraction(0.0254m));
    public static readonly LengthUnit Fathom =              new("fathom", new Fraction(72)      * new Fraction(0.0254m));
    public static readonly LengthUnit Chain =               new("ch", new Fraction(792)         * new Fraction(0.0254m));
    public static readonly LengthUnit Shackle =             new("shackle", new Fraction(1080)   * new Fraction(0.0254m));
    public static readonly LengthUnit Mile =                new("mi", new Fraction(63360)       * new Fraction(0.0254m));
    public static readonly LengthUnit NauticalMile =        new("NM", new Fraction(72913.3858m) * new Fraction(0.0254m));
    public static readonly LengthUnit UsSurveyFoot =        new("ftUS", new Fraction(1200,3937));
    public static readonly LengthUnit LightYear =           new("ly",           9460730472580800m);
    public static readonly LengthUnit KilolightYear =       new("kly",          9460730472580800m * 1e+3m);
    public static readonly LengthUnit MegalightYear =       new("Mly",          9460730472580800m * 1e+6m);
    public static readonly LengthUnit SolarRadius =         new("R⊙",           6.95510000E+08m);
    public static readonly LengthUnit AstronomicalUnit =    new("au",           149597870700m);
    public static readonly LengthUnit Parsec =              new("pc",           30856775814913673m);
    public static readonly LengthUnit Kiloparsec =          new("kpc",          30856775814913673m * 1e+3m);
    public static readonly LengthUnit Megaparsec =          new("Mpc",          30856775814913673m * 1e+6m);





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