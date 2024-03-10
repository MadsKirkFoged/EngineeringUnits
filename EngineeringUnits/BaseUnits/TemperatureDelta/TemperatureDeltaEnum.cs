using Fractions;
using System;

namespace EngineeringUnits.Units;

[Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
public record TemperatureDeltaUnit : UnitTypebase
{
    public static readonly TemperatureUnit SI = new("K", 1m, Fraction.Zero);

    public TemperatureDeltaUnit() { }
}