using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 2, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class MassMomentOfInertia : BaseUnit
{
    public MassMomentOfInertia() { }
    public MassMomentOfInertia(Fraction value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassMomentOfInertia(decimal value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassMomentOfInertia(double value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassMomentOfInertia(int value, MassMomentOfInertiaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassMomentOfInertia(UnknownUnit value) : base(value) { }

    public static MassMomentOfInertia From(double value, MassMomentOfInertiaUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static MassMomentOfInertia? From(double? value, MassMomentOfInertiaUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MassMomentOfInertiaUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MassMomentOfInertia ToUnit(MassMomentOfInertiaUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MassMomentOfInertia Zero => new(0, MassMomentOfInertiaUnit.SI);
    public static MassMomentOfInertia NaN => new(double.NaN, MassMomentOfInertiaUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator MassMomentOfInertia?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MassMomentOfInertiaUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(MassMomentOfInertia? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassMomentOfInertiaUnit>(_unit);
}
