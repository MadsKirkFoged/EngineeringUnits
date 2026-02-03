using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 2, BaseunitType.mass, 1, BaseunitType.electricCurrent, -1, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ElectricPotential : BaseUnit
{
    public ElectricPotential() { }
    public ElectricPotential(Fraction value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricPotential(decimal value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricPotential(double value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricPotential(int value, ElectricPotentialUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricPotential(UnknownUnit value) : base(value) { }

    public static ElectricPotential From(double value, ElectricPotentialUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ElectricPotential? From(double? value, ElectricPotentialUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ElectricPotentialUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricPotential ToUnit(ElectricPotentialUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricPotential Zero => new(0, ElectricPotentialUnit.SI);
    public static ElectricPotential NaN => new(double.NaN, ElectricPotentialUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ElectricPotential?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricPotentialUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ElectricPotential? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricPotentialUnit>(_unit);

    public static ElectricPotential Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<ElectricPotential, ElectricPotentialUnit>(
         input,
         (v, u) => new ElectricPotential(v, u),
         ElectricPotentialUnit.SI,
         culture);
    }
}
