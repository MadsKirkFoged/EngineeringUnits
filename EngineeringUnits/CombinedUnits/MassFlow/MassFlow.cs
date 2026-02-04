using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -1, BaseunitType.length, 0, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class MassFlow : BaseUnit
{
    public MassFlow() { }
    public MassFlow(Fraction value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlow(decimal value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlow(double value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlow(int value, MassFlowUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public MassFlow(UnknownUnit value) : base(value) { }

    public static MassFlow From(double value, MassFlowUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static MassFlow? From(double? value, MassFlowUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(MassFlowUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public MassFlow ToUnit(MassFlowUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static MassFlow Zero => new(0, MassFlowUnit.SI);
    public static MassFlow NaN => new(double.NaN, MassFlowUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator MassFlow?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, MassFlowUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(MassFlow? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<MassFlowUnit>(_unit, format);

    public static MassFlow Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<MassFlow, MassFlowUnit>(
         input,
         (v, u) => new MassFlow(v, u),
         MassFlowUnit.SI,
         culture);
    }
}
