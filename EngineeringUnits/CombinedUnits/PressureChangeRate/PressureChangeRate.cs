using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
public partial class PressureChangeRate : BaseUnit
{
    public PressureChangeRate() { }
    public PressureChangeRate(decimal value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PressureChangeRate(double value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PressureChangeRate(int value, PressureChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public PressureChangeRate(UnknownUnit value) : base(value) { }

    public static PressureChangeRate From(double value, PressureChangeRateUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static PressureChangeRate? From(double? value, PressureChangeRateUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(PressureChangeRateUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public PressureChangeRate ToUnit(PressureChangeRateUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static PressureChangeRate Zero => new(0, PressureChangeRateUnit.SI);
    public static PressureChangeRate NaN => new(double.NaN, PressureChangeRateUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator PressureChangeRate?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, PressureChangeRateUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(PressureChangeRate? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PressureChangeRateUnit>(_unit);
}
