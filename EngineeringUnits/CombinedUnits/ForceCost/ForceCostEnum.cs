namespace EngineeringUnits.Units;
public partial record ForceCostUnit : UnitTypebase
{

    public static readonly ForceCostUnit SI = new(CostUnit.SI, ForceUnit.SI);
    public static readonly ForceCostUnit USDollarPerNewton = new(CostUnit.USDollar, ForceUnit.Newton);
    public static readonly ForceCostUnit USDollarPerKilonewton = new(CostUnit.USDollar, ForceUnit.Kilonewton);
    public static readonly ForceCostUnit USDollarPerMeganewton = new(CostUnit.USDollar, ForceUnit.Meganewton);

    public ForceCostUnit(CostUnit cost, ForceUnit force)
    {
        UnitSystem localUnit = cost / force;
        var localSymbol = $"{cost}/{force}";

        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }

}    
