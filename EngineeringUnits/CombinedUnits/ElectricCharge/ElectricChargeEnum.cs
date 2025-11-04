namespace EngineeringUnits.Units;

public partial record ElectricChargeUnit : UnitTypebase
{
    public static readonly ElectricChargeUnit SI = new(ElectricCurrentUnit.SI, DurationUnit.SI, "C");
    public static readonly ElectricChargeUnit Coulomb = new(ElectricCurrentUnit.Ampere, DurationUnit.Second, "C");

    // Large units
    public static readonly ElectricChargeUnit Teracoulomb = new(PreFix.tera, Coulomb);
    public static readonly ElectricChargeUnit Gigacoulomb = new(PreFix.giga, Coulomb);
    public static readonly ElectricChargeUnit Megacoulomb = new(PreFix.mega, Coulomb);
    public static readonly ElectricChargeUnit Kilocoulomb = new(PreFix.kilo, Coulomb);

    // Small units
    public static readonly ElectricChargeUnit Millicoulomb = new(PreFix.milli, Coulomb);
    public static readonly ElectricChargeUnit Microcoulomb = new(PreFix.micro, Coulomb);
    public static readonly ElectricChargeUnit Nanocoulomb = new(PreFix.nano, Coulomb);
    public static readonly ElectricChargeUnit Picocoulomb = new(PreFix.pico, Coulomb);

    // Ampere-hour based units
    public static readonly ElectricChargeUnit AmpereHour = new(ElectricCurrentUnit.Ampere, DurationUnit.Hour, "A-h");
    public static readonly ElectricChargeUnit KiloampereHour = new(PreFix.kilo, AmpereHour);
    public static readonly ElectricChargeUnit MegaampereHour = new(PreFix.mega, AmpereHour);
    public static readonly ElectricChargeUnit MilliampereHour = new(PreFix.milli, AmpereHour);

    public ElectricChargeUnit(ElectricCurrentUnit electricCurrent, DurationUnit duration, string newSymbol)
    {
        Unit = new UnitSystem(electricCurrent * duration, newSymbol);
    }

    public ElectricChargeUnit(PreFix SI, ElectricChargeUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        return Unit.Symbol is not null ? $"{Unit.Symbol}" : $"{Unit}";
    }
}