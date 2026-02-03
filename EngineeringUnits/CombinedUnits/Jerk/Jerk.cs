using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 1, BaseunitType.mass, 0, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Jerk : BaseUnit
{
    public Jerk() { }
    public Jerk(Fraction value, JerkUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Jerk(decimal value, JerkUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Jerk(double value, JerkUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Jerk(int value, JerkUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Jerk(UnknownUnit value) : base(value) { }

    public static Jerk From(double value, JerkUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Jerk? From(double? value, JerkUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(JerkUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Jerk ToUnit(JerkUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Jerk Zero => new(0, JerkUnit.SI);
    public static Jerk NaN => new(double.NaN, JerkUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Jerk?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, JerkUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Jerk? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<JerkUnit>(_unit);

    public static Jerk Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Jerk, JerkUnit>(
         input,
         (v, u) => new Jerk(v, u),
         JerkUnit.SI,
         culture);
    }
}
