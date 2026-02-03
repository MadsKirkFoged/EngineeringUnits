using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 2, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Entropy : BaseUnit
{
    public Entropy() { }
    public Entropy(Fraction value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Entropy(decimal value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Entropy(double value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Entropy(int value, EntropyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Entropy(UnknownUnit value) : base(value) { }

    public static Entropy From(double value, EntropyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Entropy? From(double? value, EntropyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(EntropyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Entropy ToUnit(EntropyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Entropy Zero => new(0, EntropyUnit.SI);
    public static Entropy NaN => new(double.NaN, EntropyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Entropy?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, EntropyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Entropy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<EntropyUnit>(_unit);

    public static Entropy Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Entropy, EntropyUnit>(
         input,
         (v, u) => new Entropy(v, u),
         EntropyUnit.SI,
         culture);
    }
}
