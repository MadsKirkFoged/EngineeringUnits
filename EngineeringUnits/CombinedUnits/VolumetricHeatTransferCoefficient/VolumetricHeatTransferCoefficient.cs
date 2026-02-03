using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, -1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class VolumetricHeatTransferCoefficient : BaseUnit
{
    public VolumetricHeatTransferCoefficient() { }
    public VolumetricHeatTransferCoefficient(Fraction value, VolumetricHeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatTransferCoefficient(decimal value, VolumetricHeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatTransferCoefficient(double value, VolumetricHeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatTransferCoefficient(int value, VolumetricHeatTransferCoefficientUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatTransferCoefficient(UnknownUnit value) : base(value) { }

    public static VolumetricHeatTransferCoefficient From(double value, VolumetricHeatTransferCoefficientUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static VolumetricHeatTransferCoefficient? From(double? value, VolumetricHeatTransferCoefficientUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(VolumetricHeatTransferCoefficientUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public VolumetricHeatTransferCoefficient ToUnit(VolumetricHeatTransferCoefficientUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static VolumetricHeatTransferCoefficient Zero => new(0, VolumetricHeatTransferCoefficientUnit.SI);
    public static VolumetricHeatTransferCoefficient NaN => new(double.NaN, VolumetricHeatTransferCoefficientUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator VolumetricHeatTransferCoefficient?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, VolumetricHeatTransferCoefficientUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(VolumetricHeatTransferCoefficient? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumetricHeatTransferCoefficientUnit>(_unit);

    public static VolumetricHeatTransferCoefficient Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<VolumetricHeatTransferCoefficient, VolumetricHeatTransferCoefficientUnit>(
         input,
         (v, u) => new VolumetricHeatTransferCoefficient(v, u),
         VolumetricHeatTransferCoefficientUnit.SI,
         culture);
    }
}
