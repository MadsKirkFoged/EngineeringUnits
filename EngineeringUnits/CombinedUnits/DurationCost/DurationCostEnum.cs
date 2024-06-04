namespace EngineeringUnits.Units;
public partial record DurationCostUnit : UnitTypebase
{

    public static readonly DurationCostUnit SI = new(CostUnit.SI, DurationUnit.SI);

    public static readonly DurationCostUnit USDollarPerSecond =  new(CostUnit.USDollar, DurationUnit.Second);
    public static readonly DurationCostUnit USDollarPerMinute =  new(CostUnit.USDollar, DurationUnit.Minute);
    public static readonly DurationCostUnit USDollarPerHour =    new(CostUnit.USDollar, DurationUnit.Hour);
    public static readonly DurationCostUnit USDollarPerDay =     new(CostUnit.USDollar, DurationUnit.Day);
    public static readonly DurationCostUnit USDollarPerMonth30 = new(CostUnit.USDollar, DurationUnit.Month30);
    public static readonly DurationCostUnit USDollarPerYear365 = new(CostUnit.USDollar, DurationUnit.Year365);
    public static readonly DurationCostUnit MillionUSDollarPerSecond =  new(CostUnit.MillionUSDollar, DurationUnit.Second);
    public static readonly DurationCostUnit MillionUSDollarPerMinute =  new(CostUnit.MillionUSDollar, DurationUnit.Minute);
    public static readonly DurationCostUnit MillionUSDollarPerHour =    new(CostUnit.MillionUSDollar, DurationUnit.Hour);
    public static readonly DurationCostUnit MillionUSDollarPerDay =     new(CostUnit.MillionUSDollar, DurationUnit.Day);
    public static readonly DurationCostUnit MillionUSDollarPerMonth30 = new(CostUnit.MillionUSDollar, DurationUnit.Month30);
    public static readonly DurationCostUnit MillionUSDollarPerYear365 = new(CostUnit.MillionUSDollar, DurationUnit.Year365);

    public DurationCostUnit(CostUnit cost, DurationUnit duration)
    {
        UnitSystem localUnit = cost / duration;
        var localSymbol = $"{cost}/{duration}";

        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
