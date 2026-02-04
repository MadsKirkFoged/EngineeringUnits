using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 0, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ForcePerLength : BaseUnit
{
    public ForcePerLength() { }
    public ForcePerLength(Fraction value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForcePerLength(decimal value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForcePerLength(double value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForcePerLength(int value, ForcePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForcePerLength(UnknownUnit value) : base(value) { }

    public static ForcePerLength From(double value, ForcePerLengthUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ForcePerLength? From(double? value, ForcePerLengthUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ForcePerLengthUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ForcePerLength ToUnit(ForcePerLengthUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ForcePerLength Zero => new(0, ForcePerLengthUnit.SI);
    public static ForcePerLength NaN => new(double.NaN, ForcePerLengthUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ForcePerLength?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ForcePerLengthUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ForcePerLength? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<ForcePerLengthUnit>(_unit, format);

    public static ForcePerLength Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<ForcePerLength, ForcePerLengthUnit>(
         input,
         (v, u) => new ForcePerLength(v, u),
         ForcePerLengthUnit.SI,
         culture);
    }
}
