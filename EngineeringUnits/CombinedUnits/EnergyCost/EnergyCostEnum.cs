namespace EngineeringUnits.Units;
public partial record EnergyCostUnit : UnitTypebase
{

    public static readonly EnergyCostUnit SI = new(CostUnit.SI, EnergyUnit.SI);
    public static readonly EnergyCostUnit USDollarPerJoule = new(CostUnit.USDollar, EnergyUnit.Joule);
    public static readonly EnergyCostUnit USDollarPerKilojoule = new(CostUnit.USDollar, EnergyUnit.Kilojoule);
    public static readonly EnergyCostUnit USDollarPerMegajoule = new(CostUnit.USDollar, EnergyUnit.Megajoule);
    public static readonly EnergyCostUnit USDollarPerGigajoule = new(CostUnit.USDollar, EnergyUnit.Gigajoule);
    public static readonly EnergyCostUnit USDollarPerKilowattHour = new(CostUnit.USDollar, EnergyUnit.KilowattHour);
    public static readonly EnergyCostUnit DKKPerKilowattHour = new(CostUnit.DanishKrone, EnergyUnit.KilowattHour);
    public static readonly EnergyCostUnit USDollarPerMegawattHour = new(CostUnit.USDollar, EnergyUnit.MegawattHour);
    public static readonly EnergyCostUnit MillionUSDollarPerJoule = new(CostUnit.MillionUSDollar, EnergyUnit.Joule);
    public static readonly EnergyCostUnit MillionUSDollarPerKilojoule = new(CostUnit.MillionUSDollar, EnergyUnit.Kilojoule);
    public static readonly EnergyCostUnit MillionUSDollarPerMegajoule = new(CostUnit.MillionUSDollar, EnergyUnit.Megajoule);
    public static readonly EnergyCostUnit MillionUSDollarPerGigajoule = new(CostUnit.MillionUSDollar, EnergyUnit.Gigajoule);
    public static readonly EnergyCostUnit MillionUSDollarPerKilowattHour = new(CostUnit.MillionUSDollar, EnergyUnit.KilowattHour);
    public static readonly EnergyCostUnit MillionUSDollarPerMegawattHour = new(CostUnit.MillionUSDollar, EnergyUnit.MegawattHour);

    public EnergyCostUnit(CostUnit cost, EnergyUnit energy)
    {
        UnitSystem localUnit = cost / energy;
        var localSymbol = $"{cost}/{energy}";

        Unit = new UnitSystem(localUnit, localSymbol);
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}
