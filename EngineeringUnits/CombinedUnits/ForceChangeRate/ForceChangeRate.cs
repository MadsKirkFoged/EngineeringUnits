using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ForceChangeRate : BaseUnit
{
    public ForceChangeRate() { }
    public ForceChangeRate(Fraction value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceChangeRate(decimal value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceChangeRate(double value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceChangeRate(int value, ForceChangeRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceChangeRate(UnknownUnit value) : base(value) { }

    public static ForceChangeRate From(double value, ForceChangeRateUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ForceChangeRate? From(double? value, ForceChangeRateUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ForceChangeRateUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ForceChangeRate ToUnit(ForceChangeRateUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ForceChangeRate Zero => new(0, ForceChangeRateUnit.SI);
    public static ForceChangeRate NaN => new(double.NaN, ForceChangeRateUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ForceChangeRate?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ForceChangeRateUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ForceChangeRate? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ForceChangeRateUnit>(_unit);
}
