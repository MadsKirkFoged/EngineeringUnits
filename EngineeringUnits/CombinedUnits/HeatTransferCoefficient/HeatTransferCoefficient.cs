using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 0, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class HeatTransferCoefficient : BaseUnit
{
    public HeatTransferCoefficient() { }
    public HeatTransferCoefficient(Fraction value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public HeatTransferCoefficient(decimal value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public HeatTransferCoefficient(double value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public HeatTransferCoefficient(int value, HeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public HeatTransferCoefficient(UnknownUnit value) : base(value) { }

    public static HeatTransferCoefficient From(double value, HeatTransferCoefficientUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static HeatTransferCoefficient? From(double? value, HeatTransferCoefficientUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(HeatTransferCoefficientUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public HeatTransferCoefficient ToUnit(HeatTransferCoefficientUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static HeatTransferCoefficient Zero => new(0, HeatTransferCoefficientUnit.SI);
    public static HeatTransferCoefficient NaN => new(double.NaN, HeatTransferCoefficientUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator HeatTransferCoefficient?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, HeatTransferCoefficientUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(HeatTransferCoefficient? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<HeatTransferCoefficientUnit>(_unit, format);

    public static HeatTransferCoefficient Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<HeatTransferCoefficient, HeatTransferCoefficientUnit>(
         input,
         (v, u) => new HeatTransferCoefficient(v, u),
         HeatTransferCoefficientUnit.SI,
         culture);
    }
}
