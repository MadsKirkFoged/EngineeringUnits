using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 0, BaseunitType.length, 2, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Area : BaseUnit
{
    public Area() { }
    public Area(Fraction value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Area(decimal value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Area(double value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Area(int value, AreaUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Area(UnknownUnit value) : base(value) { }

    public static Area From(double value, AreaUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Area? From(double? value, AreaUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(AreaUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Area ToUnit(AreaUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Area Zero => new(0, AreaUnit.SI);
    public static Area NaN => new(double.NaN, AreaUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Area?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AreaUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Area? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AreaUnit>(_unit);

    public static Area Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Area, AreaUnit>(
         input,
         (v, u) => new Area(v, u),
         AreaUnit.SI,
         culture);
    }
}
