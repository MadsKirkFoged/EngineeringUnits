using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, -1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class VolumetricHeatCapacity : BaseUnit
{
    public VolumetricHeatCapacity() { }
    public VolumetricHeatCapacity(Fraction value, VolumetricHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatCapacity(decimal value, VolumetricHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatCapacity(double value, VolumetricHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatCapacity(int value, VolumetricHeatCapacityUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumetricHeatCapacity(UnknownUnit value) : base(value) { }

    public static VolumetricHeatCapacity From(double value, VolumetricHeatCapacityUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static VolumetricHeatCapacity? From(double? value, VolumetricHeatCapacityUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(VolumetricHeatCapacityUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public VolumetricHeatCapacity ToUnit(VolumetricHeatCapacityUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static VolumetricHeatCapacity Zero => new(0, VolumetricHeatCapacityUnit.SI);
    public static VolumetricHeatCapacity NaN => new(double.NaN, VolumetricHeatCapacityUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator VolumetricHeatCapacity?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, VolumetricHeatCapacityUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(VolumetricHeatCapacity? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<VolumetricHeatCapacityUnit>(_unit, format);

    public static VolumetricHeatCapacity Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<VolumetricHeatCapacity, VolumetricHeatCapacityUnit>(
         input,
         (v, u) => new VolumetricHeatCapacity(v, u),
         VolumetricHeatCapacityUnit.SI,
         culture);
    }
}
