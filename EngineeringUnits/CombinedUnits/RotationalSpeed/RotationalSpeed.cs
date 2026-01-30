using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -1, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class RotationalSpeed : BaseUnit
{
    public RotationalSpeed() { }
    public RotationalSpeed(decimal value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public RotationalSpeed(double value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public RotationalSpeed(int value, RotationalSpeedUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public RotationalSpeed(UnknownUnit value) : base(value) { }

    public static RotationalSpeed From(double value, RotationalSpeedUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static RotationalSpeed? From(double? value, RotationalSpeedUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(RotationalSpeedUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public RotationalSpeed ToUnit(RotationalSpeedUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static RotationalSpeed Zero => new(0, RotationalSpeedUnit.SI);
    public static RotationalSpeed NaN => new(double.NaN, RotationalSpeedUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator RotationalSpeed?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, RotationalSpeedUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(RotationalSpeed? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<RotationalSpeedUnit>(_unit);
}
