namespace EngineeringUnits.Units;

public partial record ApparentEnergyUnit : UnitTypebase
{

    public static readonly ApparentEnergyUnit SI = new(ElectricPotentialUnit.SI, ElectricCurrentUnit.SI, DurationUnit.SI);

    public static readonly ApparentEnergyUnit VoltampereHour = new(ElectricPotentialUnit.Volt, ElectricCurrentUnit.Ampere, DurationUnit.Hour, "VAh");
    public static readonly ApparentEnergyUnit MegavoltampereHour = new(PreFix.mega, VoltampereHour);
    public static readonly ApparentEnergyUnit KilovoltampereHour = new(PreFix.kilo, VoltampereHour);

    public ApparentEnergyUnit(ElectricPotentialUnit electricPotential, ElectricCurrentUnit electricCurrentUnit, DurationUnit durationUnit, string? NewSymbol = null)
    {
        Unit = new UnitSystem(electricPotential * electricCurrentUnit * durationUnit, NewSymbol);
    }

    public ApparentEnergyUnit(PreFix SI, ApparentEnergyUnit unit) : base(SI, unit) { }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}