using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -1, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class LapseRate : BaseUnit
{
    public LapseRate() { }
    public LapseRate(decimal value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LapseRate(double value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LapseRate(int value, LapseRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LapseRate(UnknownUnit value) : base(value) { }

    public static LapseRate From(double value, LapseRateUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static LapseRate? From(double? value, LapseRateUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(LapseRateUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LapseRate ToUnit(LapseRateUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LapseRate Zero => new(0, LapseRateUnit.SI);
    public static LapseRate NaN => new(double.NaN, LapseRateUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator LapseRate?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, LapseRateUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(LapseRate? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LapseRateUnit>(_unit);
}
