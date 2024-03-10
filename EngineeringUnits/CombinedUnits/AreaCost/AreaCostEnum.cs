namespace EngineeringUnits.Units;
public partial record AreaCostUnit : UnitTypebase
{

    public static readonly AreaCostUnit SI = new(CostUnit.SI, AreaUnit.SI);
    public static readonly AreaCostUnit USDollarPerSquareMeter = new(CostUnit.USDollar, AreaUnit.SquareMeter);
    public static readonly AreaCostUnit MillionUSDollarPerSquareMeter = new(CostUnit.MillionUSDollar, AreaUnit.SquareMeter);
    public static readonly AreaCostUnit EuroPerSquareMeter = new(CostUnit.Euro, AreaUnit.SquareMeter);

    public AreaCostUnit(CostUnit cost, AreaUnit area)
    {
        UnitSystem localUnit = cost / area;
        var localSymbol = $"{cost}/{area}";

        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
