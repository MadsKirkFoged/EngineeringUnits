using Fractions;

namespace EngineeringUnits.Units;

public partial record LuminousIntensityUnit : UnitTypebase
{
    public static readonly LuminousIntensityUnit SI = new(PreFix.SI);
    public static readonly LuminousIntensityUnit Candela = new("cd", 1);


    public LuminousIntensityUnit(string symbol, decimal Constant)
    {
        var unit = new RawUnit()
        {
            Symbol=symbol,
            A = new Fraction(Constant),
            UnitType = BaseunitType.luminousIntensity,
            B = 0,
            Count = 1,

        };


        Unit = new UnitSystem(unit);
    }


    public LuminousIntensityUnit(PreFix SI)
    {
        var unit = new RawUnit()
        {
            Symbol = PrefixSISymbol(SI) + BaseUnitSISymbol(BaseunitType.luminousIntensity),
            A = new Fraction(PrefixSISize(SI)),
            B = 0,
            Count = 1,
            UnitType = BaseunitType.luminousIntensity,
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