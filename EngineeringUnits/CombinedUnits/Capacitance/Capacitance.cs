using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 4, BaseunitType.length, -2, BaseunitType.mass, -1, BaseunitType.electricCurrent, 2, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Capacitance : BaseUnit
{
    public Capacitance() { }
    public Capacitance(Fraction value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Capacitance(decimal value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Capacitance(double value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Capacitance(int value, CapacitanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Capacitance(UnknownUnit value) : base(value) { }

    public static Capacitance From(double value, CapacitanceUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Capacitance? From(double? value, CapacitanceUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(CapacitanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Capacitance ToUnit(CapacitanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Capacitance Zero => new(0, CapacitanceUnit.SI);
    public static Capacitance NaN => new(double.NaN, CapacitanceUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Capacitance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, CapacitanceUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Capacitance? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<CapacitanceUnit>(_unit);

    public static Capacitance Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<Capacitance, CapacitanceUnit>(
         input,
         (v, u) => new Capacitance(v, u),
         CapacitanceUnit.SI,
         culture);
    }
}
