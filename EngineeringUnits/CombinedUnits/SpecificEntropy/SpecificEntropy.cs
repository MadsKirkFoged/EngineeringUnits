using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class SpecificEntropy : BaseUnit
{
    public SpecificEntropy() { }
    public SpecificEntropy(Fraction value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificEntropy(decimal value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificEntropy(double value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificEntropy(int value, SpecificEntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificEntropy(UnknownUnit value) : base(value) { }

    public static SpecificEntropy From(double value, SpecificEntropyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static SpecificEntropy? From(double? value, SpecificEntropyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(SpecificEntropyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public SpecificEntropy ToUnit(SpecificEntropyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static SpecificEntropy Zero => new(0, SpecificEntropyUnit.SI);
    public static SpecificEntropy NaN => new(double.NaN, SpecificEntropyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificEntropy?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, SpecificEntropyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(SpecificEntropy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<SpecificEntropyUnit>(_unit);

    public static SpecificEntropy Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<SpecificEntropy, SpecificEntropyUnit>(
         input,
         (v, u) => new SpecificEntropy(v, u),
         SpecificEntropyUnit.SI,
         culture);
    }
}
