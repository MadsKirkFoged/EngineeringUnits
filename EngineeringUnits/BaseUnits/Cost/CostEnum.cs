using Fractions;
using static EngineeringUnits.ExchangeRates;

#pragma warning disable IDE0060
namespace EngineeringUnits.Units;

public partial record CostUnit : UnitTypebase
{
    public static readonly CostUnit SI = new CostUnit("USD", "$", GetRate(Currency.USDollar));
    public static readonly CostUnit USDollar = new CostUnit("USD", "$", GetRate(Currency.USDollar));
    public static readonly CostUnit MillionUSDollar = new CostUnit("USD", "M$", GetRate(Currency.USDollar) * 1000000m);

    public static readonly CostUnit Euro = new CostUnit("Euro", "€", GetRate(Currency.Euro));
    public static readonly CostUnit BritishPound = new CostUnit("GBP", "£", GetRate(Currency.BritishPound));
    public static readonly CostUnit DanishKrone = new CostUnit("DKK", "kr", GetRate(Currency.DKK));

    // The code that's violating the rule is on this line.
    public CostUnit(string code, string Symbol, decimal Rate)
    {
        var unit = new RawUnit()
        {
            Symbol = Symbol,
            A = (Fraction)Rate,
            UnitType = BaseunitType.Cost,
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
