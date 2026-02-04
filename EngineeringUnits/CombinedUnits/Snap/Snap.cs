using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -4, BaseunitType.length, 1, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Snap : BaseUnit
{
    public Snap() { }
    public Snap(Fraction value, SnapUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Snap(decimal value, SnapUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Snap(double value, SnapUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Snap(int value, SnapUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Snap(UnknownUnit value) : base(value) { }

    public static Snap From(double value, SnapUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Snap? From(double? value, SnapUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(SnapUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Snap ToUnit(SnapUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Snap Zero => new(0, SnapUnit.SI);
    public static Snap NaN => new(double.NaN, SnapUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Snap?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, SnapUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Snap? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<SnapUnit>(_unit, format);

    public static Snap Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Snap, SnapUnit>(
         input,
         (v, u) => new Snap(v, u),
         SnapUnit.SI,
         culture);
    }
}
