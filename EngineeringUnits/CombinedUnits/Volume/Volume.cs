using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 3, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Volume : BaseUnit
{
    public Volume() { }
    public Volume(Fraction value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Volume(decimal value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Volume(double value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Volume(int value, VolumeUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Volume(UnknownUnit value) : base(value) { }

    public static Volume From(double value, VolumeUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Volume? From(double? value, VolumeUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(VolumeUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Volume ToUnit(VolumeUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Volume Zero => new(0, VolumeUnit.SI);
    public static Volume NaN => new(double.NaN, VolumeUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Volume?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, VolumeUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Volume? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<VolumeUnit>(_unit, format);

    public static Volume Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Volume, VolumeUnit>(
         input,
         (v, u) => new Volume(v, u),
         VolumeUnit.SI,
         culture);
    }
}
