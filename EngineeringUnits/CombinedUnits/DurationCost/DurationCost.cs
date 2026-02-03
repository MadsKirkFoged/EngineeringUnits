using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -1, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 1)]
public partial class DurationCost : BaseUnit
{
    public DurationCost() { }
    public DurationCost(Fraction value, DurationCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public DurationCost(decimal value, DurationCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public DurationCost(double value, DurationCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public DurationCost(int value, DurationCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public DurationCost(UnknownUnit value) : base(value) { }

    public static DurationCost From(double value, DurationCostUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static DurationCost? From(double? value, DurationCostUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(DurationCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public DurationCost ToUnit(DurationCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static DurationCost Zero => new(0, DurationCostUnit.SI);
    public static DurationCost NaN => new(double.NaN, DurationCostUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator DurationCost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, DurationCostUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(DurationCost? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<DurationCostUnit>(_unit);

    public static DurationCost Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<DurationCost, DurationCostUnit>(
         input,
         (v, u) => new DurationCost(v, u),
         DurationCostUnit.SI,
         culture);
    }
}
