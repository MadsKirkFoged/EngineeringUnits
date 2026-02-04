using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 2, BaseunitType.length, -1, BaseunitType.mass, -1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 1)]
public partial class ForceCost : BaseUnit
{
    public ForceCost() { }
    public ForceCost(Fraction value, ForceCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceCost(decimal value, ForceCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceCost(double value, ForceCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceCost(int value, ForceCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ForceCost(UnknownUnit value) : base(value) { }

    public static ForceCost From(double value, ForceCostUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ForceCost? From(double? value, ForceCostUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ForceCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ForceCost ToUnit(ForceCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ForceCost Zero => new(0, ForceCostUnit.SI);
    public static ForceCost NaN => new(double.NaN, ForceCostUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ForceCost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ForceCostUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ForceCost? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<ForceCostUnit>(_unit, format);

    public static ForceCost Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<ForceCost, ForceCostUnit>(
         input,
         (v, u) => new ForceCost(v, u),
         ForceCostUnit.SI,
         culture);
    }
}
