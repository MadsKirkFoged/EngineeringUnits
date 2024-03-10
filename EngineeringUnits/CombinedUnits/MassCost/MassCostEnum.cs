namespace EngineeringUnits.Units;

public partial record MassCostUnit : UnitTypebase
{
    public static readonly MassCostUnit SI = new(CostUnit.SI, MassUnit.SI);
    public static readonly MassCostUnit EuroPerKilogram = new(CostUnit.Euro, MassUnit.Kilogram);
    public static readonly MassCostUnit USDollarPerKilogram = new(CostUnit.USDollar, MassUnit.Kilogram);
    public static readonly MassCostUnit USDollarPerTonne = new(CostUnit.USDollar, MassUnit.Tonne);
    public static readonly MassCostUnit MillionUSDollarPerTonne = new(CostUnit.MillionUSDollar, MassUnit.Tonne);

    public MassCostUnit(CostUnit cost, MassUnit mass)
    {
        UnitSystem localUnit = cost / mass;
        var localSymbol = $"{cost}/{mass}";

        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
