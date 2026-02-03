using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 1, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Acceleration : BaseUnit
{
    public Acceleration() { }
    public Acceleration(Fraction value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Acceleration(decimal value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Acceleration(double value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Acceleration(int value, AccelerationUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Acceleration(UnknownUnit value) : base(value) { }

    public static Acceleration From(double value, AccelerationUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Acceleration? From(double? value, AccelerationUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(AccelerationUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Acceleration ToUnit(AccelerationUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Acceleration Zero => new(0, AccelerationUnit.SI);
    public static Acceleration NaN => new(double.NaN, AccelerationUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Acceleration?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, AccelerationUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Acceleration? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<AccelerationUnit>(_unit);

    public static Acceleration Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Acceleration, AccelerationUnit>(
         input,
         (v, u) => new Acceleration(v, u),
         AccelerationUnit.SI,
         culture);
    }
}
