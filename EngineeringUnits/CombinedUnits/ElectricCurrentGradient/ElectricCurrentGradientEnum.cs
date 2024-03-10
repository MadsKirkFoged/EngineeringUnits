﻿namespace EngineeringUnits.Units;

public partial record ElectricCurrentGradientUnit : UnitTypebase
{

    public static readonly ElectricCurrentGradientUnit SI = new(ElectricCurrentUnit.SI, DurationUnit.SI);
    public static readonly ElectricCurrentGradientUnit AmperePerSecond = new(ElectricCurrentUnit.Ampere, DurationUnit.Second);
    public static readonly ElectricCurrentGradientUnit AmperePerMicrosecond = new(ElectricCurrentUnit.Ampere, DurationUnit.Microsecond);
    public static readonly ElectricCurrentGradientUnit AmperePerMillisecond = new(ElectricCurrentUnit.Ampere, DurationUnit.Millisecond);
    public static readonly ElectricCurrentGradientUnit AmperePerNanosecond = new(ElectricCurrentUnit.Ampere, DurationUnit.Nanosecond);

    public ElectricCurrentGradientUnit(ElectricCurrentUnit electricCurrent, DurationUnit duration)
    {
        Unit = new UnitSystem(electricCurrent / duration,
                           $"{electricCurrent}/{duration}");

    }

    public override string ToString()
    {
        if (Unit.Symbol is not null)
            return $"{Unit.Symbol}";

        return $"{Unit}";
    }
}