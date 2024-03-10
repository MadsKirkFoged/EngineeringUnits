namespace EngineeringUnits.Units;

public partial record ElectricPotentialChangeRateUnit : UnitTypebase
{

    public static readonly ElectricPotentialChangeRateUnit SI = new(ElectricPotentialUnit.SI, DurationUnit.SI);
    public static readonly ElectricPotentialChangeRateUnit VoltPerSecond = new(ElectricPotentialUnit.Volt, DurationUnit.Second);
    public static readonly ElectricPotentialChangeRateUnit VoltPerMinute = new(ElectricPotentialUnit.Volt, DurationUnit.Minute);
    public static readonly ElectricPotentialChangeRateUnit VoltPerMicrosecond = new(ElectricPotentialUnit.Volt, DurationUnit.Microsecond);
    public static readonly ElectricPotentialChangeRateUnit VoltPerHour = new(ElectricPotentialUnit.Volt, DurationUnit.Hour);

    public static readonly ElectricPotentialChangeRateUnit MillivoltPerSecond = new(ElectricPotentialUnit.Millivolt, DurationUnit.Second);
    public static readonly ElectricPotentialChangeRateUnit MillivoltPerMinute = new(ElectricPotentialUnit.Millivolt, DurationUnit.Minute);
    public static readonly ElectricPotentialChangeRateUnit MillivoltPerMicrosecond = new(ElectricPotentialUnit.Millivolt, DurationUnit.Microsecond);
    public static readonly ElectricPotentialChangeRateUnit MillivoltPerHour = new(ElectricPotentialUnit.Millivolt, DurationUnit.Hour);

    public static readonly ElectricPotentialChangeRateUnit MicrovoltPerSecond = new(ElectricPotentialUnit.Microvolt, DurationUnit.Second);
    public static readonly ElectricPotentialChangeRateUnit MicrovoltPerMinute = new(ElectricPotentialUnit.Microvolt, DurationUnit.Minute);
    public static readonly ElectricPotentialChangeRateUnit MicrovoltPerMicrosecond = new(ElectricPotentialUnit.Microvolt, DurationUnit.Microsecond);
    public static readonly ElectricPotentialChangeRateUnit MicrovoltPerHour = new(ElectricPotentialUnit.Microvolt, DurationUnit.Hour);

    public static readonly ElectricPotentialChangeRateUnit MegavoltPerSecond = new(ElectricPotentialUnit.Megavolt, DurationUnit.Second);
    public static readonly ElectricPotentialChangeRateUnit MegavoltPerMinute = new(ElectricPotentialUnit.Megavolt, DurationUnit.Minute);
    public static readonly ElectricPotentialChangeRateUnit MegavoltPerMicrosecond = new(ElectricPotentialUnit.Megavolt, DurationUnit.Microsecond);
    public static readonly ElectricPotentialChangeRateUnit MegavoltPerHour = new(ElectricPotentialUnit.Megavolt, DurationUnit.Hour);

    public static readonly ElectricPotentialChangeRateUnit KilovoltPerSecond = new(ElectricPotentialUnit.Kilovolt, DurationUnit.Second);
    public static readonly ElectricPotentialChangeRateUnit KilovoltPerMinute = new(ElectricPotentialUnit.Kilovolt, DurationUnit.Minute);
    public static readonly ElectricPotentialChangeRateUnit KilovoltPerMicrosecond = new(ElectricPotentialUnit.Kilovolt, DurationUnit.Microsecond);
    public static readonly ElectricPotentialChangeRateUnit KilovoltPerHour = new(ElectricPotentialUnit.Kilovolt, DurationUnit.Hour);

    public ElectricPotentialChangeRateUnit(ElectricPotentialUnit electricPotential, DurationUnit duration)
    {
        Unit = new UnitSystem(electricPotential / duration,
                           $"{electricPotential}/{duration}");
    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}