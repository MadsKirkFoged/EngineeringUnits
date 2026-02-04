using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 0, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class BitRate : BaseUnit
{
    public BitRate() { }
    public BitRate(Fraction value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BitRate(decimal value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BitRate(double value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BitRate(int value, BitRateUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public BitRate(UnknownUnit value) : base(value) { }

    public static BitRate From(double value, BitRateUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static BitRate? From(double? value, BitRateUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(BitRateUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public BitRate ToUnit(BitRateUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static BitRate Zero => new(0, BitRateUnit.SI);
    public static BitRate NaN => new(double.NaN, BitRateUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator BitRate?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, BitRateUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(BitRate? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<BitRateUnit>(_unit, format);

    public static BitRate Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<BitRate, BitRateUnit>(
         input,
         (v, u) => new BitRate(v, u),
         BitRateUnit.SI,
         culture);
    }
}
