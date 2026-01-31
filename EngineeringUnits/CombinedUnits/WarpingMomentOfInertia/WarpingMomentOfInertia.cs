using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 6, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class WarpingMomentOfInertia : BaseUnit
{
    public WarpingMomentOfInertia() { }
    public WarpingMomentOfInertia(Fraction value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public WarpingMomentOfInertia(decimal value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public WarpingMomentOfInertia(double value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public WarpingMomentOfInertia(int value, WarpingMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public WarpingMomentOfInertia(UnknownUnit value) : base(value) { }

    public static WarpingMomentOfInertia From(double value, WarpingMomentOfInertiaUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static WarpingMomentOfInertia? From(double? value, WarpingMomentOfInertiaUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(WarpingMomentOfInertiaUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public WarpingMomentOfInertia ToUnit(WarpingMomentOfInertiaUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static WarpingMomentOfInertia Zero => new(0, WarpingMomentOfInertiaUnit.SI);
    public static WarpingMomentOfInertia NaN => new(double.NaN, WarpingMomentOfInertiaUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator WarpingMomentOfInertia?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, WarpingMomentOfInertiaUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(WarpingMomentOfInertia? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<WarpingMomentOfInertiaUnit>(_unit);
}
