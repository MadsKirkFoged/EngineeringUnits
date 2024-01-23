using System;

namespace EngineeringUnits.Units;

[Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
public record TemperatureDeltaUnit : UnitTypebase
{
    public static readonly TemperatureUnit SI = new("K", 1m, 1m, 0m);

    public TemperatureDeltaUnit() { }

}