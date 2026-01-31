using EngineeringUnits.Units;
using System;

namespace EngineeringUnits;

[Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
public partial class TemperatureDelta : BaseUnit
{

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public TemperatureDelta()
    {
    }

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public TemperatureDelta(int value, TemperatureUnit selectedUnit) : this()
    {
    }

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public TemperatureDelta(double value, TemperatureUnit selectedUnit) : this()
    {
    }

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public TemperatureDelta(decimal value, TemperatureUnit selectedUnit) : this()
    {
    }

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta From(double value, TemperatureUnit unit) => new(value, unit);

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public double As(TemperatureUnit ReturnInThisUnit) => (double)this.GetValueAs(ReturnInThisUnit.Unit);

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public TemperatureDelta ToUnit(TemperatureUnit selectedUnit) => new TemperatureDelta(this.GetValueAs2(selectedUnit.Unit), selectedUnit);

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static TemperatureDelta Zero => new(0, TemperatureUnit.SI);

    [Obsolete("TemperatureDelta has been removed - Just use Temperature instead")]
    public static implicit operator TemperatureDelta(UnknownUnit Unit)
    {
        TemperatureDelta local = new(0, TemperatureUnit.SI);

        //local.Transform(Unit);
        return local;
    }
}
