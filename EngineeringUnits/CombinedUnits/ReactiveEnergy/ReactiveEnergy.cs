using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;
using EngineeringUnits.Parsing;
using System;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, 2, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class ReactiveEnergy : BaseUnit
{
    public ReactiveEnergy() { }
    public ReactiveEnergy(Fraction value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ReactiveEnergy(decimal value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ReactiveEnergy(double value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ReactiveEnergy(int value, ReactiveEnergyUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public ReactiveEnergy(UnknownUnit value) : base(value) { }

    public static ReactiveEnergy From(double value, ReactiveEnergyUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static ReactiveEnergy? From(double? value, ReactiveEnergyUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(ReactiveEnergyUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public ReactiveEnergy ToUnit(ReactiveEnergyUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static ReactiveEnergy Zero => new(0, ReactiveEnergyUnit.SI);
    public static ReactiveEnergy NaN => new(double.NaN, ReactiveEnergyUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator ReactiveEnergy?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, ReactiveEnergyUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(ReactiveEnergy? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit, string? format = null) => GetStandardSymbol<ReactiveEnergyUnit>(_unit, format);

    public static ReactiveEnergy Parse(string? input, IFormatProvider? culture = null)
    {
         return QuantityParser.Parse<ReactiveEnergy, ReactiveEnergyUnit>(
         input,
         (v, u) => new ReactiveEnergy(v, u),
         ReactiveEnergyUnit.SI,
         culture);
    }
}
