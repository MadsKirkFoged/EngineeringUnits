using EngineeringUnits.Units;
using System.Diagnostics.CodeAnalysis;
using Fractions;

namespace EngineeringUnits;

// This class is auto-generated, changes to the file will be overwritten!
[UnitDimension(BaseunitType.time, -2, BaseunitType.length, -1, BaseunitType.mass, 1, BaseunitType.electricCurrent, 0, BaseunitType.temperature, 0, BaseunitType.amountOfSubstance, 0, BaseunitType.luminousIntensity, 0, BaseunitType.Cost, 0)]
public partial class Pressure : BaseUnit
{
    public Pressure() { }
    public Pressure(Fraction value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Pressure(decimal value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Pressure(double value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Pressure(int value, PressureUnit selectedUnit) : base(value, selectedUnit.Unit) { }
    public Pressure(UnknownUnit value) : base(value) { }

    public static Pressure From(double value, PressureUnit unit) => new(value, unit);

    [return: NotNullIfNotNull(nameof(value))]
    public static Pressure? From(double? value, PressureUnit? unit)
    {
        if (value is null || unit is null)
            return null;

        return From((double)value, unit);
    }
    public double As(PressureUnit ReturnInThisUnit) => this.GetValueAsDouble(ReturnInThisUnit);
    public Pressure ToUnit(PressureUnit selectedUnit) => new(this.GetValueAs(selectedUnit.Unit), selectedUnit);
    public static Pressure Zero => new(0, PressureUnit.SI);
    public static Pressure NaN => new(double.NaN, PressureUnit.SI);

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator Pressure?(UnknownUnit? Unit)
    {
        if (Unit is null)
            return null;

        GuardAgainst.DifferentUnits(Unit, PressureUnit.SI);
        return new(Unit);
    }

    [return: NotNullIfNotNull(nameof(Unit))]
    public static implicit operator UnknownUnit?(Pressure? Unit)
    {
        if (Unit is null)
            return null;

        return new(Unit);
    }

    public override string? GetStandardSymbol(UnitSystem _unit) => GetStandardSymbol<PressureUnit>(_unit);
}
