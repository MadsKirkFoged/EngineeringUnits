using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Force : BaseUnit
{
    public Force() { }
    public Force(Fraction value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Force(decimal value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Force(double value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Force(int value, ForceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Force(UnknownUnit value) : base(value) { }

    public static Force From(double value, ForceUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Force? From(double? value, ForceUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ForceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Force ToUnit(ForceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Force Zero => new(0, ForceUnit.SI);
    public static Force NaN => new(double.NaN, ForceUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Force?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ForceUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Force? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<ForceUnit>(_unit, format);

    public static Force Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Force, ForceUnit>(
         input,
         (v, u) => new Force(v, u),
         ForceUnit.SI,
         culture);
    }
}
