using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, -1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class EnergyDensity : BaseUnit
{
    public EnergyDensity() { }
    public EnergyDensity(Fraction value, EnergyDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public EnergyDensity(decimal value, EnergyDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public EnergyDensity(double value, EnergyDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public EnergyDensity(int value, EnergyDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public EnergyDensity(UnknownUnit value) : base(value) { }

    public static EnergyDensity From(double value, EnergyDensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static EnergyDensity? From(double? value, EnergyDensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(EnergyDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public EnergyDensity ToUnit(EnergyDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static EnergyDensity Zero => new(0, EnergyDensityUnit.SI);
    public static EnergyDensity NaN => new(double.NaN, EnergyDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator EnergyDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, EnergyDensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(EnergyDensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<EnergyDensityUnit>(_unit, format);

    public static EnergyDensity Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<EnergyDensity, EnergyDensityUnit>(
         input,
         (v, u) => new EnergyDensity(v, u),
         EnergyDensityUnit.SI,
         culture);
    }
}
