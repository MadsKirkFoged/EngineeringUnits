using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, -3, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Density : BaseUnit
{
    public Density() { }
    public Density(Fraction value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Density(decimal value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Density(double value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Density(int value, DensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Density(UnknownUnit value) : base(value) { }

    public static Density From(double value, DensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Density? From(double? value, DensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(DensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Density ToUnit(DensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Density Zero => new(0, DensityUnit.SI);
    public static Density NaN => new(double.NaN, DensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Density?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, DensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Density? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<DensityUnit>(_unit);

    public static Density Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Density, DensityUnit>(
         input,
         (v, u) => new Density(v, u),
         DensityUnit.SI,
         culture);
    }
}
