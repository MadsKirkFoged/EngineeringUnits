using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 1)]
public partial class AreaCost : BaseUnit
{
    public AreaCost() { }
    public AreaCost(Fraction value, AreaCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaCost(decimal value, AreaCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaCost(double value, AreaCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaCost(int value, AreaCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public AreaCost(UnknownUnit value) : base(value) { }

    public static AreaCost From(double value, AreaCostUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static AreaCost? From(double? value, AreaCostUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(AreaCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public AreaCost ToUnit(AreaCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static AreaCost Zero => new(0, AreaCostUnit.SI);
    public static AreaCost NaN => new(double.NaN, AreaCostUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator AreaCost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AreaCostUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(AreaCost? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<AreaCostUnit>(_unit, format);

    public static AreaCost Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<AreaCost, AreaCostUnit>(
         input,
         (v, u) => new AreaCost(v, u),
         AreaCostUnit.SI,
         culture);
    }
}
