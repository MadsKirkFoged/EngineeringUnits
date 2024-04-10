using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class TemperatureChangeRate : BaseUnit
{
    public TemperatureChangeRate() { }
    public TemperatureChangeRate(decimal value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public TemperatureChangeRate(double value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public TemperatureChangeRate(int value, TemperatureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public TemperatureChangeRate(UnknownUnit value) : base(value) { }

    public static TemperatureChangeRate From(double value, TemperatureChangeRateUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static TemperatureChangeRate? From(double? value, TemperatureChangeRateUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(TemperatureChangeRateUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public TemperatureChangeRate ToUnit(TemperatureChangeRateUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static TemperatureChangeRate Zero => new(0, TemperatureChangeRateUnit.SI);
    public static TemperatureChangeRate NaN => new(double.NaN, TemperatureChangeRateUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator TemperatureChangeRate?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, TemperatureChangeRateUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(TemperatureChangeRate? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<TemperatureChangeRateUnit>(_unit);
}
