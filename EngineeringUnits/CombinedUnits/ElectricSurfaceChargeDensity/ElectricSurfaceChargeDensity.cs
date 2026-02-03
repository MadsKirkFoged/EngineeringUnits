using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 1, BaseunitType.length, -2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 1, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ElectricSurfaceChargeDensity : BaseUnit
{
    public ElectricSurfaceChargeDensity() { }
    public ElectricSurfaceChargeDensity(Fraction value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricSurfaceChargeDensity(decimal value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricSurfaceChargeDensity(double value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricSurfaceChargeDensity(int value, ElectricSurfaceChargeDensityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ElectricSurfaceChargeDensity(UnknownUnit value) : base(value) { }

    public static ElectricSurfaceChargeDensity From(double value, ElectricSurfaceChargeDensityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ElectricSurfaceChargeDensity? From(double? value, ElectricSurfaceChargeDensityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ElectricSurfaceChargeDensityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ElectricSurfaceChargeDensity ToUnit(ElectricSurfaceChargeDensityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ElectricSurfaceChargeDensity Zero => new(0, ElectricSurfaceChargeDensityUnit.SI);
    public static ElectricSurfaceChargeDensity NaN => new(double.NaN, ElectricSurfaceChargeDensityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ElectricSurfaceChargeDensity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ElectricSurfaceChargeDensityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ElectricSurfaceChargeDensity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<ElectricSurfaceChargeDensityUnit>(_unit);

    public static ElectricSurfaceChargeDensity Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<ElectricSurfaceChargeDensity, ElectricSurfaceChargeDensityUnit>(
         input,
         (v, u) => new ElectricSurfaceChargeDensity(v, u),
         ElectricSurfaceChargeDensityUnit.SI,
         culture);
    }
}
