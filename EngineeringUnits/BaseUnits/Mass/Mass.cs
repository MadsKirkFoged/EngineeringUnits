using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 0, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Mass : BaseUnit
{
    public Mass() { }
    public Mass(Fraction value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Mass(decimal value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Mass(double value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Mass(int value, MassUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Mass(UnknownUnit value) : base(value) { }

    public static Mass From(double value, MassUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Mass? From(double? value, MassUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MassUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Mass ToUnit(MassUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Mass Zero => new(0, MassUnit.SI);
    public static Mass NaN => new(double.NaN, MassUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Mass?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MassUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Mass? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<MassUnit>(_unit);
}
