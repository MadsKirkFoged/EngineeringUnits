using EngineeringUnits.Parsing;

namespace EngineeringUnits.Units;

public partial record EnthalpyUnit : UnitTypebase
{

    public static readonly EnthalpyUnit SI = new(EnergyUnit.SI, MassUnit.SI);

    [Synonyms("j/kg", "j/kg", "jouleperkilogram", "joulesperkilogram", "joule per kilogram", "joules per kilogram")]
    public static readonly EnthalpyUnit JoulePerKilogram = new(EnergyUnit.Joule, MassUnit.Kilogram);

    [Synonyms("kj/kg", "kilojouleperkilogram", "kilojoulesperkilogram", "kilojoule per kilogram", "kilojoules per kilogram")]
    public static readonly EnthalpyUnit KilojoulePerKilogram = new(EnergyUnit.Kilojoule, MassUnit.Kilogram);

    [Synonyms("mj/kg", "megajouleperkilogram", "megajoulesperkilogram", "megajoule per kilogram", "megajoules per kilogram")]
    public static readonly EnthalpyUnit MegajoulePerKilogram = new(EnergyUnit.Megajoule, MassUnit.Kilogram);

    [Synonyms("btu/lb", "btuperpound", "btusperpound", "btu per pound", "btus per pound")]
    public static readonly EnthalpyUnit BtuPerPound = new(EnergyUnit.BritishThermalUnit, MassUnit.Pound);

    public static readonly EnthalpyUnit CaloriePerGram = new(EnergyUnit.Calorie, MassUnit.Gram);
    public static readonly EnthalpyUnit KilocaloriePerGram = new(EnergyUnit.Kilocalorie, MassUnit.Gram);
    public static readonly EnthalpyUnit WattDayPerKilogram = new(EnergyUnit.WattDay, MassUnit.Kilogram);
    public static readonly EnthalpyUnit KilowattDayPerKilogram = new(EnergyUnit.KilowattDay, MassUnit.Kilogram);
    public static readonly EnthalpyUnit MegawattDayPerKilogram = new(EnergyUnit.MegawattDay, MassUnit.Kilogram);
    public static readonly EnthalpyUnit GigawattDayPerKilogram = new(EnergyUnit.GigawattDay, MassUnit.Kilogram);
    public static readonly EnthalpyUnit TerawattDayPerKilogram = new(EnergyUnit.TerawattDay, MassUnit.Kilogram);
    public static readonly EnthalpyUnit WattHourPerKilogram = new(EnergyUnit.WattHour, MassUnit.Kilogram);
    public static readonly EnthalpyUnit KilowattHourPerKilogram = new(EnergyUnit.KilowattHour, MassUnit.Kilogram);
    public static readonly EnthalpyUnit MegawattHourPerKilogram = new(EnergyUnit.MegawattHour, MassUnit.Kilogram);
    public static readonly EnthalpyUnit GigawattHourPerKilogram = new(EnergyUnit.GigawattHour, MassUnit.Kilogram);
    public static readonly EnthalpyUnit WattDayPerTonne = new(EnergyUnit.WattDay, MassUnit.Tonne);
    public static readonly EnthalpyUnit KilowattDayPerTonne = new(EnergyUnit.KilowattDay, MassUnit.Tonne);
    public static readonly EnthalpyUnit MegawattDayPerTonne = new(EnergyUnit.MegawattDay, MassUnit.Tonne);
    public static readonly EnthalpyUnit GigawattDayPerTonne = new(EnergyUnit.GigawattDay, MassUnit.Tonne);
    public static readonly EnthalpyUnit TerawattDayPerTonne = new(EnergyUnit.TerawattDay, MassUnit.Tonne);
    public static readonly EnthalpyUnit WattDayPerShortTon = new(EnergyUnit.WattDay, MassUnit.ShortTon);
    public static readonly EnthalpyUnit KilowattDayPerShortTon = new(EnergyUnit.KilowattDay, MassUnit.ShortTon);
    public static readonly EnthalpyUnit MegawattDayPerShortTon = new(EnergyUnit.MegawattDay, MassUnit.ShortTon);
    public static readonly EnthalpyUnit GigawattDayPerShortTon = new(EnergyUnit.GigawattDay, MassUnit.ShortTon);
    public static readonly EnthalpyUnit TerawattDayPerShortTon = new(EnergyUnit.TerawattDay, MassUnit.ShortTon);

    public EnthalpyUnit(EnergyUnit energy, MassUnit mass)
    {
        Unit = new UnitSystem(energy / mass,
                            $"{energy}/{mass}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}