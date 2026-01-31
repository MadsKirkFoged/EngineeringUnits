using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class LinearPowerDensity : BaseUnit
{
    public LinearPowerDensity() { }
    public LinearPowerDensity(Fraction value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearPowerDensity(decimal value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearPowerDensity(double value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearPowerDensity(int value, LinearPowerDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LinearPowerDensity(UnknownUnit value) : base(value) { }

    public static LinearPowerDensity From(double value, LinearPowerDensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static LinearPowerDensity? From(double? value, LinearPowerDensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(LinearPowerDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LinearPowerDensity ToUnit(LinearPowerDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LinearPowerDensity Zero => new(0, LinearPowerDensityUnit.SI);
    public static LinearPowerDensity NaN => new(double.NaN, LinearPowerDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator LinearPowerDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, LinearPowerDensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(LinearPowerDensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LinearPowerDensityUnit>(_unit);
}
