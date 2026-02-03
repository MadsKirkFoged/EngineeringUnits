using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -1, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 1)]
public partial class LengthCost : BaseUnit
{
    public LengthCost() { }
    public LengthCost(Fraction value, LengthCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LengthCost(decimal value, LengthCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LengthCost(double value, LengthCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LengthCost(int value, LengthCostUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public LengthCost(UnknownUnit value) : base(value) { }

    public static LengthCost From(double value, LengthCostUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static LengthCost? From(double? value, LengthCostUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(LengthCostUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public LengthCost ToUnit(LengthCostUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static LengthCost Zero => new(0, LengthCostUnit.SI);
    public static LengthCost NaN => new(double.NaN, LengthCostUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator LengthCost?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, LengthCostUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(LengthCost? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<LengthCostUnit>(_unit);

    public static LengthCost Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<LengthCost, LengthCostUnit>(
         input,
         (v, u) => new LengthCost(v, u),
         LengthCostUnit.SI,
         culture);
    }
}
