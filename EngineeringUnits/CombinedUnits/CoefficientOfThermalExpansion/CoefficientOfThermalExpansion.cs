using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class CoefficientOfThermalExpansion : BaseUnit
{
    public CoefficientOfThermalExpansion() { }
    public CoefficientOfThermalExpansion(Fraction value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public CoefficientOfThermalExpansion(decimal value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public CoefficientOfThermalExpansion(double value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public CoefficientOfThermalExpansion(int value, CoefficientOfThermalExpansionUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public CoefficientOfThermalExpansion(UnknownUnit value) : base(value) { }

    public static CoefficientOfThermalExpansion From(double value, CoefficientOfThermalExpansionUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static CoefficientOfThermalExpansion? From(double? value, CoefficientOfThermalExpansionUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(CoefficientOfThermalExpansionUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public CoefficientOfThermalExpansion ToUnit(CoefficientOfThermalExpansionUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static CoefficientOfThermalExpansion Zero => new(0, CoefficientOfThermalExpansionUnit.SI);
    public static CoefficientOfThermalExpansion NaN => new(double.NaN, CoefficientOfThermalExpansionUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator CoefficientOfThermalExpansion?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, CoefficientOfThermalExpansionUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(CoefficientOfThermalExpansion? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<CoefficientOfThermalExpansionUnit>(_unit, format);

    public static CoefficientOfThermalExpansion Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<CoefficientOfThermalExpansion, CoefficientOfThermalExpansionUnit>(
         input,
         (v, u) => new CoefficientOfThermalExpansion(v, u),
         CoefficientOfThermalExpansionUnit.SI,
         culture);
    }
}
