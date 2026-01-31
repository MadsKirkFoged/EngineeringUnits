using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 1, BaseunitType.Cost, 0)]
public partial class LuminousIntensity : BaseUnit
{
    public LuminousIntensity() { }
    public LuminousIntensity(Fraction value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LuminousIntensity(decimal value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LuminousIntensity(double value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LuminousIntensity(int value, LuminousIntensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LuminousIntensity(UnknownUnit value) : base(value) { }

    public static LuminousIntensity From(double value, LuminousIntensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static LuminousIntensity? From(double? value, LuminousIntensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(LuminousIntensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LuminousIntensity ToUnit(LuminousIntensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LuminousIntensity Zero => new(0, LuminousIntensityUnit.SI);
    public static LuminousIntensity NaN => new(double.NaN, LuminousIntensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator LuminousIntensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, LuminousIntensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(LuminousIntensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LuminousIntensityUnit>(_unit);
}
