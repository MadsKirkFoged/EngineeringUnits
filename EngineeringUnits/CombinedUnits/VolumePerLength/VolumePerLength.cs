using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class VolumePerLength : BaseUnit
{
    public VolumePerLength() { }
    public VolumePerLength(Fraction value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumePerLength(decimal value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumePerLength(double value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumePerLength(int value, VolumePerLengthUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public VolumePerLength(UnknownUnit value) : base(value) { }

    public static VolumePerLength From(double value, VolumePerLengthUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static VolumePerLength? From(double? value, VolumePerLengthUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(VolumePerLengthUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public VolumePerLength ToUnit(VolumePerLengthUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static VolumePerLength Zero => new(0, VolumePerLengthUnit.SI);
    public static VolumePerLength NaN => new(double.NaN, VolumePerLengthUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator VolumePerLength?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, VolumePerLengthUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(VolumePerLength? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<VolumePerLengthUnit>(_unit);

    public static VolumePerLength Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<VolumePerLength, VolumePerLengthUnit>(
         input,
         (v, u) => new VolumePerLength(v, u),
         VolumePerLengthUnit.SI,
         culture);
    }
}
