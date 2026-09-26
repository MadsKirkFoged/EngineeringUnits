using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -3, BaseunitType.length, 2, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, -1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ThermalConductance : BaseUnit
{
    public ThermalConductance() { }
    public ThermalConductance(Fraction value, ThermalConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductance(decimal value, ThermalConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductance(double value, ThermalConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductance(int value, ThermalConductanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ThermalConductance(UnknownUnit value) : base(value) { }

    public static ThermalConductance From(double value, ThermalConductanceUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ThermalConductance? From(double? value, ThermalConductanceUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ThermalConductanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ThermalConductance ToUnit(ThermalConductanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ThermalConductance Zero => new(0, ThermalConductanceUnit.SI);
    public static ThermalConductance NaN => new(double.NaN, ThermalConductanceUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ThermalConductance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ThermalConductanceUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ThermalConductance? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<ThermalConductanceUnit>(_unit, format);

    public static ThermalConductance Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<ThermalConductance, ThermalConductanceUnit>(
         input,
         (v, u) => new ThermalConductance(v, u),
         ThermalConductanceUnit.SI,
         culture);
    }
}
