using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 1, BaseunitType.length, -3, BaseunitType.mass, 0, BaseunitType.electricCurrent, 1, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ElectricChargeDensity : BaseUnit
{
    public ElectricChargeDensity() { }
    public ElectricChargeDensity(Fraction value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricChargeDensity(decimal value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricChargeDensity(double value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricChargeDensity(int value, ElectricChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricChargeDensity(UnknownUnit value) : base(value) { }

    public static ElectricChargeDensity From(double value, ElectricChargeDensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ElectricChargeDensity? From(double? value, ElectricChargeDensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ElectricChargeDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricChargeDensity ToUnit(ElectricChargeDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricChargeDensity Zero => new(0, ElectricChargeDensityUnit.SI);
    public static ElectricChargeDensity NaN => new(double.NaN, ElectricChargeDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ElectricChargeDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricChargeDensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ElectricChargeDensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricChargeDensityUnit>(_unit);

    public static ElectricChargeDensity Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<ElectricChargeDensity, ElectricChargeDensityUnit>(
         input,
         (v, u) => new ElectricChargeDensity(v, u),
         ElectricChargeDensityUnit.SI,
         culture);
    }
}
