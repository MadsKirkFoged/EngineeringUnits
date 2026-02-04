using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, 3, BaseunitType.length, -1, BaseunitType.mass, -1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 1, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class SpecificThermalResistance : BaseUnit
{
    public SpecificThermalResistance() { }
    public SpecificThermalResistance(Fraction value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificThermalResistance(decimal value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificThermalResistance(double value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificThermalResistance(int value, SpecificThermalResistanceUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public SpecificThermalResistance(UnknownUnit value) : base(value) { }

    public static SpecificThermalResistance From(double value, SpecificThermalResistanceUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static SpecificThermalResistance? From(double? value, SpecificThermalResistanceUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(SpecificThermalResistanceUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public SpecificThermalResistance ToUnit(SpecificThermalResistanceUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static SpecificThermalResistance Zero => new(0, SpecificThermalResistanceUnit.SI);
    public static SpecificThermalResistance NaN => new(double.NaN, SpecificThermalResistanceUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator SpecificThermalResistance?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, SpecificThermalResistanceUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(SpecificThermalResistance? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<SpecificThermalResistanceUnit>(_unit, format);

    public static SpecificThermalResistance Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<SpecificThermalResistance, SpecificThermalResistanceUnit>(
         input,
         (v, u) => new SpecificThermalResistance(v, u),
         SpecificThermalResistanceUnit.SI,
         culture);
    }
}
